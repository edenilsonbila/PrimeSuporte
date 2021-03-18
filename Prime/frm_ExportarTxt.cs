using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Diagnostics;


namespace Prime
{
    public partial class frm_EnviarEmail : Form
    {
        public frm_EnviarEmail()
        {
            InitializeComponent();
        }

        private void frm_ExportarTxt_Load(object sender, EventArgs e)
        {

        }

        public static void Envia_email(String destino1, String mensagem) {

            Funcoes.msgInfo("Peterson");
            
            /*
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gzsistemas.com.br";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("edenilson.bila@gzsistemas.com.br","Tub!la44492325");
            smtp.Send("edenilson.bila@gzsistemas.com.br","vinicius.ienne@gzsistemas.com.br","Teste","Seu lindo");
       */

            
              }

        public int total_atendimento() {
            //Cria o select
           String sql = "select count(*) from tb_atendimento where id_usuario = ?id and dt_abertura = ?data";
            //Monta o comando
            MySqlCommand comando = new MySqlCommand(sql);
            comando.Parameters.AddWithValue("?id",cls_Conexao.cod_user_on);
            comando.Parameters.AddWithValue("?data", tb_data.Value.ToString("yyyy/MM/dd"));
            
            //Executa o comando e pega o valor retornado do Banco
            int total_atendimentos = Convert.ToInt32(cls_Conexao.execute_selectP(comando).Rows[0]["count(*)"].ToString());

            //Retorna o valor para chamada de função
            return total_atendimentos;
        }

        public int recupera_totais(String clausula)
        {
            
            //Cria o select
            String sql = "select count(*) from tb_atendimento where id_usuario = ?id and dt_abertura = ?data and "+clausula+"";
            //Monta o comando
            MySqlCommand comando = new MySqlCommand(sql);
            comando.Parameters.AddWithValue("?id", cls_Conexao.cod_user_on);
            comando.Parameters.AddWithValue("?data", tb_data.Value.ToString("yyyy/MM/dd"));

            //Executa o comando e pega o valor retornado do Banco
            int total_atendimentos = Convert.ToInt32(cls_Conexao.execute_selectP(comando).Rows[0]["count(*)"].ToString());

            //Retorna o valor para chamada de função
            return total_atendimentos;
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            gerarArquivo();
  
       }

