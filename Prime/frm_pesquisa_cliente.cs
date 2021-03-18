using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Prime
{
    public partial class frm_pesquisa_cliente : Form
    {
       //Esta variavel foi declarada pelo Danilo, Ver utilidade
        public string codigo_pesquisa = "";

        //Esta variavel servira para realizar a consulta no evento CellContentDoubleClick do Grid e para controle no fechamento do Form
        public string codigo_pesquisa1 = "";

        public frm_pesquisa_cliente()
        {
            InitializeComponent();
        }

        public static string chamador; 
        private void frm_pesquisa_cliente_Load(object sender, EventArgs e)
        {
            Listar_Clientes();
            cb_tp_pesquisa.SelectedText = "CNPJ";
        }

        private void Listar_Clientes()
        {
            cls_Conexao con = new cls_Conexao();
          //  con.carregar_parametros();
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select id_cliente, ds_razao_social, nu_telefone, ds_endereco, nu_cnpj from tb_cliente; ";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();
                Madapter.Fill(dt);

                dgv_cliente.DataSource = dt;


            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }


        private void txt_descricao_TextChanged(object sender, EventArgs e)
        {
            pesquisa_cliente_descricao(txt_descricao.Text);
        }

        private void txt_descricao_Click(object sender, EventArgs e)
        {
            if (txt_descricao.ReadOnly == true)
            {
                txt_descricao.ReadOnly = false;
                txt_codigo.ReadOnly = true;
                txt_codigo.Clear();
            }
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            pesquisa_cliente_codigo(txt_codigo.Text);
        }

        private void txt_codigo_Click(object sender, EventArgs e)
        {
            if (txt_codigo.ReadOnly == true)
            {
                txt_codigo.ReadOnly = false;
                txt_descricao.ReadOnly = true;
                txt_descricao.Clear();
            }
        }

        private void pesquisa_cliente_codigo(string codigo)
        {

            cls_Conexao con = new cls_Conexao();
            //con.carregar_parametros();
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select id_cliente, ds_razao_social, nu_telefone, ds_endereco, nu_cnpj from tb_cliente where id_cliente = '"+codigo+"'; ";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();
                Madapter.Fill(dt);

                dgv_cliente.DataSource = dt;


            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void pesquisa_cliente_descricao(string descricao)
        {

            cls_Conexao con = new cls_Conexao();
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            string sql = String.Empty;
   
            string teste = cb_tp_pesquisa.Text;
            
            switch (teste)
            { 
                case "CNPJ":
                    sql = "select id_cliente, ds_razao_social, nu_telefone, ds_endereco, nu_cnpj from tb_cliente where nu_cnpj = '" + descricao + "';";
                    break;
                case "FANTASIA":
                    sql = "select id_cliente, ds_razao_social, nu_telefone, ds_endereco, nu_cnpj from tb_cliente where fantasia like '%" + descricao + "%' ; ";
                    break;
                case "CODIGO":
                    sql = "select id_cliente, ds_razao_social, nu_telefone, ds_endereco, nu_cnpj from tb_cliente where id_cliente = '" + descricao + "' ; ";
                    break;
                case "RAZAO SOCIAL":
                     sql = "select id_cliente, ds_razao_social, nu_telefone, ds_endereco, nu_cnpj from tb_cliente where ds_razao_social like '%" + descricao + "%' ; ";
                    break;

            }

            try
            {
               // string sql = "select id_cliente, ds_razao_social, nu_telefone, ds_endereco, nu_cnpj from tb_cliente where ds_razao_social like '%" + descricao+ "%' ; ";
                if (sql != String.Empty)
                {
                    MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                    DataTable dt = new DataTable();
                    Madapter.Fill(dt);

                    dgv_cliente.DataSource = dt;

                }
            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void dgv_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                //codigo_pesquisa; //Variavel vai receber o código que esta no link

                //Codigo de pesquisa 'e a variavel que tem o codigo para carregar o produto na tela
                
                
                codigo_pesquisa = dgv_cliente.Rows[e.RowIndex].Cells[0].Value.ToString();


                frm_atendimento atendimento = new frm_atendimento();
                atendimento.cliente_pesquisado = codigo_pesquisa;
                
                //MessageBox.Show(codigo_pesquisa);
                this.Close();

            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            frm_cadastro_cliente.fechamento_pesquisa_nulo = true;
            frm_atendimento.nulo = true;
            this.Close();
        }

        private void dgv_cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Pega o codigo do cliente selecionado
                codigo_pesquisa1 = dgv_cliente.Rows[e.RowIndex].Cells[0].Value.ToString();

                //Monta o select
                // String sql = "select * from tb_cliente where id_cliente = " + codigo_pesquisa + "";

              //  String sql = "select c.id_cliente, c.ds_razao_social, c.nu_telefone, c.ds_endereco, c.nu_cnpj, c.fantasia, c.cod_controller" +
                String sql = "select c.id_cliente, c.ds_razao_social, c.nu_telefone, c.ds_endereco, c.nu_cnpj, c.fantasia, cod_controller," +
                             " f.id_filial, f.ds_filial as filial," +
                             " r.id_sistema as id_retaguarda, r.ds_sistema as retaguarda," +
                             " fr.id_sistema as id_frente, fr.ds_sistema as frente" +
                             " from tb_cliente c" +
                             " inner join tb_filial f on c.filial = f.id_filial" +
                             " inner join tb_sistema r on c.retaguarda = r.id_sistema" +
                             " inner join tb_sistema fr on c.frente = fr.id_sistema" +
                             " where c.id_cliente = " + codigo_pesquisa1 + "";

                if (chamador == "frm_atendimento")
                {
                   

                    //Cria o datatable e popula ele com resultado do select acima
                    frm_atendimento.dt = cls_Conexao.execute_select(sql);

                    //Esconde o formulario
                    this.Close();
                }//fim if (chamador == "frm_atendimento")
                

            if(chamador == "cadastro_cliente"){

                //Cria o datatable e popula ele com resultado do select acima
                frm_cadastro_cliente.dt_retorno_pesquisa = cls_Conexao.execute_select(sql);

                //Esconde o formulario
                this.Close();

                /*
                String sql = "select c.*, f.id_filial as id_filial, f.ds_filial as filial, r.id_sistema as id_retaguarda, r.ds_sistema as retaguarda, fr.id_sistema as id_frente from tb_cliente c " +
                                " inner join tb_filial f on c.filial = f.id_filial" +
                                " inner join tb_sistema r on c.retaguarda = r.id_sistema" +
                                " inner join tb_sistema fr on c.frente = fr.id_sistema" +
                                " where c.id_cliente = "+cod_pesquisa+"";
                */
            }//Fim if(chamador == "cadastro_cliente")

            }//Fim if (e.RowIndex != 0)
        }

        private void frm_pesquisa_cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (codigo_pesquisa1 == "")
            {   
            frm_cadastro_cliente.fechamento_pesquisa_nulo = true;
            frm_atendimento.nulo = true;
         }
        }//fim metodo
    }
}
