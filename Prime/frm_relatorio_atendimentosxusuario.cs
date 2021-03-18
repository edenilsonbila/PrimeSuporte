using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Prime
{
    public partial class frm_relatorio_atendimentosxusuario : Form
    {
        //Variaveis publicas que vão receber os valores via parametro
        public string DATA_INICIAL;
        public string DATA_FINAL;
        public string CAMINHO_REPORT = @"Z:\Alliance Sistemas\HELPDESK\bin\Debug\";


        public frm_relatorio_atendimentosxusuario()
        {
            InitializeComponent();
        }

        private void frm_relatorio_atendimentosxusuario_Load(object sender, EventArgs e)
        {

            //Instancia de um relatório dentro de Report Document 
            ReportDocument cryRpt = new ReportDocument();

            //Passo para o ReportDocument o relatório que ele vai abrir
            //cryRpt.Load(@"N:\Prime\Prime\CrystalReport5.rpt");
            // @"Z:\Alliance Sistemas\HELPDESK\bin\Debug\
            string caminho = Application.StartupPath + "\\CrystalReport5.rpt";
            cryRpt.Load(caminho);
            

            //Setparametervalue = passo o Parametro 
            cryRpt.SetParameterValue("data_inicial", DATA_INICIAL);
            cryRpt.SetParameterValue("data_fim", DATA_FINAL);

            //passa o objeto do relatório como datasource do viwer
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
