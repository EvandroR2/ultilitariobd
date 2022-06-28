
namespace bancozerado
{
    partial class frm_perguntaRelatorio
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
            this.gBoxNFEeVenda = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtNfeNao = new System.Windows.Forms.RadioButton();
            this.rbtNfeSim = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnotaManualNao = new System.Windows.Forms.RadioButton();
            this.rbtnotaManualSim = new System.Windows.Forms.RadioButton();
            this.gBoxNFE = new System.Windows.Forms.GroupBox();
            this.checkTransferencia = new System.Windows.Forms.CheckBox();
            this.checkDevClientes = new System.Windows.Forms.CheckBox();
            this.checkDevFornecedor = new System.Windows.Forms.CheckBox();
            this.checkVenda = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParticipantes = new System.Windows.Forms.TextBox();
            this.lbmMsgParticipante = new System.Windows.Forms.Label();
            this.txtRamodeAtuacao = new System.Windows.Forms.TextBox();
            this.lblRamodeAtuacao = new System.Windows.Forms.Label();
            this.btnOkfrmRelatorio = new System.Windows.Forms.Button();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.lblMsgTecnico = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtImpressoraConfigurarnaLoja = new System.Windows.Forms.RadioButton();
            this.rbtNaopossuiSuprimento = new System.Windows.Forms.RadioButton();
            this.rbtImpressoraseracomprada = new System.Windows.Forms.RadioButton();
            this.rbtNaopossuiimpressora = new System.Windows.Forms.RadioButton();
            this.rbtImpvaiSerConfignasLojas = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbtTrabalhacretiradaCrediariosemComissao = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtNaoTrabalhacretirada = new System.Windows.Forms.RadioButton();
            this.rbtTrabalhacretiradaOutrosSemComissao = new System.Windows.Forms.RadioButton();
            this.rbtTrabalhacretiradaOutroscomComissao = new System.Windows.Forms.RadioButton();
            this.rbtTrabalhacretiradaCrediariocomComissao = new System.Windows.Forms.RadioButton();
            this.txtNomedoCliente = new System.Windows.Forms.TextBox();
            this.lblMsgCliente = new System.Windows.Forms.Label();
            this.gBoxNFEeVenda.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gBoxNFE.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxNFEeVenda
            // 
            this.gBoxNFEeVenda.Controls.Add(this.groupBox4);
            this.gBoxNFEeVenda.Controls.Add(this.groupBox3);
            this.gBoxNFEeVenda.Controls.Add(this.gBoxNFE);
            this.gBoxNFEeVenda.Controls.Add(this.label4);
            this.gBoxNFEeVenda.Controls.Add(this.label5);
            this.gBoxNFEeVenda.Location = new System.Drawing.Point(16, 148);
            this.gBoxNFEeVenda.Name = "gBoxNFEeVenda";
            this.gBoxNFEeVenda.Size = new System.Drawing.Size(342, 368);
            this.gBoxNFEeVenda.TabIndex = 58;
            this.gBoxNFEeVenda.TabStop = false;
            this.gBoxNFEeVenda.Text = "Dados NFE e Venda";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtNfeNao);
            this.groupBox4.Controls.Add(this.rbtNfeSim);
            this.groupBox4.Location = new System.Drawing.Point(9, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(104, 36);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            // 
            // rbtNfeNao
            // 
            this.rbtNfeNao.AutoSize = true;
            this.rbtNfeNao.Location = new System.Drawing.Point(54, 13);
            this.rbtNfeNao.Name = "rbtNfeNao";
            this.rbtNfeNao.Size = new System.Drawing.Size(45, 17);
            this.rbtNfeNao.TabIndex = 8;
            this.rbtNfeNao.Text = "Não";
            this.rbtNfeNao.UseVisualStyleBackColor = true;
            this.rbtNfeNao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtNfeSim_KeyPress);
            // 
            // rbtNfeSim
            // 
            this.rbtNfeSim.AutoSize = true;
            this.rbtNfeSim.Checked = true;
            this.rbtNfeSim.Location = new System.Drawing.Point(6, 13);
            this.rbtNfeSim.Name = "rbtNfeSim";
            this.rbtNfeSim.Size = new System.Drawing.Size(42, 17);
            this.rbtNfeSim.TabIndex = 7;
            this.rbtNfeSim.TabStop = true;
            this.rbtNfeSim.Text = "Sim";
            this.rbtNfeSim.UseVisualStyleBackColor = true;
            this.rbtNfeSim.CheckedChanged += new System.EventHandler(this.rbtNfeSim_CheckedChanged);
            this.rbtNfeSim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtNfeSim_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnotaManualNao);
            this.groupBox3.Controls.Add(this.rbtnotaManualSim);
            this.groupBox3.Location = new System.Drawing.Point(208, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 36);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            // 
            // rbtnotaManualNao
            // 
            this.rbtnotaManualNao.AutoSize = true;
            this.rbtnotaManualNao.Location = new System.Drawing.Point(54, 13);
            this.rbtnotaManualNao.Name = "rbtnotaManualNao";
            this.rbtnotaManualNao.Size = new System.Drawing.Size(45, 17);
            this.rbtnotaManualNao.TabIndex = 6;
            this.rbtnotaManualNao.Text = "Não";
            this.rbtnotaManualNao.UseVisualStyleBackColor = true;
            this.rbtnotaManualNao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnotaManualSim_KeyPress);
            // 
            // rbtnotaManualSim
            // 
            this.rbtnotaManualSim.AutoSize = true;
            this.rbtnotaManualSim.Checked = true;
            this.rbtnotaManualSim.Location = new System.Drawing.Point(6, 13);
            this.rbtnotaManualSim.Name = "rbtnotaManualSim";
            this.rbtnotaManualSim.Size = new System.Drawing.Size(42, 17);
            this.rbtnotaManualSim.TabIndex = 5;
            this.rbtnotaManualSim.TabStop = true;
            this.rbtnotaManualSim.Text = "Sim";
            this.rbtnotaManualSim.UseVisualStyleBackColor = true;
            this.rbtnotaManualSim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnotaManualSim_KeyPress);
            // 
            // gBoxNFE
            // 
            this.gBoxNFE.Controls.Add(this.checkTransferencia);
            this.gBoxNFE.Controls.Add(this.checkDevClientes);
            this.gBoxNFE.Controls.Add(this.checkDevFornecedor);
            this.gBoxNFE.Controls.Add(this.checkVenda);
            this.gBoxNFE.Location = new System.Drawing.Point(10, 112);
            this.gBoxNFE.Name = "gBoxNFE";
            this.gBoxNFE.Size = new System.Drawing.Size(291, 126);
            this.gBoxNFE.TabIndex = 52;
            this.gBoxNFE.TabStop = false;
            this.gBoxNFE.Text = "Tipo NFE";
            // 
            // checkTransferencia
            // 
            this.checkTransferencia.AutoSize = true;
            this.checkTransferencia.Location = new System.Drawing.Point(6, 88);
            this.checkTransferencia.Name = "checkTransferencia";
            this.checkTransferencia.Size = new System.Drawing.Size(91, 17);
            this.checkTransferencia.TabIndex = 12;
            this.checkTransferencia.Text = "Transferencia";
            this.checkTransferencia.UseVisualStyleBackColor = true;
            this.checkTransferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkTransferencia_KeyPress);
            // 
            // checkDevClientes
            // 
            this.checkDevClientes.AutoSize = true;
            this.checkDevClientes.Location = new System.Drawing.Point(6, 42);
            this.checkDevClientes.Name = "checkDevClientes";
            this.checkDevClientes.Size = new System.Drawing.Size(216, 17);
            this.checkDevClientes.TabIndex = 10;
            this.checkDevClientes.Text = "Troca clientes (DEVOLUCAO CLIENTE)";
            this.checkDevClientes.UseVisualStyleBackColor = true;
            this.checkDevClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkDevClientes_KeyPress);
            // 
            // checkDevFornecedor
            // 
            this.checkDevFornecedor.AutoSize = true;
            this.checkDevFornecedor.Location = new System.Drawing.Point(6, 65);
            this.checkDevFornecedor.Name = "checkDevFornecedor";
            this.checkDevFornecedor.Size = new System.Drawing.Size(135, 17);
            this.checkDevFornecedor.TabIndex = 11;
            this.checkDevFornecedor.Text = "Devolucao Fornecedor";
            this.checkDevFornecedor.UseVisualStyleBackColor = true;
            this.checkDevFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkDevFornecedor_KeyPress);
            // 
            // checkVenda
            // 
            this.checkVenda.AutoSize = true;
            this.checkVenda.Location = new System.Drawing.Point(6, 19);
            this.checkVenda.Name = "checkVenda";
            this.checkVenda.Size = new System.Drawing.Size(57, 17);
            this.checkVenda.TabIndex = 9;
            this.checkVenda.Text = "Venda";
            this.checkVenda.UseVisualStyleBackColor = true;
            this.checkVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkVenda_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Emite NFE nas lojas e quais tipos?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 24);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nota manual no PDV?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 57;
            // 
            // txtParticipantes
            // 
            this.txtParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipantes.Location = new System.Drawing.Point(203, 114);
            this.txtParticipantes.Name = "txtParticipantes";
            this.txtParticipantes.Size = new System.Drawing.Size(345, 29);
            this.txtParticipantes.TabIndex = 4;
            this.txtParticipantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParticipantes_KeyPress);
            // 
            // lbmMsgParticipante
            // 
            this.lbmMsgParticipante.AutoSize = true;
            this.lbmMsgParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmMsgParticipante.Location = new System.Drawing.Point(12, 114);
            this.lbmMsgParticipante.Name = "lbmMsgParticipante";
            this.lbmMsgParticipante.Size = new System.Drawing.Size(185, 24);
            this.lbmMsgParticipante.TabIndex = 56;
            this.lbmMsgParticipante.Text = "Quais Participantes ?";
            // 
            // txtRamodeAtuacao
            // 
            this.txtRamodeAtuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRamodeAtuacao.Location = new System.Drawing.Point(203, 79);
            this.txtRamodeAtuacao.Name = "txtRamodeAtuacao";
            this.txtRamodeAtuacao.Size = new System.Drawing.Size(345, 29);
            this.txtRamodeAtuacao.TabIndex = 3;
            this.txtRamodeAtuacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRamodeAtuacao_KeyPress);
            // 
            // lblRamodeAtuacao
            // 
            this.lblRamodeAtuacao.AutoSize = true;
            this.lblRamodeAtuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamodeAtuacao.Location = new System.Drawing.Point(12, 79);
            this.lblRamodeAtuacao.Name = "lblRamodeAtuacao";
            this.lblRamodeAtuacao.Size = new System.Drawing.Size(125, 24);
            this.lblRamodeAtuacao.TabIndex = 55;
            this.lblRamodeAtuacao.Text = "Qual  Ramo ?";
            // 
            // btnOkfrmRelatorio
            // 
            this.btnOkfrmRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkfrmRelatorio.Location = new System.Drawing.Point(976, 536);
            this.btnOkfrmRelatorio.Name = "btnOkfrmRelatorio";
            this.btnOkfrmRelatorio.Size = new System.Drawing.Size(93, 39);
            this.btnOkfrmRelatorio.TabIndex = 60;
            this.btnOkfrmRelatorio.Text = "OK";
            this.btnOkfrmRelatorio.UseVisualStyleBackColor = true;
            this.btnOkfrmRelatorio.Click += new System.EventHandler(this.btnOkfrmRelatorio_Click);
            // 
            // txtTecnico
            // 
            this.txtTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTecnico.Location = new System.Drawing.Point(203, 44);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(345, 29);
            this.txtTecnico.TabIndex = 2;
            this.txtTecnico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTecnico_KeyPress);
            // 
            // lblMsgTecnico
            // 
            this.lblMsgTecnico.AutoSize = true;
            this.lblMsgTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTecnico.Location = new System.Drawing.Point(12, 44);
            this.lblMsgTecnico.Name = "lblMsgTecnico";
            this.lblMsgTecnico.Size = new System.Drawing.Size(139, 24);
            this.lblMsgTecnico.TabIndex = 53;
            this.lblMsgTecnico.Text = "Qual Técnico ?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservacoes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(364, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 368);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Particularidades";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(10, 50);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(203, 302);
            this.txtObservacoes.TabIndex = 13;
            this.txtObservacoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacoes_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Descreva observações:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(601, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 368);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Particularidades";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtImpressoraConfigurarnaLoja);
            this.groupBox5.Controls.Add(this.rbtNaopossuiSuprimento);
            this.groupBox5.Controls.Add(this.rbtImpressoraseracomprada);
            this.groupBox5.Controls.Add(this.rbtNaopossuiimpressora);
            this.groupBox5.Controls.Add(this.rbtImpvaiSerConfignasLojas);
            this.groupBox5.Location = new System.Drawing.Point(8, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(217, 302);
            this.groupBox5.TabIndex = 63;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eti";
            // 
            // rbtImpressoraConfigurarnaLoja
            // 
            this.rbtImpressoraConfigurarnaLoja.Location = new System.Drawing.Point(6, 119);
            this.rbtImpressoraConfigurarnaLoja.Name = "rbtImpressoraConfigurarnaLoja";
            this.rbtImpressoraConfigurarnaLoja.Size = new System.Drawing.Size(205, 31);
            this.rbtImpressoraConfigurarnaLoja.TabIndex = 17;
            this.rbtImpressoraConfigurarnaLoja.Text = "A configuração de etiqueta é realizada direto na loja.";
            this.rbtImpressoraConfigurarnaLoja.UseVisualStyleBackColor = true;
            this.rbtImpressoraConfigurarnaLoja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtImpressoraConfigurarnaLoja_KeyPress);
            // 
            // rbtNaopossuiSuprimento
            // 
            this.rbtNaopossuiSuprimento.Location = new System.Drawing.Point(6, 82);
            this.rbtNaopossuiSuprimento.Name = "rbtNaopossuiSuprimento";
            this.rbtNaopossuiSuprimento.Size = new System.Drawing.Size(205, 31);
            this.rbtNaopossuiSuprimento.TabIndex = 16;
            this.rbtNaopossuiSuprimento.Text = "Não possui um modelo de etiqueta ou suprimentos no momento para configuração.";
            this.rbtNaopossuiSuprimento.UseVisualStyleBackColor = true;
            this.rbtNaopossuiSuprimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtNaopossuiSuprimento_KeyPress);
            // 
            // rbtImpressoraseracomprada
            // 
            this.rbtImpressoraseracomprada.Location = new System.Drawing.Point(6, 45);
            this.rbtImpressoraseracomprada.Name = "rbtImpressoraseracomprada";
            this.rbtImpressoraseracomprada.Size = new System.Drawing.Size(205, 31);
            this.rbtImpressoraseracomprada.TabIndex = 15;
            this.rbtImpressoraseracomprada.Text = "A imp. de Etiqueta ainda será comprada.";
            this.rbtImpressoraseracomprada.UseVisualStyleBackColor = true;
            this.rbtImpressoraseracomprada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtImpressoraseracomprada_KeyPress);
            // 
            // rbtNaopossuiimpressora
            // 
            this.rbtNaopossuiimpressora.AutoSize = true;
            this.rbtNaopossuiimpressora.Checked = true;
            this.rbtNaopossuiimpressora.Location = new System.Drawing.Point(6, 22);
            this.rbtNaopossuiimpressora.Name = "rbtNaopossuiimpressora";
            this.rbtNaopossuiimpressora.Size = new System.Drawing.Size(159, 17);
            this.rbtNaopossuiimpressora.TabIndex = 14;
            this.rbtNaopossuiimpressora.TabStop = true;
            this.rbtNaopossuiimpressora.Text = "Não possui imp. de etiqueta.";
            this.rbtNaopossuiimpressora.UseVisualStyleBackColor = true;
            this.rbtNaopossuiimpressora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtNaopossuiimpressora_KeyPress);
            // 
            // rbtImpvaiSerConfignasLojas
            // 
            this.rbtImpvaiSerConfignasLojas.Location = new System.Drawing.Point(6, 156);
            this.rbtImpvaiSerConfignasLojas.Name = "rbtImpvaiSerConfignasLojas";
            this.rbtImpvaiSerConfignasLojas.Size = new System.Drawing.Size(205, 31);
            this.rbtImpvaiSerConfignasLojas.TabIndex = 18;
            this.rbtImpvaiSerConfignasLojas.Text = "Imp. foi config na Matriz e tbm vai fazer nas lojas";
            this.rbtImpvaiSerConfignasLojas.UseVisualStyleBackColor = true;
            this.rbtImpvaiSerConfignasLojas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtImpvaiSerConfignasLojas_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Etiqueta Cod. de Barra";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbtTrabalhacretiradaCrediariosemComissao);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.rbtNaoTrabalhacretirada);
            this.groupBox6.Controls.Add(this.rbtTrabalhacretiradaOutrosSemComissao);
            this.groupBox6.Controls.Add(this.rbtTrabalhacretiradaOutroscomComissao);
            this.groupBox6.Controls.Add(this.rbtTrabalhacretiradaCrediariocomComissao);
            this.groupBox6.Location = new System.Drawing.Point(838, 148);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(231, 368);
            this.groupBox6.TabIndex = 64;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Retirada de Funcionario";
            // 
            // rbtTrabalhacretiradaCrediariosemComissao
            // 
            this.rbtTrabalhacretiradaCrediariosemComissao.Location = new System.Drawing.Point(6, 170);
            this.rbtTrabalhacretiradaCrediariosemComissao.Name = "rbtTrabalhacretiradaCrediariosemComissao";
            this.rbtTrabalhacretiradaCrediariosemComissao.Size = new System.Drawing.Size(219, 31);
            this.rbtTrabalhacretiradaCrediariosemComissao.TabIndex = 22;
            this.rbtTrabalhacretiradaCrediariosemComissao.Text = "Forma de pagamento crediario s/ comissão";
            this.rbtTrabalhacretiradaCrediariosemComissao.UseVisualStyleBackColor = true;
            this.rbtTrabalhacretiradaCrediariosemComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtTrabalhacretiradaCrediariosemComissao_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Retirada de Funcionario";
            // 
            // rbtNaoTrabalhacretirada
            // 
            this.rbtNaoTrabalhacretirada.AutoSize = true;
            this.rbtNaoTrabalhacretirada.Checked = true;
            this.rbtNaoTrabalhacretirada.Location = new System.Drawing.Point(6, 73);
            this.rbtNaoTrabalhacretirada.Name = "rbtNaoTrabalhacretirada";
            this.rbtNaoTrabalhacretirada.Size = new System.Drawing.Size(151, 17);
            this.rbtNaoTrabalhacretirada.TabIndex = 19;
            this.rbtNaoTrabalhacretirada.TabStop = true;
            this.rbtNaoTrabalhacretirada.Text = "Não Trabalha com retirada";
            this.rbtNaoTrabalhacretirada.UseVisualStyleBackColor = true;
            this.rbtNaoTrabalhacretirada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtNaoTrabalhacretirada_KeyPress);
            // 
            // rbtTrabalhacretiradaOutrosSemComissao
            // 
            this.rbtTrabalhacretiradaOutrosSemComissao.Location = new System.Drawing.Point(6, 96);
            this.rbtTrabalhacretiradaOutrosSemComissao.Name = "rbtTrabalhacretiradaOutrosSemComissao";
            this.rbtTrabalhacretiradaOutrosSemComissao.Size = new System.Drawing.Size(219, 31);
            this.rbtTrabalhacretiradaOutrosSemComissao.TabIndex = 20;
            this.rbtTrabalhacretiradaOutrosSemComissao.Text = "Forma de pagamento outros s/ comissão";
            this.rbtTrabalhacretiradaOutrosSemComissao.UseVisualStyleBackColor = true;
            this.rbtTrabalhacretiradaOutrosSemComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtTrabalhacretiradaOutrosSemComissao_KeyPress);
            // 
            // rbtTrabalhacretiradaOutroscomComissao
            // 
            this.rbtTrabalhacretiradaOutroscomComissao.Location = new System.Drawing.Point(6, 133);
            this.rbtTrabalhacretiradaOutroscomComissao.Name = "rbtTrabalhacretiradaOutroscomComissao";
            this.rbtTrabalhacretiradaOutroscomComissao.Size = new System.Drawing.Size(219, 31);
            this.rbtTrabalhacretiradaOutroscomComissao.TabIndex = 21;
            this.rbtTrabalhacretiradaOutroscomComissao.Text = "Forma de pagamento outros c/ comissão";
            this.rbtTrabalhacretiradaOutroscomComissao.UseVisualStyleBackColor = true;
            this.rbtTrabalhacretiradaOutroscomComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtTrabalhacretiradaOutroscomComissao_KeyPress);
            // 
            // rbtTrabalhacretiradaCrediariocomComissao
            // 
            this.rbtTrabalhacretiradaCrediariocomComissao.Location = new System.Drawing.Point(6, 207);
            this.rbtTrabalhacretiradaCrediariocomComissao.Name = "rbtTrabalhacretiradaCrediariocomComissao";
            this.rbtTrabalhacretiradaCrediariocomComissao.Size = new System.Drawing.Size(219, 31);
            this.rbtTrabalhacretiradaCrediariocomComissao.TabIndex = 23;
            this.rbtTrabalhacretiradaCrediariocomComissao.Text = "Forma de pagamento crediario c/ comissão";
            this.rbtTrabalhacretiradaCrediariocomComissao.UseVisualStyleBackColor = true;
            this.rbtTrabalhacretiradaCrediariocomComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtTrabalhacretiradaCrediariocomComissao_KeyPress);
            // 
            // txtNomedoCliente
            // 
            this.txtNomedoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomedoCliente.Location = new System.Drawing.Point(203, 9);
            this.txtNomedoCliente.Name = "txtNomedoCliente";
            this.txtNomedoCliente.Size = new System.Drawing.Size(345, 29);
            this.txtNomedoCliente.TabIndex = 1;
            this.txtNomedoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomedoCliente_KeyPress);
            // 
            // lblMsgCliente
            // 
            this.lblMsgCliente.AutoSize = true;
            this.lblMsgCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgCliente.Location = new System.Drawing.Point(12, 9);
            this.lblMsgCliente.Name = "lblMsgCliente";
            this.lblMsgCliente.Size = new System.Drawing.Size(167, 24);
            this.lblMsgCliente.TabIndex = 66;
            this.lblMsgCliente.Text = "Nome do Cliente ?";
            // 
            // frm_perguntaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 586);
            this.ControlBox = false;
            this.Controls.Add(this.txtNomedoCliente);
            this.Controls.Add(this.lblMsgCliente);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxNFEeVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParticipantes);
            this.Controls.Add(this.lbmMsgParticipante);
            this.Controls.Add(this.txtRamodeAtuacao);
            this.Controls.Add(this.lblRamodeAtuacao);
            this.Controls.Add(this.btnOkfrmRelatorio);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.lblMsgTecnico);
            this.Name = "frm_perguntaRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_perguntaRelatorio_Load);
            this.gBoxNFEeVenda.ResumeLayout(false);
            this.gBoxNFEeVenda.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gBoxNFE.ResumeLayout(false);
            this.gBoxNFE.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxNFEeVenda;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtNfeNao;
        private System.Windows.Forms.RadioButton rbtNfeSim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnotaManualNao;
        private System.Windows.Forms.RadioButton rbtnotaManualSim;
        private System.Windows.Forms.GroupBox gBoxNFE;
        private System.Windows.Forms.CheckBox checkTransferencia;
        private System.Windows.Forms.CheckBox checkDevClientes;
        private System.Windows.Forms.CheckBox checkDevFornecedor;
        private System.Windows.Forms.CheckBox checkVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParticipantes;
        private System.Windows.Forms.Label lbmMsgParticipante;
        private System.Windows.Forms.TextBox txtRamodeAtuacao;
        private System.Windows.Forms.Label lblRamodeAtuacao;
        private System.Windows.Forms.Button btnOkfrmRelatorio;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Label lblMsgTecnico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtImpressoraConfigurarnaLoja;
        private System.Windows.Forms.RadioButton rbtNaopossuiSuprimento;
        private System.Windows.Forms.RadioButton rbtImpressoraseracomprada;
        private System.Windows.Forms.RadioButton rbtNaopossuiimpressora;
        private System.Windows.Forms.RadioButton rbtImpvaiSerConfignasLojas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbtTrabalhacretiradaCrediariosemComissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtNaoTrabalhacretirada;
        private System.Windows.Forms.RadioButton rbtTrabalhacretiradaOutrosSemComissao;
        private System.Windows.Forms.RadioButton rbtTrabalhacretiradaOutroscomComissao;
        private System.Windows.Forms.RadioButton rbtTrabalhacretiradaCrediariocomComissao;
        private System.Windows.Forms.TextBox txtNomedoCliente;
        private System.Windows.Forms.Label lblMsgCliente;
    }
}