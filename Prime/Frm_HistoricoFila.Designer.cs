namespace Prime
{
    partial class Frm_HistoricoFila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HistoricoFila));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tipoFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_lista = new System.Windows.Forms.DataGridView();
            this.id_fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_atentende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_filtro = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por:";
            // 
            // cb_tipoFiltro
            // 
            this.cb_tipoFiltro.FormattingEnabled = true;
            this.cb_tipoFiltro.Items.AddRange(new object[] {
            "DATA",
            "CONTATO",
            "ATENDENTE",
            "CLIENTE/CNPJ"});
            this.cb_tipoFiltro.Location = new System.Drawing.Point(72, 10);
            this.cb_tipoFiltro.Name = "cb_tipoFiltro";
            this.cb_tipoFiltro.Size = new System.Drawing.Size(134, 21);
            this.cb_tipoFiltro.TabIndex = 1;
            this.cb_tipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cb_tipoFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_lista);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // dg_lista
            // 
            this.dg_lista.AllowUserToAddRows = false;
            this.dg_lista.AllowUserToDeleteRows = false;
            this.dg_lista.AllowUserToResizeColumns = false;
            this.dg_lista.AllowUserToResizeRows = false;
            this.dg_lista.BackgroundColor = System.Drawing.Color.White;
            this.dg_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fila,
            this.id_atentende,
            this.Usuario,
            this.Quantidade,
            this.hr,
            this.Hora2,
            this.Hora3,
            this.Atendente});
            this.dg_lista.Location = new System.Drawing.Point(6, 19);
            this.dg_lista.MultiSelect = false;
            this.dg_lista.Name = "dg_lista";
            this.dg_lista.ReadOnly = true;
            this.dg_lista.RowHeadersVisible = false;
            this.dg_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_lista.Size = new System.Drawing.Size(593, 217);
            this.dg_lista.TabIndex = 14;
            // 
            // id_fila
            // 
            this.id_fila.DataPropertyName = "id_fila";
            this.id_fila.HeaderText = "id_fila";
            this.id_fila.Name = "id_fila";
            this.id_fila.ReadOnly = true;
            this.id_fila.Visible = false;
            // 
            // id_atentende
            // 
            this.id_atentende.DataPropertyName = "contato";
            this.id_atentende.FillWeight = 173.1212F;
            this.id_atentende.HeaderText = "Contato";
            this.id_atentende.Name = "id_atentende";
            this.id_atentende.ReadOnly = true;
            this.id_atentende.Width = 120;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "telefone";
            this.Usuario.FillWeight = 119.5432F;
            this.Usuario.HeaderText = "Telefone";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "cnpj";
            this.Quantidade.FillWeight = 7.335648F;
            this.Quantidade.HeaderText = "CNPJ";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 150;
            // 
            // hr
            // 
            this.hr.DataPropertyName = "hora";
            this.hr.HeaderText = "Hora";
            this.hr.Name = "hr";
            this.hr.ReadOnly = true;
            this.hr.Width = 40;
            // 
            // Hora2
            // 
            this.Hora2.DataPropertyName = "hora2";
            this.Hora2.HeaderText = "Hora2";
            this.Hora2.Name = "Hora2";
            this.Hora2.ReadOnly = true;
            this.Hora2.Width = 40;
            // 
            // Hora3
            // 
            this.Hora3.DataPropertyName = "hora3";
            this.Hora3.HeaderText = "Hora3";
            this.Hora3.Name = "Hora3";
            this.Hora3.ReadOnly = true;
            this.Hora3.Width = 40;
            // 
            // Atendente
            // 
            this.Atendente.DataPropertyName = "userAtendeu";
            this.Atendente.HeaderText = "Atendente";
            this.Atendente.Name = "Atendente";
            this.Atendente.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // tb_filtro
            // 
            this.tb_filtro.Location = new System.Drawing.Point(267, 10);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(344, 20);
            this.tb_filtro.TabIndex = 6;
            this.tb_filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_filtro_KeyPress);
            // 
            // Frm_HistoricoFila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 291);
            this.Controls.Add(this.tb_filtro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_tipoFiltro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HistoricoFila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico Fila";
            this.Load += new System.EventHandler(this.Frm_HistoricoFila_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tipoFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_atentende;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn hr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atendente;
        private System.Windows.Forms.MaskedTextBox tb_filtro;
    }
}