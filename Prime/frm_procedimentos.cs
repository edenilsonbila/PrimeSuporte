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
    public partial class frm_procedimentos : Form
    {
        public frm_procedimentos()
        {
            InitializeComponent();
        }

        private void tb_descricao_TextChanged(object sender, EventArgs e)
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection con = new MySqlConnection(cls_Conexao.driver);
            con.Open();

            
            String sql = "select * from tb_proc where descricao like '%" + tb_descricao.Text + "%'";
           // like 'Ro%' order by descricao asc;
            MySqlDataAdapter comando = new MySqlDataAdapter(sql,con);
            DataTable dtb_consulta = new DataTable();
            comando.Fill(dtb_consulta);

            dgResult.DataSource = dtb_consulta;

        }

        // Define qual foi o formulario que chamou a função de pesquisa
        public Boolean cham = false;
        public Boolean recebe_chamador(Boolean chamador) {
            cham = chamador;
            return chamador;
        }

        private void dgResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cham == false)//IF 1
            {
                frm_CadProc cad = new frm_CadProc();
                if (e.RowIndex >= 0)//IF 2
                {

                    String codigo_pesquisa = dgResult.Rows[e.RowIndex].Cells[0].Value.ToString();
               //     cls_Conexao Conexao1 = new cls_Conexao();
                    MySqlConnection conectar = new MySqlConnection(cls_Conexao.driver);
                    conectar.Open();
                    DataTable dt = new DataTable();


                    String sql = "select * from tb_proc where id = " + codigo_pesquisa + "";
                    MySqlDataAdapter dta = new MySqlDataAdapter(sql, conectar);
                    dta.Fill(dt);
                    String conteudo = Convert.ToString(dt.Rows[0]["conteudo"]);
                    String autor = Convert.ToString(dt.Rows[0]["autor"]);
                    String sistema = Convert.ToString(dt.Rows[0]["sistema"]);
                    String data = Convert.ToString(dt.Rows[0]["dtcriacao"]);
                    String revisao = Convert.ToString(dt.Rows[0]["revisao"]);
                    String aprovado = Convert.ToString(dt.Rows[0]["aprovado"]);
                    String descricao = Convert.ToString(dt.Rows[0]["descricao"]);
                    String id = Convert.ToString(dt.Rows[0]["id"]);

                    FrmVisuProc form = new FrmVisuProc();
                    form.recebe_campos(conteudo, autor, sistema, data, revisao, aprovado, descricao, id);
                    form.ShowDialog();
                }//FIm if 2
            }//Fim if 1
            else { 
             //Instancia um novo dataTable, Tabela interna que recebera os dados retornados do banco
            DataTable dt = new DataTable();

            //Cria uma nova conexao com o banco
            cls_Conexao con = new cls_Conexao();
            con.carregar_parametros();
            MySqlConnection conecta = new MySqlConnection(cls_Conexao.driver);

            //Pega o valor da campo id e monta a query
            String id =  dgResult.Rows[e.RowIndex].Cells[0].Value.ToString();
            String sql = "select * from tb_proc where id = " + id + "";

            frm_CadProc cad = new frm_CadProc();
            try
            {//Try
                //Executa o select no banco, armaze o resultado no DataTable
                MySqlDataAdapter comando = new MySqlDataAdapter(sql, conecta);
                comando.Fill(dt);

                if (dt.Rows.Count > 0)
                {//IF 1
                    cad.id_ok = 1;
                    cad.habilitar_campos();

                    //Pega os valores das colunas e atribuem aos TextBox
                    String descricao = Convert.ToString(dt.Rows[0]["descricao"]);
                    String conteudo = Convert.ToString(dt.Rows[0]["conteudo"]);
                    String autor = Convert.ToString(dt.Rows[0]["autor"]);
                    String sistema = Convert.ToString(dt.Rows[0]["sistema"]);
                    String data = Convert.ToString(dt.Rows[0]["dtcriacao"]);
                    String revisao = Convert.ToString(dt.Rows[0]["revisao"]);
                    String aprovado = Convert.ToString(dt.Rows[0]["aprovado"]);
                    String id_pes = Convert.ToString(dt.Rows[0]["id"]);
                    
                    cad.recebe_campos(descricao,conteudo,autor,sistema,data,revisao,aprovado,id_pes);
                    this.Hide();
                    cad.ShowDialog();

                }//Fim if 1
            }//Fim do Try
            catch
            {
                DialogResult dlr = MessageBox.Show("Artigo não cadastrado", "erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//Fim do catch       
               
            }//Fim Else       
    }//Fim metodo

        private void dgResult_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                
                //Monsta o comando SQL
                String sql = "select * from tb_proc where id = ?id";
                //Cria e abra a conexão com o banco de dados
                MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);
                Mcon.Open();

                //Monta e parametriza o Comando
                MySqlCommand comando = new MySqlCommand(sql, Mcon);
                comando.Parameters.AddWithValue("?id",tb_id.Text);
                MySqlDataAdapter comando1 = new MySqlDataAdapter(comando);
               
               // MySqlDataReader rd = new MySqlDataReader();
                
                DataTable dt = new DataTable();
                try
                {
                  comando1.Fill(dt);
                  dgResult.DataSource = dt;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: "+err);
                    throw;
                }



            }
        }

        private void frm_procedimentos_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
}
