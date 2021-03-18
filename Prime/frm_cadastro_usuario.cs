using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Prime
{
    public partial class frm_cadastro_usuario : Form
    {

        string Evento = "";
        string user_logado = "";

        public frm_cadastro_usuario()
        {
            InitializeComponent();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {

            
            Evento = "Incluir";

            Habilitar_campos();

            btn_excluir.Enabled = false;

          //  ver_usuario_logado();

            verifica_primeiro_atendimento();

            gb_email.Enabled = true;
            tb_codigo.Enabled = true;
            btn_pesq.Enabled = true;
        }


        private void Habilitar_campos()
        {
            //Campos
            tb_usuario.Enabled = true;
            tb_senha.Enabled = true;
            rb_tipoA.Enabled = true;
            gb_tipo.Enabled = true;
            tb_smtp.Enabled = true;
            tb_senha_smtp.Enabled = true;
            tb_usuario_smtp.Enabled = true;
            tb_porta.Enabled = true;


            //Botões
          //  btn_excluir.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_confirmar.Enabled = true;

            //Habilitar
            btn_incluir.Enabled = false;
            tb_codigo.Enabled = false;
            btn_pesq.Enabled = false;

            limpar_campos();
            /*
            group_campos.Enabled = true;

            tb_usuario.Enabled = true;
            tb_senha.Enabled = true;

            

            btn_incluir.Enabled = false;
            btn_fechar.Enabled = false;

            btn_confirmar.Enabled = true;
            btn_cancelar.Enabled = true;

            groupBox1.Enabled = true;
            */
        }

        private void ver_usuario_logado()
        {

            cls_Conexao conexao = new cls_Conexao();
            ////conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select id_usuario from tb_usuario where bi_online = 1 ";

                MySqlCommand Mcommand = new MySqlCommand(sql, Mcon);

                user_logado = Convert.ToString(Mcommand.ExecuteScalar());


            }
            catch (MySqlException err)
            {
                Funcoes.msgErro("Erro ao consultar o Banco de Dados Erro: "+err.Message);
      
            }
            finally
            {

                Mcon.Close();
            }


        }


        private void Desabilita_campos()
        {
            //Campos
            tb_usuario.Enabled = false;
            tb_senha.Enabled = false;
            rb_tipoA.Enabled = false;
            gb_tipo.Enabled = false;
            tb_smtp.Enabled = false;
            tb_senha_smtp.Enabled = false;
            tb_usuario_smtp.Enabled = false;
            tb_porta.Enabled = false;
            

            //Botões
            btn_excluir.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_confirmar.Enabled = false;

            //Habilitar
            btn_incluir.Enabled = true;
            tb_codigo.Enabled = true;
            btn_pesq.Enabled = true;

            limpar_campos();


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Desabilita_campos();
            gb_email.Enabled = false;

          //  btn_alterar.Enabled = false;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_cadastro_usuario_Load(object sender, EventArgs e)
        {
        //    Listar_usuarios();
            tb_senha.Enabled = false;
            tb_usuario.Enabled = false;
            tb_codigo.Enabled = true;
            btn_pesq.Enabled = true;
        }

        private void verifica_primeiro_atendimento()
        {
            cls_Conexao conexao = new cls_Conexao();
          //  //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {

                string Sql = "select count(*) from tb_usuario";
                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);

                int qtd_registro = Convert.ToInt16(Mcomand.ExecuteScalar());

                if (qtd_registro > 0)
                {
                    //ja ouve um registro cadastrado
                    verifica_numero_proximo_atendimento();
                }
                else
                {
                    tb_codigo.Text = "1";
                }



            }
            catch (MySqlException err)
            {

                Funcoes.msgErro("Erro ao consultar o Banco de Dados Erro: " + err.Message);
            }


        }

        private void verifica_numero_proximo_atendimento()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {

                string Sql = "select max(id_usuario)+1 from tb_usuario";
                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);

                string codigo = Convert.ToString(Mcomand.ExecuteScalar());

                tb_codigo.Text = codigo;


            }
            catch (MySqlException err)
            {

                Funcoes.msgErro("Erro ao consultar o Banco de Dados Erro: " + err.Message);
            }
        }

        private void limpar_campos()
        {
           tb_codigo.Clear();
            tb_usuario.Clear();
            tb_senha.Clear();


        }

        private bool Valida_campos()
        {


            if (tb_usuario.Text.Trim() == string.Empty)
            {

                Funcoes.msgAlerta("Preencha o campo Nome");
                tb_usuario.Focus();
                return false;

            }
          

            if (tb_senha.Text.Trim() == string.Empty)
            {

                Funcoes.msgAlerta("Preencha o campo Senha");
                tb_senha.Focus();
                return false;

            }

            return true;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (Evento == "Incluir")
            {
                bool validos = Valida_campos();

                if (validos == true)
                {

                    Cadastrar_usuario();
                    Desabilita_campos();
                    Listar_usuarios();
                }
                else
                {
                    return;

                }

            }
            if (Evento == "Alterar")
            {
                bool validos = Valida_campos();

                if (validos == true)
                {

                    Atualizar_usuario();
                    Desabilita_campos();
                    Listar_usuarios();
                }
                else
                {
                    return;
                }

            }

            Evento = "";

        }

        private void Cadastrar_usuario()
        {
            cls_Conexao conexao = new cls_Conexao();
           //conexao.carregar_parametros()
           MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {
                string tp_usuario = "";
                string ds_usuario = tb_usuario.Text.Trim();
                string ds_senha = tb_senha.Text.Trim();


                if (rb_tipoA.Checked == true)
                {
                    tp_usuario = "admin";
                }
                else
                {
                    tp_usuario = "user";
                }

                string Sql = " insert into tb_usuario " +
                            " (ds_usuario, ds_senha, tp_usuario, dt_cadastro, ds_user_cadastro,smtp,porta,usuario_smtp,senha_smtp) " +
                            " Values " +
                          //  "(?usuario,?senha,?tipo,?dt_cadastro,?user_cadastro,?smtp,?porta,?usuario_smtp,?senha_smtp)"+
                            " ('" + ds_usuario + "', md5('" + ds_senha + "'), '" + tp_usuario + "', now(), '" + cls_Conexao.user_on + "','" + tb_smtp.Text + "', '" + tb_porta.Text + "', '" + tb_usuario_smtp.Text + "','" + Criptografia.Encrypt(tb_senha_smtp.Text) + "')";
        
                MySqlCommand Mcomand = new MySqlCommand(Sql,Mcon);
              //  Mcomand.Parameters.AddWithValue("?usuario",ds_usuario);
              //  Mcomand.Parameters.AddWithValue("?senha", "md5(" + ds_senha + ")");
              //  Mcomand.Parameters.AddWithValue("?tipo", tp_usuario);
               // Mcomand.Parameters.AddWithValue("?dt_cadastro", DateTime.Now.ToString("yyyy/MM/dd"));
               // Mcomand.Parameters.AddWithValue("?user_cadastro", cls_Conexao.user_on);
               // Mcomand.Parameters.AddWithValue("?smtp", tb_smtp.Text);
               // Mcomand.Parameters.AddWithValue("?porta_smtp", tb_porta.Text);
              //  Mcomand.Parameters.AddWithValue("?usuario_smtp", tb_usuario_smtp.Text);
               // Mcomand.Parameters.AddWithValue("?senha_smtp", "md5(" + tb_senha_smtp.Text + ")");

                Mcomand.ExecuteNonQuery();

                Funcoes.msgInfo("Usuário Cadastrado com Sucesso");
                gb_email.Enabled = false;

            }
            catch (MySqlException err)
            {

                Funcoes.msgErro("Erro ao consultar o Banco de Dados Erro: " + err.Message);
            }




        }

        /// <summary>
        /// Funcao para Atualizar usuarios
        /// </summary>
        private void Atualizar_usuario()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {
                string tp_usuario = "";
                string ds_usuario = tb_usuario.Text.Trim();
                string ds_senha = tb_senha.Text.Trim();


                if (rb_tipoA.Checked == true)
                {
                    tp_usuario = "admin";
                }
                else
                {
                    tp_usuario = "user";
                }

                string Sql = " Update tb_usuario " +
                            " set ds_usuario = '" + ds_usuario + "', ds_senha = md5('" + ds_senha + "'), tp_usuario = '" + tp_usuario + "'  " +
                            " where id_usuario =  " + tb_codigo.Text + " ;";




                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);
                Mcomand.ExecuteNonQuery();

                Funcoes.msgInfo("Usuário [" + ds_usuario + "] Alterado com Sucesso");


            }
            catch (MySqlException err)
            {

                Funcoes.msgErro("Erro ao consultar o Banco de Dados Erro: " + err.Message);
            }




        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Evento = "Alterar";
            //btn_alterar.Enabled = false;

        }

        private void Listar_usuarios()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {

                string sql = " select id_usuario, ds_usuario, tp_usuario, dt_cadastro from tb_usuario; ";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                dgv_usuarios.DataSource = dt;




            }
            catch (MySqlException err)
            {

                Funcoes.msgErro("Erro ao consultar o Banco de Dados Erro: " + err.Message);
            }


        }

        private void dgv_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {

                    string codigo_pesquisa; //Variavel vai receber o código que esta no link
                    codigo_pesquisa = dgv_usuarios.Rows[e.RowIndex].Cells[0].Value.ToString();

                    tb_codigo.Text = codigo_pesquisa;
                    tb_usuario.Text = dgv_usuarios.Rows[e.RowIndex].Cells[1].Value.ToString();

                    string tipo_user = dgv_usuarios.Rows[e.RowIndex].Cells[2].Value.ToString();


                    if (tipo_user == "admin")
                    {
                        rb_tipoA.Checked = true;

                    }

                    if (tipo_user == "user")
                    {
                        rb_tipoU.Checked = true;

                    }

                    Habilitar_campos();
                    //btn_alterar.Enabled = true;


                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gb_email.Enabled = false;
        }

        private void tb_porta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_pesq_Click(object sender, EventArgs e)
        {
            frm_pesquisa_usuario pesquisa = new frm_pesquisa_usuario();
            pesquisa.ShowDialog();
        }

        private void txt_codigo_usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica a tecla prescionada 'ENTER'
            if(e.KeyChar == 13){
                //Monta select 
                string select = "select * from tb_usuario where id_usuario = ?id";

                //Cria e parametriza o comando
                MySqlCommand comando = new MySqlCommand(select);
                comando.Parameters.AddWithValue("?id", tb_codigo.Text);

                //Joga o resultado do select para o dataTable
                DataTable dt = cls_Conexao.execute_selectP(comando);

                //Verifica o retorno
                if (dt.Rows.Count > 0)
                {
                    Habilitar_campos();
                    preencherCampos(dt);
                }
                else
                {
                    Funcoes.msgInfo("Código não cadastrado");
                }
            }
        }

        public void preencherCampos(DataTable dt) { 
        tb_codigo.Text = dt.Rows[0]["id_usuario"].ToString();
     //   tb_usuario.Text = dt.Rows[0]["ds_usuario"].ToString();
        tb_senha.Text = dt.Rows[0]["ds_senha"].ToString();
        String tipo = dt.Rows[0]["id_usuario"].ToString();
        tb_smtp.Text = dt.Rows[0]["smtp"].ToString();
        tb_usuario_smtp.Text = dt.Rows[0]["usuario_smtp"].ToString();
       // tb_senha_smtp.Text = dt.Rows[0]["senha_smtp"].ToString();
        tb_porta.Text = dt.Rows[0]["porta"].ToString();

        if (tipo.Equals("admin"))
        {
            rb_tipoA.Select();
        }
        else {
            rb_tipoU.Select();
        }
        }
    }
}
