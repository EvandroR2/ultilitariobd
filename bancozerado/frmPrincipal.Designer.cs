﻿
namespace bancozerado
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnUolHost = new System.Windows.Forms.RadioButton();
            this.rbtnAzure2 = new System.Windows.Forms.RadioButton();
            this.rbtnAzure1 = new System.Windows.Forms.RadioButton();
            this.RbtnLocal = new System.Windows.Forms.RadioButton();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.lblNomeBanco = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblInstancia = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtInstancia = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.menuArquivo = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgVLogicalName = new System.Windows.Forms.DataGridView();
            this.LogicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInstZero = new System.Windows.Forms.GroupBox();
            this.txtDiretorioBuscar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnPontoMdf = new System.Windows.Forms.RadioButton();
            this.rbtnPontoBak = new System.Windows.Forms.RadioButton();
            this.lblCaminhoBak = new System.Windows.Forms.Label();
            this.btnArquivoAux = new System.Windows.Forms.Button();
            this.btnDiretorioBuscar = new System.Windows.Forms.Button();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.checkBoxInstZeroousembackup = new System.Windows.Forms.CheckBox();
            this.groupBoxInstBancoZero = new System.Windows.Forms.GroupBox();
            this.checkBoxFranquia = new System.Windows.Forms.CheckBox();
            this.txtTriPercTabTributo = new System.Windows.Forms.TextBox();
            this.txtDescTabTributo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTriPercTabTributo = new System.Windows.Forms.Label();
            this.lblCodigoFilial = new System.Windows.Forms.Label();
            this.lblcodigoRomaneio = new System.Windows.Forms.Label();
            this.lblDescTabTributo = new System.Windows.Forms.Label();
            this.lblCodigoMatrizFranquia = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.lblCodTabTributo = new System.Windows.Forms.Label();
            this.txtCodigoEmpresa = new System.Windows.Forms.TextBox();
            this.txtCodigoFilial = new System.Windows.Forms.TextBox();
            this.txtCodTabTributo = new System.Windows.Forms.TextBox();
            this.txtcodigoRomaneio = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigoMatrizFranquia = new System.Windows.Forms.TextBox();
            this.lblInfTabTributo = new System.Windows.Forms.Label();
            this.btnQuerry = new System.Windows.Forms.Button();
            this.lblDiretorioBkp = new System.Windows.Forms.Label();
            this.txtDiretorioBkp = new System.Windows.Forms.TextBox();
            this.btnDiretorioBkp = new System.Windows.Forms.Button();
            this.txtArquivoAux = new System.Windows.Forms.TextBox();
            this.lblInformeAux = new System.Windows.Forms.Label();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.lblInforme = new System.Windows.Forms.Label();
            this.lblDiretorio = new System.Windows.Forms.Label();
            this.btnDiretorio = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomedoBancoZero = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarTabela = new System.Windows.Forms.Button();
            this.lblTabelaTributo = new System.Windows.Forms.Label();
            this.lblTabelaFilial = new System.Windows.Forms.Label();
            this.lblTabelaEmpresa = new System.Windows.Forms.Label();
            this.divTabelaTributo = new System.Windows.Forms.DataGridView();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERCENTUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divTabelaFilial = new System.Windows.Forms.DataGridView();
            this.FILIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_TRIBUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_FANTASIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIL_FRANQUIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIL_CODIGO_FRANQUIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divTabelaEmpresa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZAO_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.menuArquivo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVLogicalName)).BeginInit();
            this.groupBoxInstZero.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxInstBancoZero.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divTabelaTributo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divTabelaFilial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divTabelaEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(653, 27);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 39);
            this.btnSair.TabIndex = 64;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnUolHost);
            this.groupBox1.Controls.Add(this.rbtnAzure2);
            this.groupBox1.Controls.Add(this.rbtnAzure1);
            this.groupBox1.Controls.Add(this.RbtnLocal);
            this.groupBox1.Location = new System.Drawing.Point(195, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 40);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // rbtnUolHost
            // 
            this.rbtnUolHost.AutoSize = true;
            this.rbtnUolHost.Location = new System.Drawing.Point(209, 11);
            this.rbtnUolHost.Name = "rbtnUolHost";
            this.rbtnUolHost.Size = new System.Drawing.Size(63, 17);
            this.rbtnUolHost.TabIndex = 4;
            this.rbtnUolHost.Text = "UolHost";
            this.rbtnUolHost.UseVisualStyleBackColor = true;
            this.rbtnUolHost.CheckedChanged += new System.EventHandler(this.rbtnUolHost_CheckedChanged);
            // 
            // rbtnAzure2
            // 
            this.rbtnAzure2.AutoSize = true;
            this.rbtnAzure2.Location = new System.Drawing.Point(147, 11);
            this.rbtnAzure2.Name = "rbtnAzure2";
            this.rbtnAzure2.Size = new System.Drawing.Size(58, 17);
            this.rbtnAzure2.TabIndex = 3;
            this.rbtnAzure2.Text = "Azure2";
            this.rbtnAzure2.UseVisualStyleBackColor = true;
            this.rbtnAzure2.CheckedChanged += new System.EventHandler(this.rbtnAzure2_CheckedChanged);
            // 
            // rbtnAzure1
            // 
            this.rbtnAzure1.AutoSize = true;
            this.rbtnAzure1.Location = new System.Drawing.Point(85, 11);
            this.rbtnAzure1.Name = "rbtnAzure1";
            this.rbtnAzure1.Size = new System.Drawing.Size(58, 17);
            this.rbtnAzure1.TabIndex = 2;
            this.rbtnAzure1.Text = "Azure1";
            this.rbtnAzure1.UseVisualStyleBackColor = true;
            this.rbtnAzure1.CheckedChanged += new System.EventHandler(this.rbtnAzure1_CheckedChanged);
            // 
            // RbtnLocal
            // 
            this.RbtnLocal.AutoSize = true;
            this.RbtnLocal.Checked = true;
            this.RbtnLocal.Location = new System.Drawing.Point(6, 11);
            this.RbtnLocal.Name = "RbtnLocal";
            this.RbtnLocal.Size = new System.Drawing.Size(75, 17);
            this.RbtnLocal.TabIndex = 1;
            this.RbtnLocal.TabStop = true;
            this.RbtnLocal.Text = "SQL Local";
            this.RbtnLocal.UseVisualStyleBackColor = true;
            this.RbtnLocal.CheckedChanged += new System.EventHandler(this.RbtnLocal_CheckedChanged);
            // 
            // cmbBanco
            // 
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(448, 89);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(179, 21);
            this.cmbBanco.TabIndex = 60;
            this.cmbBanco.Click += new System.EventHandler(this.cmbBanco_Click);
            this.cmbBanco.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmbBanco_MouseMove);
            // 
            // lblNomeBanco
            // 
            this.lblNomeBanco.AutoSize = true;
            this.lblNomeBanco.Location = new System.Drawing.Point(445, 72);
            this.lblNomeBanco.Name = "lblNomeBanco";
            this.lblNomeBanco.Size = new System.Drawing.Size(84, 13);
            this.lblNomeBanco.TabIndex = 59;
            this.lblNomeBanco.Text = "Nome do Banco";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(338, 72);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 58;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(231, 72);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 57;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblInstancia
            // 
            this.lblInstancia.AutoSize = true;
            this.lblInstancia.Location = new System.Drawing.Point(14, 72);
            this.lblInstancia.Name = "lblInstancia";
            this.lblInstancia.Size = new System.Drawing.Size(50, 13);
            this.lblInstancia.TabIndex = 56;
            this.lblInstancia.Text = "Instancia";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(341, 91);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 55;
            this.txtSenha.Text = "inter#system";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(234, 91);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 54;
            this.txtUsuario.Text = "sa";
            // 
            // txtInstancia
            // 
            this.txtInstancia.Location = new System.Drawing.Point(14, 91);
            this.txtInstancia.Name = "txtInstancia";
            this.txtInstancia.Size = new System.Drawing.Size(213, 20);
            this.txtInstancia.TabIndex = 53;
            this.txtInstancia.Text = ".\\pdvnet";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(12, 36);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(146, 29);
            this.lblMsg.TabIndex = 50;
            this.lblMsg.Text = "Ultilitario BD";
            // 
            // menuArquivo
            // 
            this.menuArquivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuArquivo.Location = new System.Drawing.Point(0, 0);
            this.menuArquivo.Name = "menuArquivo";
            this.menuArquivo.Size = new System.Drawing.Size(782, 24);
            this.menuArquivo.TabIndex = 69;
            this.menuArquivo.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 621);
            this.tabControl1.TabIndex = 70;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgVLogicalName);
            this.tabPage1.Controls.Add(this.groupBoxInstZero);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Restaurar BD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgVLogicalName
            // 
            this.dgVLogicalName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVLogicalName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogicalName});
            this.dgVLogicalName.Location = new System.Drawing.Point(7, 499);
            this.dgVLogicalName.Name = "dgVLogicalName";
            this.dgVLogicalName.Size = new System.Drawing.Size(155, 75);
            this.dgVLogicalName.TabIndex = 69;
            this.dgVLogicalName.Visible = false;
            // 
            // LogicalName
            // 
            this.LogicalName.HeaderText = "LogicalName";
            this.LogicalName.Name = "LogicalName";
            // 
            // groupBoxInstZero
            // 
            this.groupBoxInstZero.Controls.Add(this.txtDiretorioBuscar);
            this.groupBoxInstZero.Controls.Add(this.groupBox2);
            this.groupBoxInstZero.Controls.Add(this.lblCaminhoBak);
            this.groupBoxInstZero.Controls.Add(this.btnArquivoAux);
            this.groupBoxInstZero.Controls.Add(this.btnDiretorioBuscar);
            this.groupBoxInstZero.Controls.Add(this.btnArquivo);
            this.groupBoxInstZero.Controls.Add(this.checkBoxInstZeroousembackup);
            this.groupBoxInstZero.Controls.Add(this.groupBoxInstBancoZero);
            this.groupBoxInstZero.Controls.Add(this.lblDiretorioBkp);
            this.groupBoxInstZero.Controls.Add(this.txtDiretorioBkp);
            this.groupBoxInstZero.Controls.Add(this.btnDiretorioBkp);
            this.groupBoxInstZero.Controls.Add(this.txtArquivoAux);
            this.groupBoxInstZero.Controls.Add(this.lblInformeAux);
            this.groupBoxInstZero.Controls.Add(this.txtDiretorio);
            this.groupBoxInstZero.Controls.Add(this.txtArquivo);
            this.groupBoxInstZero.Controls.Add(this.lblInforme);
            this.groupBoxInstZero.Controls.Add(this.lblDiretorio);
            this.groupBoxInstZero.Controls.Add(this.btnDiretorio);
            this.groupBoxInstZero.Controls.Add(this.btnBackup);
            this.groupBoxInstZero.Controls.Add(this.btnDeletar);
            this.groupBoxInstZero.Controls.Add(this.btnRestaurar);
            this.groupBoxInstZero.Controls.Add(this.label1);
            this.groupBoxInstZero.Controls.Add(this.txtnomedoBancoZero);
            this.groupBoxInstZero.Location = new System.Drawing.Point(6, 6);
            this.groupBoxInstZero.Name = "groupBoxInstZero";
            this.groupBoxInstZero.Size = new System.Drawing.Size(724, 487);
            this.groupBoxInstZero.TabIndex = 68;
            this.groupBoxInstZero.TabStop = false;
            this.groupBoxInstZero.Text = "Restaurar Banco de Dados";
            // 
            // txtDiretorioBuscar
            // 
            this.txtDiretorioBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiretorioBuscar.Location = new System.Drawing.Point(14, 44);
            this.txtDiretorioBuscar.Name = "txtDiretorioBuscar";
            this.txtDiretorioBuscar.Size = new System.Drawing.Size(290, 26);
            this.txtDiretorioBuscar.TabIndex = 105;
            this.txtDiretorioBuscar.Text = "C:\\BaseSQL";
            this.txtDiretorioBuscar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtDiretorioBuscar_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnPontoMdf);
            this.groupBox2.Controls.Add(this.rbtnPontoBak);
            this.groupBox2.Location = new System.Drawing.Point(479, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 40);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // rbtnPontoMdf
            // 
            this.rbtnPontoMdf.AutoSize = true;
            this.rbtnPontoMdf.Location = new System.Drawing.Point(85, 11);
            this.rbtnPontoMdf.Name = "rbtnPontoMdf";
            this.rbtnPontoMdf.Size = new System.Drawing.Size(55, 17);
            this.rbtnPontoMdf.TabIndex = 2;
            this.rbtnPontoMdf.Text = "\".mdf\"";
            this.rbtnPontoMdf.UseVisualStyleBackColor = true;
            this.rbtnPontoMdf.CheckedChanged += new System.EventHandler(this.rbtnPontoMdf_CheckedChanged);
            // 
            // rbtnPontoBak
            // 
            this.rbtnPontoBak.AutoSize = true;
            this.rbtnPontoBak.Checked = true;
            this.rbtnPontoBak.Location = new System.Drawing.Point(6, 11);
            this.rbtnPontoBak.Name = "rbtnPontoBak";
            this.rbtnPontoBak.Size = new System.Drawing.Size(56, 17);
            this.rbtnPontoBak.TabIndex = 1;
            this.rbtnPontoBak.TabStop = true;
            this.rbtnPontoBak.Text = "\".bak\"";
            this.rbtnPontoBak.UseVisualStyleBackColor = true;
            this.rbtnPontoBak.CheckedChanged += new System.EventHandler(this.rbtnPontoBak_CheckedChanged);
            // 
            // lblCaminhoBak
            // 
            this.lblCaminhoBak.AutoSize = true;
            this.lblCaminhoBak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminhoBak.Location = new System.Drawing.Point(14, 16);
            this.lblCaminhoBak.Name = "lblCaminhoBak";
            this.lblCaminhoBak.Size = new System.Drawing.Size(249, 20);
            this.lblCaminhoBak.TabIndex = 107;
            this.lblCaminhoBak.Text = "Informe o Diretório Banco do .Bak";
            // 
            // btnArquivoAux
            // 
            this.btnArquivoAux.Location = new System.Drawing.Point(643, 111);
            this.btnArquivoAux.Name = "btnArquivoAux";
            this.btnArquivoAux.Size = new System.Drawing.Size(27, 26);
            this.btnArquivoAux.TabIndex = 104;
            this.btnArquivoAux.Text = "...";
            this.btnArquivoAux.UseVisualStyleBackColor = true;
            this.btnArquivoAux.Click += new System.EventHandler(this.btnArquivoAux_Click);
            // 
            // btnDiretorioBuscar
            // 
            this.btnDiretorioBuscar.Location = new System.Drawing.Point(310, 45);
            this.btnDiretorioBuscar.Name = "btnDiretorioBuscar";
            this.btnDiretorioBuscar.Size = new System.Drawing.Size(27, 26);
            this.btnDiretorioBuscar.TabIndex = 106;
            this.btnDiretorioBuscar.Text = "...";
            this.btnDiretorioBuscar.UseVisualStyleBackColor = true;
            this.btnDiretorioBuscar.Click += new System.EventHandler(this.btnDiretorioBuscar_Click);
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(303, 109);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(27, 26);
            this.btnArquivo.TabIndex = 103;
            this.btnArquivo.Text = "...";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // checkBoxInstZeroousembackup
            // 
            this.checkBoxInstZeroousembackup.AutoSize = true;
            this.checkBoxInstZeroousembackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInstZeroousembackup.Location = new System.Drawing.Point(473, 226);
            this.checkBoxInstZeroousembackup.Name = "checkBoxInstZeroousembackup";
            this.checkBoxInstZeroousembackup.Size = new System.Drawing.Size(197, 19);
            this.checkBoxInstZeroousembackup.TabIndex = 102;
            this.checkBoxInstZeroousembackup.Text = "Instalacao zero ou sem Backup";
            this.checkBoxInstZeroousembackup.UseVisualStyleBackColor = true;
            this.checkBoxInstZeroousembackup.CheckedChanged += new System.EventHandler(this.checkBoxInstZeroousembackup_CheckedChanged);
            this.checkBoxInstZeroousembackup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBoxInstZeroousembackup_MouseMove);
            // 
            // groupBoxInstBancoZero
            // 
            this.groupBoxInstBancoZero.Controls.Add(this.checkBoxFranquia);
            this.groupBoxInstBancoZero.Controls.Add(this.txtTriPercTabTributo);
            this.groupBoxInstBancoZero.Controls.Add(this.txtDescTabTributo);
            this.groupBoxInstBancoZero.Controls.Add(this.label3);
            this.groupBoxInstBancoZero.Controls.Add(this.label4);
            this.groupBoxInstBancoZero.Controls.Add(this.lblTriPercTabTributo);
            this.groupBoxInstBancoZero.Controls.Add(this.lblCodigoFilial);
            this.groupBoxInstBancoZero.Controls.Add(this.lblcodigoRomaneio);
            this.groupBoxInstBancoZero.Controls.Add(this.lblDescTabTributo);
            this.groupBoxInstBancoZero.Controls.Add(this.lblCodigoMatrizFranquia);
            this.groupBoxInstBancoZero.Controls.Add(this.txtNomeEmpresa);
            this.groupBoxInstBancoZero.Controls.Add(this.lblCodTabTributo);
            this.groupBoxInstBancoZero.Controls.Add(this.txtCodigoEmpresa);
            this.groupBoxInstBancoZero.Controls.Add(this.txtCodigoFilial);
            this.groupBoxInstBancoZero.Controls.Add(this.txtCodTabTributo);
            this.groupBoxInstBancoZero.Controls.Add(this.txtcodigoRomaneio);
            this.groupBoxInstBancoZero.Controls.Add(this.txtCodigoMatrizFranquia);
            this.groupBoxInstBancoZero.Controls.Add(this.lblInfTabTributo);
            this.groupBoxInstBancoZero.Controls.Add(this.btnQuerry);
            this.groupBoxInstBancoZero.Location = new System.Drawing.Point(7, 254);
            this.groupBoxInstBancoZero.Name = "groupBoxInstBancoZero";
            this.groupBoxInstBancoZero.Size = new System.Drawing.Size(663, 212);
            this.groupBoxInstBancoZero.TabIndex = 69;
            this.groupBoxInstBancoZero.TabStop = false;
            this.groupBoxInstBancoZero.Text = "Instalação de Banco Zero";
            this.groupBoxInstBancoZero.Visible = false;
            // 
            // checkBoxFranquia
            // 
            this.checkBoxFranquia.AutoSize = true;
            this.checkBoxFranquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFranquia.Location = new System.Drawing.Point(6, 19);
            this.checkBoxFranquia.Name = "checkBoxFranquia";
            this.checkBoxFranquia.Size = new System.Drawing.Size(75, 19);
            this.checkBoxFranquia.TabIndex = 65;
            this.checkBoxFranquia.Text = "Franquia";
            this.checkBoxFranquia.UseVisualStyleBackColor = true;
            this.checkBoxFranquia.CheckedChanged += new System.EventHandler(this.checkBoxFranquia_CheckedChanged);
            this.checkBoxFranquia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkBoxFranquia_MouseMove);
            // 
            // txtTriPercTabTributo
            // 
            this.txtTriPercTabTributo.Enabled = false;
            this.txtTriPercTabTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriPercTabTributo.Location = new System.Drawing.Point(531, 96);
            this.txtTriPercTabTributo.Name = "txtTriPercTabTributo";
            this.txtTriPercTabTributo.Size = new System.Drawing.Size(85, 21);
            this.txtTriPercTabTributo.TabIndex = 101;
            this.txtTriPercTabTributo.Visible = false;
            this.txtTriPercTabTributo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtTriPercTabTributo_MouseMove);
            // 
            // txtDescTabTributo
            // 
            this.txtDescTabTributo.Enabled = false;
            this.txtDescTabTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescTabTributo.Location = new System.Drawing.Point(531, 69);
            this.txtDescTabTributo.Name = "txtDescTabTributo";
            this.txtDescTabTributo.Size = new System.Drawing.Size(85, 21);
            this.txtDescTabTributo.TabIndex = 100;
            this.txtDescTabTributo.Visible = false;
            this.txtDescTabTributo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtDescTabTributo_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 72;
            this.label3.Text = "Codigo da Empresa (rede)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Nome da Empresa (rede)";
            // 
            // lblTriPercTabTributo
            // 
            this.lblTriPercTabTributo.AutoSize = true;
            this.lblTriPercTabTributo.Enabled = false;
            this.lblTriPercTabTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriPercTabTributo.Location = new System.Drawing.Point(436, 96);
            this.lblTriPercTabTributo.Name = "lblTriPercTabTributo";
            this.lblTriPercTabTributo.Size = new System.Drawing.Size(79, 15);
            this.lblTriPercTabTributo.TabIndex = 99;
            this.lblTriPercTabTributo.Text = "Tributacao %";
            this.lblTriPercTabTributo.Visible = false;
            // 
            // lblCodigoFilial
            // 
            this.lblCodigoFilial.AutoSize = true;
            this.lblCodigoFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFilial.Location = new System.Drawing.Point(3, 123);
            this.lblCodigoFilial.Name = "lblCodigoFilial";
            this.lblCodigoFilial.Size = new System.Drawing.Size(92, 15);
            this.lblCodigoFilial.TabIndex = 76;
            this.lblCodigoFilial.Text = "Codigo da Filial";
            // 
            // lblcodigoRomaneio
            // 
            this.lblcodigoRomaneio.AutoSize = true;
            this.lblcodigoRomaneio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoRomaneio.Location = new System.Drawing.Point(3, 41);
            this.lblcodigoRomaneio.Name = "lblcodigoRomaneio";
            this.lblcodigoRomaneio.Size = new System.Drawing.Size(196, 15);
            this.lblcodigoRomaneio.TabIndex = 69;
            this.lblcodigoRomaneio.Text = "Nº do Romaneio de Transferencia:";
            // 
            // lblDescTabTributo
            // 
            this.lblDescTabTributo.AutoSize = true;
            this.lblDescTabTributo.Enabled = false;
            this.lblDescTabTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescTabTributo.Location = new System.Drawing.Point(436, 69);
            this.lblDescTabTributo.Name = "lblDescTabTributo";
            this.lblDescTabTributo.Size = new System.Drawing.Size(62, 15);
            this.lblDescTabTributo.TabIndex = 98;
            this.lblDescTabTributo.Text = "Descricao";
            this.lblDescTabTributo.Visible = false;
            // 
            // lblCodigoMatrizFranquia
            // 
            this.lblCodigoMatrizFranquia.AutoSize = true;
            this.lblCodigoMatrizFranquia.Enabled = false;
            this.lblCodigoMatrizFranquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMatrizFranquia.Location = new System.Drawing.Point(3, 150);
            this.lblCodigoMatrizFranquia.Name = "lblCodigoMatrizFranquia";
            this.lblCodigoMatrizFranquia.Size = new System.Drawing.Size(146, 15);
            this.lblCodigoMatrizFranquia.TabIndex = 78;
            this.lblCodigoMatrizFranquia.Text = "codigo da matriz franquia";
            this.lblCodigoMatrizFranquia.Visible = false;
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(178, 96);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(197, 21);
            this.txtNomeEmpresa.TabIndex = 73;
            this.txtNomeEmpresa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtNomeEmpresa_MouseMove);
            // 
            // lblCodTabTributo
            // 
            this.lblCodTabTributo.AutoSize = true;
            this.lblCodTabTributo.Enabled = false;
            this.lblCodTabTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTabTributo.Location = new System.Drawing.Point(436, 44);
            this.lblCodTabTributo.Name = "lblCodTabTributo";
            this.lblCodTabTributo.Size = new System.Drawing.Size(46, 15);
            this.lblCodTabTributo.TabIndex = 97;
            this.lblCodTabTributo.Text = "Codigo";
            this.lblCodTabTributo.Visible = false;
            // 
            // txtCodigoEmpresa
            // 
            this.txtCodigoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEmpresa.Location = new System.Drawing.Point(178, 69);
            this.txtCodigoEmpresa.Name = "txtCodigoEmpresa";
            this.txtCodigoEmpresa.Size = new System.Drawing.Size(197, 21);
            this.txtCodigoEmpresa.TabIndex = 71;
            this.txtCodigoEmpresa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtCodigoEmpresa_MouseMove);
            // 
            // txtCodigoFilial
            // 
            this.txtCodigoFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFilial.Location = new System.Drawing.Point(178, 123);
            this.txtCodigoFilial.Name = "txtCodigoFilial";
            this.txtCodigoFilial.Size = new System.Drawing.Size(197, 21);
            this.txtCodigoFilial.TabIndex = 75;
            this.txtCodigoFilial.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtCodigoFilial_MouseMove);
            // 
            // txtCodTabTributo
            // 
            this.txtCodTabTributo.Enabled = false;
            this.txtCodTabTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTabTributo.Location = new System.Drawing.Point(531, 41);
            this.txtCodTabTributo.Name = "txtCodTabTributo";
            this.txtCodTabTributo.Size = new System.Drawing.Size(85, 21);
            this.txtCodTabTributo.TabIndex = 95;
            this.txtCodTabTributo.Visible = false;
            this.txtCodTabTributo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtCodTabTributo_MouseMove);
            // 
            // txtcodigoRomaneio
            // 
            this.txtcodigoRomaneio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoRomaneio.Location = new System.Drawing.Point(276, 41);
            this.txtcodigoRomaneio.Mask = "000000";
            this.txtcodigoRomaneio.Name = "txtcodigoRomaneio";
            this.txtcodigoRomaneio.Size = new System.Drawing.Size(99, 21);
            this.txtcodigoRomaneio.TabIndex = 70;
            this.txtcodigoRomaneio.Text = "000000";
            // 
            // txtCodigoMatrizFranquia
            // 
            this.txtCodigoMatrizFranquia.Enabled = false;
            this.txtCodigoMatrizFranquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMatrizFranquia.Location = new System.Drawing.Point(178, 150);
            this.txtCodigoMatrizFranquia.Name = "txtCodigoMatrizFranquia";
            this.txtCodigoMatrizFranquia.Size = new System.Drawing.Size(197, 21);
            this.txtCodigoMatrizFranquia.TabIndex = 77;
            this.txtCodigoMatrizFranquia.Visible = false;
            this.txtCodigoMatrizFranquia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtCodigoMatrizFranquia_MouseMove);
            // 
            // lblInfTabTributo
            // 
            this.lblInfTabTributo.AutoSize = true;
            this.lblInfTabTributo.Enabled = false;
            this.lblInfTabTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfTabTributo.Location = new System.Drawing.Point(452, 19);
            this.lblInfTabTributo.Name = "lblInfTabTributo";
            this.lblInfTabTributo.Size = new System.Drawing.Size(151, 15);
            this.lblInfTabTributo.TabIndex = 96;
            this.lblInfTabTributo.Text = "Informacao Tabela Tributo";
            this.lblInfTabTributo.Visible = false;
            // 
            // btnQuerry
            // 
            this.btnQuerry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuerry.Location = new System.Drawing.Point(289, 177);
            this.btnQuerry.Name = "btnQuerry";
            this.btnQuerry.Size = new System.Drawing.Size(86, 26);
            this.btnQuerry.TabIndex = 69;
            this.btnQuerry.Text = "Executar";
            this.btnQuerry.UseVisualStyleBackColor = true;
            this.btnQuerry.Click += new System.EventHandler(this.btnQuerry_Click);
            // 
            // lblDiretorioBkp
            // 
            this.lblDiretorioBkp.AutoSize = true;
            this.lblDiretorioBkp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretorioBkp.Location = new System.Drawing.Point(7, 198);
            this.lblDiretorioBkp.Name = "lblDiretorioBkp";
            this.lblDiretorioBkp.Size = new System.Drawing.Size(221, 20);
            this.lblDiretorioBkp.TabIndex = 94;
            this.lblDiretorioBkp.Text = "Informe o Diretório do Backup";
            // 
            // txtDiretorioBkp
            // 
            this.txtDiretorioBkp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiretorioBkp.Location = new System.Drawing.Point(6, 221);
            this.txtDiretorioBkp.Name = "txtDiretorioBkp";
            this.txtDiretorioBkp.Size = new System.Drawing.Size(293, 26);
            this.txtDiretorioBkp.TabIndex = 92;
            this.txtDiretorioBkp.Text = "C:\\BaseSQL";
            this.txtDiretorioBkp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtDiretorioBkp_MouseMove);
            // 
            // btnDiretorioBkp
            // 
            this.btnDiretorioBkp.Location = new System.Drawing.Point(305, 221);
            this.btnDiretorioBkp.Name = "btnDiretorioBkp";
            this.btnDiretorioBkp.Size = new System.Drawing.Size(27, 26);
            this.btnDiretorioBkp.TabIndex = 93;
            this.btnDiretorioBkp.Text = "...";
            this.btnDiretorioBkp.UseVisualStyleBackColor = true;
            this.btnDiretorioBkp.Click += new System.EventHandler(this.btnDiretorioBkp_Click);
            // 
            // txtArquivoAux
            // 
            this.txtArquivoAux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoAux.Location = new System.Drawing.Point(350, 110);
            this.txtArquivoAux.Name = "txtArquivoAux";
            this.txtArquivoAux.Size = new System.Drawing.Size(287, 26);
            this.txtArquivoAux.TabIndex = 89;
            this.txtArquivoAux.Text = "V1005_AUXILIAR.bak";
            this.txtArquivoAux.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtArquivoAux_MouseMove);
            // 
            // lblInformeAux
            // 
            this.lblInformeAux.AutoSize = true;
            this.lblInformeAux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeAux.Location = new System.Drawing.Point(350, 81);
            this.lblInformeAux.Name = "lblInformeAux";
            this.lblInformeAux.Size = new System.Drawing.Size(298, 20);
            this.lblInformeAux.TabIndex = 91;
            this.lblInformeAux.Text = "Informe o nome do arquivo Auxiliar \".bak\"";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiretorio.Location = new System.Drawing.Point(346, 44);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(290, 26);
            this.txtDiretorio.TabIndex = 82;
            this.txtDiretorio.Text = "C:\\BaseSQL";
            this.txtDiretorio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtDiretorio_MouseMove);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(10, 110);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(287, 26);
            this.txtArquivo.TabIndex = 84;
            this.txtArquivo.Text = "Loja_ZeroV1005.bak";
            this.txtArquivo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtArquivo_MouseMove);
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.Location = new System.Drawing.Point(10, 81);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(244, 20);
            this.lblInforme.TabIndex = 86;
            this.lblInforme.Text = "Informe o nome do arquivo \".bak\"";
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.AutoSize = true;
            this.lblDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretorio.Location = new System.Drawing.Point(346, 16);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(254, 20);
            this.lblDiretorio.TabIndex = 85;
            this.lblDiretorio.Text = "Informe o Diretório Banco Principal";
            // 
            // btnDiretorio
            // 
            this.btnDiretorio.Location = new System.Drawing.Point(642, 45);
            this.btnDiretorio.Name = "btnDiretorio";
            this.btnDiretorio.Size = new System.Drawing.Size(27, 26);
            this.btnDiretorio.TabIndex = 83;
            this.btnDiretorio.Text = "...";
            this.btnDiretorio.UseVisualStyleBackColor = true;
            this.btnDiretorio.Click += new System.EventHandler(this.btnDiretorio_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(338, 221);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(86, 26);
            this.btnBackup.TabIndex = 80;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(310, 169);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(114, 26);
            this.btnDeletar.TabIndex = 79;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(183, 169);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(114, 26);
            this.btnRestaurar.TabIndex = 69;
            this.btnRestaurar.Text = "RESTAURAR";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nome do Banco + codigo do ponto";
            // 
            // txtnomedoBancoZero
            // 
            this.txtnomedoBancoZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomedoBancoZero.Location = new System.Drawing.Point(7, 169);
            this.txtnomedoBancoZero.Name = "txtnomedoBancoZero";
            this.txtnomedoBancoZero.Size = new System.Drawing.Size(170, 26);
            this.txtnomedoBancoZero.TabIndex = 66;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnConsultarTabela);
            this.tabPage2.Controls.Add(this.lblTabelaTributo);
            this.tabPage2.Controls.Add(this.lblTabelaFilial);
            this.tabPage2.Controls.Add(this.lblTabelaEmpresa);
            this.tabPage2.Controls.Add(this.divTabelaTributo);
            this.tabPage2.Controls.Add(this.divTabelaFilial);
            this.tabPage2.Controls.Add(this.divTabelaEmpresa);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta Filial";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "Consulta Tabelas";
            // 
            // btnConsultarTabela
            // 
            this.btnConsultarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTabela.Location = new System.Drawing.Point(652, 6);
            this.btnConsultarTabela.Name = "btnConsultarTabela";
            this.btnConsultarTabela.Size = new System.Drawing.Size(93, 39);
            this.btnConsultarTabela.TabIndex = 74;
            this.btnConsultarTabela.Text = "Consultar";
            this.btnConsultarTabela.UseVisualStyleBackColor = true;
            this.btnConsultarTabela.Click += new System.EventHandler(this.btnConsultarTabela_Click);
            // 
            // lblTabelaTributo
            // 
            this.lblTabelaTributo.AutoSize = true;
            this.lblTabelaTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabelaTributo.Location = new System.Drawing.Point(6, 367);
            this.lblTabelaTributo.Name = "lblTabelaTributo";
            this.lblTabelaTributo.Size = new System.Drawing.Size(132, 24);
            this.lblTabelaTributo.TabIndex = 73;
            this.lblTabelaTributo.Text = "Tabela Tributo";
            // 
            // lblTabelaFilial
            // 
            this.lblTabelaFilial.AutoSize = true;
            this.lblTabelaFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabelaFilial.Location = new System.Drawing.Point(6, 167);
            this.lblTabelaFilial.Name = "lblTabelaFilial";
            this.lblTabelaFilial.Size = new System.Drawing.Size(111, 24);
            this.lblTabelaFilial.TabIndex = 72;
            this.lblTabelaFilial.Text = "Tabela Filial";
            // 
            // lblTabelaEmpresa
            // 
            this.lblTabelaEmpresa.AutoSize = true;
            this.lblTabelaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabelaEmpresa.Location = new System.Drawing.Point(6, 3);
            this.lblTabelaEmpresa.Name = "lblTabelaEmpresa";
            this.lblTabelaEmpresa.Size = new System.Drawing.Size(149, 24);
            this.lblTabelaEmpresa.TabIndex = 71;
            this.lblTabelaEmpresa.Text = "Tabela Empresa";
            // 
            // divTabelaTributo
            // 
            this.divTabelaTributo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divTabelaTributo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD,
            this.DESCRICAO,
            this.PERCENTUAL});
            this.divTabelaTributo.Location = new System.Drawing.Point(6, 394);
            this.divTabelaTributo.Name = "divTabelaTributo";
            this.divTabelaTributo.Size = new System.Drawing.Size(739, 161);
            this.divTabelaTributo.TabIndex = 2;
            // 
            // COD
            // 
            this.COD.HeaderText = "COD";
            this.COD.Name = "COD";
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Width = 150;
            // 
            // PERCENTUAL
            // 
            this.PERCENTUAL.HeaderText = "PERCENTUAL";
            this.PERCENTUAL.Name = "PERCENTUAL";
            // 
            // divTabelaFilial
            // 
            this.divTabelaFilial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divTabelaFilial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FILIAL,
            this.COD_TRIBUTO,
            this.NOME_FANTASIA,
            this.FIL_FRANQUIA,
            this.FIL_CODIGO_FRANQUIA});
            this.divTabelaFilial.Location = new System.Drawing.Point(7, 194);
            this.divTabelaFilial.Name = "divTabelaFilial";
            this.divTabelaFilial.Size = new System.Drawing.Size(739, 161);
            this.divTabelaFilial.TabIndex = 1;
            // 
            // FILIAL
            // 
            this.FILIAL.HeaderText = "FILIAL";
            this.FILIAL.Name = "FILIAL";
            this.FILIAL.Width = 40;
            // 
            // COD_TRIBUTO
            // 
            this.COD_TRIBUTO.HeaderText = "COD TRIBUTO";
            this.COD_TRIBUTO.Name = "COD_TRIBUTO";
            // 
            // NOME_FANTASIA
            // 
            this.NOME_FANTASIA.HeaderText = "NOME FANTASIA";
            this.NOME_FANTASIA.Name = "NOME_FANTASIA";
            this.NOME_FANTASIA.Width = 200;
            // 
            // FIL_FRANQUIA
            // 
            this.FIL_FRANQUIA.HeaderText = "FRANQUIA";
            this.FIL_FRANQUIA.Name = "FIL_FRANQUIA";
            this.FIL_FRANQUIA.Width = 80;
            // 
            // FIL_CODIGO_FRANQUIA
            // 
            this.FIL_CODIGO_FRANQUIA.HeaderText = "CODIGO FRANQUIA";
            this.FIL_CODIGO_FRANQUIA.Name = "FIL_CODIGO_FRANQUIA";
            // 
            // divTabelaEmpresa
            // 
            this.divTabelaEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divTabelaEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RAZAO_SOCIAL});
            this.divTabelaEmpresa.Location = new System.Drawing.Point(7, 31);
            this.divTabelaEmpresa.Name = "divTabelaEmpresa";
            this.divTabelaEmpresa.Size = new System.Drawing.Size(396, 127);
            this.divTabelaEmpresa.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // RAZAO_SOCIAL
            // 
            this.RAZAO_SOCIAL.HeaderText = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.Name = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.Width = 300;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 659);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Troca Cnpj";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 741);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.lblNomeBanco);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblInstancia);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtInstancia);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.menuArquivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuArquivo;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuArquivo.ResumeLayout(false);
            this.menuArquivo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVLogicalName)).EndInit();
            this.groupBoxInstZero.ResumeLayout(false);
            this.groupBoxInstZero.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxInstBancoZero.ResumeLayout(false);
            this.groupBoxInstBancoZero.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divTabelaTributo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divTabelaFilial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divTabelaEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAzure2;
        private System.Windows.Forms.RadioButton rbtnAzure1;
        private System.Windows.Forms.RadioButton RbtnLocal;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.Label lblNomeBanco;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblInstancia;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtInstancia;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.RadioButton rbtnUolHost;
        private System.Windows.Forms.MenuStrip menuArquivo;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtnomedoBancoZero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnDiretorio;
        private System.Windows.Forms.Label lblDiretorio;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label lblInformeAux;
        private System.Windows.Forms.TextBox txtArquivoAux;
        private System.Windows.Forms.Button btnDiretorioBkp;
        private System.Windows.Forms.TextBox txtDiretorioBkp;
        private System.Windows.Forms.Label lblDiretorioBkp;
        private System.Windows.Forms.GroupBox groupBoxInstBancoZero;
        private System.Windows.Forms.CheckBox checkBoxFranquia;
        private System.Windows.Forms.TextBox txtTriPercTabTributo;
        private System.Windows.Forms.TextBox txtDescTabTributo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTriPercTabTributo;
        private System.Windows.Forms.Label lblCodigoFilial;
        private System.Windows.Forms.Label lblcodigoRomaneio;
        private System.Windows.Forms.Label lblDescTabTributo;
        private System.Windows.Forms.Label lblCodigoMatrizFranquia;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label lblCodTabTributo;
        private System.Windows.Forms.TextBox txtCodigoEmpresa;
        private System.Windows.Forms.TextBox txtCodigoFilial;
        private System.Windows.Forms.TextBox txtCodTabTributo;
        private System.Windows.Forms.MaskedTextBox txtcodigoRomaneio;
        private System.Windows.Forms.TextBox txtCodigoMatrizFranquia;
        private System.Windows.Forms.Label lblInfTabTributo;
        private System.Windows.Forms.Button btnQuerry;
        private System.Windows.Forms.CheckBox checkBoxInstZeroousembackup;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Button btnArquivoAux;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnPontoMdf;
        private System.Windows.Forms.RadioButton rbtnPontoBak;
        private System.Windows.Forms.GroupBox groupBoxInstZero;
        private System.Windows.Forms.Label lblTabelaTributo;
        private System.Windows.Forms.Label lblTabelaFilial;
        private System.Windows.Forms.Label lblTabelaEmpresa;
        private System.Windows.Forms.DataGridView divTabelaTributo;
        private System.Windows.Forms.DataGridView divTabelaFilial;
        private System.Windows.Forms.DataGridView divTabelaEmpresa;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultarTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZAO_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERCENTUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_TRIBUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_FANTASIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIL_FRANQUIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIL_CODIGO_FRANQUIA;
        private System.Windows.Forms.TextBox txtDiretorioBuscar;
        private System.Windows.Forms.Label lblCaminhoBak;
        private System.Windows.Forms.Button btnDiretorioBuscar;
        private System.Windows.Forms.DataGridView dgVLogicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogicalName;
    }
}

