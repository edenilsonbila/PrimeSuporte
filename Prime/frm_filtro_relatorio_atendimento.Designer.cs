namespace Prime
{
    partial class frm_filtro_relatorio_atendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_filtro_relatorio_atendimento));
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(104, 62);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 0;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial";
            // 
            // dtp_inicial
            // 
            this.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicial.Location = new System.Drawing.Point(79, 6);
            this.dtp_inicial.Name = "dtp_inicial";
            this.dtp_inicial.Size = new System.Drawing.Size(100, 20);
            this.dtp_inicial.TabIndex = 2;
            // 
            // dtp_final
            // 
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(79, 36);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(100, 20);
            this.dtp_final.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(16, 62);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_filtro_relatorio_atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 97);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dtp_final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_inicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_imprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_filtro_relatorio_atendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelar;
    }
}