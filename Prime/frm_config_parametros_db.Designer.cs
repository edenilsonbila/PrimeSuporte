namespace Prime
{
    partial class frm_config_parametros_db
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_endereco_banco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_senha_banco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuario_banco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome_banco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_testar = new System.Windows.Forms.Button();
            this.btn_confirma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_endereco_banco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_senha_banco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_usuario_banco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nome_banco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexão";
            // 
            // txt_endereco_banco
            // 
            this.txt_endereco_banco.Location = new System.Drawing.Point(65, 157);
            this.txt_endereco_banco.Name = "txt_endereco_banco";
            this.txt_endereco_banco.Size = new System.Drawing.Size(145, 20);
            this.txt_endereco_banco.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço:";
            // 
            // txt_senha_banco
            // 
            this.txt_senha_banco.Location = new System.Drawing.Point(65, 114);
            this.txt_senha_banco.Name = "txt_senha_banco";
            this.txt_senha_banco.Size = new System.Drawing.Size(145, 20);
            this.txt_senha_banco.TabIndex = 5;
            this.txt_senha_banco.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // txt_usuario_banco
            // 
            this.txt_usuario_banco.Location = new System.Drawing.Point(65, 72);
            this.txt_usuario_banco.Name = "txt_usuario_banco";
            this.txt_usuario_banco.Size = new System.Drawing.Size(145, 20);
            this.txt_usuario_banco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário:";
            // 
            // txt_nome_banco
            // 
            this.txt_nome_banco.Location = new System.Drawing.Point(65, 32);
            this.txt_nome_banco.Name = "txt_nome_banco";
            this.txt_nome_banco.Size = new System.Drawing.Size(145, 20);
            this.txt_nome_banco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(12, 223);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(69, 28);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_testar
            // 
            this.btn_testar.Location = new System.Drawing.Point(87, 223);
            this.btn_testar.Name = "btn_testar";
            this.btn_testar.Size = new System.Drawing.Size(69, 28);
            this.btn_testar.TabIndex = 3;
            this.btn_testar.Text = "Testar";
            this.btn_testar.UseVisualStyleBackColor = true;
            this.btn_testar.Click += new System.EventHandler(this.btn_testar_Click);
            // 
            // btn_confirma
            // 
            this.btn_confirma.Location = new System.Drawing.Point(162, 223);
            this.btn_confirma.Name = "btn_confirma";
            this.btn_confirma.Size = new System.Drawing.Size(69, 28);
            this.btn_confirma.TabIndex = 4;
            this.btn_confirma.Text = "Confirma";
            this.btn_confirma.UseVisualStyleBackColor = true;
            this.btn_confirma.Click += new System.EventHandler(this.btn_confirma_Click);
            // 
            // frm_config_parametros_db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 263);
            this.ControlBox = false;
            this.Controls.Add(this.btn_confirma);
            this.Controls.Add(this.btn_testar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_config_parametros_db";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros";
            this.Load += new System.EventHandler(this.frm_config_parametros_db_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nome_banco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_endereco_banco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_senha_banco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usuario_banco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_testar;
        private System.Windows.Forms.Button btn_confirma;
    }
}