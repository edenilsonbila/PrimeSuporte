namespace Prime
{
    partial class frm_registrar_SA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registrar_SA));
            this.gp_sa = new System.Windows.Forms.GroupBox();
            this.txt_sa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero_atendimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_atendimento = new System.Windows.Forms.DataGridView();
            this.nAtendimento = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_registrar_sa = new System.Windows.Forms.Button();
            this.btn_listar_atendimentos = new System.Windows.Forms.Button();
            this.gp_sa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_sa
            // 
            this.gp_sa.Controls.Add(this.txt_sa);
            this.gp_sa.Controls.Add(this.label2);
            this.gp_sa.Controls.Add(this.txt_numero_atendimento);
            this.gp_sa.Controls.Add(this.label1);
            this.gp_sa.Enabled = false;
            this.gp_sa.Location = new System.Drawing.Point(13, 13);
            this.gp_sa.Name = "gp_sa";
            this.gp_sa.Size = new System.Drawing.Size(581, 50);
            this.gp_sa.TabIndex = 0;
            this.gp_sa.TabStop = false;
            // 
            // txt_sa
            // 
            this.txt_sa.Location = new System.Drawing.Point(306, 13);
            this.txt_sa.Name = "txt_sa";
            this.txt_sa.Size = new System.Drawing.Size(145, 20);
            this.txt_sa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nº   S.A";
            // 
            // txt_numero_atendimento
            // 
            this.txt_numero_atendimento.Location = new System.Drawing.Point(93, 13);
            this.txt_numero_atendimento.Name = "txt_numero_atendimento";
            this.txt_numero_atendimento.Size = new System.Drawing.Size(113, 20);
            this.txt_numero_atendimento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Atendimento";
            // 
            // dgv_atendimento
            // 
            this.dgv_atendimento.BackgroundColor = System.Drawing.Color.White;
            this.dgv_atendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_atendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAtendimento,
            this.Status,
            this.Sa});
            this.dgv_atendimento.Location = new System.Drawing.Point(13, 98);
            this.dgv_atendimento.Name = "dgv_atendimento";
            this.dgv_atendimento.RowHeadersVisible = false;
            this.dgv_atendimento.Size = new System.Drawing.Size(581, 170);
            this.dgv_atendimento.TabIndex = 1;
            this.dgv_atendimento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atendimento_CellContentClick);
            // 
            // nAtendimento
            // 
            this.nAtendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAtendimento.DataPropertyName = "id_atendimento";
            this.nAtendimento.HeaderText = "Nº Atendimento";
            this.nAtendimento.Name = "nAtendimento";
            this.nAtendimento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nAtendimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "ds_status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Sa
            // 
            this.Sa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sa.DataPropertyName = "nu_sa";
            this.Sa.HeaderText = "S.A";
            this.Sa.Name = "Sa";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(435, 69);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(159, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_registrar_sa
            // 
            this.btn_registrar_sa.Enabled = false;
            this.btn_registrar_sa.Location = new System.Drawing.Point(221, 69);
            this.btn_registrar_sa.Name = "btn_registrar_sa";
            this.btn_registrar_sa.Size = new System.Drawing.Size(159, 23);
            this.btn_registrar_sa.TabIndex = 3;
            this.btn_registrar_sa.Text = "Registrar S.A";
            this.btn_registrar_sa.UseVisualStyleBackColor = true;
            this.btn_registrar_sa.Click += new System.EventHandler(this.btn_registrar_sa_Click);
            // 
            // btn_listar_atendimentos
            // 
            this.btn_listar_atendimentos.Location = new System.Drawing.Point(13, 69);
            this.btn_listar_atendimentos.Name = "btn_listar_atendimentos";
            this.btn_listar_atendimentos.Size = new System.Drawing.Size(159, 23);
            this.btn_listar_atendimentos.TabIndex = 4;
            this.btn_listar_atendimentos.Text = "Listar Atendimentos";
            this.btn_listar_atendimentos.UseVisualStyleBackColor = true;
            this.btn_listar_atendimentos.Click += new System.EventHandler(this.btn_listar_atendimentos_Click);
            // 
            // frm_registrar_SA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 314);
            this.Controls.Add(this.btn_listar_atendimentos);
            this.Controls.Add(this.btn_registrar_sa);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dgv_atendimento);
            this.Controls.Add(this.gp_sa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_registrar_SA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar S.A";
            this.Load += new System.EventHandler(this.frm_registrar_SA_Load);
            this.gp_sa.ResumeLayout(false);
            this.gp_sa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atendimento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_sa;
        private System.Windows.Forms.TextBox txt_sa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numero_atendimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_atendimento;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_registrar_sa;
        private System.Windows.Forms.Button btn_listar_atendimentos;
        private System.Windows.Forms.DataGridViewLinkColumn nAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sa;
    }
}