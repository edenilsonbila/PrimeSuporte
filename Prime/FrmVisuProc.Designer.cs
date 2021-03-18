namespace Prime
{
    partial class FrmVisuProc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisuProc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_visualizacao = new System.Windows.Forms.RichTextBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_visualizacao);
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 492);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualização:";
            // 
            // tb_visualizacao
            // 
            this.tb_visualizacao.BackColor = System.Drawing.Color.White;
            this.tb_visualizacao.Location = new System.Drawing.Point(7, 19);
            this.tb_visualizacao.Name = "tb_visualizacao";
            this.tb_visualizacao.ReadOnly = true;
            this.tb_visualizacao.Size = new System.Drawing.Size(960, 467);
            this.tb_visualizacao.TabIndex = 0;
            this.tb_visualizacao.Text = "";
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
            this.groupBox3.Location = new System.Drawing.Point(8, 530);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 52);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações Adicionais";
            // 
            // tb_dt
            // 
            this.tb_dt.BackColor = System.Drawing.Color.White;
            this.tb_dt.Enabled = false;
            this.tb_dt.Location = new System.Drawing.Point(343, 19);
            this.tb_dt.Mask = "00/00/0000";
            this.tb_dt.Name = "tb_dt";
            this.tb_dt.ReadOnly = true;
            this.tb_dt.Size = new System.Drawing.Size(73, 20);
            this.tb_dt.TabIndex = 2;
            this.tb_dt.ValidatingType = typeof(System.DateTime);
            // 
            // tb_aprovado
            // 
            this.tb_aprovado.BackColor = System.Drawing.Color.White;
            this.tb_aprovado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_aprovado.Enabled = false;
            this.tb_aprovado.Location = new System.Drawing.Point(658, 19);
            this.tb_aprovado.Name = "tb_aprovado";
            this.tb_aprovado.ReadOnly = true;
            this.tb_aprovado.Size = new System.Drawing.Size(110, 20);
            this.tb_aprovado.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Aprovação:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tb_revisao
            // 
            this.tb_revisao.BackColor = System.Drawing.Color.White;
            this.tb_revisao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_revisao.Enabled = false;
            this.tb_revisao.Location = new System.Drawing.Point(480, 19);
            this.tb_revisao.Name = "tb_revisao";
            this.tb_revisao.ReadOnly = true;
            this.tb_revisao.Size = new System.Drawing.Size(110, 20);
            this.tb_revisao.TabIndex = 3;
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
            this.tb_sistema.BackColor = System.Drawing.Color.White;
            this.tb_sistema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_sistema.Enabled = false;
            this.tb_sistema.Location = new System.Drawing.Point(198, 19);
            this.tb_sistema.Name = "tb_sistema";
            this.tb_sistema.ReadOnly = true;
            this.tb_sistema.Size = new System.Drawing.Size(100, 20);
            this.tb_sistema.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sistema:";
            // 
            // tb_autor
            // 
            this.tb_autor.BackColor = System.Drawing.Color.White;
            this.tb_autor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_autor.Enabled = false;
            this.tb_autor.Location = new System.Drawing.Point(39, 19);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.ReadOnly = true;
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
            // button2
            // 
            this.button2.BackgroundImage = global::Prime.Properties.Resources.Untitled_1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(949, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Prime.Properties.Resources.teste;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(911, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "PROBLEMA:";
            // 
            // tb_descricao
            // 
            this.tb_descricao.BackColor = System.Drawing.Color.White;
            this.tb_descricao.Location = new System.Drawing.Point(244, 8);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.ReadOnly = true;
            this.tb_descricao.Size = new System.Drawing.Size(661, 20);
            this.tb_descricao.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.White;
            this.tb_id.Location = new System.Drawing.Point(41, 8);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(122, 20);
            this.tb_id.TabIndex = 12;
            // 
            // FrmVisuProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 594);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVisuProc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Procedimento";
            this.Load += new System.EventHandler(this.FrmVisuProc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox tb_dt;
        private System.Windows.Forms.TextBox tb_aprovado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_revisao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_sistema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox tb_visualizacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
    }
}