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
    public partial class frm_cadastro_cliente : Form
    {

        string Evento = "";
       // string user_logado = "";

        /*Esta variavel testa se o formulario de pesquisa de cliente foi fechado antes de concluir a pesquisa do cliente, afim de evitar 
        erro do dataset nulo */
        public static Boolean fechamento_pesquisa_nulo = false;

        /*Este DataTable recebe o retorno do formulario de pesquisa de cliente */
        public static DataTable dt_retorno_pesquisa;


        public frm_cadastro_cliente()
        {
            InitializeComponent();
        }

        private void frm_cadastro_cliente_Load(object sender, EventArgs e)
        {
            carregar_filial();
            carregar_frente();
            carregar_retaguarda();
            Listar_clientes();
            txt_codigo_usuario.Enabled = true;

                    }

        private void Habilitar_campos()
        {

            group_campos.Enabled = true;

            Novo.Enabled = false;
            btn_fechar.Enabled = false;

            btn_confirmar.Enabled = true;
            btn_cancelar.Enabled = true;
            tb_codController.Enabled = true;


        }

        public void carregar_filial() {
            String sql = "select * from tb_filial";
            DataTable dt = cls_Conexao.execute_select(sql);
           
            cmb_filial.DataSource = dt;
            cmb_filial.DisplayMember = "ds_filial";
            cmb_filial.ValueMember = "id_filial";
        }

        public void carregar_frente()
        {
            String sql = "select * from tb_sistema where tiposys = 'F'";
            DataTable dt = cls_Conexao.execute_select(sql);

            cmb_frente.DataSource = dt;
            cmb_frente.DisplayMember = "ds_sistema";
            cmb_frente.ValueMember = "id_sistema";
        }

        public void carregar_retaguarda()
        {
            String sql = "select * from tb_sistema where tiposys = 'R'";
            DataTable dt = cls_Conexao.execute_select(sql);

            cmb_retaguarda.DataSource = dt;
            cmb_retaguarda.DisplayMember = "ds_sistema";
            cmb_retaguarda.ValueMember = "id_sistema";
        }

        private void Desabilita_campos()
        {
            group_campos.Enabled = false;

            Novo.Enabled = true;
            btn_fechar.Enabled = true;


            btn_confirmar.Enabled = false;
            btn_cancelar.Enabled = false;

            limpar_campos();

            btn_pesq.Enabled = true;
        }

        /*
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

                MessageBox.Show(err.Message);
            }
            finally
            {

                Mcon.Close();
            }


        }


         */
        private void limpar_campos()
        {
            cmb_filial.SelectedText = "";
            cmb_frente.SelectedText = "";
            cmb_retaguarda.SelectedText = "";
            txt_cnpj.Clear();
            txt_codigo_usuario.Clear();
            txt_endereco.Clear();
            txt_razao.Clear();
            txt_telefone.Clear();
            tb_fantasia.Text = "";
            tb_codController.Clear();

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            Evento = "Incluir";

            Habilitar_campos();

         //   ver_usuario_logado();

            verifica_primeiro_cliente();

            txt_codigo_usuario.Enabled = false;
            btn_pesq.Enabled = false;
            txt_cnpj.Select();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Desabilita_campos();
            
            //Cancelar.Enabled = false;
            txt_codigo_usuario.Enabled = true;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void verifica_primeiro_cliente()
        {
            cls_Conexao conexao = new cls_Conexao();
           // //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {

                string Sql = "select count(*) from tb_cliente";
                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);

                int qtd_registro = Convert.ToInt16(Mcomand.ExecuteScalar());

                if (qtd_registro > 0)
                {
                    //ja ouve um registro cadastrado
                    verifica_numero_proximo_cliente();
                }
                else
                {
                    txt_codigo_usuario.Text = "1";
                }



            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void verifica_numero_proximo_cliente()
        {
            cls_Conexao conexao = new cls_Conexao();
         //   //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {

                string Sql = "select max(id_cliente)+1 from tb_cliente";
                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);

                string codigo = Convert.ToString(Mcomand.ExecuteScalar());

                txt_codigo_usuario.Text = codigo;


            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private bool valida_campos()
        {

            if (txt_cnpj.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o Campo [CNPJ]");
                txt_cnpj.Focus();
                return false;

            }

            if (txt_endereco.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o Campo [Endereço]");
                txt_endereco.Focus();
                return false;

            }

            if (txt_razao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o Campo [Razao Social]");
                txt_razao.Focus();
                return false;

            }

            if (txt_telefone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o Campo [telefone]");
                txt_telefone.Focus();
                return false;

            }
            return true;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (Evento == "Incluir")
            {
                bool validos = valida_campos();

                if (validos == true)
                {
                    Cadastrar_cliente();
                    Desabilita_campos();
                    Listar_clientes();
                }
                else
                {
                    return;
                }

            }
            if (Evento == "Alterar")
            {
                bool validos = valida_campos();

                if (validos == true)
                {
                    Atualizar_cliente();
                    Desabilita_campos();
                    Listar_clientes();
                }
                else
                {
                    return;
                }
            }

            Evento = "";
        }

        private void Cadastrar_cliente()
        {
            cls_Conexao conexao = new cls_Conexao();
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            //Verifica se ja existe CNPJ Cadastrado
            if(valida_cnpj(txt_cnpj.Text) == true){
                MessageBox.Show("CNPJ já cadastrado","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            try
            {
                //string nu_cnpj = txt_cnpj.Text.Trim();
                //string ds_razao_social = txt_razao.Text.Trim();
                //string fantasia = tb_fantasia.Text.Trim();
                //string ds_endereco = txt_endereco.Text.Trim();
                //string nu_telefone = txt_telefone.Text.Trim();
                //string filial = cmb_filial.SelectedValue.ToString();
                //string retaguarda = cmb_retaguarda.SelectedValue.ToString();
                //string frente = cmb_frente.SelectedValue.ToString();

                string Sql = " insert into tb_cliente " +
                           " (ds_razao_social, nu_telefone, ds_endereco, nu_cnpj, dt_cadastro, ds_user_cadastro,fantasia,filial,retaguarda,frente,cod_controller) " +
                           " Values " +
                           " (?razao, ?tel , ?endereco, ?cnpj , now(), ?user ,?fantasia , ?filial,?retaguarda,?frente,?controller);";

                /*
                INSERT ANTIGO UTILIZANDO CONCATENAÇãO
                string Sql2 = " insert into tb_cliente " +
                            " (ds_razao_social, nu_telefone, ds_endereco, nu_cnpj, dt_cadastro, ds_user_cadastro,fantasia,filial,retaguarda,frente) " +
                            " Values " +
                            " ('" + ds_razao_social + "', '" + nu_telefone + "', '" + ds_endereco + "', '" + nu_cnpj + "', now(), '" + cls_Conexao.user_on + "','" + fantasia + "','" + filial + "','" + retaguarda + "','" + frente + "') ;";
                */

                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);
                Mcomand.Parameters.AddWithValue("?razao",txt_razao.Text);
                Mcomand.Parameters.AddWithValue("?tel", txt_telefone.Text);
                Mcomand.Parameters.AddWithValue("?endereco", txt_endereco.Text);
                Mcomand.Parameters.AddWithValue("?cnpj", txt_cnpj.Text);
                Mcomand.Parameters.AddWithValue("?user", cls_Conexao.user_on);
                Mcomand.Parameters.AddWithValue("?fantasia", tb_fantasia.Text);
                Mcomand.Parameters.AddWithValue("?filial", cmb_filial.SelectedValue.ToString());
                Mcomand.Parameters.AddWithValue("?retaguarda", cmb_retaguarda.SelectedValue.ToString());
                Mcomand.Parameters.AddWithValue("?frente", cmb_frente.SelectedValue.ToString());
                Mcomand.Parameters.AddWithValue("?controller",tb_codController.Text);
                Mcomand.ExecuteNonQuery();

                Mcon.Close();

                MessageBox.Show("Cliente Cadastrado com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message);
            }




        }


        public static Boolean valida_cnpj(String cnpj) {
            Boolean existe = false;

            String sql = "select * from tb_cliente where nu_cnpj = '" + cnpj + "'";
            DataTable dt = cls_Conexao.execute_select(sql);
            
            if(dt.Rows.Count > 0){
                existe = true;
            }

            return existe;
        }


        /// <summary>
        /// Funcao para Atualizar usuarios
        /// </summary>
        private void Atualizar_cliente()
        {
            cls_Conexao conexao = new cls_Conexao();
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();
            try
            {
                /*
                string ds_razao_social = txt_razao.Text.Trim();
                string nu_telefone = txt_telefone.Text.Trim();
                string ds_endereco = txt_endereco.Text.Trim();
                string nu_cnpj = txt_cnpj.Text.Trim();
                string fantasia = tb_fantasia.Text.Trim();
                string filial = cmb_filial.Text;
                string retaguarda = cmb_retaguarda.Text;
                string frente = cmb_frente.Text;
                */
                /*

                string Sql = " Update tb_cliente " +
                            " set ds_razao_social = '" + ds_razao_social + "', nu_telefone = '" + nu_telefone + "', ds_endereco = '" + ds_endereco + "', retaguarda = '" + retaguarda + "',frente = '" + frente + "', filial = '" + filial +"',fantasia = '" + fantasia + "', nu_cnpj = '" + nu_cnpj + "'  " +
                            " where id_cliente =  " + txt_codigo_usuario.Text + " ;";
                 * */

                string Sql = " Update tb_cliente " +
                            " set ds_razao_social = ?razao, nu_telefone = ?tel, ds_endereco = ?endereco, retaguarda = ?retaguarda,frente = ?frente, filial = ?filial,fantasia = ?fantasia, nu_cnpj = ?cnpj, cod_controller = ?controller " +
                            " where id_cliente =  " + txt_codigo_usuario.Text + " ;";

                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);
                Mcomand.Parameters.AddWithValue("?razao", txt_razao.Text);
                Mcomand.Parameters.AddWithValue("?tel", txt_telefone.Text);
                Mcomand.Parameters.AddWithValue("?endereco", txt_endereco.Text);
                Mcomand.Parameters.AddWithValue("?cnpj", txt_cnpj.Text);
                Mcomand.Parameters.AddWithValue("?user", cls_Conexao.user_on);
                Mcomand.Parameters.AddWithValue("?fantasia", tb_fantasia.Text);
                Mcomand.Parameters.AddWithValue("?filial", cmb_filial.SelectedValue.ToString());
                Mcomand.Parameters.AddWithValue("?retaguarda", cmb_retaguarda.SelectedValue.ToString());
                Mcomand.Parameters.AddWithValue("?frente", cmb_frente.SelectedValue.ToString());
                Mcomand.Parameters.AddWithValue("?controller",tb_codController.Text);
                Mcomand.ExecuteNonQuery();

              //  cls_Conexao.execute_sql(Sql);
                MessageBox.Show("Cliente Alterado com Sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);


            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }




        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Evento = "Alterar";
          //  Cancelar.Enabled = false;
        }

        private void Listar_clientes()
        {
            cls_Conexao conexao = new cls_Conexao();
          //  //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {

                string sql = " select id_cliente, ds_razao_social, nu_telefone, nu_cnpj, ds_endereco, fantasia from tb_cliente; ";

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

        private void dgv_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {

                    string codigo_pesquisa; //Variavel vai receber o código que esta no link
                    codigo_pesquisa = dgv_cliente.Rows[e.RowIndex].Cells[0].Value.ToString();

                    txt_codigo_usuario.Text = codigo_pesquisa;
                    txt_razao.Text = dgv_cliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_telefone.Text = dgv_cliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_cnpj.Text = dgv_cliente.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txt_endereco.Text = dgv_cliente.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tb_fantasia.Text = dgv_cliente.Rows[e.RowIndex].Cells[5].Value.ToString();
                                        
                    Habilitar_campos();
                   // Cancelar.Enabled = true;
                    Evento = "Alterar";
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_pesq_Click(object sender, EventArgs e)
        {
            fechamento_pesquisa_nulo = false;

            frm_pesquisa_cliente.chamador = "cadastro_cliente";
            frm_pesquisa_cliente frm_pesq = new frm_pesquisa_cliente();
            frm_pesq.ShowDialog();

            if(fechamento_pesquisa_nulo == false){
                preencher_campos(dt_retorno_pesquisa);
                Habilitar_campos();
                Evento = "Alterar";                
            }


        }

        public void preencher_campos(DataTable dt) { 
        txt_codigo_usuario.Text = dt.Rows[0]["id_cliente"].ToString();
        txt_cnpj.Text = dt.Rows[0]["nu_cnpj"].ToString();
        txt_endereco.Text = dt.Rows[0]["ds_endereco"].ToString();
        txt_razao.Text = dt.Rows[0]["ds_razao_social"].ToString();
        txt_telefone.Text = dt.Rows[0]["nu_telefone"].ToString();
        tb_fantasia.Text = dt.Rows[0]["fantasia"].ToString();
        tb_codController.Text = dt.Rows[0]["cod_controller"].ToString();

        //Combo Filial
       // cmb_filial.DataSource = dt;
     //   cmb_filial.ValueMember = "id_filial";
       // cmb_filial.DisplayMember = "filial";
        cmb_filial.SelectedText = dt.Rows[0]["filial"].ToString();
        cmb_filial.SelectedValue = dt.Rows[0]["id_filial"].ToString();

        //Combo Retaguarda
      //  cmb_retaguarda.DataSource = dt;
      //  cmb_retaguarda.ValueMember = "id_retaguarda";
       // cmb_retaguarda.DisplayMember = "retaguarda";
        cmb_retaguarda.SelectedText = dt.Rows[0]["retaguarda"].ToString();
        cmb_retaguarda.SelectedValue = dt.Rows[0]["id_retaguarda"].ToString();

        //Combo Frente
       // cmb_frente.DataSource = dt;
      //  cmb_frente.ValueMember = "id_frente";
      //  cmb_frente.DisplayMember = "frente";
        cmb_frente.SelectedText = dt.Rows[0]["frente"].ToString();
        cmb_frente.SelectedValue = dt.Rows[0]["id_frente"].ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tb_codController_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }
    }
}
