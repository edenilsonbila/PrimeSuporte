using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime
{
    public partial class frm_pesquisa_usuario : Form
    {
        public frm_pesquisa_usuario()
        {
            InitializeComponent();
        }

        private void tb_filtro_TextChanged(object sender, EventArgs e)
        {
            String valor = tb_filtro.Text.ToString();
            String filtro = cb_tipoPesquisa.Text.ToString();

            String sql = "select id_usuario,ds_usuario from tb_usuario";

            String clausula = "";

            if (filtro == "Código")
            {
                 clausula = " where id_usuario like '%" + valor + "%'";
            }
            else {
                 clausula = " where ds_usuario like '%" + valor + "%'";
            }

            sql += clausula;

           // Funcoes.msgInfo(sql);

          DataTable dt = cls_Conexao.execute_select(sql);

          dgResult.DataSource = dt;

        }

        private void frm_pesquisa_usuario_Load(object sender, EventArgs e)
        {
            dgResult.Columns.Add("Text","Nome");
        }
    }
}
