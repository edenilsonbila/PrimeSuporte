namespace Prime
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorarAtendimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSAControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.analisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentosXUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_monitorar = new System.Windows.Forms.Button();
            this.btn_Atendimento = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_remover = new System.Windows.Forms.Button();
            this.tb_detalhes = new System.Windows.Forms.Button();
            this.tb_editar = new System.Windows.Forms.Button();
            this.btn_historico = new System.Windows.Forms.Button();
            this.dg_lista = new System.Windows.Forms.DataGridView();
            this.id_fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_atentende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_nova_fila = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Sobre = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.atendimentosToolStripMenuItem,
            this.filaToolStripMenuItem,
            this.analisesToolStripMenuItem,
            this.procedimentosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // atendimentosToolStripMenuItem
            // 
            this.atendimentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atendimentoChamadoToolStripMenuItem,
            this.monitorarAtendimentosToolStripMenuItem,
            this.registrarSAControllerToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.enviarEmailToolStripMenuItem});
            this.atendimentosToolStripMenuItem.Name = "atendimentosToolStripMenuItem";
            this.atendimentosToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.atendimentosToolStripMenuItem.Text = "Atendimentos";
            // 
            // atendimentoChamadoToolStripMenuItem
            // 
            this.atendimentoChamadoToolStripMenuItem.Name = "atendimentoChamadoToolStripMenuItem";
            this.atendimentoChamadoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.atendimentoChamadoToolStripMenuItem.Text = "Atendimento Chamado";
            this.atendimentoChamadoToolStripMenuItem.Click += new System.EventHandler(this.atendimentoChamadoToolStripMenuItem_Click);
            // 
            // monitorarAtendimentosToolStripMenuItem
            // 
            this.monitorarAtendimentosToolStripMenuItem.Name = "monitorarAtendimentosToolStripMenuItem";
            this.monitorarAtendimentosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.monitorarAtendimentosToolStripMenuItem.Text = "Monitorar Atendimentos";
            this.monitorarAtendimentosToolStripMenuItem.Click += new System.EventHandler(this.monitorarAtendimentosToolStripMenuItem_Click);
            // 
            // registrarSAControllerToolStripMenuItem
            // 
            this.registrarSAControllerToolStripMenuItem.Name = "registrarSAControllerToolStripMenuItem";
            this.registrarSAControllerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.registrarSAControllerToolStripMenuItem.Text = "Registrar S.A (Controller)";
            this.registrarSAControllerToolStripMenuItem.Click += new System.EventHandler(this.registrarSAControllerToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // enviarEmailToolStripMenuItem
            // 
            this.enviarEmailToolStripMenuItem.Name = "enviarEmailToolStripMenuItem";
            this.enviarEmailToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.enviarEmailToolStripMenuItem.Text = "Enviar E-mail";
            this.enviarEmailToolStripMenuItem.Click += new System.EventHandler(this.enviarEmailToolStripMenuItem_Click);
            // 
            // filaToolStripMenuItem
            // 
            this.filaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.filaToolStripMenuItem1});
            this.filaToolStripMenuItem.Name = "filaToolStripMenuItem";
            this.filaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filaToolStripMenuItem.Text = "Fila";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // filaToolStripMenuItem1
            // 
            this.filaToolStripMenuItem1.Name = "filaToolStripMenuItem1";
            this.filaToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.filaToolStripMenuItem1.Text = "Histórico";
            this.filaToolStripMenuItem1.Click += new System.EventHandler(this.filaToolStripMenuItem1_Click);
            // 
            // analisesToolStripMenuItem
            // 
            this.analisesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atendentesToolStripMenuItem});
            this.analisesToolStripMenuItem.Name = "analisesToolStripMenuItem";
            this.analisesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analisesToolStripMenuItem.Text = "Analises";
            this.analisesToolStripMenuItem.Click += new System.EventHandler(this.analisesToolStripMenuItem_Click);
            // 
            // atendentesToolStripMenuItem
            // 
            this.atendentesToolStripMenuItem.Name = "atendentesToolStripMenuItem";
            this.atendentesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.atendentesToolStripMenuItem.Text = "Atendentes";
            this.atendentesToolStripMenuItem.Click += new System.EventHandler(this.atendentesToolStripMenuItem_Click);
            // 
            // procedimentosToolStripMenuItem
            // 
            this.procedimentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.cadastrarToolStripMenuItem});
            this.procedimentosToolStripMenuItem.Name = "procedimentosToolStripMenuItem";
            this.procedimentosToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.procedimentosToolStripMenuItem.Text = "Procedimentos";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atendimentosXUsuáriosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // atendimentosXUsuáriosToolStripMenuItem
            // 
            this.atendimentosXUsuáriosToolStripMenuItem.Name = "atendimentosXUsuáriosToolStripMenuItem";
            this.atendimentosXUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.atendimentosXUsuáriosToolStripMenuItem.Text = "Atendimentos X Usuários";
            this.atendimentosXUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.atendimentosXUsuáriosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUserLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1362, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolUserLogado
            // 
            this.toolUserLogado.BackColor = System.Drawing.Color.White;
            this.toolUserLogado.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolUserLogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolUserLogado.LinkColor = System.Drawing.Color.White;
            this.toolUserLogado.Name = "toolUserLogado";
            this.toolUserLogado.Size = new System.Drawing.Size(67, 17);
            this.toolUserLogado.Text = "USUÁRIO: ";
            this.toolUserLogado.Click += new System.EventHandler(this.toolUserLogado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Novo Chamado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Monitorar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Atendimentos";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_monitorar
            // 
            this.btn_monitorar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_monitorar.BackgroundImage")));
            this.btn_monitorar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_monitorar.FlatAppearance.BorderSize = 0;
            this.btn_monitorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monitorar.Location = new System.Drawing.Point(132, 54);
            this.btn_monitorar.Name = "btn_monitorar";
            this.btn_monitorar.Size = new System.Drawing.Size(89, 67);
            this.btn_monitorar.TabIndex = 4;
            this.btn_monitorar.UseVisualStyleBackColor = true;
            this.btn_monitorar.Click += new System.EventHandler(this.btn_monitorar_Click);
            // 
            // btn_Atendimento
            // 
            this.btn_Atendimento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Atendimento.BackgroundImage")));
            this.btn_Atendimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Atendimento.FlatAppearance.BorderSize = 0;
            this.btn_Atendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atendimento.Location = new System.Drawing.Point(12, 54);
            this.btn_Atendimento.Name = "btn_Atendimento";
            this.btn_Atendimento.Size = new System.Drawing.Size(89, 67);
            this.btn_Atendimento.TabIndex = 3;
            this.btn_Atendimento.UseVisualStyleBackColor = true;
            this.btn_Atendimento.Click += new System.EventHandler(this.btn_Atendimento_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Prime.Properties.Resources.Prime_Suporte1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(90, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 302);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_remover);
            this.groupBox1.Controls.Add(this.tb_detalhes);
            this.groupBox1.Controls.Add(this.tb_editar);
            this.groupBox1.Controls.Add(this.btn_historico);
            this.groupBox1.Controls.Add(this.dg_lista);
            this.groupBox1.Controls.Add(this.btn_nova_fila);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(604, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 343);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILA";
            // 
            // tb_remover
            // 
            this.tb_remover.Location = new System.Drawing.Point(10, 311);
            this.tb_remover.Name = "tb_remover";
            this.tb_remover.Size = new System.Drawing.Size(75, 23);
            this.tb_remover.TabIndex = 21;
            this.tb_remover.Text = "Remover";
            this.tb_remover.UseVisualStyleBackColor = true;
            this.tb_remover.Click += new System.EventHandler(this.tb_remover_Click);
            // 
            // tb_detalhes
            // 
            this.tb_detalhes.Location = new System.Drawing.Point(91, 311);
            this.tb_detalhes.Name = "tb_detalhes";
            this.tb_detalhes.Size = new System.Drawing.Size(75, 23);
            this.tb_detalhes.TabIndex = 20;
            this.tb_detalhes.Text = "Detalhes";
            this.tb_detalhes.UseVisualStyleBackColor = true;
            this.tb_detalhes.Click += new System.EventHandler(this.tb_detalhes_Click);
            // 
            // tb_editar
            // 
            this.tb_editar.Location = new System.Drawing.Point(172, 311);
            this.tb_editar.Name = "tb_editar";
            this.tb_editar.Size = new System.Drawing.Size(75, 23);
            this.tb_editar.TabIndex = 19;
            this.tb_editar.Text = "Editar";
            this.tb_editar.UseVisualStyleBackColor = true;
            this.tb_editar.Click += new System.EventHandler(this.tb_editar_Click);
            // 
            // btn_historico
            // 
            this.btn_historico.Location = new System.Drawing.Point(253, 311);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(75, 23);
            this.btn_historico.TabIndex = 18;
            this.btn_historico.Text = "Histórico";
            this.btn_historico.UseVisualStyleBackColor = true;
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // dg_lista
            // 
            this.dg_lista.AllowUserToAddRows = false;
            this.dg_lista.AllowUserToDeleteRows = false;
            this.dg_lista.AllowUserToResizeColumns = false;
            this.dg_lista.AllowUserToResizeRows = false;
            this.dg_lista.BackgroundColor = System.Drawing.Color.White;
            this.dg_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fila,
            this.id_atentende,
            this.Usuario,
            this.Quantidade,
            this.hr,
            this.Hora2,
            this.Hora3});
            this.dg_lista.Location = new System.Drawing.Point(6, 19);
            this.dg_lista.MultiSelect = false;
            this.dg_lista.Name = "dg_lista";
            this.dg_lista.ReadOnly = true;
            this.dg_lista.RowHeadersVisible = false;
            this.dg_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_lista.Size = new System.Drawing.Size(404, 286);
            this.dg_lista.TabIndex = 17;
            this.dg_lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_lista_CellContentClick_1);
            // 
            // id_fila
            // 
            this.id_fila.DataPropertyName = "id_fila";
            this.id_fila.HeaderText = "id_fila";
            this.id_fila.Name = "id_fila";
            this.id_fila.ReadOnly = true;
            this.id_fila.Visible = false;
            this.id_fila.Width = 20;
            // 
            // id_atentende
            // 
            this.id_atentende.DataPropertyName = "contato";
            this.id_atentende.FillWeight = 173.1212F;
            this.id_atentende.HeaderText = "Contato";
            this.id_atentende.Name = "id_atentende";
            this.id_atentende.ReadOnly = true;
            this.id_atentende.Width = 90;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "telefone";
            this.Usuario.FillWeight = 119.5432F;
            this.Usuario.HeaderText = "Telefone";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 80;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "cnpj";
            this.Quantidade.FillWeight = 7.335648F;
            this.Quantidade.HeaderText = "CNPJ";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 110;
            // 
            // hr
            // 
            this.hr.DataPropertyName = "hora";
            this.hr.HeaderText = "Hora";
            this.hr.Name = "hr";
            this.hr.ReadOnly = true;
            this.hr.Width = 40;
            // 
            // Hora2
            // 
            this.Hora2.DataPropertyName = "hora2";
            this.Hora2.HeaderText = "Hora2";
            this.Hora2.Name = "Hora2";
            this.Hora2.ReadOnly = true;
            this.Hora2.Width = 40;
            // 
            // Hora3
            // 
            this.Hora3.DataPropertyName = "hora3";
            this.Hora3.HeaderText = "Hora3";
            this.Hora3.Name = "Hora3";
            this.Hora3.ReadOnly = true;
            this.Hora3.Width = 40;
            // 
            // btn_nova_fila
            // 
            this.btn_nova_fila.Location = new System.Drawing.Point(334, 311);
            this.btn_nova_fila.Name = "btn_nova_fila";
            this.btn_nova_fila.Size = new System.Drawing.Size(75, 23);
            this.btn_nova_fila.TabIndex = 16;
            this.btn_nova_fila.Text = "Novo";
            this.btn_nova_fila.UseVisualStyleBackColor = true;
            this.btn_nova_fila.Click += new System.EventHandler(this.btn_nova_fila_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(6, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fila:";
            // 
            // Sobre
            // 
            this.Sobre.AutoSize = true;
            this.Sobre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sobre.Location = new System.Drawing.Point(1316, 5);
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(35, 13);
            this.Sobre.TabIndex = 16;
            this.Sobre.Text = "Sobre";
            this.Sobre.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1362, 562);
            this.Controls.Add(this.Sobre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_monitorar);
            this.Controls.Add(this.btn_Atendimento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prime Suporte - Versão: 1.0.0 ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_principal_FormClosed);
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentoChamadoToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolUserLogado;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem monitorarAtendimentosToolStripMenuItem;
        private System.Windows.Forms.Button btn_Atendimento;
        private System.Windows.Forms.Button btn_monitorar;
        private System.Windows.Forms.ToolStripMenuItem registrarSAControllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendentesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentosXUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filaToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.DataGridView dg_lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_atentende;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn hr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora3;
        private System.Windows.Forms.Button btn_nova_fila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tb_remover;
        private System.Windows.Forms.Button tb_detalhes;
        private System.Windows.Forms.Button tb_editar;
        private System.Windows.Forms.Label Sobre;
    }
}