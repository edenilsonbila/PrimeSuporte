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

    public partial class frm_NovoFila : Form
    {
        public frm_NovoFila()
        {
            InitializeComponent();
        }

        private void frm_NovoFila_Load(object sender, EventArgs e)
        {

            tb_hora.Text = DateTime.Now.ToString("HH:mm");

            tb_cnpj.Focus();

        }

        public static Boolean cliente_preenchido = false;

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if(tb_cnpj.MaskCompleted == false){
                Funcoes.msgAlerta("CNPJ Inválido");
                tb_cnpj.Focus();
                return;
            }
            if(tb_contato.Text == ""){
                Funcoes.msgAlerta("Campo Contato é Obrigatório");
                tb_contato.Focus();
                return;
            }
            if (tb_fantasia.Text == "")
            {
                Funcoes.msgAlerta("Campo Fantasia é Obrigatório");
                tb_fantasia.Focus();
                return;
            }
            if (tb_cnpj.MaskCompleted == false)
            {
                Funcoes.msgAlerta("Hora Inválida");
                tb_hora.Focus();
                return;
            }

            String sql = "insert into fila (contato,telefone,cliente,cnpj,hora,data,obs) values (?contato,?tel,?cliente,?cnpj,?hora,?data,?obs)";
            MySqlCommand comando = new MySqlCommand(sql);
            comando.Parameters.AddWithValue("?contato", tb_contato.Text.ToString());
            comando.Parameters.AddWithValue("?tel", tb_telefone.Text.ToString());
            comando.Parameters.AddWithValue("?cliente", tb_fantasia.Text.ToString());
            comando.Parameters.AddWithValue("?cnpj", tb_cnpj.Text.ToString());
            comando.Parameters.AddWithValue("?hora", tb_hora.Text.ToString());
            comando.Parameters.AddWithValue("?data", DateTime.Now.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("?obs", tb_obs.Text.ToString());
            // comando.Parameters.AddWithValue("?atendido", tb_a.Text);
            // comando.Parameters.AddWithValue("?userAtendeu", tb_contato.Text);

            if (cls_Conexao.insert(comando) == true)
            {
                Funcoes.msgInfo("Fila atualizada com sucesso");
                this.Close();
            }

        }

        private void tb_cnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tb_cnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                //Verifica se o txt_codigo_cliente esta diferente de vazio
                if (tb_cnpj.Text != String.Empty)
                {
                    String sql = "select nu_telefone, fantasia from tb_cliente where nu_cnpj = '"+ tb_cnpj.Text +"'";

                    //  string sql = "select * from tb_cliente where nu_cnpj = '" + txt_cnpj.Text + "'";
                    DataTable dt = cls_Conexao.execute_select(sql);

                    if (dt.Rows.Count > 0)
                    {
                        tb_fantasia.Text = dt.Rows[0]["fantasia"].ToString();
                        tb_telefone.Text = dt.Rows[0]["nu_telefone"].ToString();
                        tb_fantasia.Enabled = false;
                      //  tb_telefone.Enabled = false;
                        tb_contato.Focus();
                        cliente_preenchido = true;
                    }
                    else {
                        cliente_preenchido = false;
                        tb_contato.Focus();
                    }

                }
            }
        }

        private void tb_contato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13){
                if (cliente_preenchido == true)
                {
                    btn_confirmar.Select();
                }
                else {
                    tb_telefone.Focus();
                }
            }
        }

        private void tb_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tb_fantasia.Focus();
            }
        }

        private void tb_fantasia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_confirmar.Select();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpar_campos();
        }

        public void limpar_campos() {
            tb_fantasia.Text = "";
            tb_contato.Text = "";
            tb_cnpj.Text = "";
            tb_telefone.Text = "";
        }

    }
}
