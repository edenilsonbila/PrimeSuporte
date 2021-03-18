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
    public partial class Frm_HistoricoFila : Form
    {
        public Frm_HistoricoFila()
        {
            InitializeComponent();
        }

        private void Frm_HistoricoFila_Load(object sender, EventArgs e)
        {
            atualiza_fila();
        }

        private void atualiza_fila()
        {
            DataTable dt = cls_Conexao.execute_select("select id_fila,contato,telefone,cnpj,hora, hora2,hora3,userAtendeu from fila where data = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' order by atendido desc");

            dg_lista.DataSource = dt;
        }

        private void cb_tipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpa a mascara e o conteudo do campo
            tb_filtro.Mask = "";
            tb_filtro.Clear();

            //Caso selecionando data, coloca uma mascara de data no tb
            if (cb_tipoFiltro.Text == "DATA")
            {
                tb_filtro.Mask = "00/00/0000";
            }

            //Caso seja cnpj coloca uma mascara de CNPJ
            if (cb_tipoFiltro.Text == "CLIENTE/CNPJ")
            {
                tb_filtro.Mask = "00,000,000/0000-00";
            }
        }

        private void tb_filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13){

                String sql = "";

                if (cb_tipoFiltro.Text == "DATA")
                {
                    string filtro = tb_filtro.Text;
                    filtro = Convert.ToDateTime(filtro).ToString("yyyy-MM-dd");
                    sql = "select contato,telefone,cnpj,hora,hora2,hora3,userAtendeu from fila where data = '"+ filtro +"'";
                    dg_lista.DataSource = cls_Conexao.execute_select(sql);
                }

                if (cb_tipoFiltro.Text == "CLIENTE/CNPJ")
                {
                    string filtro = tb_filtro.Text;
                    sql = "select contato,telefone,cnpj,hora,hora2,hora3,userAtendeu from fila where cnpj = '" + filtro + "'";
                    dg_lista.DataSource = cls_Conexao.execute_select(sql);
                }

                if (cb_tipoFiltro.Text == "CONTATO")
                {
                    string filtro = tb_filtro.Text;
                    sql = "select contato,telefone,cnpj,hora,hora2,hora3,userAtendeu from fila where contato = '" + filtro + "'";
                    dg_lista.DataSource = cls_Conexao.execute_select(sql);
                }

                if (cb_tipoFiltro.Text == "ATENDENTE")
                {
                    string filtro = tb_filtro.Text;
                    sql = "select contato,telefone,cnpj,hora,hora2,hora3,userAtendeu from fila where userAtendeu = '" + filtro + "'";
                    dg_lista.DataSource = cls_Conexao.execute_select(sql);
                }
                /*

                if (cmb_filtro.Text == "CNPJ")
                {
                    string filtro = txt_parametro.Text;
                    string sql = " select " +
                                     " a.id_atendimento as id, " +
                                     " c.ds_razao_social as razao, " +
                                     " f.ds_filial as filial, " +
                                     " s.ds_sistema as sistema, " +
                                     " a.dt_abertura as abertura, " +
                                     " u.ds_usuario as usuario " +

                                     " from tb_atendimento a " +

                                     " inner join tb_filial f on f.id_filial = a.id_filial " +
                                     " inner join tb_cliente c on c.id_cliente = a.id_cliente " +
                                     " inner join tb_sistema s on s.id_sistema = a.id_sistema " +
                                     " inner join tb_usuario u on u.id_usuario = a.id_usuario " +
                                     " where c.nu_cnpj = '" + filtro + "'";
                    DataTable dt = cls_Conexao.execute_select(sql);
                    dgv_atendimentos.DataSource = dt;
                 * 
                }
                 * */
            }
        }
    }
}
