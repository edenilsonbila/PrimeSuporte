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
    public partial class frm_visualizacao_de__Atendimentos : Form
    {
        public string id_atendimento;

        public frm_visualizacao_de__Atendimentos()
        {
            InitializeComponent();
        }

        private void frm_visualizacao_de__Atendimentos_Load(object sender, EventArgs e)
        {
            //Função que traz na tela os dados relacionados ao atendimento selecionado
            Carregar_Dados_atendimento(id_atendimento);



        }

        private void Carregar_Dados_atendimento(string id_atendimento)
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {
                string Sql = " select " +
                            " t.id_atendimento as id_atendimento, " +
                            " t.nu_sa as nu_sa, "+
                            " u.ds_usuario as ds_usuario, " +
                            " f.ds_filial as ds_filial, " +
                            " s.ds_sistema as ds_sistema, " +
                            " t.ds_status as ds_status, " +
                            " c.ds_razao_social as ds_razao_social, " +
                            " t.ds_problema as ds_problema, " +
                            " t.ds_solucao as ds_solucao, " +
                            " t.ds_observacao as ds_observacao, " +
                            " t.dt_abertura as dt_abertura, " +
                            " t.dt_fechamento as dt_fechamento " +

                            " from " +
                            " tb_atendimento t " +

                            " inner join tb_usuario u on u.id_usuario = t.id_usuario " +
                            " inner join tb_filial f on f.id_filial = t.id_filial " +
                            " inner join tb_sistema s on s.id_sistema = t.id_sistema " +
                            " inner join tb_cliente c on c.id_cliente = t.id_cliente " +

                            " where t.id_atendimento = '" + id_atendimento + "' ";



                MySqlDataAdapter Madapter = new MySqlDataAdapter(Sql, Mcon);

                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                //Jogo cada informação para um campo LABELs
                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    lbl_atendente.Text = Convert.ToString(dt.Rows[i]["ds_usuario"]);
                    lbl_cliente.Text = Convert.ToString(dt.Rows[i]["ds_razao_social"]);
                    lbl_data_fim.Text = Convert.ToString(dt.Rows[i]["dt_fechamento"]);
                    lbl_data_inicio.Text = Convert.ToString(dt.Rows[i]["dt_abertura"]);

                    lbl_filial.Text = Convert.ToString(dt.Rows[i]["ds_filial"]);
                    lbl_numero_atendimento.Text = Convert.ToString(dt.Rows[i]["id_atendimento"]);
                    lbl_obs.Text = Convert.ToString(dt.Rows[i]["ds_observacao"]);
                    lbl_problema.Text = Convert.ToString(dt.Rows[i]["ds_problema"]);

                    lbl_sistema.Text = Convert.ToString(dt.Rows[i]["ds_sistema"]);
                    lbl_solucao.Text = Convert.ToString(dt.Rows[i]["ds_solucao"]);
                    lbl_status.Text = Convert.ToString(dt.Rows[i]["ds_status"]);

                    lbl_sa.Text = Convert.ToString(dt.Rows[i]["nu_sa"]);

                }

            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }







        }
    }
}
