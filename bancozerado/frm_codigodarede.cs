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


namespace bancozerado
{
    public partial class frm_codigodarede : Form
    {
        public frm_codigodarede()
        {
            InitializeComponent();
        }
        

        public string InstanciaSql { get; set; }

        public string UsuarioSql { get; set; }

        public string SenhaSql { get; set; }

        public string BancoSql { get; set; }

        public string redeSql { get; set; }


        clsapoio clsapoio = new clsapoio();
        

        

        private void frm_codigodarede_Load(object sender, EventArgs e)
        {
             
            clsapoio.nomeInstancia = InstanciaSql;
            clsapoio.nomeUsuario = UsuarioSql;
            clsapoio.nomeSenha = SenhaSql;
            clsapoio.Bdbanco = BancoSql;


            try

            {
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = null;
                clsapoio.stringBDBD();
                adaptador = new SqlDataAdapter("SELECT emp_codigo,LEFT (EMP_RAZAO_SOCIAL,15) FROM EMPRESAS", clsapoio.conn);
                adaptador.Fill(dados);
                    foreach (DataRow linha in dados.Rows)
                    {
                        dGV_empresa.Rows.Add(linha.ItemArray);

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                clsapoio.desconectarBD();
            }
        }
        private void btn_ok_rede_Click(object sender, EventArgs e)
        {
            if (dGV_empresa.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vazio");
            }
            else
            {
                
                redeSql = dGV_empresa.SelectedRows[0].Cells[0].Value.ToString();
                Close();


            }
        }



    }
}

