namespace Prime
{
    partial class frm_analise_atendentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_analise_atendentes));
            this.dgv_pesquisa = new System.Windows.Forms.DataGridView();
            this.id_atentende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_filtro = new System.Windows.Forms.GroupBox();
            this.btn_pesqusiar = new System.Windows.Forms.Button();
            this.date_time_fim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date_time_iniciao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisa)).BeginInit();
            this.gb_filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pesquisa
            // 
            this.dgv_pesquisa.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_atentende,
            this.Usuario,
            this.Quantidade});
            this.dgv_pesquisa.Location = new System.Drawing.Point(12, 67);
            this.dgv_pesquisa.Name = "dgv_pesquisa";
            this.dgv_pesquisa.RowHeadersVisible = false;
            this.dgv_pesquisa.Size = new System.Drawing.Size(504, 177);
            this.dgv_pesquisa.TabIndex = 0;
            // 
            // id_atentende
            // 
            this.id_atentende.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_atentende.DataPropertyName = "id_usuario";
            this.id_atentende.HeaderText = "Código usuário";
            this.id_atentende.Name = "id_atentende";
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.DataPropertyName = "atendente";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantidade.DataPropertyName = "qtd";
            this.Quantidade.HeaderText = "Quantidade de Atendimentos";
            this.Quantidade.Name = "Quantidade";
            // 
            // gb_filtro
            // 
            this.gb_filtro.Controls.Add(this.btn_pesqusiar);
            this.gb_filtro.Controls.Add(this.date_time_fim);
            this.gb_filtro.Controls.Add(this.label2);
            this.gb_filtro.Controls.Add(this.date_time_iniciao);
            this.gb_filtro.Controls.Add(this.label1);
            this.gb_filtro.Location = new System.Drawing.Point(12, 13);
            this.gb_filtro.Name = "gb_filtro";
            this.gb_filtro.Size = new System.Drawing.Size(504, 48);
            this.gb_filtro.TabIndex = 1;
            this.gb_filtro.TabStop = false;
            this.gb_filtro.Text = "filtro";
            // 
            // btn_pesqusiar
            // 
            this.btn_pesqusiar.Location = new System.Drawing.Point(385, 12);
            this.btn_pesqusiar.Name = "btn_pesqusiar";
            this.btn_pesqusiar.Size = new System.Drawing.Size(113, 23);
            this.btn_pesqusiar.TabIndex = 9;
            this.btn_pesqusiar.Text = "Pesquisar";
            this.btn_pesqusiar.UseVisualStyleBackColor = true;
            this.btn_pesqusiar.Click += new System.EventHandler(this.btn_pesqusiar_Click);
            // 
            // date_time_fim
            // 
            this.date_time_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_time_fim.Location = new System.Drawing.Point(261, 12);
            this.date_time_fim.Name = "date_time_fim";
            this.date_time_fim.Size = new System.Drawing.Size(97, 20);
            this.date_time_fim.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Final";
            // 
            // date_time_iniciao
            // 
            this.date_time_iniciao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_time_iniciao.Location = new System.Drawing.Point(72, 12);
            this.date_time_iniciao.Name = "date_time_iniciao";
            this.date_time_iniciao.Size = new System.Drawing.Size(97, 20);
            this.date_time_iniciao.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Inicial";
            // 
            // frm_analise_atendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 256);
            this.Controls.Add(this.gb_filtro);
            this.Controls.Add(this.dgv_pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_analise_atendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analise de Atendimentos - Por Atendente";
            this.Load += new System.EventHandler(this.frm_analise_atendentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisa)).EndInit();
            this.gb_filtro.ResumeLayout(false);
            this.gb_filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pesquisa;
        private System.Windows.Forms.GroupBox gb_filtro;
        private System.Windows.Forms.DateTimePicker date_time_fim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_time_iniciao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pesqusiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_atentende;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}