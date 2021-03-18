namespace Prime
{
    partial class frm_CadProc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadProc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_solucao = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_dt = new System.Windows.Forms.MaskedTextBox();
            this.tb_aprovado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_revisao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sistema = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.tb_descricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar";
            // 
            // button3
            // 
            this.button3.Image = global::Prime.Properties.Resources.magnifying_glass_189254_640;
            this.button3.Location = new System.Drawing.Point(140, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 10;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tb_descricao
            // 
            this.tb_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_descricao.Enabled = false;
            this.tb_descricao.Location = new System.Drawing.Point(261, 17);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(506, 20);
            this.tb_descricao.TabIndex = 1;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição do Erro:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(34, 17);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 0;
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_solucao);
            this.groupBox2.Location = new System.Drawing.Point(13, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 316);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descrição da Solução:";
            // 
            // tb_solucao
            // 
            this.tb_solucao.Enabled = false;
            this.tb_solucao.Location = new System.Drawing.Point(10, 20);
            this.tb_solucao.Name = "tb_solucao";
            this.tb_solucao.Size = new System.Drawing.Size(757, 290);
            this.tb_solucao.TabIndex = 0;
            this.tb_solucao.Text = "";
            this.tb_solucao.TextChanged += new System.EventHandler(this.tb_solucao_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_dt);
            this.groupBox3.Controls.Add(this.tb_aprovado);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_revisao);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_sistema);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_autor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 417);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 52);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações Adicionais";
            // 
            // tb_dt
            // 
            this.tb_dt.Enabled = false;
            this.tb_dt.Location = new System.Drawing.Point(343, 19);
            this.tb_dt.Mask = "00/00/0000";
            this.tb_dt.Name = "tb_dt";
            this.tb_dt.Size = new System.Drawing.Size(73, 20);
            this.tb_dt.TabIndex = 2;
            this.tb_dt.ValidatingType = typeof(System.DateTime);
            this.tb_dt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_dt_MaskInputRejected);
            // 
            // tb_aprovado
            // 
            this.tb_aprovado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_aprovado.Enabled = false;
            this.tb_aprovado.Location = new System.Drawing.Point(658, 19);
            this.tb_aprovado.Name = "tb_aprovado";
            this.tb_aprovado.Size = new System.Drawing.Size(110, 20);
            this.tb_aprovado.TabIndex = 4;
            this.tb_aprovado.TextChanged += new System.EventHandler(this.tb_aprovado_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Aprovado:";
            // 
            // tb_revisao
            // 
            this.tb_revisao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_revisao.Enabled = false;
            this.tb_revisao.Location = new System.Drawing.Point(480, 19);
            this.tb_revisao.Name = "tb_revisao";
            this.tb_revisao.Size = new System.Drawing.Size(110, 20);
            this.tb_revisao.TabIndex = 3;
            this.tb_revisao.TextChanged += new System.EventHandler(this.tb_revisao_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Revisão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data:";
            // 
            // tb_sistema
            // 
            this.tb_sistema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_sistema.Enabled = false;
            this.tb_sistema.Location = new System.Drawing.Point(198, 19);
            this.tb_sistema.Name = "tb_sistema";
            this.tb_sistema.Size = new System.Drawing.Size(100, 20);
            this.tb_sistema.TabIndex = 1;
            this.tb_sistema.TextChanged += new System.EventHandler(this.tb_sistema_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sistema:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_autor
            // 
            this.tb_autor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_autor.Enabled = false;
            this.tb_autor.Location = new System.Drawing.Point(39, 19);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(100, 20);
            this.tb_autor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor:";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(711, 475);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(13, 8);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(49, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Enabled = false;
            this.btn_excluir.Location = new System.Drawing.Point(68, 8);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(55, 23);
            this.btn_excluir.TabIndex = 1;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(129, 8);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(61, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_CadProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 510);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CadProc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Procedimentos Técnicos";
            this.Load += new System.EventHandler(this.frm_CadProc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_sistema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tb_solucao;
        private System.Windows.Forms.TextBox tb_revisao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_aprovado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.MaskedTextBox tb_dt;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_cancelar;
    }
}