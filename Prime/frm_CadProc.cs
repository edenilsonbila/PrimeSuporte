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
    public partial class frm_CadProc : Form
    {
        public frm_CadProc()
        {
            InitializeComponent();
        }

        public int id_ok = 0;
      
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public int verifica_campos() {
            int no_empty = 0;

            if (tb_descricao.Text == "")
            {
                MessageBox.Show("Descrição não pode estar em branco", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                no_empty = 1;
            }
            if (tb_solucao.Text == "")
            {
                MessageBox.Show("Por favor descreva uma solução para este erro", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                no_empty = 1;
            }
            if (tb_autor.Text == "")
            {
                no_empty = 1;
                MessageBox.Show("Autor não pode estar em branco", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (tb_sistema.Text == "")
            {
                no_empty = 1;
                MessageBox.Show("Informe o sistema alvo, caso não se enquandre use : Geral ou Todos", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return no_empty;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int campo_ok = verifica_campos();
           // String id = tb_id.Text;
            String descricao = tb_descricao.Text;
            //String conteudo = tb_solucao.Text;
            String autor = tb_autor.Text;
            String dtcriacao = tb_dt.Text;
            String aprovado = tb_aprovado.Text;
            String revisao = tb_revisao.Text;
            String sistema = tb_sistema.Text;
            String solucao = tb_solucao.Text;

           // cls_Conexao con = new cls_Conexao();
           // con.carregar_parametros();
            
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
            Mcon.Open();

            String sql;

            if (campo_ok != 1)
            {
                
                if (id_ok == 0)
                {
                    sql = "insert into tb_proc (descricao,conteudo,autor,dtcriacao,aprovado,revisao,sistema) values (?descricao, ?solu,?autor,?dtcri,?apro,?revi,?sis)";
                    MySqlCommand comando = new MySqlCommand(sql, Mcon); 
                    comando.Parameters.AddWithValue("?descricao", descricao);
                    comando.Parameters.AddWithValue("?solu", solucao);
                    comando.Parameters.AddWithValue("?autor", autor);
                    comando.Parameters.AddWithValue("?dtcri", dtcriacao);
                    comando.Parameters.AddWithValue("?apro", aprovado);
                    comando.Parameters.AddWithValue("?revi", revisao);
                    comando.Parameters.AddWithValue("?sis", sistema);
                    // sql = "insert into tb_proc (descricao,conteudo,autor,dtcriacao,aprovado,revisao,sistema) values (?descricao, '" + solucao  + "', '" + autor + "','" + dtcriacao + "','" + aprovado + "','" + revisao + "','" + sistema + "')";
                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Procedimento Salvo com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitar_campos();
                        limpa_campos();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao inserir registros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
                else
                {
                    sql = "update tb_proc set descricao = ?descricao ,conteudo = ?conteudo ,autor= ?conteudo,dtcriacao= ?dtcri ,aprovado= ?apro,revisao= ?revi,sistema = ?sis where id= " + tb_id.Text + "";
                    //sql = "update tb_proc set descricao = '" + descricao + "' ,conteudo = '" + tb_solucao.Text + "' ,autor= '" + autor + "',dtcriacao= '" + dtcriacao + "' ,aprovado= '" + aprovado + "',revisao= '" + revisao + "',sistema ='" + sistema + "' where id= " + tb_id.Text + "";
                     MySqlCommand comando = new MySqlCommand(sql, Mcon); 
                    comando.Parameters.AddWithValue("?descricao", descricao);
                    comando.Parameters.AddWithValue("?solu", solucao);
                    comando.Parameters.AddWithValue("?autor", autor);
                    comando.Parameters.AddWithValue("?dtcri", dtcriacao);
                    comando.Parameters.AddWithValue("?apro", aprovado);
                    comando.Parameters.AddWithValue("?revi", revisao);
                    comando.Parameters.AddWithValue("?sis", sistema);
                    comando.Parameters.AddWithValue("?conteudo",tb_solucao.Text);
                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Procedimento Salvo com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitar_campos();
                        limpa_campos();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao inserir registros","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }

        public void pesquisar_id() {
            //Instancia um novo dataTable, Tabela interna que recebera os dados retornados do banco
            DataTable dt = new DataTable();

            //Cria uma nova conexao com o banco
            cls_Conexao con = new cls_Conexao();
           // con.carregar_parametros();
            MySqlConnection conecta = new MySqlConnection(cls_Conexao.driver);

            //Pega o valor da campo id e monta a query
            String id = tb_id.Text;
            String sql = "select * from tb_proc where id = " + id + "";

            try
            {
                //Executa o select no banco, armaze o resultado no DataTable
                MySqlDataAdapter comando = new MySqlDataAdapter(sql, conecta);
                comando.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    id_ok = 1;
                    habilitar_campos();
                    tb_id.Enabled = false;
                    //Pega os valores das colunas e atribuem aos TextBox
                    tb_descricao.Text = Convert.ToString(dt.Rows[0]["descricao"]);
                    tb_solucao.Text = Convert.ToString(dt.Rows[0]["conteudo"]);
                    tb_autor.Text = Convert.ToString(dt.Rows[0]["autor"]);
                    tb_sistema.Text = Convert.ToString(dt.Rows[0]["sistema"]);
                    tb_dt.Text = Convert.ToString(dt.Rows[0]["dtcriacao"]);
                    tb_revisao.Text = Convert.ToString(dt.Rows[0]["revisao"]);
                    tb_aprovado.Text = Convert.ToString(dt.Rows[0]["aprovado"]);
                }
                else
                {
                  DialogResult dlr =  MessageBox.Show("Artigo não cadastrado", "erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex.GetBaseException();
            }
                

        }

        public void recebe_campos(String descricao, String solucao, String autor, String sistema, String data, String revisao,String aprovado,String id) {
            tb_descricao.Text = descricao;
            tb_solucao.Text = solucao;
            tb_autor.Text = autor;
            tb_sistema.Text = sistema;
            tb_dt.Text = data;
            tb_revisao.Text = revisao;
            tb_aprovado.Text = aprovado;
            tb_id.Enabled = false;
            tb_id.Text = id;
        }
        public void limpa_campos(){
        tb_aprovado.Text = "";
        tb_autor.Text = "";
        tb_dt.Text = "";
        tb_id.Text = "";
        tb_revisao.Text = "";
        tb_sistema.Text = "";
        tb_solucao.Text = "";
        tb_descricao.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();            
                frm_procedimentos cad = new frm_procedimentos();
                cad.recebe_chamador(true);
                cad.ShowDialog();
                
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_solucao_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_aprovado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_revisao_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_dt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tb_sistema_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_ok = 0;
            String sql = "select max(id) + 1 as id from tb_proc";
            cls_Conexao con = new cls_Conexao();
            MySqlConnection conectar = new MySqlConnection(cls_Conexao.driver);
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(sql, conectar);
            ad.Fill(dt);
            tb_id.Text = Convert.ToString(dt.Rows[0]["id"]);
            habilitar_campos();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // ID_OK controla se sera feito um Update no procedimento ou um select
            id_ok = 0;
            desabilitar_campos();
            limpa_campos();
        }

        public void habilitar_campos() {
            this.tb_aprovado.Enabled = true;
            this.tb_id.Enabled = false;
            this.tb_descricao.Enabled = true;
            this.tb_solucao.Enabled = true;
            this.tb_autor.Enabled = true;
            this.tb_sistema.Enabled = true;
            this.tb_dt.Enabled = true;
            this.tb_revisao.Enabled = true;
            this.tb_aprovado.Enabled = true;
            this.btn_salvar.Enabled = true;
            this.btn_excluir.Enabled = true;
            this.btn_cancelar.Enabled = true;
            this.btn_novo.Enabled = false;
        }

        public void desabilitar_campos() {
            this.tb_aprovado.Enabled = false;
            this.tb_id.Enabled = true;
            this.tb_descricao.Enabled = false;
            this.tb_solucao.Enabled = false;
            this.tb_autor.Enabled = false;
            this.tb_sistema.Enabled = false;
            this.tb_dt.Enabled = false;
            this.tb_revisao.Enabled = false;
            this.tb_aprovado.Enabled = false;
            this.btn_salvar.Enabled = false;
            this.btn_excluir.Enabled = false;
            this.btn_cancelar.Enabled = false;
            this.btn_novo.Enabled = true;
        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                if(tb_id.Text != "")
                pesquisar_id();
            tb_id.Focus();

        }

        private void frm_CadProc_Load(object sender, EventArgs e)
        {
            tb_id.Focus();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Deseja realmente excluir este procedimento?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (a == DialogResult.Yes)
            {
                try
                {
                    cls_Conexao conexao = new cls_Conexao();
                    MySqlConnection con = new MySqlConnection(cls_Conexao.driver);
                    con.Open();
                    int id = Convert.ToInt32(tb_id.Text);
                    String sql = "delete from tb_proc where id = " + id + "";
                    MySqlCommand comando = new MySqlCommand(sql, con);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    desabilitar_campos();
                    limpa_campos();
                }catch(MySqlException ex){
                    MessageBox.Show("Erro ao excluir registro" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
