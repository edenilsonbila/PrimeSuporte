namespace Prime
{
    partial class frm_destinatarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_destino1 = new System.Windows.Forms.TextBox();
            this.tb_destino2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_destino3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "C:";
            // 
            // tb_destino1
            // 
            this.tb_destino1.Location = new System.Drawing.Point(36, 10);
            this.tb_destino1.Name = "tb_destino1";
            this.tb_destino1.Size = new System.Drawing.Size(282, 20);
            this.tb_destino1.TabIndex = 1;
            // 
            // tb_destino2
            // 
            this.tb_destino2.Location = new System.Drawing.Point(36, 36);
            this.tb_destino2.Name = "tb_destino2";
            this.tb_destino2.Size = new System.Drawing.Size(282, 20);
            this.tb_destino2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CC:";
            // 
            // tb_destino3
            // 
            this.tb_destino3.Location = new System.Drawing.Point(36, 62);
            this.tb_destino3.Name = "tb_destino3";
            this.tb_destino3.Size = new System.Drawing.Size(282, 20);
            this.tb_destino3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CC:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_destinatarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 120);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_destino3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_destino2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_destino1);
            this.Controls.Add(this.label1);
            this.Name = "frm_destinatarios";
            this.Text = "frm_destinatarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_destino1;
        private System.Windows.Forms.TextBox tb_destino2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_destino3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}