        public void gerarArquivo() {
            String clausula;
            total_atendimento();

            //Total sanado
            clausula = "ds_status = 'SANADO'";
            int total_sanado = recupera_totais(clausula);

            //Total Externo
            clausula = "ds_status = 'EXTERNO'";
            int total_externo = recupera_totais(clausula);

            //Total Des
            clausula = "ds_status = 'DESENVOLVIMENTO'";
            int total_des = recupera_totais(clausula);

            //Total Pendente
            clausula = "ds_status = 'PENDENTE'";
            int total_pendente = recupera_totais(clausula);

            //Total Jundiai
            clausula = "id_filial = 4";
            int total_jdi = recupera_totais(clausula);

            //Total ABC
            clausula = "id_filial = 5";
            int total_abc = recupera_totais(clausula);

            //Total Ribeirao
            clausula = "id_filial = 6";
            int total_rib = recupera_totais(clausula);

            //Total Revenda
            clausula = "id_filial = 8";
            int total_rev = recupera_totais(clausula);

            /* TOTAIS POR SISTEMA - RETAGUARDA*/

            //Total Mercoflex
            clausula = "id_sistema = 1";
            int total_flex = recupera_totais(clausula);

            //Total Super
            clausula = "id_sistema = 4";
            int total_super = recupera_totais(clausula);

            //Total Mercatto
            clausula = "id_sistema = 6";
            int total_mercatto = recupera_totais(clausula);

            //Total Outros
            clausula = "id_sistema = 7";
            int total_outros = recupera_totais(clausula);

            /* TOTAIS FRENTE */

            //Total Flex
            clausula = "frente = 3";
            int total_f_flex = recupera_totais(clausula);
            //Total Super
            clausula = "frente = 9";
            int total_f_super = recupera_totais(clausula);
            //Total Outros
            clausula = "frente = 8";
            int total_f_outros = recupera_totais(clausula);


            //Cria o select a ser executado
            //String sql = "select * from tb_atendimento t inner join tb_usuario u on t.id_usuario = u.id_usuario where t.dt_abertura = '" + tb_data.Value.ToString("yyyy/MM/dd") + "' and u.id_usuario = " + cls_Conexao.cod_user_on;
            String sql = "select t.id_cliente, c.ds_razao_social, c.nu_cnpj, c.cod_controller, ds_filial, ds_contato_cliente, c.nu_telefone, ds_problema, ds_solucao, r.ds_sistema as retaguarda, fr.ds_sistema as frente" +
                " from tb_atendimento t" +
                " inner join tb_usuario u on t.id_usuario = u.id_usuario" +
                " inner join tb_cliente c on t.id_cliente = c.id_cliente" +
                " inner join tb_filial f on t.id_filial = f.id_filial" +
                " inner join tb_sistema r on t.id_sistema = r.id_sistema" +
                " inner join tb_sistema fr on t.frente = fr.id_sistema" +
                " where t.dt_abertura = '" + tb_data.Value.ToString("yyyy/MM/dd") + "' and u.id_usuario = " + cls_Conexao.cod_user_on;

            //Cria o comando a ser executado e parametriza ele
            MySqlCommand comando = new MySqlCommand(sql);
            comando.Parameters.AddWithValue("?data", tb_data.Value.ToString("yyyy/MM/dd"));

            //Cria um datatable e executa o comando SQL
            DataTable dt = cls_Conexao.execute_selectP(comando);

            //Verifica se retornou registros
            if (dt.Rows.Count > 0)
            {

                String mes = tb_data.Value.ToString("MM");
                String ano = tb_data.Value.ToString("yyyy");

                //Verifica se existe a pasta Atendimentos na pasta do Programa
                if (Funcoes.verificaArquivo(Application.StartupPath.ToString() + @"\atendimentos") == false)
                {
                    //Caso não exista é criada
                    Directory.CreateDirectory(Application.StartupPath.ToString() + @"\atendimentos");
                }

                //Verifica se existe a pasta do ano em questão
                if (Funcoes.verificaArquivo(Application.StartupPath.ToString() + @"\atendimentos\" + ano) == false)
                {
                    Directory.CreateDirectory(Application.StartupPath.ToString() + @"\atendimentos\" + ano);
                }

                //Verifica se existe a pasta do mes em questão
                if (Funcoes.verificaArquivo(Application.StartupPath.ToString() + @"\atendimentos\" + ano + "\\" + mes) == false)
                {
                    Directory.CreateDirectory(Application.StartupPath.ToString() + @"\atendimentos\" + ano + "\\" + mes);
                }

                //Cria uma variavel com o caminho para a pasta
                String caminho_atendimento = Application.StartupPath.ToString() + @"\atendimentos";



                int i = 0;


                //   MessageBox.Show("C:\\" + Application.StartupPath.ToString() + "\\Atendimentos" + DateTime.Today.ToString("ddMMyy") + ".txt");
                //Cria o arquivo
                StreamWriter sw = new StreamWriter(caminho_atendimento + "\\" + ano + "\\" + mes + "\\" + tb_data.Value.ToString("ddMMyy") + ".txt");

                sw.WriteLine();
                sw.WriteLine("============== TOTAL ATENDIMENTO ====================");
                sw.WriteLine();
                sw.WriteLine("ATENDIMENTOS: " + total_atendimento());
                sw.WriteLine();
                sw.WriteLine("====================== STATUS =======================");
                sw.WriteLine("SANADO: " + total_sanado);
                sw.WriteLine("EXTERNO: " + total_externo);
                sw.WriteLine("DESENVOLVIMENTO: " + total_des);
                sw.WriteLine("PENDENTE: " + total_pendente);
                sw.WriteLine();
                sw.WriteLine("====================== FILIAL =======================");
                sw.WriteLine("JUNDIAI: " + total_jdi);
                sw.WriteLine("ABC: " + total_abc);
                sw.WriteLine("RIBEIRAO: " + total_rib);
                sw.WriteLine("REVENDA " + total_rev);
                sw.WriteLine();
                sw.WriteLine("=================== RETAGUARDA ======================");
                sw.WriteLine("MERCOFLEX: " + total_flex);
                sw.WriteLine("MERCATTO: " + total_mercatto);
                sw.WriteLine("SUPER: " + total_super);
                sw.WriteLine("OUTROS: " + total_outros);
                sw.WriteLine();
                sw.WriteLine("====================== FRENTE =======================");
                sw.WriteLine("FLEX: " + total_f_flex + " | SUPER:   " + total_f_super + "    | OUTROS: " + total_f_outros);
                sw.WriteLine("=====================================================");
                sw.WriteLine();
                sw.WriteLine();
                sw.WriteLine("===================== CLIENTES ======================");

                for (i = 0; i < dt.Rows.Count; i++)
                {

                    sw.WriteLine();
                    sw.WriteLine("Código cliente : " + dt.Rows[i]["cod_controller"]);
                    sw.WriteLine("Nome estabelecimento: " + dt.Rows[i]["ds_razao_social"]);
                    sw.WriteLine("CNPJ: " + dt.Rows[i]["nu_cnpj"]);
                    sw.WriteLine("Localidade: " + dt.Rows[i]["ds_filial"]);
                    sw.WriteLine("Contato: " + dt.Rows[i]["ds_contato_cliente"]);
                    sw.WriteLine("Telefone: " + dt.Rows[i]["nu_telefone"]);
                    sw.WriteLine("Sistema: " + dt.Rows[i]["retaguarda"] + "         Frente: " + dt.Rows[i]["frente"]);
                    sw.WriteLine("Problema: " + dt.Rows[i]["ds_problema"]);
                    sw.WriteLine("Solução: " + dt.Rows[i]["ds_solucao"]);
                    sw.WriteLine();
                    sw.WriteLine("=====================================================");

                }
                sw.Flush();
                sw.Close();
                Funcoes.msgInfo("Arquivo Exportado com Sucesso");
                DialogResult conf = Funcoes.msgQuestion("Deseja abrir o diretório de exportação?");

                if(conf == DialogResult.Yes){
                    Process.Start("Explorer", caminho_atendimento + "\\" + ano + "\\" + mes);
                }

            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}

/*
            VERIFICAR A UTILIDADE DESTA TABELA..
           ______________________________________________________________________________________________________ 
           |Data dos Atendimentos:                          |	            Retaguarda     |	Frente de Loja  |
           |Status do Atendimento	|Total|Unidade GZ |Total|Flex |Mercatto |Super |Outros |Super |Flex |Outros |
           |Problemas sanados:	    |4    |Jundiaí:	  |4 	|	  |     	|      |       |      |     |       |
           |Desenvolvimento:	    |0	  |ABC:	      |0	|     |	        |      |       |      |     |       |
           |Atendimento externo:	|0	  |Ribeirão:  |0	|     |	        |      |       |      |     |       |
           |Dependência cliente:	|0	  |Revenda:	  |0	|     |	        |      |       |      |     |       |
           |Total de atendimentos:	|4	  |	          |0	|     |	        |      |       |      |     |       |
           |________________________|_____|___________|_____|_____|_________|______|_______|______|_____|_______|
            
             
                sw.WriteLine();
                sw.WriteLine("|Data dos Atendimentos:                          |	            Retaguarda     |	Frente de Loja  |");
                sw.WriteLine("|Status do Atendimento    |Total|Unidade GZ |Total|Flex |Mercatto |Super |Outros |Super |Flex |Outros |");
                sw.WriteLine("|Problemas sanados:       |4    |Jundiaí:	  |4 	|	  |     	|      |       |      |     |       |");
                sw.WriteLine("|Desenvolvimento:         |0	  |ABC:	      |0	|     |	        |      |       |      |     |       |");
                sw.WriteLine("|Atendimento externo:     |0	  |Ribeirão:  |0	|     |	        |      |       |      |     |       |");
                sw.WriteLine("|Dependência cliente:     |0	  |Revenda:	  |0	|     |	        |      |       |      |     |       |");
                sw.WriteLine("|Total de atendimentos:   |4	  |	          |0	|     |	        |      |       |      |     |       |");
                sw.WriteLine("|_______________________ _|_____|___________|_____|_____|_________|______|_______|______|_____|_______|");
                sw.WriteLine();
                
            */