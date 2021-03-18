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
    public partial class frm_filtro_relatorio_atendimento : Form
    {
        public frm_filtro_relatorio_atendimento()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

            //verifica se o usuário parametrizou certinha a data.
            if (dtp_inicial.Value.Date > dtp_final.Value.Date)
            {
                MessageBox.Show("Data Inicial não pode ser maior que data final","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //se a data inicial for maior, ele estoura
            }
            
            //Instancia do Objeto do form do relatório
            frm_relatorio_atendimentosxusuario report = new frm_relatorio_atendimentosxusuario();

            //coleta as datas dos componentes e formata no formato ideal para o SELECT
            string data_inicial = dtp_inicial.Value.ToString("yyyy-MM-dd");
            string data_final = dtp_final.Value.ToString("yyyy-MM-dd");

            //Envia os parametros para dentro do Objeto(form)
            report.DATA_INICIAL = data_inicial;
            report.DATA_FINAL = data_final;
            
            //Abre o report
            report.ShowDialog();
        }
    }
}
