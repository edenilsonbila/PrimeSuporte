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
    public partial class frm_registrar_SA : Form
    {
        public frm_registrar_SA()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_listar_atendimentos_Click(object sender, EventArgs e)
        {

            gp_sa.Enabled = false;
            txt_numero_atendimento.Clear();
            btn_registrar_sa.Enabled = false;
            Listar_atendimentos();
        }



        private void limpar()
        {

            gp_sa.Enabled = false;
            txt_numero_atendimento.Clear();
            btn_registrar_sa.Enabled = false;
            Listar_atendimentos();


        }

        private void Listar_atendimentos()
        {

            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {
                string sql = " select id_atendimento, ds_status, nu_sa from tb_atendimento where ds_status = 'Gerar S.A'; ";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();
                Madapter.Fill(dt);

                dgv_atendimento.DataSource = dt;



            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void frm_registrar_SA_Load(object sender, EventArgs e)
        {
            Listar_atendimentos();
        }

        private void dgv_atendimento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {


                    txt_numero_atendimento.Text = dgv_atendimento.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txt_sa.Text = dgv_atendimento.Rows[e.RowIndex].Cells[2].Value.ToString();

                    gp_sa.Enabled = true;

                    if (txt_sa.Text == string.Empty)
                    {
                        btn_registrar_sa.Enabled = true;
                        txt_sa.Focus();
                    }
                }



            }
        }

        private void btn_registrar_sa_Click(object sender, EventArgs e)
        {
            if (txt_numero_atendimento.Text.Trim() == string.Empty)
            {
                return;
            }

            if (txt_sa.Text.Trim() == string.Empty)
            {
                MessageBox.Show("preencha o numero da S.A");
                txt_sa.Focus();
                return;
            }


            bool existe_sa = Verifica_ja_existe_sa(txt_numero_atendimento.Text.Trim());

            if (existe_sa == true)
            {
                MessageBox.Show("SA ja esta Aberta");
                return;
            }
            else
            {


                grava_nu_sa();

                limpar();

                Listar_atendimentos();
            }



        }

        private bool Verifica_ja_existe_sa(string nu_atendimento)
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {
                string sql = "select nu_sa from tb_atendimento where id_atendimento = '" + nu_atendimento + "' ;";

                MySqlCommand Mcommand = new MySqlCommand(sql, Mcon);
                string SA = Convert.ToString(Mcommand.ExecuteScalar());


                if (SA == string.Empty)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }

            return false;



        }

        private void grava_nu_sa()
        {
            string sql = " update tb_atendimento set nu_sa = '" + txt_sa.Text.Trim() + "' where id_atendimento = '" + txt_numero_atendimento.Text.Trim() + "' ; ";

            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {


                MySqlCommand Mcommand = new MySqlCommand(sql, Mcon);
                Mcommand.ExecuteNonQuery();

                MessageBox.Show("S.A [" + txt_sa.Text + "] registrada com sucesso para o Atendimento [" + txt_numero_atendimento.Text + "]");



            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }

    }
}
