namespace Prime
{
    partial class frm_EnviarEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EnviarEmail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_data);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportar para arquivo texto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(143, 78);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(75, 23);
            this.btn_exportar.TabIndex = 1;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // tb_data
            // 
            this.tb_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_data.Location = new System.Drawing.Point(126, 21);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(97, 20);
            this.tb_data.TabIndex = 3;
            // 
            // frm_ExportarTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 109);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 147);
            this.MinimumSize = new System.Drawing.Size(360, 147);
            this.Name = "frm_ExportarTxt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Atendimentos";
            this.Load += new System.EventHandler(this.frm_ExportarTxt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.DateTimePicker tb_data;
    }
}