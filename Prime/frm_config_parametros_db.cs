using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Prime
{
    public partial class frm_config_parametros_db : Form
    {
        public frm_config_parametros_db()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
          //  this.Close();
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {

            bool validacao_campos = valida_campos();

            if (validacao_campos == true)
            {

                string dbname = txt_nome_banco.Text.Trim();
                string user = txt_usuario_banco.Text.Trim();

                //Criptografa a senha.
                string senha = Criptografia.Encrypt(txt_senha_banco.Text.Trim());
             
                string localdb = txt_endereco_banco.Text.Trim();

                StreamWriter sw = new StreamWriter("config.ini");
                sw.WriteLine("dbname=" + dbname);
                sw.WriteLine("userdb=" + user);
                sw.WriteLine("senhadb=" + senha);
                sw.WriteLine("serverdb=" + localdb);

                sw.Close();

                MessageBox.Show("Arquivo de configuracao criado com Sucesso");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private bool valida_campos()
        {

            if (txt_nome_banco.Text.Trim() == String.Empty)
            {
                MessageBox.Show(" Preecha o Campo [Nome do Banco]");
                txt_nome_banco.Focus();

                return false;
            }

            if (txt_senha_banco.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Campo senha não pode estar em branco","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_senha_banco.Focus();

                return false;
            }

            if (txt_usuario_banco.Text.Trim() == String.Empty)
            {
                MessageBox.Show(" Preecha o Campo [Usuário]");
                txt_usuario_banco.Focus();

                return false;
            }

            if (txt_endereco_banco.Text.Trim() == String.Empty)
            {
                MessageBox.Show(" Preecha o Campo [Endereço]");
                txt_endereco_banco.Focus();

                return false;
            }



            return true;
        }

        private void teste_conexao_db()
        {

            string dbname = txt_nome_banco.Text.Trim();
            string user = txt_usuario_banco.Text.Trim();
            string senha = txt_senha_banco.Text.Trim();
            string localdb = txt_endereco_banco.Text.Trim();

            string string_conection = "server=" + localdb + ";database=" + dbname + ";uid=" + user + ";pwd=" + senha + ";";

            MySqlConnection Mcon = new MySqlConnection(string_conection);
            

            try
            {
                Mcon.Open();

                if (Mcon.State == ConnectionState.Open)
                {

                    MessageBox.Show("Conectado ");
                }
                

            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }
            catch (TimeoutException errr)
            {

                MessageBox.Show(errr.Message);
            }



        }

        private void btn_testar_Click(object sender, EventArgs e)
        {
            teste_conexao_db();
        }

        private void frm_config_parametros_db_Load(object sender, EventArgs e)
        {

        }

    }
}
