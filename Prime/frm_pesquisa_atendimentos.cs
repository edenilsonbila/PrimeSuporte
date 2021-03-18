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
    public partial class frm_pesquisa_atendimentos : Form
    {
        public string codigo_pesquisa_atendimento = "";

        public frm_pesquisa_atendimentos()
        {
            InitializeComponent();
        }

        public DataTable dt;
        private void frm_pesquisa_atendimentos_Load(object sender, EventArgs e)
        {
            Carregar_combo_filtro();
            
            Listar_atendimentos();
           
        }

        private void Carregar_combo_filtro()
        {
            /*

            Dictionary<string, string> dicFiltro = new Dictionary<string, string>();

            //Preenchendo o Dictionary
            dicFiltro.Add(" -- ", "-- Selecione uma Opção --");
            dicFiltro.Add("a.id_atendimento", "Nº Atendimento");
            dicFiltro.Add("c.ds_razao_social", "Cliente");
            dicFiltro.Add("f.ds_filial", "Filial");
            dicFiltro.Add("u.ds_usuario", "Usuario");
            dicFiltro.Add("a.dt_abertura", "Data Abertura");

            //Informando ao ComboBox que sua fonte de dados é o Dictionary
            cmb_filtro.DataSource = new BindingSource(dicFiltro, null);
            //O valor de exibição será "Value", ou seja, o nome do estado
            cmb_filtro.DisplayMember = "Value";
            //O valor interno será "Key", ou seja, a sigla do estado
            cmb_filtro.ValueMember = "Key";

            */
        }


        private void Listar_atendimentos()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {
                string sql =  " select " +
                              " a.id_atendimento as id, " +
                              " c.ds_razao_social as razao, " +
                              " f.ds_filial as filial, " +
                              " s.ds_sistema as sistema, " +
                              " a.dt_abertura as abertura, " +
                              " u.ds_usuario as usuario " +

                              " from tb_atendimento a " +

                              " inner join tb_filial f on f.id_filial = a.id_filial " +
                              " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                              " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                              " inner join tb_usuario u on u.id_usuario = a.id_usuario ";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                dgv_atendimentos.DataSource = dt;

            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }



        }

        private void pesquisa_atendimentos_com_filtro(string tipo_filtro, string filtro)
        {
           
            try
            {
                string sql = " select " +
                              " a.id_atendimento as id, " +
                              " c.ds_razao_social as razao, " +
                              " f.ds_filial as filial, " +
                              " s.ds_sistema as sistema, " +
                              " a.dt_abertura as abertura, " +
                              " u.ds_usuario as usuario " +

                              " from tb_atendimento a " +

                              " inner join tb_filial f on f.id_filial = a.id_filial " +
                              " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                              " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                              " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                              " Where "+tipo_filtro+" =  '" + filtro + "' ";


                //Se o filtro for por razão social
                if (tipo_filtro == "RAZAO" )
                {
                     sql = " select " +
                              " a.id_atendimento as id, " +
                              " c.ds_razao_social as razao, " +
                              " f.ds_filial as filial, " +
                              " s.ds_sistema as sistema, " +
                              " a.dt_abertura as abertura, " +
                              " u.ds_usuario as usuario " +

                              " from tb_atendimento a " +

                              " inner join tb_filial f on f.id_filial = a.id_filial " +
                              " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                              " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                              " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                              " Where c.ds_razao_social like  '%" + filtro + "%' ";
                    dt = cls_Conexao.execute_select(sql);
                  }

                if (tipo_filtro == "Nº ATENDIMENTO")
                {
                    sql = " select " +
                             " a.id_atendimento as id, " +
                             " c.ds_razao_social as razao, " +
                             " f.ds_filial as filial, " +
                             " s.ds_sistema as sistema, " +
                             " a.dt_abertura as abertura, " +
                             " u.ds_usuario as usuario " +

                             " from tb_atendimento a " +

                             " inner join tb_filial f on f.id_filial = a.id_filial " +
                             " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                             " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                             " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                             " Where a.id_atendimento =  '" + filtro + "' ";
                    dt = cls_Conexao.execute_select(sql);
                }

                if (tipo_filtro == "FILIAL")
                {
                    sql = " select " +
                             " a.id_atendimento as id, " +
                             " c.ds_razao_social as razao, " +
                             " f.ds_filial as filial, " +
                             " s.ds_sistema as sistema, " +
                             " a.dt_abertura as abertura, " +
                             " u.ds_usuario as usuario " +

                             " from tb_atendimento a " +

                             " inner join tb_filial f on f.id_filial = a.id_filial " +
                             " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                             " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                             " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                             " Where f.ds_filial like  '%" + filtro + "%' ";
                    dt = cls_Conexao.execute_select(sql);
                }

                if(cmb_filtro.Text == "FANTASIA"){
                    sql = " select " +
                                 " a.id_atendimento as id, " +
                                 " c.ds_razao_social as razao, " +
                                 " f.ds_filial as filial, " +
                                 " s.ds_sistema as sistema, " +
                                 " a.dt_abertura as abertura, " +
                                 " u.ds_usuario as usuario " +

                                 " from tb_atendimento a " +

                                 " inner join tb_filial f on f.id_filial = a.id_filial " +
                                 " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                                 " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                                 " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                                 " Where c.fantasia like  '%" + filtro + "%' ";
                    dt = cls_Conexao.execute_select(sql);
                }


                if (cmb_filtro.Text == "PROBLEMA")
                {
                    sql = " select " +
                                 " a.id_atendimento as id, " +
                                 " c.ds_razao_social as razao, " +
                                 " f.ds_filial as filial, " +
                                 " s.ds_sistema as sistema, " +
                                 " a.dt_abertura as abertura, " +
                                 " u.ds_usuario as usuario " +

                                 " from tb_atendimento a " +

                                 " inner join tb_filial f on f.id_filial = a.id_filial " +
                                 " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                                 " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                                 " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                                 " Where a.ds_problema like  '%" + filtro + "%' ";
                    dt = cls_Conexao.execute_select(sql);
                }
             
                dgv_atendimentos.DataSource = dt;
               
            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_listar_Click(object sender, EventArgs e)
        {
            Listar_atendimentos();
        }

        private void dgv_atendimentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
                if (e.ColumnIndex == 0)
                {
                    
                    string codigo_pesquisa; //Variavel vai receber o código que esta no link
                    codigo_pesquisa = dgv_atendimentos.Rows[e.RowIndex].Cells[0].Value.ToString();

                    codigo_pesquisa_atendimento = codigo_pesquisa;


                    this.Close();


                }
             */
        }

        private void txt_parametro_TextChanged_1(object sender, EventArgs e)
        {
            string tipofiltro = cmb_filtro.Text;
            string parametro = txt_parametro.Text.Trim();

            if (cmb_filtro.Text != "")
            {
               
                pesquisa_atendimentos_com_filtro(tipofiltro, parametro);
            }
            else
            {

                return;
            }
        }

        private void cmb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpa a mascara e o conteudo do campo
            txt_parametro.Mask = "";
            txt_parametro.Clear();

            //Caso selecionando data, coloca uma mascara de data no tb
            if (cmb_filtro.Text == "DATA") {
                txt_parametro.Mask = "00/00/0000";
            }

            //Caso seja cnpj coloca uma mascara de CNPJ
             if (cmb_filtro.Text == "CNPJ")
            {
                txt_parametro.Mask = "00,000,000/0000-00";
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (cmb_filtro.Text == "DATA")
            {
                string filtro = txt_parametro.Text;
                filtro = Convert.ToDateTime(filtro).ToString("yyyy/MM/dd");
               string sql = " select " +
                         " a.id_atendimento as id, " +
                         " c.ds_razao_social as razao, " +
                         " f.ds_filial as filial, " +
                         " s.ds_sistema as sistema, " +
                         " a.dt_abertura as abertura, " +
                         " u.ds_usuario as usuario " +

                         " from tb_atendimento a " +

                         " inner join tb_filial f on f.id_filial = a.id_filial " +
                         " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                         " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                         " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                         " Where  date(dt_abertura) = '" + filtro + "';";
               dt = cls_Conexao.execute_select(sql);
               dgv_atendimentos.DataSource = dt;
            }

            if(cmb_filtro.Text == "CNPJ"){
                string filtro = txt_parametro.Text;
                string sql = " select " +
                                 " a.id_atendimento as id, " +
                                 " c.ds_razao_social as razao, " +
                                 " f.ds_filial as filial, " +
                                 " s.ds_sistema as sistema, " +
                                 " a.dt_abertura as abertura, " +
                                 " u.ds_usuario as usuario " +

                                 " from tb_atendimento a " +

                                 " inner join tb_filial f on f.id_filial = a.id_filial " +
                                 " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                                 " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                                 " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                                 " where c.nu_cnpj = '" + filtro + "'";
             DataTable dt = cls_Conexao.execute_select(sql);
             dgv_atendimentos.DataSource = dt;
            }
        }

        private void dgv_atendimentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void pesquisar_atendimentos(String filtro) {
            if (cmb_filtro.Text == "DATA")
            {
                filtro = txt_parametro.Text;
                filtro = Convert.ToDateTime(filtro).ToString("yyyy/MM/dd");
                string sql = " select " +
                          " a.id_atendimento as id, " +
                          " c.ds_razao_social as razao, " +
                          " f.ds_filial as filial, " +
                          " s.ds_sistema as sistema, " +
                          " a.dt_abertura as abertura, " +
                          " u.ds_usuario as usuario " +

                          " from tb_atendimento a " +

                          " inner join tb_filial f on f.id_filial = a.id_filial " +
                          " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                          " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                          " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                          " Where  date(dt_abertura) = '" + filtro + "';";
                dt = cls_Conexao.execute_select(sql);
                dgv_atendimentos.DataSource = dt;
            }

            if (cmb_filtro.Text == "CNPJ")
            {
                filtro = txt_parametro.Text;
                string sql = " select " +
                                 " a.id_atendimento as id, " +
                                 " c.ds_razao_social as razao, " +
                                 " f.ds_filial as filial, " +
                                 " s.ds_sistema as sistema, " +
                                 " a.dt_abertura as abertura, " +
                                 " u.ds_usuario as usuario " +

                                 " from tb_atendimento a " +

                                 " inner join tb_filial f on f.id_filial = a.id_filial " +
                                 " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                                 " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                                 " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                                 " where c.nu_cnpj = '" + filtro + "'";
                DataTable dt = cls_Conexao.execute_select(sql);
                dgv_atendimentos.DataSource = dt;
            }
        }

        private void dgv_atendimentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string codigo_pesquisa; //Variavel vai receber o código que esta no link
                codigo_pesquisa = dgv_atendimentos.Rows[e.RowIndex].Cells[0].Value.ToString();
                codigo_pesquisa_atendimento = codigo_pesquisa;
                this.Close();
            }
        }

        private void txt_parametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13){
              pesquisar_atendimentos(txt_parametro.Text);
            }
        }
    }
}
