namespace Prime
{
    partial class frm_procedimentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_procedimentos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_descricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // tb_descricao
            // 
            this.tb_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_descricao.Location = new System.Drawing.Point(217, 15);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(466, 20);
            this.tb_descricao.TabIndex = 3;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(35, 15);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 1;
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dgResult
            // 
            this.dgResult.AllowUserToAddRows = false;
            this.dgResult.AllowUserToDeleteRows = false;
            this.dgResult.AllowUserToResizeColumns = false;
            this.dgResult.AllowUserToResizeRows = false;
            this.dgResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(6, 12);
            this.dgResult.MultiSelect = false;
            this.dgResult.Name = "dgResult";
            this.dgResult.ReadOnly = true;
            this.dgResult.RowHeadersVisible = false;
            this.dgResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResult.ShowEditingIcon = false;
            this.dgResult.Size = new System.Drawing.Size(684, 305);
            this.dgResult.TabIndex = 1;
            this.dgResult.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResult_CellContentDoubleClick);
            this.dgResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResult_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgResult);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 323);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados:";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(631, 400);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(550, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frm_procedimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 435);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_procedimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procedimentos";
            this.Load += new System.EventHandler(this.frm_procedimentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCancel;
    }
}