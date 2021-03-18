using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Security.Cryptography;

namespace Prime
{
    public partial class frm_principal : Form
    {

        //public string User_logado = "";
        // public string User_logado_codigo = "";

        public frm_principal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro_usuario user = new frm_cadastro_usuario();
            user.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro_cliente cli = new frm_cadastro_cliente();
            cli.ShowDialog();
        }

        private void atendimentoChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pegar o usario que esta Logado no momento
            // string user = toolUserLogado.Text;
            // user = user.Replace("Usuário Logado: ", "");

            frm_atendimento atendimento = new frm_atendimento();
            //  atendimento.user_logado = user;  // Passo para a tela de atendimento o usuario que esta logado
            atendimento.ShowDialog();
        }

        private void verifica_existe_arquivo_config()
        {


            if (!File.Exists("config.ini"))
            {
                MessageBox.Show("Arquivo de configuração não encontrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_config_parametros_db conf = new frm_config_parametros_db();
                conf.ShowDialog();
            }

            //  atualiza_fila();
        }

        private void atualiza_fila()
        {
            DataTable dt = cls_Conexao.execute_select("select id_fila,contato,telefone,cnpj,hora, hora2,hora3 from fila where atendido != 'OK' and data = '" + DateTime.Now.ToString("yyyy-MM-dd") +"' order by atendido desc");

            dg_lista.DataSource = dt;
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            //Ajusta o local do LOGO
            int xTela = (this.Width / 2) - (this.panel1.Width / 2);
            int yTela = (this.Height / 2) - (this.panel1.Height / 2);

            panel1.Location = new Point(xTela, yTela);

            //Ajusta o local do GroupBox da Fila
            int xGroup = this.Width - this.groupBox1.Width - 25;
            int yGroup = menuStrip1.Height + 10;

            groupBox1.Location = new Point(xGroup, yGroup);

            //Ajusta o local do Label Sobre
            int xSobre = this.Width - this.Sobre.Width - 30;
            int ySobre = menuStrip1.Height - 19;

            Sobre.Location = new Point(xSobre, ySobre);

            //Verifica se existe o arquivo de configuração
          //  verifica_existe_arquivo_config();

    

            frm_login login = new frm_login();
            login.ShowDialog();

            if (cls_Conexao.user_on != "")
            {
                
                toolUserLogado.Text = "USUÁRIO: " + cls_Conexao.user_on.ToUpper();
            }

            verifica_licenca();

            atualiza_fila();

            timer1.Start();

            Application.DoEvents();
        }

        private void verifica_licenca() {
            String sql = "select * from licenca";

            MySqlCommand command = new MySqlCommand(sql);

            DataTable dt = cls_Conexao.execute_selectP(command);

            DateTime datexp = Convert.ToDateTime(Criptografia.Decript(dt.Rows[0]["dtexp"].ToString()));
            DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));

           // Funcoes.msgInfo(datexp.ToString());
           // Funcoes.msgInfo(dataAtual.ToString());

            if (dataAtual >= datexp)
            {
                Funcoes.msgAlerta("A Versão de Avaliação do sistema Expirou Contate o Administrador do Sistema");
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Deseja realmente sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolUserLogado_Click(object sender, EventArgs e)
        {

        }

        private void monitorarAtendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_monitoramento monitor = new frm_monitoramento();
            monitor.ShowDialog();
        }

        private void btn_Atendimento_Click(object sender, EventArgs e)
        {

            //Pegar o usario que esta Logado no momento

            //string user = cls_Conexao.user_on;
            /*
            string user = toolUserLogado.Text;
            user = user.Replace("Usuário Logado: ", "");
            */

            frm_atendimento atendimento = new frm_atendimento();
            //atendimento.user_logado = user;  // Passo para a tela de atendimento o usuario que esta logado
            atendimento.ShowDialog();

        }

        private void btn_monitorar_Click(object sender, EventArgs e)
        {
            frm_monitoramento monitor = new frm_monitoramento();
            monitor.ShowDialog();
        }

        private void frm_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //coloca o usuario que estava online como offline
            //  offline_usuario();
        }
        private void offline_usuario()
        {
            cls_Conexao conexao = new cls_Conexao();
            //conexao.carregar_parametros()
            MySqlConnection Mcon = new MySqlConnection(cls_Conexao.driver);

            Mcon.Open();

            string user = toolUserLogado.Text;
            user = user.Replace("Usuário Logado: ", "");

            try
            {

                string sql = " update tb_usuario set bi_online = 0 where ds_usuario = '" + user + "' ; ";
                MySqlCommand Mcommand = new MySqlCommand(sql, Mcon);

                Mcommand.ExecuteNonQuery();

            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void registrarSAControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_registrar_SA sa = new frm_registrar_SA();
            sa.ShowDialog();
        }

        private void atendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_analise_atendentes atendente = new frm_analise_atendentes();
            atendente.ShowDialog();
        }

        private void atendimentosXUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_filtro_relatorio_atendimento report = new frm_filtro_relatorio_atendimento();
            report.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_procedimentos frm_proc = new frm_procedimentos();
            frm_proc.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadProc frm_cad_proc = new frm_CadProc();
            frm_cad_proc.ShowDialog();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_EnviarEmail txt = new frm_EnviarEmail();
            txt.ShowDialog();
        }

        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Email email = new frm_Email();
            email.ShowDialog();
        }

        private void analisesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NovoFila fila = new frm_NovoFila();
            fila.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualiza_fila();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_nova_fila_Click_1(object sender, EventArgs e)
        {
            frm_NovoFila fila = new frm_NovoFila();
            fila.ShowDialog();
            atualiza_fila();
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            Frm_HistoricoFila fila = new Frm_HistoricoFila();
            fila.ShowDialog();
        }

        private void dg_lista_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
       
            if (Funcoes.msgQuestion("Deseja marcar este atendimento como atendido?") == DialogResult.Yes)
            {
                String sql = "update fila set atendido = 'OK', userAtendeu = ?atendente where id_fila = ?id_fila";
                MySqlCommand comando = new MySqlCommand(sql);

                comando.Parameters.AddWithValue("?atendente", cls_Conexao.user_on);
                comando.Parameters.AddWithValue("?id_fila", dg_lista.Rows[e.RowIndex].Cells[0].Value);

                if (cls_Conexao.update(comando) == true)
                {
                    Funcoes.msgInfo("Fila atualizada com sucesso!");
                    atualiza_fila();
                }
     
            }
        }

        private void filaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_HistoricoFila historico = new Frm_HistoricoFila();
            historico.ShowDialog();
        }

        private void tb_editar_Click(object sender, EventArgs e)
        {
            //Frm_EditarFila.id_fila = dg_lista.Rows[]
          //  Frm_EditarFila fila = new Frm_EditarFila();
          //  fila.ShowDialog();
        }

        private void tb_detalhes_Click(object sender, EventArgs e)
        {

        }

        private void tb_remover_Click(object sender, EventArgs e)
        {

        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.Show();
        }
    }
}
