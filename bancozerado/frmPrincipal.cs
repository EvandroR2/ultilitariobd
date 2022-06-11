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
using System.IO;

namespace bancozerado
{
    public partial class frmPrincipal : Form
    {
        clsapoio clsapoio = new clsapoio();
        public frmPrincipal()
        {
            InitializeComponent();
        }


        //Chama o Formulario de login
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            frmLogin f = new frmLogin();

            while (CadastroUsuarios.UsuarioLogado == null)
            {
                Visible = false;
                f.ShowDialog();

                if (frmLogin.Cancelar)
                {
                    Application.Exit();
                    return;

                }

            }

            Visible = true;
        }
        //Mensagem sobre versao
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvedor: Evandro  \n" + "Contato: Implantacao  \n" + "Versão 0.0.1");
        }

        //BUSCANDO INFORMAÇÕES DO BANCO DE DADOS
        private void carregaBanco()
        {
            clsapoio.nomeInstancia = txtInstancia.Text;
            clsapoio.nomeUsuario = txtUsuario.Text;
            clsapoio.nomeSenha = txtSenha.Text;
            clsapoio.Bdbanco = cmbBanco.Text;

            try
            {
                clsapoio.stringBD();
                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases where name not in ('master', 'model', 'tempdb', 'msdb') and name not like('%ReportServer$PDVNET%')", clsapoio.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cmbBanco.DisplayMember = "name";
                cmbBanco.DataSource = dt;
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

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                carregaBanco();
            }
        }


        private void btnConectar_Click(object sender, EventArgs e)
        {
            //if (cmbBanco.Text != "")
            //{
            //    try
            //    {
            //        clsapoio.stringBDBD();
            //        lblResultado.Text = "Conectado";



            //    }

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString(), "Encontro Inicial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        lblResultado.Text = "ERRO ! \n" + ex;

            //    }
            //    finally
            //    {
            //        clsapoio.desconectarBD();
            //        lblResultado.Text = "Conectado";
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Preencha o banco de dados");
            //}
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void cmbBanco_Click(object sender, EventArgs e)
        {
            carregaBanco();
        }


        #region Botao_radio
        private void RbtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            cmbBanco.Text = "";
            txtInstancia.Text = @".\pdvnet";
            txtUsuario.Text = "sa";
            txtSenha.Text = @"inter#system";
            carregaBanco();
            cmbBanco.Enabled = true;
        }

        private void rbtnAzure1_CheckedChanged(object sender, EventArgs e)
        {
            cmbBanco.Text = "";
            txtInstancia.Text = "azure1.pdvnet.com.br";
            txtUsuario.Text = "implantacao.relatorio";
            txtSenha.Text = @"2nbUrWD)rb}D";
            carregaBanco();
            cmbBanco.Enabled = true;
        }

        private void rbtnAzure2_CheckedChanged(object sender, EventArgs e)
        {
            cmbBanco.Text = "";
            txtInstancia.Text = "azure2.pdvnet.com.br";
            txtUsuario.Text = "implantacao.relatorio";
            txtSenha.Text = @"2nbUrWD)rb}D";
            carregaBanco();
            cmbBanco.Enabled = true;
        }

        private void rbtnUolHost_CheckedChanged(object sender, EventArgs e)
        {
            cmbBanco.Text = "";
            txtInstancia.Text = "servidor1.pdvnet.com.br";
            txtUsuario.Text = "implantacao.relatorio";
            txtSenha.Text = @"2nbUrWD)rb}D";
            carregaBanco();
            cmbBanco.Enabled = true;
        }

        #endregion


        //instalacao de banco zero

        private void checkBoxFranquia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFranquia.Checked)
            {
                lblCodigoMatrizFranquia.Enabled = true;
                lblCodigoMatrizFranquia.Visible = true;
                txtCodigoMatrizFranquia.Enabled = true;
                txtCodigoMatrizFranquia.Visible = true;
                lblInfTabTributo.Enabled = true;
                lblInfTabTributo.Visible = true;
                lblCodTabTributo.Enabled = true;
                lblCodTabTributo.Visible = true;
                lblDescTabTributo.Enabled = true;
                lblDescTabTributo.Visible = true;
                lblTriPercTabTributo.Enabled = true;
                lblTriPercTabTributo.Visible = true;
                txtCodTabTributo.Enabled = true;
                txtCodTabTributo.Visible = true;
                txtDescTabTributo.Enabled = true;
                txtDescTabTributo.Visible = true;
                txtTriPercTabTributo.Enabled = true;
                txtTriPercTabTributo.Visible = true;

            }
            else
            {
                lblCodigoMatrizFranquia.Enabled = false;
                lblCodigoMatrizFranquia.Visible = false;
                txtCodigoMatrizFranquia.Enabled = false;
                txtCodigoMatrizFranquia.Visible = false;
                lblInfTabTributo.Enabled = false;
                lblInfTabTributo.Visible = false;
                lblCodTabTributo.Enabled = false;
                lblCodTabTributo.Visible = false;
                lblDescTabTributo.Enabled = false;
                lblDescTabTributo.Visible = false;
                lblTriPercTabTributo.Enabled = false;
                lblTriPercTabTributo.Visible = false;
                txtCodTabTributo.Enabled = false;
                txtCodTabTributo.Visible = false;
                txtDescTabTributo.Enabled = false;
                txtDescTabTributo.Visible = false;
                txtTriPercTabTributo.Enabled = false;
                txtTriPercTabTributo.Visible = false;
            }
        }

        private void checkBoxInstZeroousembackup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInstZeroousembackup.Checked)
            {
                groupBoxInstBancoZero.Visible = true;
            }
            else
            {
                groupBoxInstBancoZero.Visible = false;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {


            clsapoio.nomeInstancia = txtInstancia.Text;
            clsapoio.nomeUsuario = txtUsuario.Text;
            clsapoio.nomeSenha = txtSenha.Text;

            string nomedobancoZero = txtnomedoBancoZero.Text;
            string path = txtDiretorio.Text;
            string file = txtArquivo.Text;
            string fileAux = txtArquivoAux.Text;
            if (txtnomedoBancoZero.Text == "")
            {
                MessageBox.Show("Campo Vazio !");
                cmbBanco.Focus();
            }
            else
            {
                if (rbtnPontoBak.Checked)
                {
                    try
                    {
                        clsapoio.stringBD();
                        SqlCommand cmd = new SqlCommand(@"USE [master] RESTORE DATABASE [" + nomedobancoZero + @"] FROM  DISK = N'" + path + @"\" + file + @"' WITH  FILE = 1,  MOVE N'BDLOJA' TO N'C:\BASESQL\" + nomedobancoZero + @".mdf ',  MOVE N'BDLOJA_log' TO N'C:\BASESQL\" + nomedobancoZero + @"_1.ldf',  NOUNLOAD,  STATS = 5", clsapoio.conn);
                        SqlDataReader dr = cmd.ExecuteReader();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        clsapoio.desconectarBD();
                    }
                    try
                    {
                        clsapoio.stringBD();
                        SqlCommand cmd = new SqlCommand(@"USE [master] RESTORE DATABASE [" + nomedobancoZero + @"_AUXILIAR] FROM  DISK = N'" + path + @"\" + fileAux + @"' WITH  FILE = 1,  MOVE N'BDREDMTv3_AUXILIAR_DAT' TO N'C:\BaseSQL\IMPLANTACAO5PDVNET_" + nomedobancoZero + @"_AUXILIAR.mdf',  MOVE N'BDREDMTv3_AUXILIAR_LOG' TO N'C:\BaseSQL\IMPLANTACAO5PDVNET_" + nomedobancoZero + @"_AUXILIAR.ldf',  NOUNLOAD,  STATS = 5", clsapoio.conn);
                        SqlDataReader dr = cmd.ExecuteReader();

                        MessageBox.Show("Banco de dados restaurado " + nomedobancoZero + "\n" + "Banco de dados restaurado " + nomedobancoZero + "_Auxiliar");

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        clsapoio.desconectarBD();

                    }
                    txtnomedoBancoZero.Text = "";
                }
                else
                {
                    try
                    {
                        clsapoio.stringBD();
                        SqlCommand cmd = new SqlCommand(@"USE [master] CREATE DATABASE [" + nomedobancoZero + @"] ON ( FILENAME = N'" + path + @"\" + file + @".mdf'),( FILENAME = N'" + path + @"\" + file + @"_1.ldf' ) FOR ATTACH", clsapoio.conn);
                        SqlDataReader dr = cmd.ExecuteReader();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        clsapoio.desconectarBD();
                    }
                    try
                    {
                        clsapoio.stringBD();
                        SqlCommand cmd = new SqlCommand(@"USE [master] CREATE DATABASE [" + nomedobancoZero + @"_AUXILIAR] ON ( FILENAME = N'" + path + @"\" + fileAux + @".mdf'),( FILENAME = N'" + path + @"\" + fileAux + @".ldf' ) FOR ATTACH", clsapoio.conn);
                        SqlDataReader dr = cmd.ExecuteReader();

                        MessageBox.Show("Banco de dados anexado " + nomedobancoZero + "\n" + "Banco de dados anexado " + nomedobancoZero + "_Auxiliar");

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        clsapoio.desconectarBD();

                    }
                    txtnomedoBancoZero.Text = "";
                }


            }




            #region copiarerestaurar
            //File.Copy(path, pathCombine, true);

            //Task[] tasks0 =
            //    {
            //    Task.Factory.StartNew(() =>
            //    {
            //        File.Copy(path, pathCombine, true);
            //    })

            //    };

            //Task.WaitAll(tasks0);

            //Task[] tasks1 =
            //{

            //    Task.Factory.StartNew(() =>
            //    {
            //        try
            //{
            //    clsapoio.stringBD();
            //    SqlCommand cmd = new SqlCommand(@"USE [master];  RESTORE DATABASE[" + nomedobancoZero + @"] FROM DISK = N'" + pathCombine + "' WITH FILE = 1, NOUNLOAD, STATS = 5; ", clsapoio.conn);
            //    SqlDataReader dr = cmd.ExecuteReader();

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //finally
            //{
            //    clsapoio.desconectarBD();
            //    MessageBox.Show("Banco de dados restaurado " + nomedobancoZero);
            //}

            //    })

            //    };

            //Task.WaitAll(tasks1);

            //File.Copy(path, pathCombine, true);

            #endregion
            #region antigo

            //    Task[] tasks0 =
            //        {
            //        Task.Factory.StartNew(() =>
            //        {
            //            File.Copy(path, pathCombine, true);
            //        })

            //        };

            //    Task.WaitAll(tasks0);

            //    Task[] tasks1 =
            //    {

            //        Task.Factory.StartNew(() =>
            //        {
            //            try
            //                {
            //                    clsapoio.stringBD();
            //                    SqlCommand cmd = new SqlCommand(@"USE [master];  RESTORE DATABASE[" + nomedobancoZero + @"] FROM DISK = N'" + pathCombine + "' WITH FILE = 1, NOUNLOAD, STATS = 5; ", clsapoio.conn);
            //                    SqlDataReader dr = cmd.ExecuteReader();

            //                }

            //                catch (Exception ex)
            //                {
            //                    MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                }
            //                finally
            //                {
            //                    clsapoio.desconectarBD();
            //                    MessageBox.Show("Banco de dados restaurado " + nomedobancoZero);
            //                }

            //        })

            //        };

            //    Task.WaitAll(tasks1);

            //    Task[] tasks2 =
            //        {
            //        Task.Factory.StartNew(() =>
            //        {
            //            try
            //            {
            //                clsapoio.stringBD();

            //                SqlCommand cmd = new SqlCommand(@"USE [master]; BACKUP DATABASE [" + nomedobancoZero + @"] TO DISK = N'C:\basesql\" + nomedobancoZero + "dataehora" +  @".bak' WITH NOFORMAT, NOINIT, NAME = N'" + nomedobancoZero + @" - Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10;", clsapoio.conn);
            //                SqlDataReader dr1 = cmd.ExecuteReader();


            //            }

            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            }
            //            finally
            //            {
            //                clsapoio.desconectarBD();

            //            }
            //        })

            //        };

            //    Task.WaitAll(tasks2);

            //    Task[] tasks3 =
            //        {
            //        Task.Factory.StartNew(() =>
            //        {

            //            try
            //            {
            //                clsapoio.stringBD();

            //                SqlCommand cmd = new SqlCommand(@"EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + nomedobancoZero + "' USE [master];", clsapoio.conn);
            //                SqlDataReader dr1 = cmd.ExecuteReader();


            //            }

            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            }
            //            finally
            //            {
            //                clsapoio.desconectarBD();
            //            }
            //            try
            //            {
            //                clsapoio.stringBD();

            //                SqlCommand cmd1 = new SqlCommand(@"DROP DATABASE [" + nomedobancoZero + "];", clsapoio.conn);
            //                SqlDataReader dr = cmd1.ExecuteReader();

            //            }

            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            }
            //            finally
            //            {
            //                clsapoio.desconectarBD();
            //                MessageBox.Show("Banco de dados Deletado " + nomedobancoZero);
            //            }
            //        })

            //        };

            //    Task.WaitAll(tasks3);

            //    Task[] tasks4 =
            //        {
            //        Task.Factory.StartNew(() =>
            //        {
            //            try
            //            {
            //                clsapoio.stringBD();
            //                SqlCommand cmd = new SqlCommand(@"USE [master];  RESTORE DATABASE[" + nomedobancoZero + @"] FROM DISK = N'" + pathCombine + "' WITH FILE = 1, NOUNLOAD, STATS = 5; ", clsapoio.conn);
            //                SqlDataReader dr = cmd.ExecuteReader();

            //            }

            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            }
            //            finally
            //            {
            //                clsapoio.desconectarBD();
            //                MessageBox.Show("Banco de dados restaurado " + nomedobancoZero);
            //            }
            //        })

            //        };

            //    Task.WaitAll(tasks4);
            #endregion

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            clsapoio.nomeInstancia = txtInstancia.Text;
            clsapoio.nomeUsuario = txtUsuario.Text;
            clsapoio.nomeSenha = txtSenha.Text;
            string nomedobancoZero = cmbBanco.Text;
            var result = MessageBox.Show("Tem certeza que voce vai deletar o banco de dados?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (cmbBanco.SelectedItem == null)
                {
                    MessageBox.Show("Campo Vazio !");
                    cmbBanco.Focus();
                }
                else
                {
                    if (rbtnPontoBak.Checked)
                    {
                        try
                        {
                            clsapoio.stringBD();

                            SqlCommand cmd1 = new SqlCommand(@"EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'" + nomedobancoZero + "' USE [master] DROP DATABASE [" + nomedobancoZero + "]", clsapoio.conn);
                            SqlDataReader dr1 = cmd1.ExecuteReader();

                            MessageBox.Show("Banco de dados Deletado " + nomedobancoZero);

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
                    else
                    {
                        try
                        {
                            clsapoio.stringBD();

                            SqlCommand cmd1 = new SqlCommand(@"USE [master] ALTER DATABASE [" + nomedobancoZero + "] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE USE [master] EXEC master.dbo.sp_detach_db @dbname = N'" + nomedobancoZero + "', @skipchecks = 'false'", clsapoio.conn);
                            SqlDataReader dr1 = cmd1.ExecuteReader();

                            MessageBox.Show("Banco de dados Desanexado " + nomedobancoZero);
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

                }



            }


        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            clsapoio.nomeInstancia = txtInstancia.Text;
            clsapoio.nomeUsuario = txtUsuario.Text;
            clsapoio.nomeSenha = txtSenha.Text;

            string nomedobancoZero = cmbBanco.Text;
            string pathBackup = txtDiretorioBkp.Text;
            //string dataHora = DateTime.Now.ToString();
            DateTime dta = DateTime.Now;
            string dtaStr = dta.ToString("dd" + "MM" + "yyyy" + "HH"); //data formatada to string

            if (cmbBanco.SelectedItem == null)
            {
                MessageBox.Show("Campo Vazio !");
                cmbBanco.Focus();
            }
            else
            {
                try
                {
                    clsapoio.stringBD();

                    SqlCommand cmd1 = new SqlCommand(@"USE [master]; BACKUP DATABASE [" + nomedobancoZero + @"] TO DISK = N'" + pathBackup + @"\" + nomedobancoZero + dtaStr + @".bak' WITH NOFORMAT, NOINIT, NAME = N'" + nomedobancoZero + @" - Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10;", clsapoio.conn);
                    SqlDataReader dr1 = cmd1.ExecuteReader();

                    MessageBox.Show("Feito Backup do Banco de dados " + nomedobancoZero + "\n" + "Diretorio " + pathBackup + @"\" + nomedobancoZero + dtaStr + @".bak");

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







        }

        private void btnDiretorio_Click(object sender, EventArgs e)
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
                txtDiretorio.Text = fbd1.SelectedPath;
            }
        }

        private void btnDiretorioBkp_Click(object sender, EventArgs e)
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
                txtDiretorio.Text = fbd1.SelectedPath;
            }
        }

        private void btnQuerry_Click(object sender, EventArgs e)
        {
            clsapoio.nomeInstancia = txtInstancia.Text;
            clsapoio.nomeUsuario = txtUsuario.Text;
            clsapoio.nomeSenha = txtSenha.Text;
            clsapoio.Bdbanco = cmbBanco.Text;

            string codigoEmpresa = txtCodigoEmpresa.Text;
            string nomeEmpresa = txtNomeEmpresa.Text;
            string codigoFilial = txtCodigoFilial.Text;
            string nomedobancoZero = txtnomedoBancoZero.Text;
            string codigoRomaneio = txtcodigoRomaneio.Text;
            string codigoMatrizFranquia = txtCodigoMatrizFranquia.Text;
            string codTributacao = txtCodTabTributo.Text;
            string descTributacao = txtDescTabTributo.Text;
            string percTributacao = txtTriPercTabTributo.Text;
            var result = MessageBox.Show("Ja verificou o ultimo numero de transferencia?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (cmbBanco.SelectedItem == null)
                {
                    MessageBox.Show("Campo Vazio !");
                    cmbBanco.Focus();
                }
                else
                {
                    if (!checkBoxFranquia.Checked)
                    {
                        if ((txtCodigoEmpresa.Text != "") && (txtNomeEmpresa.Text != "") && (txtCodigoFilial.Text != "") && (txtcodigoRomaneio.Text != ""))
                        {
                            #region bancodedadosproprios
                            Task[] tasks0 =
                                {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"delete from empresas", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks0);
                            Task[] tasks1 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"insert into empresas (emp_codigo,emp_razao_social) values ('" + codigoEmpresa + "','" + nomeEmpresa + "')", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks1);
                            Task[] tasks2 =
                                {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"delete from filial", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks2);
                            Task[] tasks3 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"insert into filial values ('" + codigoFilial + "','" + nomedobancoZero + "','ISENTO','','N','',0,'" + codigoEmpresa + "','','.','',0,0,'" + nomedobancoZero + "',0,0,0,NULL,1,0,1,0,'','','',1,1,1,0,0,1,1,'',1,0,1,0,'',1,2,3,0,1,1,0,0,1,1,1,0,0,0,'','',0,0,0,0,0,0,0,'4132',0,'-1',0,0,'0000000000000002',3,1,'20-05-2022',1,1,0,1,0,0,0,1,'00987654',0,0,0,0,0,1,0,0,'',0,0,0,'',0,0)", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks3);
                            Task[] tasks4 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"delete from registros where reg_tipo = 11 and reg_filial = '" + codigoFilial + "'", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks4);
                            Task[] tasks5 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"insert into REGISTROS values (11,'" + codigoRomaneio + "','" + codigoFilial + "')", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();

                             MessageBox.Show("Empresa: ('" + codigoEmpresa + "','" + nomeEmpresa + "')  \n Filial: ('" + codigoFilial + "', RAZAO_SOCIAL = '" + nomedobancoZero + "', EMPRESA = '" + codigoEmpresa + "') \n Transferencia: ('" + codigoRomaneio + "') \n FIM", "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks5);



                            checkBoxInstZeroousembackup.Checked = false;
                            #endregion
                        }
                        else
                        {
                            MessageBox.Show("Campo Vazio !");
                            txtCodigoEmpresa.Focus();
                        }



                    }
                    else
                    {
                        if ((txtCodigoEmpresa.Text != "") && (txtNomeEmpresa.Text != "") && (txtCodigoFilial.Text != "") && (txtcodigoRomaneio.Text != "") && (txtCodigoMatrizFranquia.Text != "") && (txtCodTabTributo.Text != "") && (txtDescTabTributo.Text != "") && (txtTriPercTabTributo.Text != ""))
                        {
                            #region bancodedadosfranquia
                            Task[] tasks0 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"delete from empresas", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks0);
                            Task[] tasks1 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"insert into empresas (emp_codigo,emp_razao_social) values ('" + codigoEmpresa + "','" + nomeEmpresa + "')", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };
                            Task.WaitAll(tasks1);
                            Task[] tasks2 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"delete from filial", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks2);


                            Task[] tasks3 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"insert into filial values ('" + codigoFilial + "','" + nomedobancoZero + "','ISENTO','','N','',0,'" + codigoEmpresa + "','','.','',0,0,'" + nomedobancoZero + "',0,1," + codigoMatrizFranquia + ",NULL,1,0,1,0,'','','',1,1,1,0,0,1,1,'',1,0,1,0,'',1,2,3,0,1,1,0,0,1,1,1,0,0,0,'','',0,0,0,0,0,0,0,'4132',0,'-1',0,0,'0000000000000002',3,1,'20-05-2022',1,1,0,1,0,0,0,1,'00987654',0,0,0,0,0,1,0,0,'',0,0,0,'',0,0)", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks3);
                            Task[] tasks4 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"delete from registros where reg_tipo = 11 and reg_filial = '" + codigoFilial + "'", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks4);
                            Task[] tasks5 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"insert into REGISTROS values (11,'" + codigoRomaneio + "','" + codigoFilial + "')", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks5);
                            Task[] tasks6 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"delete from franquiaconf where fra_filial = '" + codigoFilial + "'", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks6);
                            Task[] tasks7 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"delete from FRANQUIACONF)", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks7);
                            Task[] tasks8 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"delete GERENCIAL  where ger_codigo = '04'", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks8);
                            Task[] tasks9 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"insert into GERENCIAL values ('04','(+) CREDITOS')", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks9);
                            Task[] tasks10 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"delete from TABELATRIBUTO", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks10);
                            Task[] tasks11 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"insert into TABELATRIBUTO values ('" + codTributacao + "','" + descTributacao + "','0','01-01-2000','01-01-2000','00987654','0','" + percTributacao + "')", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();



                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks11);
                            Task[] tasks12 =
                                    {
                    Task.Factory.StartNew(() =>
                    {
                        try
                            {
                                clsapoio.stringBDBD();

                                SqlCommand cmd1 = new SqlCommand(@"insert into FRANQUIACONF values ('" + codigoFilial + "', '1','1','0',GETDATE())", clsapoio.conn);
                                SqlDataReader dr1 = cmd1.ExecuteReader();

                            MessageBox.Show("Empresa: ('" + codigoEmpresa + "','" + nomeEmpresa + "')  \n Filial: ('" + codigoFilial + "', RAZAO_SOCIAL = '" + nomedobancoZero + "', EMPRESA = '" + codigoEmpresa + "') \n Transferencia: ('" + codigoRomaneio + "') \n Franquiaconf: OK \n Classificacao Gerencial: OK \n TABELATRIBUTO: ('" + codTributacao + ",'" + descTributacao + "',0,'01-01-2000','01-01-2000','00987654','0','" + percTributacao + "') FIM", "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                            }

                        catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        finally
                            {
                                clsapoio.desconectarBD();
                            }
                    })

                    };

                            Task.WaitAll(tasks12);




                            checkBoxInstZeroousembackup.Checked = false;
                            #endregion
                        }
                        else
                        {
                            MessageBox.Show("Campo Vazio !");
                            txtCodigoEmpresa.Focus();
                        }

                    }
                }
            }
            else
            {
                txtcodigoRomaneio.Focus();
            }

        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {


            if (rbtnPontoBak.Checked)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Abrir Arquivo BAK ...";
                dialog.Filter = "text file|*.bak";
                DialogResult result = dialog.ShowDialog();


                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    if (File.Exists(dialog.FileName))
                    {
                        FileInfo file = new FileInfo(dialog.FileName);
                        Text = Application.ProductName + " - " + file.Name;

                        Gerenciador.FolderPath = file.DirectoryName + "\\";
                        Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                        Gerenciador.FileExt = file.Extension;

                        try
                        {
                            txtArquivo.Text = file.Name.Remove(file.Name.LastIndexOf(".")) + file.Extension;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao Abrir Arquivo: \n" + ex.Message);
                        }
                        finally
                        {
                            MessageBox.Show("Arquivo adicionado");
                        }


                    }
                }

            }
            else
            {
                OpenFileDialog dialogmdf = new OpenFileDialog();
                dialogmdf.Title = "Abrir Arquivo MDF ...";
                dialogmdf.Filter = "text file|*.mdf";
                DialogResult resultmdf = dialogmdf.ShowDialog();


                if (resultmdf != DialogResult.Cancel && resultmdf != DialogResult.Abort)
                {
                    if (File.Exists(dialogmdf.FileName))
                    {
                        FileInfo file = new FileInfo(dialogmdf.FileName);
                        Text = Application.ProductName + " - " + file.Name;

                        Gerenciador.FolderPath = file.DirectoryName + "\\";
                        Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                        Gerenciador.FileExt = file.Extension;

                        try
                        {
                            txtArquivo.Text = file.Name.Remove(file.Name.LastIndexOf("."));

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao Abrir Arquivo: \n" + ex.Message);
                        }
                        finally
                        {
                            MessageBox.Show("Arquivo adicionado");
                        }


                    }
                }
            }

        }

        private void btnArquivoAux_Click(object sender, EventArgs e)
        {



            if (rbtnPontoBak.Checked)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Abrir ...";
                dialog.Filter = "text file|*.bak";
                DialogResult result = dialog.ShowDialog();


                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    if (File.Exists(dialog.FileName))
                    {
                        FileInfo file = new FileInfo(dialog.FileName);
                        Text = Application.ProductName + " - " + file.Name;

                        Gerenciador.FolderPath = file.DirectoryName + "\\";
                        Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                        Gerenciador.FileExt = file.Extension;

                        try
                        {
                            txtArquivoAux.Text = file.Name.Remove(file.Name.LastIndexOf(".")) + file.Extension;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao Abrir Arquivo: \n" + ex.Message);
                        }
                        finally
                        {
                            MessageBox.Show("Arquivo adicionado");
                        }


                    }
                }
            }
            else
            {
                OpenFileDialog dialogmdf = new OpenFileDialog();
                dialogmdf.Title = "Abrir ...";
                dialogmdf.Filter = "text file|*.mdf";
                DialogResult resultmdf = dialogmdf.ShowDialog();


                if (resultmdf != DialogResult.Cancel && resultmdf != DialogResult.Abort)
                {
                    if (File.Exists(dialogmdf.FileName))
                    {
                        FileInfo file = new FileInfo(dialogmdf.FileName);
                        Text = Application.ProductName + " - " + file.Name;

                        Gerenciador.FolderPath = file.DirectoryName + "\\";
                        Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                        Gerenciador.FileExt = file.Extension;

                        try
                        {
                            txtArquivoAux.Text = file.Name.Remove(file.Name.LastIndexOf("."));

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao Abrir Arquivo: \n" + ex.Message);
                        }
                        finally
                        {
                            MessageBox.Show("Arquivo adicionado");
                        }


                    }
                }
            }

        }

        private void rbtnPontoBak_CheckedChanged(object sender, EventArgs e)
        {
            lblInforme.Text = "Informe o nome do arquivo \".bak\"";
            lblInformeAux.Text = "Informe o nome do arquivo Auxiliar \".bak\"";
            txtArquivo.Text = "Loja_ZeroV1005.bak";
            txtArquivoAux.Text = "V1005_AUXILIAR.bak";
            btnRestaurar.Text = "Restaurar";
            btnDeletar.Text = "Deletar";
            checkBoxInstZeroousembackup.Visible = true;

        }

        private void rbtnPontoMdf_CheckedChanged(object sender, EventArgs e)
        {
            lblInforme.Text = "Informe o nome do arquivo \".mdf\"";
            lblInformeAux.Text = "Informe o nome do arquivo Auxiliar \".mdf\"";
            txtArquivo.Text = "";
            txtArquivoAux.Text = "";
            btnRestaurar.Text = "Anexar";
            btnDeletar.Text = "Desanexar";
            checkBoxInstZeroousembackup.Checked = false;
            checkBoxInstZeroousembackup.Visible = false;

        }

        private void btnConsultarTabela_Click(object sender, EventArgs e)
        {
            clsapoio.nomeInstancia = txtInstancia.Text;
            clsapoio.nomeUsuario = txtUsuario.Text;
            clsapoio.nomeSenha = txtSenha.Text;
            clsapoio.Bdbanco = cmbBanco.Text;

            divTabelaEmpresa.Rows.Clear();
            divTabelaFilial.Rows.Clear();
            divTabelaTributo.Rows.Clear();
            string queryempresa = "select emp_codigo,emp_razao_social from empresas";
            string queryfilial = "select fil_codigo,fil_razao_social,fil_franquia,fil_codigo_franquia from filial";
            string querytributo = "select tat_codigo,tat_descricao,tat_valor from tabelatributo";
            try
            {
                clsapoio.stringBDBD();
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(queryempresa, clsapoio.conn);
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    divTabelaEmpresa.Rows.Add(linha.ItemArray);
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
            try
            {
                clsapoio.stringBDBD();
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(queryfilial, clsapoio.conn);
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    divTabelaFilial.Rows.Add(linha.ItemArray);
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
            try
            {
                clsapoio.stringBDBD();
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(querytributo, clsapoio.conn);
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    divTabelaTributo.Rows.Add(linha.ItemArray);
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
    }
}



