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
    public partial class frm_relatorioservico : Form
    {
        public frm_relatorioservico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbServico.SelectedIndex == 0)
            {
                frm_relatorioservico_reinstalacao f = new frm_relatorioservico_reinstalacao();
                f.Show();
                Close();
            }
        }

        private void cmbServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                frm_relatorioservico_reinstalacao f = new frm_relatorioservico_reinstalacao();
                f.Show();
                Close();

            }
            
        }
    }
}
