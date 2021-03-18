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

    
    public partial class frm_atendimento : Form
    {
        public string cliente_pesquisado;
      // public string user_logado = "999";
        string Evento = "";
       // public string User_logado_descricao;
        public static DataTable dt;

        public static Boolean nulo = false;

        public frm_atendimento()
        {
            InitializeComponent();
        }

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        /*
        private void ver_usuario_logado()
        {

            cls_Conexao conexao = new cls_Conexao();
        //    //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {
                string sql = "select id_usuario from tb_usuario where ds_usuario = '"+user_logado+"' ";

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
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void recebe_campos(String codigo,String cnpj, String razao, String Fantasia, String telefone, String filial,String retaguarda,String frente) {
            txt_cd_cliente.Text = codigo;
            txt_cnpj.Text = cnpj;
            txt_razao_social.Text = razao;
            tb_fantasia.Text = Fantasia;
            txt_telefone.Text = telefone;
            cmb_filial.SelectedText = filial;
            cmb_sistema.SelectedText = filial;
            cb_frente.SelectedText = filial;

            Habilitar_campos();
        }

        private void frm_atendimento_Load(object sender, EventArgs e)
        {
            tb_data.Text = DateTime.Now.Date.ToString();

            Carregar_comboBox_Filial();
            Carregar_comboBox_Sistema();

            tb_data.Enabled = true;
            tb_fantasia.Enabled = false;
            tb_filial.Enabled = false;
            tb_frente.Enabled = false;
            tb_retag.Enabled = false;
            txt_razao_social.Enabled = false;
            txt_telefone.Enabled = false;
            
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            Evento = "Incluir";

         Habilitar_campos();
                

            /*
            //ver_usuario_logado();

            verifica_primeiro_atendimento();
            */
            txt_cnpj.Focus();

        }

      private int carrega_numero_chamado(){
          int num_chamado = 0;

          return num_chamado;
        }

        public void Habilitar_campos()
        {
            txt_numero_atendimento.Enabled = false;
            group_campos.Enabled = true;

            btn_incluir.Enabled = false;
            btn_fechar.Enabled = false;

            btn_confirmar.Enabled = true;
            btn_cancelar.Enabled = true;

            btn_pesquisar.Enabled = false;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Desabilita_campos();
            campos_no_readonly();
            btn_alterar.Enabled = false;
            btn_historico.Enabled = false;
        }

        private void Desabilita_campos()
        {
            txt_numero_atendimento.Enabled = true;
            group_campos.Enabled = false;

            btn_incluir.Enabled = true;
            btn_fechar.Enabled = true;


            btn_confirmar.Enabled = false;
            btn_cancelar.Enabled = false;

            btn_pesquisar.Enabled = true;

            Limpa_campos();
        }

        private void Limpa_campos()
        {
            txt_cd_cliente.Clear();
            txt_cnpj.Clear();
            txt_contato_cliente.Clear();
            txt_numero_atendimento.Clear();
            txt_observacao.Clear();
            txt_problema.Clear();
            txt_razao_social.Clear();
            txt_solucao.Clear();
            txt_telefone.Clear();
            tb_sa.Clear();
            tb_fantasia.Clear();
            tb_filial.Clear();
            tb_frente.Clear();
            tb_sa.Clear();
            tb_retag.Clear();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Carregar_comboBox_Filial()
        {

            cls_Conexao conexao = new cls_Conexao();
           // //conexao.carregar_parametros()
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

        private void Carregar_comboBox_Sistema()
        {

            cls_Conexao conexao = new cls_Conexao();
          //  //conexao.carregar_parametros()
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


        private void Verifica_numero_atendimento()
        {
            cls_Conexao conexao = new cls_Conexao();
            ////conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {

               // String sql = "";


            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void btn_pesquisa_cliente_Click(object sender, EventArgs e)
        {
            frm_pesquisa_cliente cli = new frm_pesquisa_cliente();
            cli.ShowDialog();

            txt_cd_cliente.Text = cli.codigo_pesquisa;

            if (txt_cd_cliente.Text == string.Empty)
            {
                return;
            }
            else
            {


                //Verifica a existencia de cliente
                int qtd = verifica_existencia_cliente(txt_cd_cliente.Text);

                if (qtd == 0)
                {
                    MessageBox.Show("Cliente Não Encontrado");
                }
                else
                {
                    //Carrega o resto da Informacao
                    Carregar_campos_cliente(txt_cd_cliente.Text);
                    txt_contato_cliente.Focus();

                    btn_historico.Enabled = true;
                }

            }

        }

        private int verifica_existencia_cliente(string codigo)
        {
            cls_Conexao conexao = new cls_Conexao();
         //   //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {

                String sql = "select count(*) from tb_cliente where id_cliente =  '" + codigo + "';";

                MySqlCommand Mcomand = new MySqlCommand(sql, Mcon);

                int qtd_encontrada = Convert.ToInt16(Mcomand.ExecuteScalar());


                return qtd_encontrada;

            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }

            return 0;

        }

        private int verifica_existencia_cliente_cnpj(string cnpj)
        {
            cls_Conexao conexao = new cls_Conexao();
            //   //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            

            try
            {

                String sql = "select count(*) from tb_cliente where nu_cnpj =  '" + cnpj + "';";

                MySqlCommand Mcomand = new MySqlCommand(sql, Mcon);

                int qtd_encontrada = Convert.ToInt16(Mcomand.ExecuteScalar());


                return qtd_encontrada;

            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }

            return 0;

        }

        //Preenche os campos com o resultado de um datatable
        public void preencher_campos(DataTable dt) {
            txt_cd_cliente.Text = Convert.ToString(dt.Rows[0]["id_cliente"]);
            txt_razao_social.Text = Convert.ToString(dt.Rows[0]["ds_razao_social"]);
            tb_fantasia.Text = Convert.ToString(dt.Rows[0]["fantasia"]);
            txt_telefone.Text = Convert.ToString(dt.Rows[0]["nu_telefone"]);
            tb_filial.Text = Convert.ToString(dt.Rows[0]["filial"]);
            tb_retag.Text = Convert.ToString(dt.Rows[0]["retaguarda"]);
            tb_frente.Text = Convert.ToString(dt.Rows[0]["frente"]);
            txt_cnpj.Text = Convert.ToString(dt.Rows[0]["nu_cnpj"]);
            tb_id_retag.Text = Convert.ToString(dt.Rows[0]["id_retaguarda"]);
            tb_id_filial.Text = Convert.ToString(dt.Rows[0]["id_filial"]);
            tb_id_frente.Text = Convert.ToString(dt.Rows[0]["id_frente"]);
        }

        private void Carregar_campos_cliente(string codigo)
        {
            cls_Conexao conexao = new cls_Conexao();
          //  //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {

                String sql = "select id_cliente, ds_razao_social, nu_telefone, ds_endereco, nu_cnpj  from tb_cliente where id_cliente =  '" + codigo + "';";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    txt_razao_social.Text = Convert.ToString(dt.Rows[i]["ds_razao_social"]);
                    txt_telefone.Text = Convert.ToString(dt.Rows[i]["nu_telefone"]);
                    txt_cnpj.Text = Convert.ToString(dt.Rows[i]["nu_cnpj"]);
                }


            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void Carregar_campos_cliente_cnpj(string cnpj)
        {
            cls_Conexao conexao = new cls_Conexao();
            //  //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            try
            {

                String sql = "select id_cliente, ds_razao_social, nu_telefone, ds_endereco, nu_cnpj,filial,retaguarda,frente,fantasia from tb_cliente where nu_cnpj =  '" + cnpj + "';";

                MySqlDataAdapter Madapter = new MySqlDataAdapter(sql, Mcon);
                DataTable dt = new DataTable();

                Madapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txt_cd_cliente.Text = Convert.ToString(dt.Rows[i]["id_cliente"]);
                    txt_razao_social.Text = Convert.ToString(dt.Rows[i]["ds_razao_social"]);
                    tb_fantasia.Text = Convert.ToString(dt.Rows[i]["fantasia"]);
                    txt_telefone.Text = Convert.ToString(dt.Rows[i]["nu_telefone"]);
                    tb_filial.Text = Convert.ToString(dt.Rows[i]["filial"]);
                    tb_retag.Text = Convert.ToString(dt.Rows[i]["retaguarda"]);
                    tb_frente.Text = Convert.ToString(dt.Rows[i]["frente"]);
                }


            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void btn_pesquisa_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
   

        }

       
        private void txt_cd_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                //Verifica se o txt_codigo_cliente esta diferente de vazio
                if (txt_cd_cliente.Text.Trim() != String.Empty)
                {
                    String sql = "select c.id_cliente, c.ds_razao_social, c.nu_telefone, c.ds_endereco, c.nu_cnpj, c.fantasia," +
                          " f.id_filial, f.ds_filial as filial," +
                          " r.id_sistema as id_retaguarda, r.ds_sistema as retaguarda," +
                          " fr.id_sistema as id_frente, fr.ds_sistema as frente" +
                          " from tb_cliente c" +
                          " inner join tb_filial f on c.filial = f.id_filial" +
                          " inner join tb_sistema r on c.retaguarda = r.id_sistema" +
                          " inner join tb_sistema fr on c.frente = fr.id_sistema" +
                          " where c.id_cliente = " + txt_cd_cliente.Text + "";



                    //  string sql = "select * from tb_cliente where nu_cnpj = '" + txt_cnpj.Text + "'";
                    DataTable dt = cls_Conexao.execute_select(sql);

                    if (dt.Rows.Count > 0)
                    {
                        preencher_campos(dt);
                        txt_contato_cliente.Focus();
                        campos_readonly();
                    }
                    else
                    {

                        if (MessageBox.Show("Cliente não cadastrado, Deseja cadastrar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString() == "Yes")
                        {
                            frm_cadastro_cliente frm = new frm_cadastro_cliente();
                            frm.ShowDialog();
                        }
                    }


                    /*
                    //Monsta query select
                    string sql = "select * from tb_cliente where id_cliente = '" + Convert.ToInt32(txt_cd_cliente.Text) + "'";
                    
                    //Executa comando Select que retorna data table
                    DataTable dt;
                    dt = cls_Conexao.execute_select(sql);

                    //Verifica se retornou registros caso sim:
                    if (dt.Rows.Count > 0)
                    {
                        //Envia dt para prenchimento dos campos
                        preencher_campos(dt);
                        txt_contato_cliente.Focus();
                        btn_historico.Enabled = true;
                        campos_readonly();
                    }
                        //Caso não haja exibe uma mensagem:
                    else {
                        MessageBox.Show("Cliente não cadastrado","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txt_cd_cliente.Clear();
                        txt_cd_cliente.Focus();
                    }
                    */
                }
                
            }
        }


        private void verifica_numero_proximo_atendimento()
        {
            cls_Conexao conexao = new cls_Conexao();
           // //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {

                string Sql = "select max(id_atendimento)+1 from tb_atendimento";
                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);

                string numero_atendimento = Convert.ToString(Mcomand.ExecuteScalar());

                txt_numero_atendimento.Text = numero_atendimento;


            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void verifica_primeiro_atendimento()
        {
            cls_Conexao conexao = new cls_Conexao();
         //   //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            try
            {

                string Sql = "select count(*) from tb_atendimento";
                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);

                int qtd_registro = Convert.ToInt16(Mcomand.ExecuteScalar());

                if (qtd_registro > 0)
                {
                    //ja ouve um registro cadastrado
                    verifica_numero_proximo_atendimento();
                }
                else
                {
                    txt_numero_atendimento.Text = "1";
                }



            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void Criar_Atendimento()
        {
            cls_Conexao conexao = new cls_Conexao();
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            string id_cliente = txt_cd_cliente.Text.Trim();
            string ds_contato_cliente = txt_contato_cliente.Text.Trim();
            string id_filial = tb_id_filial.Text;
            string id_sistema = tb_id_retag.Text;
            string ds_problema = txt_problema.Text.Trim();
            string data = Convert.ToDateTime(tb_data.Text).ToString("yyyy/MM/dd");
            string ds_solucao = txt_solucao.Text.Trim();
            string ds_status = cmb_status.Text;
            string ds_observacao = txt_observacao.Text.Trim();
           
            int num_sa = 0;

            if (tb_sa.Text != "")
            {
                num_sa = Convert.ToInt32(tb_sa.Text);
            }

            /*
            string Sql = " Insert Into tb_atendimento " +
                            " (id_cliente, ds_contato_cliente, id_filial, id_sistema, " +
                            "  ds_problema, ds_solucao, dt_abertura, ds_status, nu_sa,  id_usuario, " +
                            "  ds_observacao, frente) " +
                            " values (?id_cliente, ?ds_contato_cli, ?id_filial, ?id_sistema, ?ds_problema, ?ds_solucao, ?dt_abertura, ?ds_status, ?nu_sa, ?id_usuario, ?ds_observacao, ?frente)";
            */
            //Insert padrão caso nao tenha SA
            string Sql = " Insert Into tb_atendimento " +
                            " (id_cliente, ds_contato_cliente, id_filial, id_sistema, " +
                            "  ds_problema, ds_solucao, dt_abertura, ds_status, nu_sa,  id_usuario, " +
                            "  ds_observacao, frente) " +
                            " Values (" +
                            " " + id_cliente + " , '" + ds_contato_cliente + "', " + id_filial + ", " + id_sistema + ", " +
                            " '" + ds_problema + "', '" + ds_solucao + "','" + data + "' ,'" + ds_status + "'," + num_sa + "," + cls_Conexao.cod_user_on + " , " +
                            " '" + ds_observacao + "', " + tb_id_frente.Text +")";
           //Tenta inserir no Banco de Dados
            try
            {
                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);
                /*
                Mcomand.Parameters.AddWithValue("?id_cliente", txt_cd_cliente.Text);
                Mcomand.Parameters.AddWithValue("?ds_contato_cliente", txt_contato_cliente.Text);
                Mcomand.Parameters.AddWithValue("?id_filial", tb_id_filial);
                Mcomand.Parameters.AddWithValue("?id_sistema", tb_id_retag.Text);
                Mcomand.Parameters.AddWithValue("?ds_problema", txt_problema.Text);
                Mcomand.Parameters.AddWithValue("?ds_solucao", txt_solucao.Text);
                Mcomand.Parameters.AddWithValue("?dt_abertura", DateTime.Now.ToString("yyyy/MM/dd"));
                Mcomand.Parameters.AddWithValue("?ds_status", cmb_status.SelectedText);
                Mcomand.Parameters.AddWithValue("?nu_sa", num_sa);
                Mcomand.Parameters.AddWithValue("?id_usuario", cls_Conexao.cod_user_on);
                Mcomand.Parameters.AddWithValue("?ds_observacao", txt_observacao.Text);
                Mcomand.Parameters.AddWithValue("?frente", tb_id_frente.Text);
                 * */
                Mcomand.ExecuteNonQuery();
                MessageBox.Show("Atendimento [ "+txt_numero_atendimento.Text+" ] Incluido com Sucesso","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Desabilita_campos();
                campos_no_readonly();
            }
            catch (MySqlException err)
            {
                MessageBox.Show("Ocorreu um erro: "+err.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Alterar_atendimento()
        {
            cls_Conexao conexao = new cls_Conexao();
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            //Declara as variaveis
            string id_cliente = txt_cd_cliente.Text.Trim();
            string ds_contato_cliente = txt_contato_cliente.Text.Trim();
            string id_filial = cmb_filial.SelectedValue.ToString();
            string id_sistema = cmb_sistema.SelectedValue.ToString();
            string ds_problema = txt_problema.Text.Trim();
            string ds_solucao = txt_solucao.Text.Trim();
            string ds_status = cmb_status.Text;
            string ds_observacao = txt_observacao.Text.Trim();
            int num_sa = 0;

            //Caso o campo da SA não esteja vazio, atribui o valor dele, convertido para Inteiro
            if (tb_sa.Text != "")
            {
                num_sa = Convert.ToInt32(tb_sa.Text);
            }

            //Update padrao
            String Sql = " Update tb_atendimento " +
                             " Set id_cliente = " + id_cliente + ", ds_contato_cliente = '" + ds_contato_cliente + "', id_filial = " + id_filial + ", id_sistema = " + id_sistema + ", " +
                             "  ds_problema = '" + ds_problema + "', ds_solucao = '" + ds_solucao + "', ds_status = '" + ds_status + "', " +  /* "', id_usuario = " + id_usuario + ", " + */
                             "  ds_observacao = '" + ds_observacao + "',nu_sa = '" + num_sa + "', dt_fechamento = now() " +
                             " where id_atendimento = " + txt_numero_atendimento.Text + " ;";
           
            //Tenta inserir no banco de dador
            try
            {
                MySqlCommand Mcomand = new MySqlCommand(Sql, Mcon);
                Mcomand.ExecuteNonQuery();
                MessageBox.Show("Atendimento [ " + txt_numero_atendimento.Text + " ] Alterado com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Desabilita_campos();
            }
            catch (MySqlException err)
            {
                MessageBox.Show("Ocorreu um erro: " + err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void campos_readonly() {
            tb_data.ReadOnly = true;
            tb_fantasia.ReadOnly = true;
            tb_filial.ReadOnly = true;
            tb_frente.ReadOnly = true;
            tb_retag.ReadOnly = true;
            txt_cd_cliente.ReadOnly = true;
            txt_cnpj.ReadOnly = true;
            txt_numero_atendimento.ReadOnly = true;
            txt_razao_social.ReadOnly = true;
            txt_telefone.ReadOnly = true;
        }

        public void campos_no_readonly()
        {
            tb_data.ReadOnly = false;
            tb_fantasia.ReadOnly = false;
            tb_filial.ReadOnly = false;
            tb_frente.ReadOnly = false;
            tb_retag.ReadOnly = false;
            txt_cd_cliente.ReadOnly = false;
            txt_cnpj.ReadOnly = false;
            txt_numero_atendimento.ReadOnly = false;
            txt_razao_social.ReadOnly = false;
            txt_telefone.ReadOnly = false;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (Evento == "Alterar")
            {
                if (txt_numero_atendimento.Text == String.Empty)
                {
                    return;
                }
                else
                {


                    bool inconsistencia = valida_campos_em_branco();
                    
                    if (inconsistencia == true)
                    {
                        return;
                    }
                    else
                    {
                        Alterar_atendimento();
                    }

                }
            }
            else 
            {
                if (Evento == "Incluir")
                {
                    bool inconsistencia = valida_campos_em_branco();

                    if (inconsistencia == true)
                    {
                        return;
                    }
                    else
                    {
                        //Inclusao
                        Criar_Atendimento();
                    }
                    
                    
                }
                
            }

            Evento = "";
            
        }

        private bool valida_campos_em_branco()
        {

            if (txt_numero_atendimento.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo [Nº Atendimento] é de preenchimento obrigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_numero_atendimento.Focus();
                return true;
            }
            
            if (cmb_status.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor selecione um STATUS","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cmb_status.Focus();
                return true;
            }

            if (txt_cd_cliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo Código do Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_cd_cliente.Focus();
                return true;
            }

            if (txt_problema.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Descricao do problema é de preenchimento obrigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_problema.Focus();
                return true;
            }

            if (txt_solucao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Solução é de preenchimento obrigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_solucao.Focus();
                return true;
            }

            if (txt_contato_cliente.Text == string.Empty)
            {
                MessageBox.Show("Campo Contato é de preenchimento obrigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_solucao.Focus();
                return true;
            }

            return false;
        }


        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            frm_pesquisa_atendimentos pesquisa = new frm_pesquisa_atendimentos();
            pesquisa.ShowDialog();
            txt_numero_atendimento.Text = pesquisa.codigo_pesquisa_atendimento;
            if (txt_numero_atendimento.Text == String.Empty)
            {
                return;
            }
            else
            {
                Habilitar_campos();
                Carregar_dados_atendimento(txt_numero_atendimento.Text);
                btn_alterar.Enabled = true;
                btn_historico.Enabled = true;
            }
        }

        private void Carregar_dados_atendimento(string nu_atendimento)
        {
            try
            {


                String Sql = "select t.id_cliente, t.ds_contato_cliente, t.ds_problema, t.ds_solucao, t.dt_abertura, t.ds_observacao, t.ds_status, t.nu_sa,"+
                    " c.ds_razao_social, c.nu_cnpj, c.fantasia, c.nu_telefone,"+
                    " r.id_sistema as id_retaguarda, r.ds_sistema as retaguarda,"+
                    " fr.id_sistema as id_frente, fr.ds_sistema as frente,"+
                    " f.id_filial, f.ds_filial as filial"+
                    " from tb_atendimento t"+
                    " inner join tb_usuario u on t.id_usuario = u.id_usuario"+
                    " inner join tb_cliente c on t.id_cliente = c.id_cliente"+
                    " inner join tb_filial f on t.id_filial = f.id_filial"+
                    " inner join tb_sistema r on t.id_sistema = r.id_sistema"+
                    " inner join tb_sistema fr on t.frente = fr.id_sistema"+
                    " where id_atendimento = "+ nu_atendimento +"";

                /*
                String Sql = "select t.id_cliente, c.ds_razao_social, c.nu_cnpj, id_filial, ds_filial, ds_contato_cliente, c.nu_telefone, ds_problema, ds_solucao, r.ds_sistema as retaguarda, fr.ds_sistema as frente," +
               " r.id_sistema as id_retaguarda, r.ds_sistemas as retaguarda,"+
               " fr.id_sistema as id_frente, fr.ds_sistemas as frente" +
               " from tb_atendimento t" +
               " inner join tb_usuario u on t.id_usuario = u.id_usuario" +
               " inner join tb_cliente c on t.id_cliente = c.id_cliente" +
               " inner join tb_filial f on t.id_filial = f.id_filial" +
               " inner join tb_sistema r on t.id_sistema = r.id_sistema" +
               " inner join tb_sistema fr on t.frente = fr.id_sistema" +
               " where id_atendimento = " + nu_atendimento + "";
                */
                /*
                string Sql1 =  " select "+
                              " id_atendimento, "+
                              " id_cliente, "+
                              " ds_contato_cliente, "+
                              " id_filial, "+
                              " id_sistema, "+
                              " ds_problema, "+
                              " ds_solucao, "+
                              " dt_abertura, "+
                              " ds_status, "+
                              " id_usuario, "+
                              " ds_observacao "+
                              " from tb_atendimento where id_atendimento = '"+nu_atendimento+"' ;" ;            
                 * */

                //Executa o comando SQL
                DataTable dt = cls_Conexao.execute_select(Sql);

                if (dt.Rows.Count > 0)
                {
                    txt_cd_cliente.Text = Convert.ToString(dt.Rows[0]["id_cliente"]);
                    txt_cnpj.Text = Convert.ToString(dt.Rows[0]["nu_cnpj"]);
                    txt_razao_social.Text = Convert.ToString(dt.Rows[0]["ds_razao_social"]);
                    tb_fantasia.Text = Convert.ToString(dt.Rows[0]["fantasia"]);

                    //Filial
                    tb_id_filial.Text = Convert.ToString(dt.Rows[0]["id_filial"]);
                    tb_filial.Text = Convert.ToString(dt.Rows[0]["filial"]);

                    //Retaguarda
                    tb_id_frente.Text = Convert.ToString(dt.Rows[0]["id_frente"]);
                    tb_frente.Text = Convert.ToString(dt.Rows[0]["frente"]);

                    //Frente
                    tb_id_retag.Text = Convert.ToString(dt.Rows[0]["id_retaguarda"]);
                    tb_retag.Text = Convert.ToString(dt.Rows[0]["retaguarda"]);

                    txt_contato_cliente.Text = Convert.ToString(dt.Rows[0]["ds_contato_cliente"]);
                    tb_data.Text = Convert.ToDateTime(Convert.ToString(dt.Rows[0]["dt_abertura"])).ToString("dd/MM/yyyy");
                    txt_telefone.Text = Convert.ToString(dt.Rows[0]["nu_telefone"]);
                    txt_problema.Text = Convert.ToString(dt.Rows[0]["ds_problema"]);
                    txt_solucao.Text = Convert.ToString(dt.Rows[0]["ds_solucao"]);
                    txt_observacao.Text = Convert.ToString(dt.Rows[0]["ds_observacao"]);

                    cmb_status.Text = Convert.ToString(dt.Rows[0]["ds_status"]);

                    int nu_sa = Convert.ToInt32(dt.Rows[0]["nu_sa"]);

                    if (nu_sa != 0) {
                        tb_sa.Text = Convert.ToString(dt.Rows[0]["nu_sa"]);
                    }
                  //  tb_data.Text = Convert.ToDateTime(dt.Rows[0]["ds_observacao"]).ToString("dd/MM/yyyy");
                    Habilitar_campos();
                    Evento = "Alterar";
                }
                else {
                    MessageBox.Show("Atendimento Não Encontrado","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Evento = "Alterar";
            //ver_usuario_logado();
            btn_alterar.Enabled = false;
        }

        private void btn_cadastrar_usuario_Click(object sender, EventArgs e)
        {
            frm_cadastro_cliente cli = new frm_cadastro_cliente();
            cli.ShowDialog();
        }

        private void txt_cd_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            frm_historico_atendimento_cliente hist = new frm_historico_atendimento_cliente();
            hist.codigo_cliente = txt_cd_cliente.Text;
            hist.ShowDialog();

        }


        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_status.Text == "EXTERNO")
            {
                tb_sa.Enabled = true;
                lbl_sa.Enabled = true;
            }
            else {
                tb_sa.Enabled = false;
                lbl_sa.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Informa que por enquanto o cod não esta nulo
            nulo = false;
           frm_pesquisa_cliente.chamador = "frm_atendimento";
           frm_pesquisa_cliente form = new frm_pesquisa_cliente();
           form.ShowDialog();

            //Verifica se o o formulario foi fechado siretamente, sem obter o codigo de pesquisa, o que seria nulo
     
           if (nulo == false)
           {
               preencher_campos(dt);
               campos_readonly();
               tb_data.ReadOnly = false;
               txt_contato_cliente.Focus();

           }
                
        }

        private void txt_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //Verifica se o txt_codigo_cliente esta diferente de vazio
                if (txt_cnpj.Text.Trim() != String.Empty)
                {
                    String sql = "select c.id_cliente, c.ds_razao_social, c.nu_telefone, c.ds_endereco, c.nu_cnpj, c.fantasia," +
                           " f.id_filial, f.ds_filial as filial," +
                           " r.id_sistema as id_retaguarda, r.ds_sistema as retaguarda," +
                           " fr.id_sistema as id_frente, fr.ds_sistema as frente" +
                           " from tb_cliente c" +
                           " inner join tb_filial f on c.filial = f.id_filial" +
                           " inner join tb_sistema r on c.retaguarda = r.id_sistema" +
                           " inner join tb_sistema fr on c.frente = fr.id_sistema" +
                           " where c.nu_cnpj = '" + txt_cnpj.Text + "'";

                  //  string sql = "select * from tb_cliente where nu_cnpj = '" + txt_cnpj.Text + "'";
                    DataTable dt = cls_Conexao.execute_select(sql);

                    if (dt.Rows.Count > 0)
                    {
                        preencher_campos(dt);
                        txt_contato_cliente.Focus();
                        campos_readonly();
                    }
                    else {

                        if (MessageBox.Show("Cliente não cadastrado, Deseja cadastrar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString() == "Yes")
                        {
                            frm_cadastro_cliente frm = new frm_cadastro_cliente();
                            frm.ShowDialog();
                        }
                    }
                }

            }
        }

        private void btn_pesq_Click(object sender, EventArgs e)
        {
            frm_pesquisa_atendimentos pesquisa = new frm_pesquisa_atendimentos();
            pesquisa.ShowDialog();
            txt_numero_atendimento.Text = pesquisa.codigo_pesquisa_atendimento;
            if (txt_numero_atendimento.Text == String.Empty)
            {
                return;
            }
            else
            {
                Habilitar_campos();
                Carregar_dados_atendimento(txt_numero_atendimento.Text);
                btn_alterar.Enabled = true;
                btn_historico.Enabled = true;
                Evento = "Alterar";
            }
        }

        private void txt_numero_atendimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                if (txt_numero_atendimento.Text != String.Empty)
                {
                    Carregar_dados_atendimento(txt_numero_atendimento.Text);
                    
                }
            }

        }
    }
}
