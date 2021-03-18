namespace Prime
{
    partial class frm_pesquisa_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pesquisa_cliente));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.CodigoCliente = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Razao_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tp_pesquisa = new System.Windows.Forms.ComboBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descricão:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descricao.Location = new System.Drawing.Point(309, 13);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.ReadOnly = true;
            this.txt_descricao.Size = new System.Drawing.Size(429, 20);
            this.txt_descricao.TabIndex = 11;
            this.txt_descricao.Click += new System.EventHandler(this.txt_descricao_Click);
            this.txt_descricao.TextChanged += new System.EventHandler(this.txt_descricao_TextChanged);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fechar.Location = new System.Drawing.Point(654, 303);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(84, 24);
            this.btn_fechar.TabIndex = 9;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.AllowUserToAddRows = false;
            this.dgv_cliente.AllowUserToDeleteRows = false;
            this.dgv_cliente.AllowUserToResizeColumns = false;
            this.dgv_cliente.AllowUserToResizeRows = false;
            this.dgv_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_cliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_cliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCliente,
            this.Razao_Social,
            this.Telefone,
            this.Endereco,
            this.Cnpj});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgv_cliente.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_cliente.Location = new System.Drawing.Point(16, 40);
            this.dgv_cliente.MultiSelect = false;
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_cliente.RowHeadersVisible = false;
            this.dgv_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cliente.Size = new System.Drawing.Size(722, 257);
            this.dgv_cliente.TabIndex = 8;
            this.dgv_cliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cliente_CellDoubleClick);
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CodigoCliente.DataPropertyName = "id_cliente";
            this.CodigoCliente.FillWeight = 111.6751F;
            this.CodigoCliente.HeaderText = "Código Cliente";
            this.CodigoCliente.Name = "CodigoCliente";
            this.CodigoCliente.ReadOnly = true;
            this.CodigoCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodigoCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Razao_Social
            // 
            this.Razao_Social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Razao_Social.DataPropertyName = "ds_razao_social";
            this.Razao_Social.FillWeight = 97.08122F;
            this.Razao_Social.HeaderText = "Razão Social";
            this.Razao_Social.Name = "Razao_Social";
            this.Razao_Social.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefone.DataPropertyName = "nu_telefone";
            this.Telefone.FillWeight = 97.08122F;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Endereco.DataPropertyName = "ds_endereco";
            this.Endereco.FillWeight = 97.08122F;
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            // 
            // Cnpj
            // 
            this.Cnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cnpj.DataPropertyName = "nu_cnpj";
            this.Cnpj.FillWeight = 97.08122F;
            this.Cnpj.HeaderText = "Cnpj";
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pesquisar por:";
            // 
            // cb_tp_pesquisa
            // 
            this.cb_tp_pesquisa.FormattingEnabled = true;
            this.cb_tp_pesquisa.Items.AddRange(new object[] {
            "CNPJ",
            "FANTASIA",
            "RAZAO SOCIAL",
            "CODIGO"});
            this.cb_tp_pesquisa.Location = new System.Drawing.Point(96, 12);
            this.cb_tp_pesquisa.Name = "cb_tp_pesquisa";
            this.cb_tp_pesquisa.Size = new System.Drawing.Size(143, 21);
            this.cb_tp_pesquisa.TabIndex = 15;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo.Location = new System.Drawing.Point(62, 37);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 10;
            this.txt_codigo.Visible = false;
            this.txt_codigo.Click += new System.EventHandler(this.txt_codigo_Click);
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // frm_pesquisa_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 339);
            this.Controls.Add(this.cb_tp_pesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.dgv_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_pesquisa_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_pesquisa_cliente_FormClosing);
            this.Load += new System.EventHandler(this.frm_pesquisa_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Button btn_fechar;
        public System.Windows.Forms.DataGridView dgv_cliente;
        private System.Windows.Forms.DataGridViewLinkColumn CodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razao_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tp_pesquisa;
        private System.Windows.Forms.TextBox txt_codigo;
    }
}