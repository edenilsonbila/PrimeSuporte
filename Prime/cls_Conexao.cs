using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Prime
{

    
    class cls_Conexao
    {
        public static string dbname = "helpdeskdb";
        public static string server = "192.168.1.37";
        public static string uid = "prime";
       public static string pwd = "All!ance";
        public static string driver = "server=" + server + ";database=" + dbname + ";uid=" + uid + ";pwd=" + pwd + ";";
        public static string user_on = "";
        public static string cod_user_on = "";
       // public string string_conection;

        public string recebe_user_online(String usuario) {
            user_on = usuario;
            return user_on;
        }

        public string recebe_cod_user(String cod_user)
        {
            cod_user_on = cod_user;
            return cod_user;
        }

       // public string string_conection = "server=" + server + ";database=" + dbname + ";uid=" + uid + ";pwd=" + pwd + ";";

        public static Boolean insert(MySqlCommand comando) {

            Boolean sucess = false;
           
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            comando.Connection = Mcon;

            try
            {
                comando.ExecuteNonQuery();
                sucess = true;
            }
            catch (Exception)
            {
                sucess = false;
                Funcoes.msgErro("Falha ao inserir registro");
                throw;
            }
            Mcon.Close();
            return sucess;
        }

        public static Boolean update(MySqlCommand comando)
        {

            Boolean sucess = false;

            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            comando.Connection = Mcon;

            try
            {
                comando.ExecuteNonQuery();
                sucess = true;
            }
            catch (Exception)
            {
                sucess = false;
                Funcoes.msgErro("Falha ao inserir registro");
                throw;
            }
            Mcon.Close();
            return sucess;
        }


        //Select
        public static DataTable execute_select(String sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            MySqlDataAdapter dta = new MySqlDataAdapter(sql, Mcon);
            dta.Fill(dt);
            Mcon.Close();
            return dt;
        }

        //Executa comandos SELECT com paramentros e não concatenação
        public static DataTable execute_selectP(MySqlCommand comando)
        {
            //Cria o DataTable que receberá o resultado da Consulta
            DataTable dt = new DataTable();

            //Cria a conexão com a Base de Dados
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            //Aponta ao MySqlCommand que esta vindo por parametro, qual será a conexão a ser utilizada
            comando.Connection = Mcon;
   
            //Cria o DataAdapter que executara o comando SQL, e mostra a ela qual comando executar
            MySqlDataAdapter dta = new MySqlDataAdapter(comando);

            //Preenche o DataTabel com o Retorno do Select
            dta.Fill(dt);

            Mcon.Close();

            //Retorna o DataTable ao solicitante
            return dt;
        } 

        //Update, Delete, Insert
        public static void execute_sql(String comando)
        {
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();
            MySqlCommand comand = new MySqlCommand(comando, Mcon);
            try
            {
                comand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao executar comando: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Mcon.Close();

        }

        public static void conectar() {
            driver = "server=" + server + ";database=" + dbname + ";uid=" + uid + ";pwd=" + pwd + ";";
            MySqlConnection conexao = new MySqlConnection(driver);
            try
            {
                conexao.Open();
            }
            catch {
                Funcoes.msgErro("Falha ao conectar ao Banco de Dados");
            }
        }


        public string carregar_parametros()
        {

           // bool arq_existe = verifica_existe_arquivo_config();

            if (File.Exists("config.ini"))
         //   if (arq_existe == true)
            {

                StreamReader sr = new StreamReader("config.ini");
                string arquivo = sr.ReadToEnd();
                string[] arquivoVet = arquivo.Split('\r');

                string linha1 = arquivoVet[0];
                string linha2 = arquivoVet[1];
                string linha3 = arquivoVet[2];
                string linha4 = arquivoVet[3];

                linha1 = linha1.Replace("dbname=", "");
                linha2 = linha2.Replace("\nuserdb=", "");
                linha3 = linha3.Replace("\nsenhadb=", "");
                linha4 = linha4.Replace("\nserverdb=", "");

                dbname = linha1;
                server = linha4;
                uid = linha2;
                //Descriptografa a senha...
                pwd = Criptografia.Decript(linha3);

                driver = "server=" + server + ";database=" + dbname + ";uid=" + uid + ";pwd=" + pwd + ";";
            }
            else
            {
                MessageBox.Show("Arquivo de Configuração não encontrado!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Exit();
            }
            return driver;
        }
    }

}
