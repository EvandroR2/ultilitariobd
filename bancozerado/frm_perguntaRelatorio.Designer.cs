﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRamodeAtuacao = new System.Windows.Forms.TextBox();
            this.lblRamodeAtuacao = new System.Windows.Forms.Label();
            this.btnOkfrmRelatorio = new System.Windows.Forms.Button();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
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
            this.gBoxNFEeVenda.Location = new System.Drawing.Point(16, 111);
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
            this.rbtNfeNao.TabIndex = 7;
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
            this.rbtNfeSim.TabIndex = 6;
            this.rbtNfeSim.TabStop = true;
            this.rbtNfeSim.Text = "Sim";
            this.rbtNfeSim.UseVisualStyleBackColor = true;
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
            this.rbtnotaManualNao.TabIndex = 5;
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
            this.rbtnotaManualSim.TabIndex = 4;
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
            this.checkTransferencia.TabIndex = 11;
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
            this.checkDevClientes.TabIndex = 9;
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
            this.checkDevFornecedor.TabIndex = 10;
            this.checkDevFornecedor.Text = "Devolucao Fornecedor";
            this.checkDevFornecedor.UseVisualStyleBackColor = true;
            this.checkDevFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkDevFornecedor_KeyPress);
            // 
            // checkVenda
            // 
            this.checkVenda.AutoSize = true;
            this.checkVenda.Checked = true;
            this.checkVenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkVenda.Location = new System.Drawing.Point(6, 19);
            this.checkVenda.Name = "checkVenda";
            this.checkVenda.Size = new System.Drawing.Size(57, 17);
            this.checkVenda.TabIndex = 8;
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
            this.txtParticipantes.Location = new System.Drawing.Point(203, 77);
            this.txtParticipantes.Name = "txtParticipantes";
            this.txtParticipantes.Size = new System.Drawing.Size(345, 29);
            this.txtParticipantes.TabIndex = 3;
            this.txtParticipantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParticipantes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Quais Participantes ?";
            // 
            // txtRamodeAtuacao
            // 
            this.txtRamodeAtuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRamodeAtuacao.Location = new System.Drawing.Point(203, 42);
            this.txtRamodeAtuacao.Name = "txtRamodeAtuacao";
            this.txtRamodeAtuacao.Size = new System.Drawing.Size(345, 29);
            this.txtRamodeAtuacao.TabIndex = 2;
            this.txtRamodeAtuacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRamodeAtuacao_KeyPress);
            // 
            // lblRamodeAtuacao
            // 
            this.lblRamodeAtuacao.AutoSize = true;
            this.lblRamodeAtuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamodeAtuacao.Location = new System.Drawing.Point(12, 42);
            this.lblRamodeAtuacao.Name = "lblRamodeAtuacao";
            this.lblRamodeAtuacao.Size = new System.Drawing.Size(125, 24);
            this.lblRamodeAtuacao.TabIndex = 55;
            this.lblRamodeAtuacao.Text = "Qual  Ramo ?";
            // 
            // btnOkfrmRelatorio
            // 
            this.btnOkfrmRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkfrmRelatorio.Location = new System.Drawing.Point(976, 499);
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
            this.txtTecnico.Location = new System.Drawing.Point(203, 7);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(345, 29);
            this.txtTecnico.TabIndex = 1;
            this.txtTecnico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTecnico_KeyPress);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(12, 7);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(139, 24);
            this.lblMsg.TabIndex = 53;
            this.lblMsg.Text = "Qual Técnico ?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservacoes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(364, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 368);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Particularidades";
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
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(10, 50);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(203, 302);
            this.txtObservacoes.TabIndex = 61;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(601, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 368);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Particularidades";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton6);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(8, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(217, 302);
            this.groupBox5.TabIndex = 63;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eti";
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(6, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(205, 31);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Imp. foi config na Matriz e tbm vai fazer nas lojas";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Não possui imp. de etiqueta.";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(6, 82);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(205, 31);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "Não possui um modelo de etiqueta ou suprimentos no momento para configuração.";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(6, 45);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(205, 31);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Text = "A imp. de Etiqueta ainda será comprada.";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.Location = new System.Drawing.Point(6, 119);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(205, 31);
            this.radioButton6.TabIndex = 12;
            this.radioButton6.Text = "A configuração de etiqueta é realizada direto na loja.";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton5);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.radioButton9);
            this.groupBox6.Controls.Add(this.radioButton8);
            this.groupBox6.Controls.Add(this.radioButton7);
            this.groupBox6.Controls.Add(this.radioButton10);
            this.groupBox6.Location = new System.Drawing.Point(838, 111);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(231, 368);
            this.groupBox6.TabIndex = 64;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Retirada de Funcionario";
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(6, 170);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(219, 31);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.Text = "Forma de pagamento crediario s/ comissão";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.Location = new System.Drawing.Point(6, 133);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(219, 31);
            this.radioButton7.TabIndex = 11;
            this.radioButton7.Text = "Forma de pagamento outros c/ comissão";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.Location = new System.Drawing.Point(6, 96);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(219, 31);
            this.radioButton8.TabIndex = 10;
            this.radioButton8.Text = "Forma de pagamento outros s/ comissão";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Checked = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 73);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(151, 17);
            this.radioButton9.TabIndex = 9;
            this.radioButton9.Text = "Não Trabalha com retirada";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.Location = new System.Drawing.Point(6, 207);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(219, 31);
            this.radioButton10.TabIndex = 8;
            this.radioButton10.Text = "Forma de pagamento crediario c/ comissão";
            this.radioButton10.UseVisualStyleBackColor = true;
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
            // frm_perguntaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 550);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxNFEeVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParticipantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRamodeAtuacao);
            this.Controls.Add(this.lblRamodeAtuacao);
            this.Controls.Add(this.btnOkfrmRelatorio);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.lblMsg);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRamodeAtuacao;
        private System.Windows.Forms.Label lblRamodeAtuacao;
        private System.Windows.Forms.Button btnOkfrmRelatorio;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton10;
    }
}