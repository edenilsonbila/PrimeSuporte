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
    public partial class frm_analise_atendentes : Form
    {
        public frm_analise_atendentes()
        {
            InitializeComponent();
        }

        private void frm_analise_atendentes_Load(object sender, EventArgs e)
        {
            Pesquisar_dados();



        }

        private void Pesquisar_dados()
        {

            cls_Conexao conexao = new cls_Conexao();
           // //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select " +
                            " u.id_usuario as id_usuario, " +
                            " u.ds_usuario as atendente, " +
                            " count(a.id_atendimento) as qtd " +
                            " from tb_atendimento a " +
                            " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                            " group by u.id_usuario; ";

                //" Where date(t.dt_abertura) >= '" + date_time_iniciao.Value.ToString("yyyy-MM-dd") + "' and  date(t.dt_abertura) <= '" + date_time_fim.Value.ToString("yyyy-MM-dd") + "' ";
                
                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                dgv_pesquisa.DataSource = dt;



            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }
            finally
            {

                Mcon.Close();
            }


        }

        private void btn_pesqusiar_Click(object sender, EventArgs e)
        {
            //Verifica se a Data inicial 'e maior que a final
            if (date_time_iniciao.Value.Date > date_time_fim.Value.Date)
            {

               Funcoes.msgAlerta("Data Inicial Não pode ser maior que data Final");
                date_time_iniciao.Focus();
                return;


            }

            pesquisa_com_filtro();


        }

        private void pesquisa_com_filtro()
        {

            cls_Conexao conexao = new cls_Conexao();
         //   //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select " +
                            " u.id_usuario as id_usuario, " +
                            " u.ds_usuario as atendente, " +
                            " count(a.id_atendimento) as qtd " +
                            " from tb_atendimento a " +
                            " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                            " Where date(a.dt_abertura) >= '" + date_time_iniciao.Value.ToString("yyyy-MM-dd") + "'"+ 
                            " and  date(a.dt_abertura) <= '" + date_time_fim.Value.ToString("yyyy-MM-dd") + "' "+
                            " group by u.id_usuario ";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                dgv_pesquisa.DataSource = dt;



            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }
            finally
            {

                Mcon.Close();
            }



        }

    }
}
