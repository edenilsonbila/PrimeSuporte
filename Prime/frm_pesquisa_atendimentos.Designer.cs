namespace Prime
{
    partial class frm_pesquisa_atendimentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pesquisa_atendimentos));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.dgv_atendimentos = new System.Windows.Forms.DataGridView();
            this.numero_atendimento = new System.Windows.Forms.DataGridViewLinkColumn();
            this.azao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_filtro = new System.Windows.Forms.ComboBox();
            this.btn_listar = new System.Windows.Forms.Button();
            this.txt_parametro = new System.Windows.Forms.MaskedTextBox();
            this.Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atendimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Filtro";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Parametro";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fechar.Location = new System.Drawing.Point(603, 254);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(131, 33);
            this.btn_fechar.TabIndex = 15;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // dgv_atendimentos
            // 
            this.dgv_atendimentos.AllowUserToAddRows = false;
            this.dgv_atendimentos.AllowUserToDeleteRows = false;
            this.dgv_atendimentos.AllowUserToResizeColumns = false;
            this.dgv_atendimentos.AllowUserToResizeRows = false;
            this.dgv_atendimentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_atendimentos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_atendimentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_atendimentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_atendimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_atendimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_atendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_atendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_atendimento,
            this.azao,
            this.Filial,
            this.Sistema,
            this.Abertura,
            this.Usuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_atendimentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_atendimentos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_atendimentos.Location = new System.Drawing.Point(12, 43);
            this.dgv_atendimentos.MultiSelect = false;
            this.dgv_atendimentos.Name = "dgv_atendimentos";
            this.dgv_atendimentos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_atendimentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_atendimentos.RowHeadersVisible = false;
            this.dgv_atendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_atendimentos.Size = new System.Drawing.Size(722, 205);
            this.dgv_atendimentos.TabIndex = 14;
            this.dgv_atendimentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atendimentos_CellDoubleClick);
            // 
            // numero_atendimento
            // 
            this.numero_atendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numero_atendimento.DataPropertyName = "id";
            this.numero_atendimento.HeaderText = "Nº Atendimento";
            this.numero_atendimento.Name = "numero_atendimento";
            this.numero_atendimento.ReadOnly = true;
            // 
            // azao
            // 
            this.azao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.azao.DataPropertyName = "razao";
            this.azao.HeaderText = "Cliente ";
            this.azao.Name = "azao";
            this.azao.ReadOnly = true;
            this.azao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.azao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Filial
            // 
            this.Filial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Filial.DataPropertyName = "filial";
            this.Filial.HeaderText = "Filial";
            this.Filial.Name = "Filial";
            this.Filial.ReadOnly = true;
            // 
            // Sistema
            // 
            this.Sistema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sistema.DataPropertyName = "sistema";
            this.Sistema.HeaderText = "Sistema";
            this.Sistema.Name = "Sistema";
            this.Sistema.ReadOnly = true;
            // 
            // Abertura
            // 
            this.Abertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abertura.DataPropertyName = "abertura";
            this.Abertura.HeaderText = "Abertura";
            this.Abertura.Name = "Abertura";
            this.Abertura.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // cmb_filtro
            // 
            this.cmb_filtro.FormattingEnabled = true;
            this.cmb_filtro.Items.AddRange(new object[] {
            "Nº ATENDIMENTO",
            "CNPJ",
            "RAZAO",
            "FANTASIA",
            "PROBLEMA",
            "DATA",
            "FILIAL"});
            this.cmb_filtro.Location = new System.Drawing.Point(48, 15);
            this.cmb_filtro.Name = "cmb_filtro";
            this.cmb_filtro.Size = new System.Drawing.Size(196, 21);
            this.cmb_filtro.TabIndex = 20;
            this.cmb_filtro.SelectedIndexChanged += new System.EventHandler(this.cmb_filtro_SelectedIndexChanged);
            // 
            // btn_listar
            // 
            this.btn_listar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_listar.Location = new System.Drawing.Point(466, 254);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(131, 33);
            this.btn_listar.TabIndex = 21;
            this.btn_listar.Text = "Listar Todos";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // txt_parametro
            // 
            this.txt_parametro.Location = new System.Drawing.Point(311, 15);
            this.txt_parametro.Name = "txt_parametro";
            this.txt_parametro.Size = new System.Drawing.Size(387, 20);
            this.txt_parametro.TabIndex = 22;
            this.txt_parametro.TextChanged += new System.EventHandler(this.txt_parametro_TextChanged_1);
            this.txt_parametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_parametro_KeyPress);
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackgroundImage = global::Prime.Properties.Resources.SetaDireita;
            this.Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pesquisar.Location = new System.Drawing.Point(704, 13);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(30, 23);
            this.Pesquisar.TabIndex = 23;
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // frm_pesquisa_atendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 305);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.txt_parametro);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.cmb_filtro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.dgv_atendimentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_pesquisa_atendimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Atendimentos";
            this.Load += new System.EventHandler(this.frm_pesquisa_atendimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atendimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fechar;
        public System.Windows.Forms.DataGridView dgv_atendimentos;
        private System.Windows.Forms.ComboBox cmb_filtro;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.MaskedTextBox txt_parametro;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.DataGridViewLinkColumn numero_atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn azao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}