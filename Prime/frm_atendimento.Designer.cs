namespace Prime
{
    partial class frm_atendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_atendimento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_historico = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.group_campos = new System.Windows.Forms.GroupBox();
            this.tb_id_filial = new System.Windows.Forms.TextBox();
            this.tb_id_frente = new System.Windows.Forms.TextBox();
            this.tb_id_retag = new System.Windows.Forms.TextBox();
            this.tb_filial = new System.Windows.Forms.TextBox();
            this.tb_frente = new System.Windows.Forms.TextBox();
            this.tb_retag = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_sa = new System.Windows.Forms.TextBox();
            this.lbl_sa = new System.Windows.Forms.Label();
            this.cb_frente = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_fantasia = new System.Windows.Forms.TextBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cadastrar_usuario = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_observacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_solucao = new System.Windows.Forms.TextBox();
            this.txt_problema = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_contato_cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_razao_social = new System.Windows.Forms.TextBox();
            this.cmb_sistema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_filial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cd_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero_atendimento = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_pesq = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.group_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_historico);
            this.groupBox1.Controls.Add(this.btn_fechar);
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.btn_alterar);
            this.groupBox1.Controls.Add(this.btn_incluir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_historico
            // 
            this.btn_historico.Enabled = false;
            this.btn_historico.Location = new System.Drawing.Point(399, 13);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(131, 22);
            this.btn_historico.TabIndex = 5;
            this.btn_historico.Text = "Histórico Atendimentos";
            this.btn_historico.UseVisualStyleBackColor = true;
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(213, 12);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(63, 22);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(144, 12);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(63, 22);
            this.btn_pesquisar.TabIndex = 3;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Enabled = false;
            this.btn_alterar.Location = new System.Drawing.Point(75, 12);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(63, 22);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(6, 12);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(63, 22);
            this.btn_incluir.TabIndex = 1;
            this.btn_incluir.Text = "Novo";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // group_campos
            // 
            this.group_campos.Controls.Add(this.tb_id_filial);
            this.group_campos.Controls.Add(this.tb_id_frente);
            this.group_campos.Controls.Add(this.tb_id_retag);
            this.group_campos.Controls.Add(this.tb_filial);
            this.group_campos.Controls.Add(this.tb_frente);
            this.group_campos.Controls.Add(this.tb_retag);
            this.group_campos.Controls.Add(this.tb_data);
            this.group_campos.Controls.Add(this.label16);
            this.group_campos.Controls.Add(this.label15);
            this.group_campos.Controls.Add(this.button1);
            this.group_campos.Controls.Add(this.txt_telefone);
            this.group_campos.Controls.Add(this.label14);
            this.group_campos.Controls.Add(this.tb_sa);
            this.group_campos.Controls.Add(this.lbl_sa);
            this.group_campos.Controls.Add(this.cb_frente);
            this.group_campos.Controls.Add(this.label13);
            this.group_campos.Controls.Add(this.tb_fantasia);
            this.group_campos.Controls.Add(this.cmb_status);
            this.group_campos.Controls.Add(this.txt_cnpj);
            this.group_campos.Controls.Add(this.label4);
            this.group_campos.Controls.Add(this.btn_cadastrar_usuario);
            this.group_campos.Controls.Add(this.label12);
            this.group_campos.Controls.Add(this.txt_observacao);
            this.group_campos.Controls.Add(this.label11);
            this.group_campos.Controls.Add(this.label10);
            this.group_campos.Controls.Add(this.txt_solucao);
            this.group_campos.Controls.Add(this.txt_problema);
            this.group_campos.Controls.Add(this.label9);
            this.group_campos.Controls.Add(this.txt_contato_cliente);
            this.group_campos.Controls.Add(this.label8);
            this.group_campos.Controls.Add(this.label7);
            this.group_campos.Controls.Add(this.label6);
            this.group_campos.Controls.Add(this.txt_razao_social);
            this.group_campos.Controls.Add(this.cmb_sistema);
            this.group_campos.Controls.Add(this.label3);
            this.group_campos.Controls.Add(this.cmb_filial);
            this.group_campos.Controls.Add(this.label2);
            this.group_campos.Controls.Add(this.txt_cd_cliente);
            this.group_campos.Enabled = false;
            this.group_campos.Location = new System.Drawing.Point(12, 85);
            this.group_campos.Name = "group_campos";
            this.group_campos.Size = new System.Drawing.Size(543, 449);
            this.group_campos.TabIndex = 1;
            this.group_campos.TabStop = false;
            this.group_campos.Text = "Informaçõe do chamado:";
            this.group_campos.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tb_id_filial
            // 
            this.tb_id_filial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_id_filial.Location = new System.Drawing.Point(460, 15);
            this.tb_id_filial.Name = "tb_id_filial";
            this.tb_id_filial.Size = new System.Drawing.Size(24, 20);
            this.tb_id_filial.TabIndex = 41;
            this.tb_id_filial.Visible = false;
            // 
            // tb_id_frente
            // 
            this.tb_id_frente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_id_frente.Location = new System.Drawing.Point(430, 15);
            this.tb_id_frente.Name = "tb_id_frente";
            this.tb_id_frente.Size = new System.Drawing.Size(24, 20);
            this.tb_id_frente.TabIndex = 40;
            this.tb_id_frente.Visible = false;
            // 
            // tb_id_retag
            // 
            this.tb_id_retag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_id_retag.Location = new System.Drawing.Point(400, 17);
            this.tb_id_retag.Name = "tb_id_retag";
            this.tb_id_retag.Size = new System.Drawing.Size(24, 20);
            this.tb_id_retag.TabIndex = 39;
            this.tb_id_retag.Visible = false;
            // 
            // tb_filial
            // 
            this.tb_filial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_filial.Location = new System.Drawing.Point(414, 97);
            this.tb_filial.Name = "tb_filial";
            this.tb_filial.Size = new System.Drawing.Size(116, 20);
            this.tb_filial.TabIndex = 38;
            // 
            // tb_frente
            // 
            this.tb_frente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_frente.Location = new System.Drawing.Point(259, 97);
            this.tb_frente.Name = "tb_frente";
            this.tb_frente.Size = new System.Drawing.Size(116, 20);
            this.tb_frente.TabIndex = 37;
            // 
            // tb_retag
            // 
            this.tb_retag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_retag.Location = new System.Drawing.Point(93, 97);
            this.tb_retag.Name = "tb_retag";
            this.tb_retag.Size = new System.Drawing.Size(116, 20);
            this.tb_retag.TabIndex = 36;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(287, 126);
            this.tb_data.Mask = "00/00/0000";
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(88, 20);
            this.tb_data.TabIndex = 35;
            this.tb_data.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(248, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Data:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Retaguarda:";
            // 
            // button1
            // 
            this.button1.Image = global::Prime.Properties.Resources.magnifying_glass_189254_640;
            this.button1.Location = new System.Drawing.Point(334, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(441, 126);
            this.txt_telefone.Mask = "(00) 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(89, 20);
            this.txt_telefone.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(213, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Frente:";
            // 
            // tb_sa
            // 
            this.tb_sa.Enabled = false;
            this.tb_sa.Location = new System.Drawing.Point(430, 418);
            this.tb_sa.Name = "tb_sa";
            this.tb_sa.Size = new System.Drawing.Size(107, 20);
            this.tb_sa.TabIndex = 25;
            // 
            // lbl_sa
            // 
            this.lbl_sa.AutoSize = true;
            this.lbl_sa.Enabled = false;
            this.lbl_sa.Location = new System.Drawing.Point(397, 421);
            this.lbl_sa.Name = "lbl_sa";
            this.lbl_sa.Size = new System.Drawing.Size(27, 13);
            this.lbl_sa.TabIndex = 24;
            this.lbl_sa.Text = "S.A:";
            // 
            // cb_frente
            // 
            this.cb_frente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_frente.FormattingEnabled = true;
            this.cb_frente.Items.AddRange(new object[] {
            "FLEX",
            "SUPER",
            "OUTROS"});
            this.cb_frente.Location = new System.Drawing.Point(259, 126);
            this.cb_frente.Name = "cb_frente";
            this.cb_frente.Size = new System.Drawing.Size(116, 21);
            this.cb_frente.TabIndex = 30;
            this.cb_frente.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Nome Fantasia:";
            // 
            // tb_fantasia
            // 
            this.tb_fantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_fantasia.Location = new System.Drawing.Point(93, 71);
            this.tb_fantasia.Name = "tb_fantasia";
            this.tb_fantasia.Size = new System.Drawing.Size(437, 20);
            this.tb_fantasia.TabIndex = 28;
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "PENDENTE",
            "SANADO",
            "DESENVOLVIMENTO",
            "EXTERNO"});
            this.cmb_status.Location = new System.Drawing.Point(167, 417);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(228, 21);
            this.cmb_status.TabIndex = 6;
            this.cmb_status.SelectedIndexChanged += new System.EventHandler(this.cmb_status_SelectedIndexChanged);
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(222, 19);
            this.txt_cnpj.Mask = "00,000,000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(106, 20);
            this.txt_cnpj.TabIndex = 27;
            this.txt_cnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cnpj_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // btn_cadastrar_usuario
            // 
            this.btn_cadastrar_usuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar_usuario.BackgroundImage")));
            this.btn_cadastrar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cadastrar_usuario.Location = new System.Drawing.Point(364, 17);
            this.btn_cadastrar_usuario.Name = "btn_cadastrar_usuario";
            this.btn_cadastrar_usuario.Size = new System.Drawing.Size(24, 23);
            this.btn_cadastrar_usuario.TabIndex = 23;
            this.btn_cadastrar_usuario.UseVisualStyleBackColor = true;
            this.btn_cadastrar_usuario.Click += new System.EventHandler(this.btn_cadastrar_usuario_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Observações:";
            // 
            // txt_observacao
            // 
            this.txt_observacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_observacao.Location = new System.Drawing.Point(6, 369);
            this.txt_observacao.Multiline = true;
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.Size = new System.Drawing.Size(528, 42);
            this.txt_observacao.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Descrição da solução:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Descrição do problema:";
            // 
            // txt_solucao
            // 
            this.txt_solucao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_solucao.Location = new System.Drawing.Point(10, 232);
            this.txt_solucao.Multiline = true;
            this.txt_solucao.Name = "txt_solucao";
            this.txt_solucao.Size = new System.Drawing.Size(524, 117);
            this.txt_solucao.TabIndex = 14;
            // 
            // txt_problema
            // 
            this.txt_problema.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_problema.Location = new System.Drawing.Point(10, 172);
            this.txt_problema.Multiline = true;
            this.txt_problema.Name = "txt_problema";
            this.txt_problema.Size = new System.Drawing.Size(524, 41);
            this.txt_problema.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Contato:";
            // 
            // txt_contato_cliente
            // 
            this.txt_contato_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_contato_cliente.Location = new System.Drawing.Point(93, 123);
            this.txt_contato_cliente.Name = "txt_contato_cliente";
            this.txt_contato_cliente.Size = new System.Drawing.Size(139, 20);
            this.txt_contato_cliente.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CNPJ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Razão Social:";
            // 
            // txt_razao_social
            // 
            this.txt_razao_social.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_razao_social.Location = new System.Drawing.Point(93, 45);
            this.txt_razao_social.Name = "txt_razao_social";
            this.txt_razao_social.Size = new System.Drawing.Size(437, 20);
            this.txt_razao_social.TabIndex = 9;
            // 
            // cmb_sistema
            // 
            this.cmb_sistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sistema.FormattingEnabled = true;
            this.cmb_sistema.Items.AddRange(new object[] {
            "MERCOFLEX",
            "FLEXCONCENT",
            "MERCOSUPER",
            "MERCATTO",
            "OUTROS"});
            this.cmb_sistema.Location = new System.Drawing.Point(131, 149);
            this.cmb_sistema.Name = "cmb_sistema";
            this.cmb_sistema.Size = new System.Drawing.Size(116, 21);
            this.cmb_sistema.TabIndex = 7;
            this.cmb_sistema.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filial:";
            // 
            // cmb_filial
            // 
            this.cmb_filial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filial.FormattingEnabled = true;
            this.cmb_filial.Items.AddRange(new object[] {
            "MATRIZ",
            "ABC",
            "RIBEIRAO",
            "PARÁ"});
            this.cmb_filial.Location = new System.Drawing.Point(414, 126);
            this.cmb_filial.Name = "cmb_filial";
            this.cmb_filial.Size = new System.Drawing.Size(116, 21);
            this.cmb_filial.TabIndex = 5;
            this.cmb_filial.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código Cliente:";
            // 
            // txt_cd_cliente
            // 
            this.txt_cd_cliente.Location = new System.Drawing.Point(93, 19);
            this.txt_cd_cliente.Name = "txt_cd_cliente";
            this.txt_cd_cliente.Size = new System.Drawing.Size(77, 20);
            this.txt_cd_cliente.TabIndex = 8;
            this.txt_cd_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cd_cliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Atendimento:";
            // 
            // txt_numero_atendimento
            // 
            this.txt_numero_atendimento.Location = new System.Drawing.Point(105, 59);
            this.txt_numero_atendimento.Name = "txt_numero_atendimento";
            this.txt_numero_atendimento.Size = new System.Drawing.Size(100, 20);
            this.txt_numero_atendimento.TabIndex = 0;
            this.txt_numero_atendimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_atendimento_KeyPress);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(480, 540);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Enabled = false;
            this.btn_confirmar.Location = new System.Drawing.Point(399, 540);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 16;
            this.btn_confirmar.Text = "Salvar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_pesq
            // 
            this.btn_pesq.Image = global::Prime.Properties.Resources.magnifying_glass_189254_640;
            this.btn_pesq.Location = new System.Drawing.Point(211, 57);
            this.btn_pesq.Name = "btn_pesq";
            this.btn_pesq.Size = new System.Drawing.Size(24, 23);
            this.btn_pesq.TabIndex = 27;
            this.btn_pesq.UseVisualStyleBackColor = true;
            this.btn_pesq.Click += new System.EventHandler(this.btn_pesq_Click);
            // 
            // frm_atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 568);
            this.Controls.Add(this.btn_pesq);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.group_campos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_numero_atendimento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_atendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimentos";
            this.Load += new System.EventHandler(this.frm_atendimento_Load);
            this.groupBox1.ResumeLayout(false);
            this.group_campos.ResumeLayout(false);
            this.group_campos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.GroupBox group_campos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_razao_social;
        private System.Windows.Forms.ComboBox cmb_sistema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_filial;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_cd_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero_atendimento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_solucao;
        private System.Windows.Forms.TextBox txt_problema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_contato_cliente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_cadastrar_usuario;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.TextBox tb_sa;
        private System.Windows.Forms.Label lbl_sa;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_frente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_fantasia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_observacao;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Button btn_pesq;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox tb_data;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_filial;
        private System.Windows.Forms.TextBox tb_retag;
        private System.Windows.Forms.TextBox tb_frente;
        private System.Windows.Forms.TextBox tb_id_filial;
        private System.Windows.Forms.TextBox tb_id_frente;
        private System.Windows.Forms.TextBox tb_id_retag;
    }
}

