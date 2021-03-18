namespace Prime
{
    partial class frm_pesquisa_usuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tipoPesquisa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            this.gb_pesquisa = new System.Windows.Forms.GroupBox();
            this.Resultado = new System.Windows.Forms.GroupBox();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.gb_pesquisa.SuspendLayout();
            this.Resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar por:";
            // 
            // cb_tipoPesquisa
            // 
            this.cb_tipoPesquisa.FormattingEnabled = true;
            this.cb_tipoPesquisa.Items.AddRange(new object[] {
            "Código",
            "Usuário"});
            this.cb_tipoPesquisa.Location = new System.Drawing.Point(94, 15);
            this.cb_tipoPesquisa.Name = "cb_tipoPesquisa";
            this.cb_tipoPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cb_tipoPesquisa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtro:";
            // 
            // tb_filtro
            // 
            this.tb_filtro.Location = new System.Drawing.Point(259, 15);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(402, 20);
            this.tb_filtro.TabIndex = 3;
            this.tb_filtro.TextChanged += new System.EventHandler(this.tb_filtro_TextChanged);
            // 
            // gb_pesquisa
            // 
            this.gb_pesquisa.Controls.Add(this.cb_tipoPesquisa);
            this.gb_pesquisa.Controls.Add(this.tb_filtro);
            this.gb_pesquisa.Controls.Add(this.label1);
            this.gb_pesquisa.Controls.Add(this.label2);
            this.gb_pesquisa.Location = new System.Drawing.Point(12, 12);
            this.gb_pesquisa.Name = "gb_pesquisa";
            this.gb_pesquisa.Size = new System.Drawing.Size(667, 51);
            this.gb_pesquisa.TabIndex = 4;
            this.gb_pesquisa.TabStop = false;
            this.gb_pesquisa.Text = "Pesquisa";
            // 
            // Resultado
            // 
            this.Resultado.Controls.Add(this.dgResult);
            this.Resultado.Location = new System.Drawing.Point(12, 69);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(667, 217);
            this.Resultado.TabIndex = 5;
            this.Resultado.TabStop = false;
            this.Resultado.Text = "Resultado";
            // 
            // dgResult
            // 
            this.dgResult.AllowUserToAddRows = false;
            this.dgResult.AllowUserToDeleteRows = false;
            this.dgResult.AllowUserToResizeColumns = false;
            this.dgResult.AllowUserToResizeRows = false;
            this.dgResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(6, 19);
            this.dgResult.MultiSelect = false;
            this.dgResult.Name = "dgResult";
            this.dgResult.ReadOnly = true;
            this.dgResult.RowHeadersVisible = false;
            this.dgResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResult.ShowEditingIcon = false;
            this.dgResult.Size = new System.Drawing.Size(655, 192);
            this.dgResult.TabIndex = 2;
            // 
            // frm_pesquisa_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 298);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.gb_pesquisa);
            this.Name = "frm_pesquisa_usuario";
            this.Text = "frm_pesquisa_usuario";
            this.Load += new System.EventHandler(this.frm_pesquisa_usuario_Load);
            this.gb_pesquisa.ResumeLayout(false);
            this.gb_pesquisa.PerformLayout();
            this.Resultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tipoPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_filtro;
        private System.Windows.Forms.GroupBox gb_pesquisa;
        private System.Windows.Forms.GroupBox Resultado;
        private System.Windows.Forms.DataGridView dgResult;
    }
}