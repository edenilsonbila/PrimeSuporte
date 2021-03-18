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
    public partial class FrmVisuProc : Form
    {
        public FrmVisuProc()
        {
            InitializeComponent();
        }

        public void recebe_campos(String conteudo,String autor, String sistema, String dtaprovado, String revisao, String aprovado, String descricao,String id) {
            tb_visualizacao.Text = conteudo;
            tb_autor.Text = autor;
            tb_sistema.Text = sistema;
            tb_dt.Text = dtaprovado;
            tb_revisao.Text = revisao;
            tb_aprovado.Text = aprovado;
            tb_descricao.Text = descricao;
            tb_id.Text = id;
        }
        private void FrmVisuProc_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int font_atual = Convert.ToInt32(tb_visualizacao.Font.Size);
            font_atual = font_atual + 1;
            if(font_atual <= 18)
             tb_visualizacao.Font = new Font("tahoma",font_atual);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int font_atual = Convert.ToInt32(tb_visualizacao.Font.Size);
            font_atual = font_atual - 1;
            if (font_atual >= 8)
            {
                tb_visualizacao.Font = new Font("tahoma", font_atual);
            }
        }
    }
}
