namespace Prime
{
    partial class frm_Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Email));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_cc1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_para = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.DateTimePicker();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_cc1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_cc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_para);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_data);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // tb_cc1
            // 
            this.tb_cc1.Location = new System.Drawing.Point(45, 105);
            this.tb_cc1.Name = "tb_cc1";
            this.tb_cc1.Size = new System.Drawing.Size(224, 20);
            this.tb_cc1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cc:";
            // 
            // tb_cc
            // 
            this.tb_cc.Location = new System.Drawing.Point(45, 79);
            this.tb_cc.Name = "tb_cc";
            this.tb_cc.Size = new System.Drawing.Size(224, 20);
            this.tb_cc.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cc:";
            // 
            // tb_para
            // 
            this.tb_para.Location = new System.Drawing.Point(45, 53);
            this.tb_para.Name = "tb_para";
            this.tb_para.Size = new System.Drawing.Size(224, 20);
            this.tb_para.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Para:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data:";
            // 
            // tb_data
            // 
            this.tb_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_data.Location = new System.Drawing.Point(45, 19);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(97, 20);
            this.tb_data.TabIndex = 4;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(213, 172);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 207);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(316, 245);
            this.MinimumSize = new System.Drawing.Size(316, 245);
            this.Name = "frm_Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar atendimentos por e-mail";
            this.Load += new System.EventHandler(this.frm_Email_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker tb_data;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox tb_cc1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_para;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}