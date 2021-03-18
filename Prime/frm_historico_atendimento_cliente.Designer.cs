namespace Prime
{
    partial class frm_historico_atendimento_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_historico_atendimento_cliente));
            this.dgv_pesquisa = new System.Windows.Forms.DataGridView();
            this.codigo_Atendimento = new System.Windows.Forms.DataGridViewLinkColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataabertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pesquisa
            // 
            this.dgv_pesquisa.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_Atendimento,
            this.user,
            this.status,
            this.Filial,
            this.Cliente,
            this.Sistema,
            this.dataabertura,
            this.DataFechamento});
            this.dgv_pesquisa.Location = new System.Drawing.Point(12, 12);
            this.dgv_pesquisa.Name = "dgv_pesquisa";
            this.dgv_pesquisa.RowHeadersVisible = false;
            this.dgv_pesquisa.Size = new System.Drawing.Size(900, 215);
            this.dgv_pesquisa.TabIndex = 2;
            this.dgv_pesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pesquisa_CellContentClick);
            // 
            // codigo_Atendimento
            // 
            this.codigo_Atendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo_Atendimento.DataPropertyName = "id_atendimento";
            this.codigo_Atendimento.HeaderText = "Atendimento";
            this.codigo_Atendimento.Name = "codigo_Atendimento";
            this.codigo_Atendimento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codigo_Atendimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // user
            // 
            this.user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user.DataPropertyName = "user";
            this.user.HeaderText = "Usuario";
            this.user.Name = "user";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // Filial
            // 
            this.Filial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Filial.DataPropertyName = "filial";
            this.Filial.HeaderText = "Filial";
            this.Filial.Name = "Filial";
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Sistema
            // 
            this.Sistema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sistema.DataPropertyName = "sistema";
            this.Sistema.HeaderText = "Sistema";
            this.Sistema.Name = "Sistema";
            // 
            // dataabertura
            // 
            this.dataabertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataabertura.DataPropertyName = "abertura";
            this.dataabertura.HeaderText = "Data Abertura";
            this.dataabertura.Name = "dataabertura";
            // 
            // DataFechamento
            // 
            this.DataFechamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataFechamento.DataPropertyName = "fechamento";
            this.DataFechamento.HeaderText = "Data Fechamento";
            this.DataFechamento.Name = "DataFechamento";
            // 
            // frm_historico_atendimento_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 239);
            this.Controls.Add(this.dgv_pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_historico_atendimento_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de Atendimentos";
            this.Load += new System.EventHandler(this.frm_historico_atendimento_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pesquisa;
        private System.Windows.Forms.DataGridViewLinkColumn codigo_Atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataabertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFechamento;
    }
}