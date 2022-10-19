using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;

namespace bancozerado
{
    public partial class frm_perguntaRelatorio : Form
    {
        clsapoio clsapoio = new clsapoio();
        public frm_perguntaRelatorio()
        {
            InitializeComponent();
        }


        private void frm_perguntaRelatorio_Load(object sender, EventArgs e)
        {
            txtNomedoCliente.Focus();
        }

        private void txtNomedoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTecnico.Focus();
            }
            
        }

        private void txtTecnico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtRamodeAtuacao.Focus();
            }
        }

        private void txtRamodeAtuacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtParticipantes.Focus();
            }
        }

        private void txtParticipantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtnotaManualSim.Focus();
            }
        }
        private void rbtnotaManualSim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtNfeSim.Focus();
            }
        }

        private void rbtNfeSim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (rbtNfeSim.Checked)
                {
                    checkVenda.Focus();
                } else
                {
                    txtObservacoes.Focus();
                }
                
            }
        }
        private void rbtNfeSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNfeSim.Checked)
            {
                gBoxNFE.Visible = true;
            }
            else
            {
                gBoxNFE.Visible = false;
            }
        }
        private void checkVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkDevClientes.Focus();
            }
        }

        private void checkDevClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkDevFornecedor.Focus();
            }
        }

        private void checkDevFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkTransferencia.Focus();
            }
        }

        private void checkTransferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtObservacoes.Focus();
            }
        }

        private void txtObservacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtNaopossuiimpressora.Focus();
            }
        }
        private void rbtNaopossuiimpressora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtImpressoraseracomprada.Focus();
            }
        }

        private void rbtImpressoraseracomprada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtNaopossuiSuprimento.Focus();
            }
        }

        private void rbtNaopossuiSuprimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtImpressoraConfigurarnaLoja.Focus();
            }
        }

        private void rbtImpressoraConfigurarnaLoja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtImpvaiSerConfignasLojas.Focus();
            }
        }

        private void rbtImpvaiSerConfignasLojas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtNaoTrabalhacretirada.Focus();
            }
        }

        private void rbtNaoTrabalhacretirada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtTrabalhacretiradaOutrosSemComissao.Focus();
            }
        }

        private void rbtTrabalhacretiradaOutrosSemComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtTrabalhacretiradaOutroscomComissao.Focus();
            }
        }

        private void rbtTrabalhacretiradaOutroscomComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtTrabalhacretiradaCrediariosemComissao.Focus();
            }
        }

        private void rbtTrabalhacretiradaCrediariosemComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                rbtTrabalhacretiradaCrediariocomComissao.Focus();
            }
        }

        private void rbtTrabalhacretiradaCrediariocomComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOkfrmRelatorio.Focus();
            }
        }


        private void btnOkfrmRelatorio_Click(object sender, EventArgs e)
        {
            if ((txtTecnico.Text != "") && (txtParticipantes.Text != "") && (txtRamodeAtuacao.Text != ""))
            {
                clsapoio.auditoriaTexto("Nome do Cliente: " + txtNomedoCliente.Text);
                clsapoio.auditoriaTexto("Técnico: " + txtTecnico.Text);
                clsapoio.auditoriaTexto("Ramo de Atuação: " + txtRamodeAtuacao.Text);
                clsapoio.auditoriaTexto("Participantes: " + txtParticipantes.Text);

                clsapoio.auditoriaTexto("\n");
                clsapoio.auditoriaTexto("Informações da loja \n");
                clsapoio.auditoriaTexto("A loja vai Trabalhar com Nota manual? ");
                if (rbtnotaManualSim.Checked)
                {
                    clsapoio.auditoriaTexto("Utiliza na loja a tela de nota Manual.");
                }
                else
                {
                    clsapoio.auditoriaTexto("Não utiliza na loja a tela de nota Manual.");
                }
                clsapoio.auditoriaTexto("\n");
                if (!rbtNfeSim.Checked)
                {
                    clsapoio.auditoriaTexto("Como que sera o processo de NFE? ");
                    clsapoio.auditoriaTexto("Emissão de notas fiscais eletrônicas serão emitidas somente no Retaguarda.");
                }
                else
                {
                    clsapoio.auditoriaTexto("Como que sera o processo de NFE nas lojas? ");
                    if (checkVenda.Checked)
                    {

                        clsapoio.auditoriaTexto("Emissão de NFE de " + checkVenda.Text);
                    }
                    if (checkDevFornecedor.Checked)
                    {
                        clsapoio.auditoriaTexto("Emissão de NFE de " + checkDevFornecedor.Text);
                    }
                    if (checkDevClientes.Checked)
                    {
                        clsapoio.auditoriaTexto("Emissão de NFE de " + checkDevClientes.Text);
                    }
                    if (checkTransferencia.Checked)
                    {
                        clsapoio.auditoriaTexto("Emissão de NFE de " + checkTransferencia.Text);
                    }
                    clsapoio.auditoriaTexto("\n");
                }
                if (txtObservacoes.Text != "")
                {
                    clsapoio.auditoriaTexto("Observações do Clientes: \n");
                    clsapoio.auditoriaTexto(txtObservacoes.Text + "\n");
                }
                clsapoio.auditoriaTexto("Impressora Codigo de Barra: \n");
                if (rbtNaopossuiimpressora.Checked)
                {
                    clsapoio.auditoriaTexto("Cliente não vai trabalhar com Impressora de Codigo de Barra no momento \n");
                }
                if (rbtImpressoraseracomprada.Checked)
                {
                    clsapoio.auditoriaTexto("Cliente ainda vai adquirir uma impressora de Codigo de barra");
                    clsapoio.auditoriaTexto("Indicado as impressora com Linguagem PPLA Argox \n");
                }
                if (rbtNaopossuiSuprimento.Checked)
                {
                    clsapoio.auditoriaTexto("Cliente tem a impressora de Codigo de Barra mas ainda não tem os suprimento para a impressão");
                    clsapoio.auditoriaTexto("Assim que comprar o suprimento fazer contato e agendar o serviço. \n");
                }
                if (rbtImpressoraConfigurarnaLoja.Checked)
                {
                    clsapoio.auditoriaTexto("A impressora vai ser configurada na loja \n");
                }
                if (rbtImpvaiSerConfignasLojas.Checked)
                {
                    clsapoio.auditoriaTexto("A impressora vai ser configurada na Retaguarda e tambem vai ser enviado o layout para as lojas. \n");
                }
                clsapoio.auditoriaTexto("Retirada de funcionario: \n");
                if (rbtNaoTrabalhacretirada.Checked)
                {
                    clsapoio.auditoriaTexto("Cliente não vai trabalhar com retirada de funcionario \n");
                }
                if (rbtTrabalhacretiradaOutrosSemComissao.Checked)
                {
                    clsapoio.auditoriaTexto("Retirada de funcionario vai ser na forma de pagamento Outros sem gerar comissão \n");
                }
                if (rbtTrabalhacretiradaOutroscomComissao.Checked)
                {
                    clsapoio.auditoriaTexto("Retirada de funcionario vai ser na forma de pagamento Outros com comissão \n");
                }
                if (rbtTrabalhacretiradaCrediariosemComissao.Checked)
                {
                    clsapoio.auditoriaTexto("Retirada de funcionario vai ser na forma de pagamento Crédiario sem gerar comissão \n");
                }
                if (rbtTrabalhacretiradaCrediariocomComissao.Checked)
                {
                    clsapoio.auditoriaTexto("Retirada de funcionario vai ser na forma de pagamento Crédiario com comissão \n");
                }




                Close();
            }
            else
            {
                MessageBox.Show("Preencha os campos Vazios");
            }
        }

        
    }
}
