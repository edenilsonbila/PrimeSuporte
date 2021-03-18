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
    public partial class frm_login : Form
    {
        //public static string usuario_online;
      //  public string User_logado = "";
       // public string User_logado_codigo = "";
        public int logins;
        public int max_logins;

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

                if (txt_usuario.Text.Trim() == "Usuario" || txt_usuario.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Campo usuário está em branco","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_usuario.Focus();
                return;
            }

            if (txt_senha.Text.Trim() == string.Empty || txt_senha.Text.Trim() == "Senha")
            {
                MessageBox.Show("Campo senha está em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_senha.Focus();
                return;
            }
            login_bloqueio();
       //  logar(txt_usuario.Text.ToUpper(),txt_senha.Text.ToUpper());
        //verifica_existe_usuario();
        }


        //Este método de login verifica bloqueio de usuario por excesso de login
        public String login_bloqueio() {
            try
            {
                //Cria e executa o select
                String sql = "select * from tb_usuario where ds_usuario=?user and ds_senha=md5(?senha)";

                //Cria o comando a ser passado ao MySql e adiciona os parametros
                MySqlCommand comando = new MySqlCommand(sql);
                comando.Parameters.AddWithValue("?user", txt_usuario.Text);
                comando.Parameters.AddWithValue("?senha", txt_senha.Text);

                //Executa o comando SQL no banco de dados
                //DataTable dt = cls_Conexao.execute_select(sql,comando);
                DataTable dt = cls_Conexao.execute_selectP(comando);

                if (dt.Rows.Count != 0)
                {
                    //Verifica os logins restantes
                    max_logins = Convert.ToInt32(dt.Rows[0]["max_logins"]);
                    logins = Convert.ToInt32(dt.Rows[0]["logins"]);

                    if (logins >= max_logins)
                    {
                        MessageBox.Show("Você excedeu o limite maximo de acessos, contate o administrador do sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                    }
                    else
                    {
                        int logins_rest = max_logins - logins;
                        //  MessageBox.Show(logins_rest+" logins restantes","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        frm_principal principal = new frm_principal();

                        cls_Conexao.user_on = Convert.ToString(dt.Rows[0]["ds_usuario"]);
                        principal.toolUserLogado.Text = cls_Conexao.user_on;
                        cls_Conexao.cod_user_on = Convert.ToString(dt.Rows[0]["id_usuario"]);
                        this.Close();
                        atualizar_login();
                    }
                    /*
                    cls_Conexao.user_on = Convert.ToString(dt.Rows[0]["ds_usuario"]);
                    cls_Conexao.cod_user_on = Convert.ToString(dt.Rows[0]["id_usuario"]);
                    this.Close()*/
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválidos", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_senha.Clear();
                    txt_usuario.Clear();
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Não foi possivel conectar-se ao banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return cls_Conexao.user_on;
        }

        public String login_normal() {

            try
            {
                //Cria e executa o select
                String sql = "select * from tb_usuario where ds_usuario=?user and ds_senha=md5(?senha)";

                //Cria o comando a ser passado ao MySql e adiciona os parametros
                MySqlCommand comando = new MySqlCommand(sql);
                comando.Parameters.AddWithValue("?user", txt_usuario.Text);
                comando.Parameters.AddWithValue("?senha", txt_senha.Text);

                //Executa o comando SQL no banco de dados
                //DataTable dt = cls_Conexao.execute_select(sql,comando);
                DataTable dt = cls_Conexao.execute_selectP(comando);

                if (dt.Rows.Count != 0)
                {
                    cls_Conexao.user_on = Convert.ToString(dt.Rows[0]["ds_usuario"]);
                    // frm_principal principal = new frm_principal();
                    //   principal.toolUserLogado.Text = cls_Conexao.user_on;
                    cls_Conexao.cod_user_on = Convert.ToString(dt.Rows[0]["id_usuario"]);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválidos", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_senha.Clear();
                    txt_usuario.Clear();
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Não foi possivel conectar-se ao banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return cls_Conexao.user_on;
        }

        public string logar(String user, String senha) {
            return login_bloqueio();
        }


        public void atualizar_login() {
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();
            int total_login = logins + 1;
            string sql = "update tb_usuario set logins = "+total_login+" where id_usuario = "+cls_Conexao.cod_user_on+"";
            cls_Conexao.execute_sql(sql);
        }

        private void offline_usuario()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {
                string sql = " update tb_usuario set bi_online = 0 ; ";
                MySqlCommand Mcommand = new MySqlCommand(sql, Mcon);

                Mcommand.ExecuteNonQuery();

            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }


        private void online_usuario()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {
                string sql = " update tb_usuario set bi_online = 1 where ds_usuario = '" + txt_usuario.Text.Trim() + "' and ds_senha = md5('" + txt_senha.Text.Trim() + "'); ";
                MySqlCommand Mcommand = new MySqlCommand(sql, Mcon);

                Mcommand.ExecuteNonQuery();

            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }    
        }

        /*
        private void verifica_existe_usuario_code()
        {

            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {
                string sql = " select id_usuario from tb_usuario where ds_usuario = '" + txt_usuario.Text.Trim() + "' and ds_senha = md5('" + txt_senha.Text.Trim() + "'); ";
                MySqlCommand Mcommand = new MySqlCommand(sql, Mcon);



                frm_principal principal = new frm_principal();
                principal.User_logado_codigo = Convert.ToString(Mcommand.ExecuteScalar());

                User_logado_codigo = Convert.ToString(Mcommand.ExecuteScalar());
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        */

        private void frm_login_Load(object sender, EventArgs e)
        {
          //  cls_Conexao con = new cls_Conexao();
        //    cls_Conexao.user_on = "false";
      //   String driver = con.carregar_parametros();
          //  cls_Conexao.driver = driver;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar a Aplicação","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                  Application.Exit();
            }
            
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "Usuário")
            txt_usuario.Text = "";
         txt_usuario.CharacterCasing = CharacterCasing.Upper;
            txt_usuario.ForeColor = Color.Black;
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
             //   txt_usuario.Text = "Usuario";
                txt_usuario.ForeColor = Color.Gray;
                txt_usuario.PasswordChar = (char)0;
                
               txt_usuario.CharacterCasing = CharacterCasing.Normal;
                txt_usuario.Text = "Usuário";
            }
        }

        private void txt_senha_Enter(object sender, EventArgs e)
        {
            if (txt_senha.Text == "Senha" )
            {
                txt_senha.Text = "";
                txt_senha.ForeColor = Color.Black;
                txt_senha.PasswordChar = '*';
                txt_senha.CharacterCasing = CharacterCasing.Upper;
            }
           
        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            if (txt_senha.Text == "")
            {
                txt_senha.ForeColor = Color.Gray;
                txt_senha.Text = "Senha";
            }
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
          if (cls_Conexao.user_on == "false")
           {
                Application.Exit();
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/*

try
            {
               //Cria e executa o select
               String sql = "select * from tb_usuario where ds_usuario=?user and ds_senha=md5(?senha)";

                //Cria o comando a ser passado ao MySql e adiciona os parametros
               MySqlCommand comando = new MySqlCommand(sql);
               comando.Parameters.AddWithValue("?user",txt_usuario.Text);
               comando.Parameters.AddWithValue("?senha", txt_senha.Text);

                //Executa o comando SQL no banco de dados
               //DataTable dt = cls_Conexao.execute_select(sql,comando);
               DataTable dt = cls_Conexao.execute_selectP(comando);

               if (dt.Rows.Count != 0)
               {
                   cls_Conexao.user_on = Convert.ToString(dt.Rows[0]["ds_usuario"]);
                  // frm_principal principal = new frm_principal();
                //   principal.toolUserLogado.Text = cls_Conexao.user_on;
                   cls_Conexao.cod_user_on = Convert.ToString(dt.Rows[0]["id_usuario"]);
                   this.Close();
               }
               else
               {
                   MessageBox.Show("Usuário ou Senha Inválidos", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   txt_senha.Clear();
                   txt_usuario.Clear();
               }
              
            }
            catch (MySqlException){
                MessageBox.Show("Não foi possivel conectar-se ao banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return cls_Conexao.user_on;

            /*
            //Verifica se retornou registros
            if (dt.Rows.Count != 0)
            {
                //Verifica os logins restantes
                max_logins = Convert.ToInt32(dt.Rows[0]["max_logins"]);
                logins = Convert.ToInt32(dt.Rows[0]["logins"]);

                if (logins >= max_logins)
                {
                    MessageBox.Show("Você excedeu o limite maximo de acessos, contate o administrador do sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                else
                {
                    int logins_rest = max_logins - logins;
                    //  MessageBox.Show(logins_rest+" logins restantes","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frm_principal principal = new frm_principal();

                    cls_Conexao.user_on = Convert.ToString(dt.Rows[0]["ds_usuario"]);
                    principal.toolUserLogado.Text = cls_Conexao.user_on;
                    cls_Conexao.cod_user_on = Convert.ToString(dt.Rows[0]["id_usuario"]);
                    this.Close();
                    atualizar_login();
                }
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_senha.Clear();
                txt_usuario.Clear();
            }
             * */