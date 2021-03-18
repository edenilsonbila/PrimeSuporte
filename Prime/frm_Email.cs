using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prime
{
    public partial class frm_Email : Form
    {
        public frm_Email()
        {
            InitializeComponent();
        }

        public int total_atendimento()
        {
            //Cria o select
            String sql = "select count(*) from tb_atendimento where id_usuario = ?id and dt_abertura = ?data";
            //Monta o comando
            MySqlCommand comando = new MySqlCommand(sql);
            comando.Parameters.AddWithValue("?id", cls_Conexao.cod_user_on);
            comando.Parameters.AddWithValue("?data", tb_data.Value.ToString("yyyy/MM/dd"));

            //Executa o comando e pega o valor retornado do Banco
            int total_atendimentos = Convert.ToInt32(cls_Conexao.execute_selectP(comando).Rows[0]["count(*)"].ToString());

            //Retorna o valor para chamada de função
            return total_atendimentos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Monta o comando que buscara os parametros para o Envio do e-mail.
            String sqlCommand = "select smtp,porta,usuario_smtp,senha_smtp from tb_usuario where id_usuario = " + cls_Conexao.cod_user_on;
            DataTable retornoBanco = cls_Conexao.execute_select(sqlCommand);

            //Verifica se há parâmetros para enviar o e-mail
            if (retornoBanco.Rows[0]["smtp"].ToString() != String.Empty)
            {
                String destinatario = "";
                String cc1 = "";
                String cc2 = "";

                //recupera os parametros
                String host = retornoBanco.Rows[0]["smtp"].ToString();
                int porta = Convert.ToInt32(retornoBanco.Rows[0]["porta"].ToString());
                String usuario = retornoBanco.Rows[0]["usuario_smtp"].ToString();
                String senha = Criptografia.Decript(retornoBanco.Rows[0]["senha_smtp"].ToString());

                //Monta o SMTP com os paratros vindos do banco
                SmtpClient smtp = getSMTP(host, porta, usuario, senha);
                MailMessage email = getEmail(usuario);

                //valida destinatario
                if (Funcoes.ValidarEmail(tb_para.Text) == true)
                  {
                    destinatario = tb_para.Text;
                    email.To.Add(destinatario);
                  }else{
                    Funcoes.msgAlerta("E-mail destinatário invalido");
                    tb_para.Focus();
                    return;
                }

                //Valida CC´s
                if (tb_cc.Text != "")
                {
                    if (Funcoes.ValidarEmail(tb_cc.Text) == true)
                    {
                        cc1 = tb_cc.Text;
                        email.CC.Add(cc1);
                    }
                    else
                    {
                        Funcoes.msgAlerta("E-mail destinatário invalido");
                        return;
                    }
                }

                if (tb_cc1.Text != "")
                {
                    if (Funcoes.ValidarEmail(tb_cc1.Text) == true)
                    {
                        cc2 = tb_cc1.Text;
                        email.CC.Add(cc2);
                    }
                    else
                    {
                        Funcoes.msgAlerta("E-mail destinatário invalido");
                        return;
                    }
                }
                

                try
                {
                    if (gerarArquivo() != String.Empty)
                    {
                        smtp.Send(email);
                        Funcoes.msgInfo("E-mail enviado com sucesso!");
                    }
                    else {
                        Funcoes.msgAlerta("Nenhum registro encontrado");
                    }
                }
                catch (SmtpException ex)
                {
                    Funcoes.msgErro("Falha ao enviar e-mail erro: " + ex);
                }

            }
            else
            {
                Funcoes.msgInfo("Parâmetros de e-mail não configurado");
            }
        }

        public int recupera_totais(String clausula)
        {

            //Cria o select
            String sql = "select count(*) from tb_atendimento where id_usuario = ?id and dt_abertura = ?data and " + clausula + "";
            //Monta o comando
            MySqlCommand comando = new MySqlCommand(sql);
            comando.Parameters.AddWithValue("?id", cls_Conexao.cod_user_on);
            comando.Parameters.AddWithValue("?data", tb_data.Value.ToString("yyyy/MM/dd"));

            //Executa o comando e pega o valor retornado do Banco
            int total_atendimentos = Convert.ToInt32(cls_Conexao.execute_selectP(comando).Rows[0]["count(*)"].ToString());

            //Retorna o valor para chamada de função
            return total_atendimentos;
        }

        public String gerarArquivo()
        {
            String clausula;
            String mailMessage = "";

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
                mailMessage = "============== TOTAL ATENDIMENTO ==================== <br/>" +
                     "<br/>" +
                     "ATENDIMENTOS: " + total_atendimento() + "<br/>" +
                     "<br/>" +
                     "====================== STATUS =======================" +
                     "<br/>" +
                     "SANADO: " + total_sanado + "<br/>" +
                     "EXTERNO: " + total_externo + "<br/>" +
                     "DESENVOLVIMENTO: " + total_des + "<br/>" +
                     "PENDENTE: " + total_pendente + "<br/>" +
                     "====================== FILIAL =======================" +
                     "<br/>" +
                     "JUNDIAI: " + total_jdi + "<br/>" +
                     "ABC: " + total_abc + "<br/>" +
                     "RIBEIRAO: " + total_rib + "<br/>" +
                     "REVENDA " + total_rev + "<br/>" +
                     "<br/>" +
                     "=================== RETAGUARDA ======================" + "<br/>" +
                     "MERCOFLEX: " + total_flex + "<br/>" +
                     "MERCATTO: " + total_mercatto + "<br/>" +
                     "SUPER: " + total_super + "<br/>" +
                     "OUTROS: " + total_outros + "<br/>" +
                     "<br/>" +
                     "====================== FRENTE =======================" + "<br/>" +
                     "FLEX: " + total_f_flex + " | SUPER:   " + total_f_super + "    | OUTROS: " + total_f_outros + "<br/>" +
                     "=====================================================" + "<br/>" +
                     "<br/>" +
                     "<br/>" +
                     "===================== CLIENTES ======================" +
                     "<br/>";

                int i = 0;


                for (i = 0; i < dt.Rows.Count; i++)
                {
                    mailMessage += "<br/>" +
                    "Código cliente : " + dt.Rows[i]["cod_controller"] + "<br/>" +
                    "Nome estabelecimento: " + dt.Rows[i]["ds_razao_social"] + "<br/>" +
                    "CNPJ: " + dt.Rows[i]["nu_cnpj"] + "<br/>" +
                    "Localidade: " + dt.Rows[i]["ds_filial"] + "<br/>" +
                    "Contato: " + dt.Rows[i]["ds_contato_cliente"] + "<br/>" +
                    "Telefone: " + dt.Rows[i]["nu_telefone"] + "<br/>" +
                    "Sistema: " + dt.Rows[i]["retaguarda"] + "         Frente: " + dt.Rows[i]["frente"] + "<br/>" +
                    "Problema: " + dt.Rows[i]["ds_problema"] + "<br/>" +
                    "Solução: " + dt.Rows[i]["ds_solucao"] + "<br/>" +
                    "<br/>" +
                    "=====================================================";

                }
            }

            return mailMessage;
        }

        public SmtpClient getSMTP(String host, int porta, String usuario, String senha)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = host;
            smtp.Port = porta;
            smtp.Credentials = new System.Net.NetworkCredential(usuario, senha);
            return smtp;
        }

        public MailMessage getEmail(String remetente)
        {
            MailMessage email = new MailMessage();
            email.IsBodyHtml = true;
            email.From = new MailAddress(remetente);
            email.Subject = "Atendimentos Diários " + tb_data.Value.ToString("dd/MM/yyyy");
            email.Body = gerarArquivo();
            email.Priority = System.Net.Mail.MailPriority.Normal;
            email.SubjectEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            email.BodyEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            return email;
        }

        private void frm_Email_Load(object sender, EventArgs e)
        {

        }
    }
}
