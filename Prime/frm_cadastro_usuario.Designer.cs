namespace Prime
{
    partial class frm_cadastro_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_usuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.group_campos = new System.Windows.Forms.GroupBox();
            this.btn_pesq = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_tipoU = new System.Windows.Forms.RadioButton();
            this.rb_tipoA = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.gb_email = new System.Windows.Forms.GroupBox();
            this.tb_senha_smtp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_usuario_smtp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_porta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_smtp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_tipo = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.group_campos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.gb_email.SuspendLayout();
            this.gb_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_fechar);
            this.groupBox1.Controls.Add(this.btn_incluir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 41);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(83, 10);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 25);
            this.btn_excluir.TabIndex = 1;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(164, 10);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 25);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(5, 10);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(75, 25);
            this.btn_incluir.TabIndex = 0;
            this.btn_incluir.Text = "Novo";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // group_campos
            // 
            this.group_campos.Controls.Add(this.gb_tipo);
            this.group_campos.Controls.Add(this.btn_pesq);
            this.group_campos.Controls.Add(this.dgv_usuarios);
            this.group_campos.Controls.Add(this.label3);
            this.group_campos.Controls.Add(this.tb_senha);
            this.group_campos.Controls.Add(this.label2);
            this.group_campos.Controls.Add(this.tb_usuario);
            this.group_campos.Controls.Add(this.tb_codigo);
            this.group_campos.Controls.Add(this.label1);
            this.group_campos.Location = new System.Drawing.Point(12, 59);
            this.group_campos.Name = "group_campos";
            this.group_campos.Size = new System.Drawing.Size(330, 127);
            this.group_campos.TabIndex = 2;
            this.group_campos.TabStop = false;
            // 
            // btn_pesq
            // 
            this.btn_pesq.Image = global::Prime.Properties.Resources.magnifying_glass_189254_640;
            this.btn_pesq.Location = new System.Drawing.Point(164, 10);
            this.btn_pesq.Name = "btn_pesq";
            this.btn_pesq.Size = new System.Drawing.Size(24, 23);
            this.btn_pesq.TabIndex = 5;
            this.btn_pesq.UseVisualStyleBackColor = true;
            this.btn_pesq.Click += new System.EventHandler(this.btn_pesq_Click);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Tipo,
            this.data_cadastro});
            this.dgv_usuarios.Location = new System.Drawing.Point(277, 108);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.Size = new System.Drawing.Size(21, 13);
            this.dgv_usuarios.TabIndex = 20;
            this.dgv_usuarios.Visible = false;
            this.dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.DataPropertyName = "id_usuario";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "ds_usuario";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.DataPropertyName = "tp_usuario";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // data_cadastro
            // 
            this.data_cadastro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_cadastro.DataPropertyName = "dt_cadastro";
            this.data_cadastro.HeaderText = "Cadastro";
            this.data_cadastro.Name = "data_cadastro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo:";
            // 
            // rb_tipoU
            // 
            this.rb_tipoU.AutoSize = true;
            this.rb_tipoU.Location = new System.Drawing.Point(133, 9);
            this.rb_tipoU.Name = "rb_tipoU";
            this.rb_tipoU.Size = new System.Drawing.Size(61, 17);
            this.rb_tipoU.TabIndex = 4;
            this.rb_tipoU.Text = "Usuário";
            this.rb_tipoU.UseVisualStyleBackColor = true;
            // 
            // rb_tipoA
            // 
            this.rb_tipoA.AutoSize = true;
            this.rb_tipoA.Checked = true;
            this.rb_tipoA.Location = new System.Drawing.Point(40, 9);
            this.rb_tipoA.Name = "rb_tipoA";
            this.rb_tipoA.Size = new System.Drawing.Size(88, 17);
            this.rb_tipoA.TabIndex = 3;
            this.rb_tipoA.TabStop = true;
            this.rb_tipoA.Text = "Administrador";
            this.rb_tipoA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
            // 
            // tb_senha
            // 
            this.tb_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_senha.Location = new System.Drawing.Point(58, 70);
            this.tb_senha.MaxLength = 50;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(256, 20);
            this.tb_senha.TabIndex = 2;
            this.tb_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário:";
            // 
            // tb_usuario
            // 
            this.tb_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_usuario.Location = new System.Drawing.Point(58, 41);
            this.tb_usuario.MaxLength = 50;
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(256, 20);
            this.tb_usuario.TabIndex = 1;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(58, 13);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 20);
            this.tb_codigo.TabIndex = 0;
            this.tb_codigo.TextChanged += new System.EventHandler(this.txt_codigo_usuario_TextChanged);
            this.tb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_usuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(258, 314);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(84, 27);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Enabled = false;
            this.btn_confirmar.Location = new System.Drawing.Point(168, 314);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(84, 27);
            this.btn_confirmar.TabIndex = 0;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // gb_email
            // 
            this.gb_email.Controls.Add(this.tb_senha_smtp);
            this.gb_email.Controls.Add(this.label7);
            this.gb_email.Controls.Add(this.tb_usuario_smtp);
            this.gb_email.Controls.Add(this.label8);
            this.gb_email.Controls.Add(this.tb_porta);
            this.gb_email.Controls.Add(this.label6);
            this.gb_email.Controls.Add(this.tb_smtp);
            this.gb_email.Controls.Add(this.label5);
            this.gb_email.Enabled = false;
            this.gb_email.Location = new System.Drawing.Point(12, 192);
            this.gb_email.Name = "gb_email";
            this.gb_email.Size = new System.Drawing.Size(330, 116);
            this.gb_email.TabIndex = 21;
            this.gb_email.TabStop = false;
            this.gb_email.Text = "Configurações de E-mail";
            // 
            // tb_senha_smtp
            // 
            this.tb_senha_smtp.Location = new System.Drawing.Point(57, 76);
            this.tb_senha_smtp.MaxLength = 45;
            this.tb_senha_smtp.Name = "tb_senha_smtp";
            this.tb_senha_smtp.PasswordChar = '*';
            this.tb_senha_smtp.Size = new System.Drawing.Size(165, 20);
            this.tb_senha_smtp.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Senha:";
            // 
            // tb_usuario_smtp
            // 
            this.tb_usuario_smtp.Location = new System.Drawing.Point(57, 49);
            this.tb_usuario_smtp.MaxLength = 45;
            this.tb_usuario_smtp.Name = "tb_usuario_smtp";
            this.tb_usuario_smtp.Size = new System.Drawing.Size(165, 20);
            this.tb_usuario_smtp.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Usuário:";
            // 
            // tb_porta
            // 
            this.tb_porta.Location = new System.Drawing.Point(277, 22);
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.Size = new System.Drawing.Size(37, 20);
            this.tb_porta.TabIndex = 3;
            this.tb_porta.Text = "0";
            this.tb_porta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tb_porta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_porta_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Porta:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_smtp
            // 
            this.tb_smtp.Location = new System.Drawing.Point(58, 22);
            this.tb_smtp.Name = "tb_smtp";
            this.tb_smtp.Size = new System.Drawing.Size(163, 20);
            this.tb_smtp.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "SMTP:";
            // 
            // gb_tipo
            // 
            this.gb_tipo.Controls.Add(this.label4);
            this.gb_tipo.Controls.Add(this.rb_tipoA);
            this.gb_tipo.Controls.Add(this.rb_tipoU);
            this.gb_tipo.Location = new System.Drawing.Point(17, 90);
            this.gb_tipo.Name = "gb_tipo";
            this.gb_tipo.Size = new System.Drawing.Size(200, 29);
            this.gb_tipo.TabIndex = 21;
            this.gb_tipo.TabStop = false;
            // 
            // frm_cadastro_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 348);
            this.Controls.Add(this.gb_email);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.group_campos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(371, 386);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(371, 386);
            this.Name = "frm_cadastro_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frm_cadastro_usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.group_campos.ResumeLayout(false);
            this.group_campos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.gb_email.ResumeLayout(false);
            this.gb_email.PerformLayout();
            this.gb_tipo.ResumeLayout(false);
            this.gb_tipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.GroupBox group_campos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_tipoU;
        private System.Windows.Forms.RadioButton rb_tipoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.DataGridViewLinkColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_cadastro;
        private System.Windows.Forms.GroupBox gb_email;
        private System.Windows.Forms.TextBox tb_porta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_smtp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_senha_smtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_usuario_smtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_pesq;
        private System.Windows.Forms.GroupBox gb_tipo;
    }
}