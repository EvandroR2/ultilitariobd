using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancozerado
{
    public partial class frm_relatorioservico_reinstalacao : Form
    {
        public frm_relatorioservico_reinstalacao()
        {
            InitializeComponent();
        }

        clsapoio clsapoio = new clsapoio();
        private void frm_relatorioservico_reinstalacao_Load(object sender, EventArgs e)
        {
            txtNomeCliente.Focus();
        }


        private void limpaCampo()
        {
            txtNomeCliente.Text = "";
            txtNomeParticipante.Text = "";
            txtIdSessao.Text = "";
            txtFilial.Text = "";
            txtCodSuporte.Text = "";
            txtImpEtiqueta.Text = "";
            txtImpFiscal.Text = "";
            txtDadosVenda.Text = "";
            txtPedEtiqueta.Text = "";
            txtRomaneioTrans.Text = "";
            checkCBackup.Checked = true;
            checkCImpNfiscal.Checked = true;
            checkTesteEmissao.Checked = true;
            checkCimpCod.Checked = false;
            checkExplCli.Checked = false;
            checkRomaneioTrans.Checked = false;
            checkPedEtiqueta.Checked = false;
            txtImpEtiqueta.Visible = false;
            txtDadosVenda.Clear();
            txtNomeCliente.Focus();
            rbtnLoja.Checked = true;

        }

        #region RadioTipodeSistema

        private void rbtnMatriz_CheckedChanged(object sender, EventArgs e)
        {
            checkCImpNfiscal.Checked = false;
            checkCImpNfiscal.Visible = false;
            checkRomaneioTrans.Checked = false;
            checkRomaneioTrans.Visible = false;
            checkPedEtiqueta.Checked = false;
            checkPedEtiqueta.Visible = false;
            checkTesteEmissao.Checked = false;
            txtDadosVenda.Clear();
        }

        private void rbtnLoja_CheckedChanged(object sender, EventArgs e)
        {
            checkCImpNfiscal.Checked = true;
            checkCImpNfiscal.Visible = true;
            checkRomaneioTrans.Checked = false;
            checkRomaneioTrans.Visible = true;
            checkPedEtiqueta.Checked = false;
            checkPedEtiqueta.Visible = true;
            checkTesteEmissao.Checked = true;
            txtDadosVenda.Clear();
        }

        private void rbtnPontoUnico_CheckedChanged(object sender, EventArgs e)
        {
            checkCImpNfiscal.Checked = true;
            checkCImpNfiscal.Visible = true;
            checkRomaneioTrans.Checked = false;
            checkRomaneioTrans.Visible = true;
            checkPedEtiqueta.Checked = false;
            checkPedEtiqueta.Visible = true;
            checkTesteEmissao.Checked = true;
            txtDadosVenda.Clear();
        }

        #endregion

        #region funcaocheckvisible
        private void checkCBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCBackup.Checked)
            {
                groupBoxSbackup.Visible = false;
            }
            else
            {
                groupBoxSbackup.Visible = true;
            }
        }

        private void checkCImpNfiscal_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkCImpNfiscal.Checked)
            {
                txtImpFiscal.Visible = false;
                lblMarcaeModeloImpFiscal.Visible = false;
            }
            else
            {
                txtImpFiscal.Visible = true;
                lblMarcaeModeloImpFiscal.Visible = true;
            }
        }
        private void checkCimpCod_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkCimpCod.Checked)
            {
                txtImpEtiqueta.Visible = false;
                lblMarcaeModeloImpCodEtiqueta.Visible = false;
            }
            else
            {
                txtImpEtiqueta.Visible = true;
                lblMarcaeModeloImpCodEtiqueta.Visible = true;
            }
        }
        private void checkTesteEmissao_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkTesteEmissao.Checked)
            {
            }
            else
            {
            }
        }

        private void checkExplCli_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkRomaneioTrans_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkRomaneioTrans.Checked)
            {
                txtRomaneioTrans.Visible = false;
            }
            else
            {
                txtRomaneioTrans.Visible = true;
            }
        }

        private void checkPedEtiqueta_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkPedEtiqueta.Checked)
            {
                txtPedEtiqueta.Visible = false;
            }
            else
            {
                txtPedEtiqueta.Visible = true;
            }
        }
        #endregion

        #region FuncaoEnter
        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNomeParticipante.Focus();
            }
        }

        private void txtNomeParticipante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtIdSessao.Focus();
            }
        }

        private void txtIdSessao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkCBackup.Focus();
            }
        }
        private void checkCBackup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtFilial.Focus();
            }
        }

        private void txtFilial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCodSuporte.Focus();
            }
        }

        private void txtCodSuporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkCImpNfiscal.Focus();
            }
        }
        private void checkCImpNfiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (checkCImpNfiscal.Checked)
                {
                    txtImpFiscal.Focus();
                }
                else
                {
                    checkCimpCod.Focus();
                }
            }
        }
        private void txtImpFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkCimpCod.Focus();
            }
        }

        private void checkCimpCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (checkCimpCod.Checked)
                {
                    txtImpEtiqueta.Focus();
                }
                else
                {
                    checkTesteEmissao.Focus();
                }
            }

        }
        private void txtImpEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkTesteEmissao.Focus();
            }
        }
        private void checkTesteEmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (checkCBackup.Checked)
                {
                    txtDadosVenda.Focus();
                }
                else
                {
                    checkExplCli.Focus();
                }
            }
        }
        private void checkExplCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkRomaneioTrans.Focus();
            }
        }
        private void checkRomaneioTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (checkRomaneioTrans.Checked)
                {
                    txtRomaneioTrans.Focus();
                }
                else
                {
                    checkPedEtiqueta.Focus();
                }
            }
        }
        private void txtRomaneioTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkPedEtiqueta.Focus();
            }
        }
        private void checkPedEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (checkPedEtiqueta.Checked)
                {
                    txtPedEtiqueta.Focus();
                }
                else
                {
                    txtDadosVenda.Focus();
                }
            }
        }
        private void txtPedEtiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDadosVenda.Focus();
            }
        }
        private void txtDadosVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnReinstalacaoConfirmar.Focus();

            }
        }
        private void txtDiretorioArquivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnReinstalacaoConfirmar.Focus();

            }
        }

        #endregion





        private void btnReinstalacaoConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == "")
            {
                MessageBox.Show("Campo Obrigatorio");
                txtNomeCliente.Focus();
            }
            else
            {
                if (txtNomeParticipante.Text == "")
                {
                    MessageBox.Show("Campo Obrigatorio");
                    txtNomeParticipante.Focus();
                }
                else
                {
                    if ((!checkCBackup.Checked) && (checkRomaneioTrans.Checked) && (txtRomaneioTrans.Text == ""))
                    {
                        MessageBox.Show("Campo Obrigatorio");
                        txtRomaneioTrans.Focus();

                    }

                    else
                    {
                        if (txtDiretorioArquivo.Text == "")
                        {
                            MessageBox.Show("Campo Obrigatorio");
                            txtDiretorioArquivo.Focus();

                        }
                        else
                        {
                            if ((!checkCBackup.Checked) && (!checkExplCli.Checked))
                            {
                                MessageBox.Show("Importante Explicar ao cliente");

                            }


                            clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Serviço: Reinstalação");
                            clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Nome do Cliente: " + txtNomeCliente.Text);
                            clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Nome do Participante: " + txtNomeParticipante.Text);
                            clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Id da Sessão: " + txtIdSessao.Text);
                            clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"\n");
                            if (rbtnMatriz.Checked)
                            {
                                clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Tipo de Sistema: Matriz");
                            }
                            if (rbtnLoja.Checked)
                            {
                                clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Tipo de Sistema: Loja");
                            }
                            if (rbtnPontoUnico.Checked)
                            {
                                clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Tipo de Sistema: Ponto Unico");
                            }
                            clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Filial: " + txtFilial.Text);
                            clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Codigo do Suporte: " + txtCodSuporte.Text);
                            if (checkCBackup.Checked)
                            {
                                clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Serviço feito com Backup");
                            }
                            else
                            {
                                clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Serviço feito sem Backup");
                                if (checkExplCli.Checked)
                                {
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Cliente avisado que dados foram perdidos como por exemplo:");
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Vendas só poderam ser vista do dia atual da instalação para frente");
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Entrada de mercadoria que foram feita somente do dia atual da instalação para frente");
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"entre outras movimentações tambem foram perdidas");
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"No caso de ter uma Retaguarda, pode ser consultado por lá.");
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Muito Importante:");
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Como que foi explicado que esta sendo feito a instalação sem backup");
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Caso recupere o backup mais a frente, não é possivel fazer importação ou algo do tipo.");
                                }
                                if (checkRomaneioTrans.Checked)
                                {
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Foi pego Romaneio de Transferencia, informação para seguir com a sequencia de numero de transferencia");
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Romaneio: " + txtRomaneioTrans.Text);
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"\n");
                                }
                                if (checkPedEtiqueta.Checked)
                                {
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Foi pego o numero do ultimo pedido de etiqueta.");
                                    clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Pedido de etiqueta: " + txtPedEtiqueta.Text);
                                }
                            }
                            if (checkCImpNfiscal.Checked)
                            {
                                clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Apontado impressora para impressão da venda");
                                clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Impressora: " + txtImpFiscal.Text);

                            }
                            if (checkCimpCod.Checked)
                            {
                                clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Apontado impressora para impressão de Codigo de Barra");
                                clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Impressora: " + txtImpEtiqueta.Text);

                            }
                            if (checkTesteEmissao.Checked)
                            {
                                clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,"Feito teste de venda:");
                            }

                            clsapoio.escreverauditoriaServico(txtDiretorioArquivo,txtNomeCliente ,txtDadosVenda.Text);

                            MessageBox.Show("Arquivo Criado Diretorio: " + txtDiretorioArquivo.Text);
                            var result = MessageBox.Show("Deseja limpar e gerar um novo Arquivo ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                limpaCampo();
                            }
                            else
                            {
                                Close();
                            }
                        }



                    }
                }
            }
        }

        private void btnDiretorioBuscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd1 = new FolderBrowserDialog();

            //Define as propriedades do controle FolderBronserDialog
            fbd1.Description = "Selecione um diretório";
            fbd1.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd1.ShowNewFolderButton = true;

            DialogResult resultado = fbd1.ShowDialog();

            //Exibe a caixa de dialogo
            if (resultado == DialogResult.OK)
            {
                //Exibe a pasta selecionada
                txtDiretorioArquivo.Text = fbd1.SelectedPath;
            }
        }


    }
}
