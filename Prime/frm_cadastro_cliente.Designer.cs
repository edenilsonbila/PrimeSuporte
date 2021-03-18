namespace Prime
{
    partial class frm_cadastro_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_cliente));
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.group_campos = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_frente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_retaguarda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_filial = new System.Windows.Forms.ComboBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_fantasia = new System.Windows.Forms.TextBox();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_razao = new System.Windows.Forms.TextBox();
            this.btn_pesq = new System.Windows.Forms.Button();
            this.txt_codigo_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_codController = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.group_campos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Tipo,
            this.data_cadastro,
            this.Endereco});
            this.dgv_cliente.Enabled = false;
            this.dgv_cliente.Location = new System.Drawing.Point(297, 17);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.RowHeadersVisible = false;
            this.dgv_cliente.Size = new System.Drawing.Size(20, 13);
            this.dgv_cliente.TabIndex = 25;
            this.dgv_cliente.Visible = false;
            this.dgv_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cliente_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.DataPropertyName = "id_cliente";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "ds_razao_social";
            this.Nome.HeaderText = "Razao";
            this.Nome.Name = "Nome";
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.DataPropertyName = "nu_telefone";
            this.Tipo.HeaderText = "Telefone";
            this.Tipo.Name = "Tipo";
            // 
            // data_cadastro
            // 
            this.data_cadastro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_cadastro.DataPropertyName = "nu_cnpj";
            this.data_cadastro.HeaderText = "CNPJ";
            this.data_cadastro.Name = "data_cadastro";
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "ds_endereco";
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.Name = "Endereco";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(307, 272);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(84, 26);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Enabled = false;
            this.btn_confirmar.Location = new System.Drawing.Point(217, 272);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(84, 26);
            this.btn_confirmar.TabIndex = 23;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // group_campos
            // 
            this.group_campos.Controls.Add(this.tb_codController);
            this.group_campos.Controls.Add(this.label10);
            this.group_campos.Controls.Add(this.label9);
            this.group_campos.Controls.Add(this.cmb_frente);
            this.group_campos.Controls.Add(this.label8);
            this.group_campos.Controls.Add(this.cmb_retaguarda);
            this.group_campos.Controls.Add(this.label7);
            this.group_campos.Controls.Add(this.cmb_filial);
            this.group_campos.Controls.Add(this.txt_telefone);
            this.group_campos.Controls.Add(this.label6);
            this.group_campos.Controls.Add(this.tb_fantasia);
            this.group_campos.Controls.Add(this.txt_cnpj);
            this.group_campos.Controls.Add(this.label5);
            this.group_campos.Controls.Add(this.label4);
            this.group_campos.Controls.Add(this.label3);
            this.group_campos.Controls.Add(this.txt_endereco);
            this.group_campos.Controls.Add(this.label2);
            this.group_campos.Controls.Add(this.txt_razao);
            this.group_campos.Enabled = false;
            this.group_campos.Location = new System.Drawing.Point(12, 90);
            this.group_campos.Name = "group_campos";
            this.group_campos.Size = new System.Drawing.Size(393, 176);
            this.group_campos.TabIndex = 22;
            this.group_campos.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Frente:";
            // 
            // cmb_frente
            // 
            this.cmb_frente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_frente.FormattingEnabled = true;
            this.cmb_frente.Location = new System.Drawing.Point(247, 144);
            this.cmb_frente.Name = "cmb_frente";
            this.cmb_frente.Size = new System.Drawing.Size(132, 21);
            this.cmb_frente.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Retaguarda:";
            // 
            // cmb_retaguarda
            // 
            this.cmb_retaguarda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_retaguarda.FormattingEnabled = true;
            this.cmb_retaguarda.Location = new System.Drawing.Point(75, 144);
            this.cmb_retaguarda.Name = "cmb_retaguarda";
            this.cmb_retaguarda.Size = new System.Drawing.Size(116, 21);
            this.cmb_retaguarda.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Filial:";
            // 
            // cmb_filial
            // 
            this.cmb_filial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filial.FormattingEnabled = true;
            this.cmb_filial.Location = new System.Drawing.Point(220, 117);
            this.cmb_filial.Name = "cmb_filial";
            this.cmb_filial.Size = new System.Drawing.Size(159, 21);
            this.cmb_filial.TabIndex = 27;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(79, 117);
            this.txt_telefone.Mask = "(00)0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(100, 20);
            this.txt_telefone.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fantasia:";
            // 
            // tb_fantasia
            // 
            this.tb_fantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_fantasia.Location = new System.Drawing.Point(79, 65);
            this.tb_fantasia.Name = "tb_fantasia";
            this.tb_fantasia.Size = new System.Drawing.Size(300, 20);
            this.tb_fantasia.TabIndex = 11;
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(79, 13);
            this.txt_cnpj.Mask = "00,000,000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(116, 20);
            this.txt_cnpj.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CNPJ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_endereco.Location = new System.Drawing.Point(79, 91);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(300, 20);
            this.txt_endereco.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razão Social:";
            // 
            // txt_razao
            // 
            this.txt_razao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_razao.Location = new System.Drawing.Point(79, 39);
            this.txt_razao.Name = "txt_razao";
            this.txt_razao.Size = new System.Drawing.Size(300, 20);
            this.txt_razao.TabIndex = 2;
            // 
            // btn_pesq
            // 
            this.btn_pesq.Image = global::Prime.Properties.Resources.magnifying_glass_189254_640;
            this.btn_pesq.Location = new System.Drawing.Point(167, 61);
            this.btn_pesq.Name = "btn_pesq";
            this.btn_pesq.Size = new System.Drawing.Size(24, 23);
            this.btn_pesq.TabIndex = 28;
            this.btn_pesq.UseVisualStyleBackColor = true;
            this.btn_pesq.Click += new System.EventHandler(this.btn_pesq_Click);
            // 
            // txt_codigo_usuario
            // 
            this.txt_codigo_usuario.BackColor = System.Drawing.Color.White;
            this.txt_codigo_usuario.Location = new System.Drawing.Point(61, 63);
            this.txt_codigo_usuario.Name = "txt_codigo_usuario";
            this.txt_codigo_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_usuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_cliente);
            this.groupBox1.Controls.Add(this.btn_fechar);
            this.groupBox1.Controls.Add(this.Novo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 43);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(155, 9);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(67, 27);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(6, 9);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(67, 21);
            this.Novo.TabIndex = 1;
            this.Novo.Text = "Incluir";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Código Controller:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tb_codController
            // 
            this.tb_codController.BackColor = System.Drawing.Color.White;
            this.tb_codController.Location = new System.Drawing.Point(297, 13);
            this.tb_codController.MaxLength = 5;
            this.tb_codController.Name = "tb_codController";
            this.tb_codController.Size = new System.Drawing.Size(82, 20);
            this.tb_codController.TabIndex = 29;
            this.tb_codController.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_codController_KeyPress);
            // 
            // frm_cadastro_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 310);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.group_campos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_pesq);
            this.Controls.Add(this.txt_codigo_usuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frm_cadastro_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.group_campos.ResumeLayout(false);
            this.group_campos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cliente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.GroupBox group_campos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_razao;
        private System.Windows.Forms.TextBox txt_codigo_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.DataGridViewLinkColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_fantasia;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.Button btn_pesq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_filial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_frente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_retaguarda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_codController;
    }
}