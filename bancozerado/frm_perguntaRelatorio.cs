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
            txtTecnico.Focus();
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
                checkVenda.Focus();
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
                btnOkfrmRelatorio.Focus();
            }
        }

        private void btnOkfrmRelatorio_Click(object sender, EventArgs e)
        {
            if ((txtTecnico.Text != "") && (txtParticipantes.Text != "") && (txtRamodeAtuacao.Text != ""))
            {
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






                Close();
            }
            else
            {
                MessageBox.Show("Preencha os campos Vazios");
            }
        }

        
    }
}
