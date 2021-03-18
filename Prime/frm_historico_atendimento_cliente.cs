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
    public partial class frm_historico_atendimento_cliente : Form
    {
        public string codigo_cliente;

        public frm_historico_atendimento_cliente()
        {
            InitializeComponent();
        }

        private void frm_historico_atendimento_cliente_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(codigo_cliente);
            listar_atendimentos_cliente(codigo_cliente);
        }

        private void listar_atendimentos_cliente(string cliente)
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
                             " where c.id_cliente = '" + cliente + "'";

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


    }
}
