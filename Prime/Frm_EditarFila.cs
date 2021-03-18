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

namespace Prime
{
    public partial class Frm_EditarFila : Form
    {
        public Frm_EditarFila()
        {
            InitializeComponent();
        }

        public static int id_fila = 0;

        private void Frm_EditarFila_Load(object sender, EventArgs e)
        {
            Funcoes.msgInfo(id_fila.ToString());

            String sql = "select * from fila where id_fila = ?id";

            MySqlCommand comando = new MySqlCommand(sql);
            comando.Parameters.AddWithValue("?id",id_fila);

            DataTable dt = cls_Conexao.execute_selectP(comando);

            tb_cnpj.Text = dt.Rows[0]["cnpj"].ToString();
            tb_contato.Text = dt.Rows[0]["contato"].ToString();
            tb_telefone.Text = dt.Rows[0]["telefone"].ToString();
            tb_fantasia.Text = dt.Rows[0]["cliente"].ToString();
            tb_hora.Text = dt.Rows[0]["hora"].ToString();
            tb_obs.Text = dt.Rows[0]["obs"].ToString();

        }
    }
}
