namespace Prime
{
    partial class frm_monitoramento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_monitoramento));
            this.group_filtros = new System.Windows.Forms.GroupBox();
            this.cmb_filtrar_cliente = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.cmb_filtrar_filial = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_filial = new System.Windows.Forms.ComboBox();
            this.cmb_filtrar_sistema = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_sistema = new System.Windows.Forms.ComboBox();
            this.cmb_filtrar_status = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_filtrar_usuario = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_usuario = new System.Windows.Forms.ComboBox();
            this.date_time_fim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date_time_iniciao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_pesquisa = new System.Windows.Forms.DataGridView();
            this.codigo_Atendimento = new System.Windows.Forms.DataGridViewLinkColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataabertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_listar_todos = new System.Windows.Forms.Button();
            this.group_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // group_filtros
            // 
            this.group_filtros.Controls.Add(this.cmb_filtrar_cliente);
            this.group_filtros.Controls.Add(this.label7);
            this.group_filtros.Controls.Add(this.cmb_cliente);
            this.group_filtros.Controls.Add(this.cmb_filtrar_filial);
            this.group_filtros.Controls.Add(this.label6);
            this.group_filtros.Controls.Add(this.cmb_filial);
            this.group_filtros.Controls.Add(this.cmb_filtrar_sistema);
            this.group_filtros.Controls.Add(this.label5);
            this.group_filtros.Controls.Add(this.cmb_sistema);
            this.group_filtros.Controls.Add(this.cmb_filtrar_status);
            this.group_filtros.Controls.Add(this.label4);
            this.group_filtros.Controls.Add(this.cmb_status);
            this.group_filtros.Controls.Add(this.cmb_filtrar_usuario);
            this.group_filtros.Controls.Add(this.label3);
            this.group_filtros.Controls.Add(this.cmb_usuario);
            this.group_filtros.Controls.Add(this.date_time_fim);
            this.group_filtros.Controls.Add(this.label2);
            this.group_filtros.Controls.Add(this.date_time_iniciao);
            this.group_filtros.Controls.Add(this.label1);
            this.group_filtros.Location = new System.Drawing.Point(12, 4);
            this.group_filtros.Name = "group_filtros";
            this.group_filtros.Size = new System.Drawing.Size(900, 169);
            this.group_filtros.TabIndex = 0;
            this.group_filtros.TabStop = false;
            this.group_filtros.Text = "Filtros";
            // 
            // cmb_filtrar_cliente
            // 
            this.cmb_filtrar_cliente.AutoSize = true;
            this.cmb_filtrar_cliente.Location = new System.Drawing.Point(802, 83);
            this.cmb_filtrar_cliente.Name = "cmb_filtrar_cliente";
            this.cmb_filtrar_cliente.Size = new System.Drawing.Size(51, 17);
            this.cmb_filtrar_cliente.TabIndex = 19;
            this.cmb_filtrar_cliente.Text = "Filtrar";
            this.cmb_filtrar_cliente.UseVisualStyleBackColor = true;
            this.cmb_filtrar_cliente.CheckedChanged += new System.EventHandler(this.cmb_filial_cliente_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cliente";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cliente.Enabled = false;
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(525, 83);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(271, 21);
            this.cmb_cliente.TabIndex = 17;
            // 
            // cmb_filtrar_filial
            // 
            this.cmb_filtrar_filial.AutoSize = true;
            this.cmb_filtrar_filial.Location = new System.Drawing.Point(802, 42);
            this.cmb_filtrar_filial.Name = "cmb_filtrar_filial";
            this.cmb_filtrar_filial.Size = new System.Drawing.Size(51, 17);
            this.cmb_filtrar_filial.TabIndex = 16;
            this.cmb_filtrar_filial.Text = "Filtrar";
            this.cmb_filtrar_filial.UseVisualStyleBackColor = true;
            this.cmb_filtrar_filial.CheckedChanged += new System.EventHandler(this.cmb_filtrar_filial_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Filial";
            // 
            // cmb_filial
            // 
            this.cmb_filial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filial.Enabled = false;
            this.cmb_filial.FormattingEnabled = true;
            this.cmb_filial.Location = new System.Drawing.Point(525, 40);
            this.cmb_filial.Name = "cmb_filial";
            this.cmb_filial.Size = new System.Drawing.Size(271, 21);
            this.cmb_filial.TabIndex = 14;
            // 
            // cmb_filtrar_sistema
            // 
            this.cmb_filtrar_sistema.AutoSize = true;
            this.cmb_filtrar_sistema.Location = new System.Drawing.Point(802, 131);
            this.cmb_filtrar_sistema.Name = "cmb_filtrar_sistema";
            this.cmb_filtrar_sistema.Size = new System.Drawing.Size(51, 17);
            this.cmb_filtrar_sistema.TabIndex = 13;
            this.cmb_filtrar_sistema.Text = "Filtrar";
            this.cmb_filtrar_sistema.UseVisualStyleBackColor = true;
            this.cmb_filtrar_sistema.CheckedChanged += new System.EventHandler(this.cmb_filtrar_sistema_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sistema";
            // 
            // cmb_sistema
            // 
            this.cmb_sistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sistema.Enabled = false;
            this.cmb_sistema.FormattingEnabled = true;
            this.cmb_sistema.Location = new System.Drawing.Point(525, 129);
            this.cmb_sistema.Name = "cmb_sistema";
            this.cmb_sistema.Size = new System.Drawing.Size(271, 21);
            this.cmb_sistema.TabIndex = 11;
            // 
            // cmb_filtrar_status
            // 
            this.cmb_filtrar_status.AutoSize = true;
            this.cmb_filtrar_status.Location = new System.Drawing.Point(382, 133);
            this.cmb_filtrar_status.Name = "cmb_filtrar_status";
            this.cmb_filtrar_status.Size = new System.Drawing.Size(51, 17);
            this.cmb_filtrar_status.TabIndex = 10;
            this.cmb_filtrar_status.Text = "Filtrar";
            this.cmb_filtrar_status.UseVisualStyleBackColor = true;
            this.cmb_filtrar_status.CheckedChanged += new System.EventHandler(this.cmb_filtrar_status_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.Enabled = false;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Em Atendimento",
            "Aberto",
            "Finalizado",
            "Gerar S.A"});
            this.cmb_status.Location = new System.Drawing.Point(89, 129);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(271, 21);
            this.cmb_status.TabIndex = 8;
            // 
            // cmb_filtrar_usuario
            // 
            this.cmb_filtrar_usuario.AutoSize = true;
            this.cmb_filtrar_usuario.Location = new System.Drawing.Point(382, 90);
            this.cmb_filtrar_usuario.Name = "cmb_filtrar_usuario";
            this.cmb_filtrar_usuario.Size = new System.Drawing.Size(51, 17);
            this.cmb_filtrar_usuario.TabIndex = 7;
            this.cmb_filtrar_usuario.Text = "Filtrar";
            this.cmb_filtrar_usuario.UseVisualStyleBackColor = true;
            this.cmb_filtrar_usuario.CheckedChanged += new System.EventHandler(this.cmb_filtrar_usuario_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuário";
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_usuario.Enabled = false;
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Location = new System.Drawing.Point(89, 86);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Size = new System.Drawing.Size(271, 21);
            this.cmb_usuario.TabIndex = 5;
            // 
            // date_time_fim
            // 
            this.date_time_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_time_fim.Location = new System.Drawing.Point(263, 44);
            this.date_time_fim.Name = "date_time_fim";
            this.date_time_fim.Size = new System.Drawing.Size(97, 20);
            this.date_time_fim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final";
            // 
            // date_time_iniciao
            // 
            this.date_time_iniciao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_time_iniciao.Location = new System.Drawing.Point(89, 44);
            this.date_time_iniciao.Name = "date_time_iniciao";
            this.date_time_iniciao.Size = new System.Drawing.Size(97, 20);
            this.date_time_iniciao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial";
            // 
            // dgv_pesquisa
            // 
            this.dgv_pesquisa.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_Atendimento,
            this.user,
            this.status,
            this.Filial,
            this.Cliente,
            this.Sistema,
            this.dataabertura,
            this.DataFechamento});
            this.dgv_pesquisa.Location = new System.Drawing.Point(12, 179);
            this.dgv_pesquisa.Name = "dgv_pesquisa";
            this.dgv_pesquisa.RowHeadersVisible = false;
            this.dgv_pesquisa.Size = new System.Drawing.Size(900, 215);
            this.dgv_pesquisa.TabIndex = 1;
            this.dgv_pesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pesquisa_CellContentClick);
            // 
            // codigo_Atendimento
            // 
            this.codigo_Atendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo_Atendimento.DataPropertyName = "id_atendimento";
            this.codigo_Atendimento.HeaderText = "Atendimento";
            this.codigo_Atendimento.Name = "codigo_Atendimento";
            this.codigo_Atendimento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codigo_Atendimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // user
            // 
            this.user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user.DataPropertyName = "user";
            this.user.HeaderText = "Usuario";
            this.user.Name = "user";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // Filial
            // 
            this.Filial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Filial.DataPropertyName = "filial";
            this.Filial.HeaderText = "Filial";
            this.Filial.Name = "Filial";
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Sistema
            // 
            this.Sistema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sistema.DataPropertyName = "sistema";
            this.Sistema.HeaderText = "Sistema";
            this.Sistema.Name = "Sistema";
            // 
            // dataabertura
            // 
            this.dataabertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataabertura.DataPropertyName = "abertura";
            this.dataabertura.HeaderText = "Data Abertura";
            this.dataabertura.Name = "dataabertura";
            // 
            // DataFechamento
            // 
            this.DataFechamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataFechamento.DataPropertyName = "fechamento";
            this.DataFechamento.HeaderText = "Data Fechamento";
            this.DataFechamento.Name = "DataFechamento";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(795, 400);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(117, 42);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(672, 400);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(117, 42);
            this.btn_pesquisar.TabIndex = 21;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_listar_todos
            // 
            this.btn_listar_todos.Location = new System.Drawing.Point(12, 400);
            this.btn_listar_todos.Name = "btn_listar_todos";
            this.btn_listar_todos.Size = new System.Drawing.Size(117, 42);
            this.btn_listar_todos.TabIndex = 22;
            this.btn_listar_todos.Text = "Listar Todos";
            this.btn_listar_todos.UseVisualStyleBackColor = true;
            this.btn_listar_todos.Click += new System.EventHandler(this.btn_listar_todos_Click);
            // 
            // frm_monitoramento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.btn_listar_todos);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.dgv_pesquisa);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.group_filtros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_monitoramento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoramento de Chamados";
            this.Load += new System.EventHandler(this.frm_monitoramento_Load);
            this.group_filtros.ResumeLayout(false);
            this.group_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_filtros;
        private System.Windows.Forms.DateTimePicker date_time_fim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_time_iniciao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_pesquisa;
        private System.Windows.Forms.CheckBox cmb_filtrar_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_usuario;
        private System.Windows.Forms.CheckBox cmb_filtrar_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.CheckBox cmb_filtrar_filial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_filial;
        private System.Windows.Forms.CheckBox cmb_filtrar_sistema;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_sistema;
        private System.Windows.Forms.CheckBox cmb_filtrar_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_listar_todos;
        private System.Windows.Forms.DataGridViewLinkColumn codigo_Atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataabertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFechamento;
    }
}