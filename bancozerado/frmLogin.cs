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
    public partial class frmLogin : Form
    {
        public static bool Cancelar = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string nome = txtUsuario.Text;
                string senha = txtSenha.Text;
                if (CadastroUsuarios.Login(nome, senha))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ERROUUU!!!");
                    txtUsuario.Text = "";
                    txtSenha.Text = "";

                    Close();
                }
            }
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;
            if (CadastroUsuarios.Login(nome, senha))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROUUU!!!");
                txtUsuario.Text = "";
                txtSenha.Text = "";

                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
