namespace Prime
{
    partial class frm_NovoFila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NovoFila));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_hora = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_fantasia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_contato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_obs);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_hora);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_fantasia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_telefone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_contato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_cnpj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente:";
            // 
            // tb_hora
            // 
            this.tb_hora.Location = new System.Drawing.Point(61, 123);
            this.tb_hora.Mask = "00:00";
            this.tb_hora.Name = "tb_hora";
            this.tb_hora.Size = new System.Drawing.Size(41, 20);
            this.tb_hora.TabIndex = 5;
            this.tb_hora.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hora:";
            // 
            // tb_fantasia
            // 
            this.tb_fantasia.Location = new System.Drawing.Point(61, 97);
            this.tb_fantasia.Name = "tb_fantasia";
            this.tb_fantasia.Size = new System.Drawing.Size(116, 20);
            this.tb_fantasia.TabIndex = 4;
            this.tb_fantasia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_fantasia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fantasia:";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(61, 71);
            this.tb_telefone.Mask = "(00)0000-00000";
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(116, 20);
            this.tb_telefone.TabIndex = 3;
            this.tb_telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_telefone_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefone:";
            // 
            // tb_contato
            // 
            this.tb_contato.Location = new System.Drawing.Point(61, 45);
            this.tb_contato.Name = "tb_contato";
            this.tb_contato.Size = new System.Drawing.Size(116, 20);
            this.tb_contato.TabIndex = 2;
            this.tb_contato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contato_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Contato:";
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(61, 19);
            this.tb_cnpj.Mask = "00,000,000/0000-00";
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(116, 20);
            this.tb_cnpj.TabIndex = 1;
            this.tb_cnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_cnpj_MaskInputRejected);
            this.tb_cnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cnpj_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CNPJ:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(132, 212);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 0;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(51, 212);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Obs:";
            // 
            // tb_obs
            // 
            this.tb_obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_obs.Location = new System.Drawing.Point(61, 149);
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(116, 32);
            this.tb_obs.TabIndex = 21;
            this.tb_obs.Text = "";
            // 
            // frm_NovoFila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 247);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_NovoFila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir Cliente";
            this.Load += new System.EventHandler(this.frm_NovoFila_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_contato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tb_telefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_fantasia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tb_hora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confirmar;
        public System.Windows.Forms.MaskedTextBox tb_cnpj;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RichTextBox tb_obs;
        private System.Windows.Forms.Label label6;
    }
}