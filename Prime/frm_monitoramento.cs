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
    public partial class frm_monitoramento : Form
    {
        /*
        //N~ao foi necessario utilizar isto
        int bi_filtro_data = 0;
        int bi_filtro_usuario = 0;
        int bi_filtro_status = 0;
        int bi_filtro_filial = 0;
        int bi_filtro_cliente = 0;
        int bi_filtro_sistema = 0;
        */
         
        public frm_monitoramento()
        {
            InitializeComponent();
        }

        private void frm_monitoramento_Load(object sender, EventArgs e)
        {
            Listar_dados_grid();
            carregar_combo_filial();
            carregar_combo_usuario();
            carregar_combo_cliente();
            carregar_combo_sistema();
        }

        /// <summary>
        /// Funcao para listar todos os registros da tabela Tb_atendimento com alguns joins
        /// </summary>
        private void Listar_dados_grid()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {

                string sql = "select " +
                             " t.id_atendimento as id_atendimento, " +
                             " u.ds_usuario as user, " +
                             " t.ds_status as status, " +
                             " f.ds_filial as filial, " +
                             " c.ds_razao_social as cliente, " +
                             " s.ds_sistema as sistema, " +
                             " t.dt_abertura as abertura, " +
                             " t.dt_fechamento as fechamento " +
                             " from tb_atendimento t " +
                             " inner join tb_usuario u on u.id_usuario = t.id_usuario " +
                             " inner join tb_filial f on f.id_filial = t.id_filial " +
                             " inner join tb_cliente c on c.id_cliente = t.id_cliente " +
                             " inner join tb_sistema s on s.id_sistema = t.id_sistema ";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);


                dgv_pesquisa.DataSource = dt;

            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void btn_listar_todos_Click(object sender, EventArgs e)
        {

            // Carrega o GRID com os dados Sem Filtro
            Listar_dados_grid();
        }

        /// <summary>
        /// Funcao para carregar combno USuario
        /// </summary>
        private void carregar_combo_usuario()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select id_usuario, ds_usuario from tb_usuario";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                cmb_usuario.DataSource = dt;
                cmb_usuario.DisplayMember = "ds_usuario";
                cmb_usuario.ValueMember = "id_usuario";



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

        /// <summary>
        /// Funcao para carregar o combo Filial
        /// </summary>
        private void carregar_combo_filial()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select id_filial, ds_filial from tb_filial";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                cmb_filial.DataSource = dt;
                cmb_filial.DisplayMember = "ds_filial";
                cmb_filial.ValueMember = "id_filial";



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

        /// <summary>
        /// Funcao para carregar o combo cliente
        /// </summary>
        private void carregar_combo_cliente()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select id_cliente, ds_razao_social from tb_cliente";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                cmb_cliente.DataSource = dt;
                cmb_cliente.DisplayMember = "ds_razao_social";
                cmb_cliente.ValueMember = "id_cliente";



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

        /// <summary>
        /// Funcao para Carregar o combo SISTEMA
        /// </summary>
        private void carregar_combo_sistema()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select id_sistema, ds_sistema from tb_sistema";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                cmb_sistema.DataSource = dt;
                cmb_sistema.DisplayMember = "ds_sistema";
                cmb_sistema.ValueMember = "id_sistema";



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

        private void cmb_filtrar_data_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_filtrar_usuario_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtrar_usuario.Checked)
            {
                cmb_usuario.Enabled = true;
               // bi_filtro_usuario = 1;
            }
            else
            {
                cmb_usuario.Enabled = false;
               // bi_filtro_usuario = 0;
            }
        }

        private void cmb_filtrar_status_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtrar_status.Checked)
            {
                cmb_status.Enabled = true;
               // bi_filtro_status = 1;
            }
            else
            {
                cmb_status.Enabled = false;
               // bi_filtro_status = 0;
            }
        }

        private void cmb_filtrar_filial_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtrar_filial.Checked)
            {
                cmb_filial.Enabled = true;
                //bi_filtro_filial = 1;
            }
            else
            {
                cmb_filial.Enabled = false;
               // bi_filtro_filial = 0;
            }
        }

        private void cmb_filial_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtrar_cliente.Checked)
            {
                cmb_cliente.Enabled = true;
                //bi_filtro_cliente = 1;
            }
            else
            {
                cmb_cliente.Enabled = false;
               // bi_filtro_cliente = 0;
            }
        }

        private void cmb_filtrar_sistema_CheckedChanged(object sender, EventArgs e)
        {
            if (cmb_filtrar_sistema.Checked)
            {
                cmb_sistema.Enabled = true;
              //  bi_filtro_sistema = 1;
            }
            else
            {
                cmb_sistema.Enabled = false;
              //  bi_filtro_sistema = 0;
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            


            //Verifica se a Data inicial 'e maior que a final
            if (date_time_iniciao.Value.Date > date_time_fim.Value.Date)
            {

                MessageBox.Show("Data Inicial Não pode ser maior que data Final");
                date_time_iniciao.Focus();
                return;


            }

            if (cmb_filtrar_status.Checked)
            {
                //Verifica se o combo do status esta em branco
                if (cmb_status.Text == String.Empty)
                {
                    MessageBox.Show("Selecione um Status para Ser Filtrado");
                    cmb_status.Focus();
                    return;
                }  
            }
            


            //filtro inicial sempre tem data
            //Chama fun'ca~ao para filtrar os dados
            filtrar_dados();
        }


        /// <summary>
        /// Fun'c~ao que faz a filtragem dos dados 
        /// ela tem uma linha que chama a fun;cao para verificar os filtros utilizados
        /// 
        /// </summary>
        private void filtrar_dados()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select " +
                            " t.id_atendimento as id_atendimento, " +
                            " u.ds_usuario as user, " +
                            " t.ds_status as status, " +
                            " f.ds_filial as filial, " +
                            " c.ds_razao_social as cliente, " +
                            " s.ds_sistema as sistema, " +
                            " t.dt_abertura as abertura, " +
                            " t.dt_fechamento as fechamento " +
                            " from tb_atendimento t " +
                            " inner join tb_usuario u on u.id_usuario = t.id_usuario " +
                            " inner join tb_filial f on f.id_filial = t.id_filial " +
                            " inner join tb_cliente c on c.id_cliente = t.id_cliente " +
                            " inner join tb_sistema s on s.id_sistema = t.id_sistema " +
                            " Where date(t.dt_abertura) >= '" + date_time_iniciao.Value.ToString("yyyy-MM-dd") + "' and  date(t.dt_abertura) <= '" + date_time_fim.Value.ToString("yyyy-MM-dd") + "' ";

                //variavel Sql vai receber a string remontada com os filtros utilizados
                sql = verifica_filtros(sql);



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

        /// <summary>
        /// Esta Fun'cao serve para verifica quais sao os filtros utilizados
        /// toda vez que ela detecta que um filtro esta marcado, ela vai concatenar um texto
        /// para a string da select
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private string verifica_filtros(string sql)
        {

            //variaveis que armazenam as peda'cos da Select
            string patch_sql_usuario = "";
            string patch_sql_status = "";
            string patch_sql_filial = "";
            string patch_sql_cliente = "";
            string patch_sql_sistema = "";

            //verificando quais sao os Filtros utilizados

            if (cmb_filtrar_usuario.Checked)
            {
                patch_sql_usuario = " and u.ds_usuario = '" + cmb_usuario.Text + "'  ";
            }

            if (cmb_filtrar_status.Checked)
            {
                patch_sql_status = " and t.ds_status = '" + cmb_status.Text + "' ";
            }

            if (cmb_filtrar_filial.Checked)
            {
                patch_sql_filial = " and f.ds_filial = '" + cmb_filial.Text + "' ";

            }

            if (cmb_filtrar_cliente.Checked)
            {
                patch_sql_cliente = " and c.ds_razao_social = '" + cmb_cliente.Text + "' ";

            }

            if (cmb_filtrar_sistema.Checked)
            {
                patch_sql_sistema = " and s.ds_sistema = '" + cmb_sistema.Text + "' ";

            }

            //Remonta a variavel sql com os filtros necessarios
            sql = sql + patch_sql_usuario + patch_sql_status + patch_sql_filial + patch_sql_cliente + patch_sql_sistema;


            return sql;
        }

        private void dgv_pesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //vejo qual a coluna clicada (Coluna 0 é a coluna do cod funcionario)
                if (e.ColumnIndex == 0)
                {

                    string codigo_pesquisa; //Variavel vai receber o código que esta no link
                    codigo_pesquisa = dgv_pesquisa.Rows[e.RowIndex].Cells[0].Value.ToString();

                    frm_visualizacao_de__Atendimentos vizualizar = new frm_visualizacao_de__Atendimentos();
                    vizualizar.id_atendimento = codigo_pesquisa;
                    vizualizar.ShowDialog();
                    
                    
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
