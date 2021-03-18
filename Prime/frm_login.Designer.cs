namespace Prime
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_usuario.Location = new System.Drawing.Point(30, 14);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(239, 26);
            this.txt_usuario.TabIndex = 21;
            this.txt_usuario.Text = "Usuário";
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_senha.Location = new System.Drawing.Point(30, 58);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(239, 26);
            this.txt_senha.TabIndex = 23;
            this.txt_senha.Text = "Senha";
            this.txt_senha.Enter += new System.EventHandler(this.txt_senha_Enter);
            this.txt_senha.Leave += new System.EventHandler(this.txt_senha_Leave);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Image = global::Prime.Properties.Resources.icone_seguranca1;
            this.btn_confirmar.Location = new System.Drawing.Point(85, 90);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(94, 30);
            this.btn_confirmar.TabIndex = 18;
            this.btn_confirmar.Text = "Acessar";
            this.btn_confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::Prime.Properties.Resources.cancel_148744_640;
            this.btn_cancelar.Location = new System.Drawing.Point(185, 90);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(84, 30);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_login
            // 
            this.AcceptButton = this.btn_confirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(297, 139);
            this.ControlBox = false;
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_login_FormClosed);
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
    }
}