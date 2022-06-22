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
using System.Diagnostics;
using System.Management;
using System.Management.Instrumentation;

namespace bancozerado
{
    public partial class frmPrincipal : Form
    {
        clsapoio clsapoio = new clsapoio();


        public frmPrincipal()
        {
            InitializeComponent();
        }


        #region frm_superior
        //Chama o Formulario de login
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Process aProcess = Process.GetCurrentProcess();
            string aProcName = aProcess.ProcessName;

            if (Process.GetProcessesByName(aProcName).Length > 1)
            {
                MessageBox.Show("O programa já está em execução!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

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
            MessageBox.Show("Desenvolvedor: Evandro  \n" + "Contato: Implantacao  \n" + "Versão 1.1.2");
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
                cmbBanco.DataSource = dt;
                cmbBanco.DisplayMember = "name";
                /*
                 * //SqlCommand cmd = new SqlCommand(@"RESTORE FILELISTONLY  from DISK =N'C:\BaseSQL\LOJAFLA\bak0206.bak'", clsapoio.conn);
                cmbBanco.DisplayMember = "LogicalName"; 
                //string num_pedido = ds.Tables[0].Rows[0]["COLUNA DO BD"].ToString();
                 */
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



        private void btnSair_Click(object sender, EventArgs e)
        {

            clsapoio.encerraSistema();

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

        #endregion

        #region page_restaurarbd


        private void btnRestaurar_Click(object sender, EventArgs e)
        {


            clsapoio.nomeInstancia = txtInstancia.Text;
            clsapoio.nomeUsuario = txtUsuario.Text;
            clsapoio.nomeSenha = txtSenha.Text;

            string nomedobancoZero = txtnomedoBancoZero.Text;
            string path = txtDiretorio.Text;
            string pathBuscar = txtDiretorioBuscar.Text;
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
                    //try
                    //{
                    //    clsapoio.stringBD();
                    //    SqlCommand cmd = new SqlCommand(@"RESTORE FILELISTONLY  from DISK =N'" + pathBuscar + @"\" + file +"'", clsapoio.conn);
                    //    SqlDataReader dr = cmd.ExecuteReader();
                    //    if (dr.Read())
                    //    {
                    //        msgBanco = dr.GetString(0);

                    //    }


                    //}

                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                    //finally
                    //{
                    //    clsapoio.desconectarBD();
                    //    lblMsg.Text = msgBanco;
                    //}
                    try
                    {
                        string queryprincipal = @"USE [master] RESTORE DATABASE [" + nomedobancoZero + @"] FROM  DISK = N'" + pathBuscar + @"\" + file + @"' WITH  FILE = 1,  MOVE N'BDLOJA' TO N'" + path + @"\" + nomedobancoZero + @".mdf ',  MOVE N'BDLOJA_log' TO N'" + path + @"\" + nomedobancoZero + @"_1.ldf',  NOUNLOAD,  STATS = 5";
                        clsapoio.stringBD();
                        SqlCommand cmd = new SqlCommand(queryprincipal, clsapoio.conn);
                        clsapoio.auditoriaTexto(queryprincipal);
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
                    #region projetoemandamento
                    //try
                    //{
                    //    clsapoio.stringBD();
                    //    SqlDataReader dr = null;
                    //    SqlCommand cmd = new SqlCommand(@"RESTORE FILELISTONLY  from DISK =N'" + pathBuscar + @"\" + fileAux + "'", clsapoio.conn);
                    //    SqlParameter param = new SqlParameter();
                    //    param.ParameterName = "@LogicalName";
                    //    // param.Value = cboCidade.Text;
                    //    cmd.Parameters.Add(param);
                    //    dr = cmd.ExecuteReader();
                    //    if (dr.HasRows)
                    //    {
                    //        while (dr.Read())
                    //        {
                    //            MessageBox.Show(dr.ToString());

                    //        }
                    //    }


                    //    // SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases where name not in ('master', 'model', 'tempdb', 'msdb') and name not like('%ReportServer$PDVNET%')", clsapoio.conn);
                    //    //SqlDataReader dr = cmd.ExecuteReader();
                    //    //if (dr.HasRows)
                    //    //{
                    //    //    while (dr.Read())
                    //    //    {
                    //    //        //MessageBox.Show("Resultado" + dr.GetString(0));
                    //    //        string[,] b1 = 
                    //    //            {
                    //    //            {dr.GetString(0)}

                    //    //            };
                    //    //        MessageBox.Show(b1[0,0]);
                    //    //        //clsapoio.auditoriaTexto(b1);

                    //    //    }
                    //    //}


                    //}

                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                    //finally
                    //{
                    //    clsapoio.desconectarBD();
                    //}

                    #endregion
                    try
                    {
                        string queryauxiliar = @"USE [master] RESTORE DATABASE [" + nomedobancoZero + @"_AUXILIAR] FROM  DISK = N'" + pathBuscar + @"\" + fileAux + @"' WITH  FILE = 1,  MOVE N'BDREDMTv3_AUXILIAR_DAT' TO N'" + path + @"\IMPLANTACAO5PDVNET_" + nomedobancoZero + @"_AUXILIAR.mdf',  MOVE N'BDREDMTv3_AUXILIAR_LOG' TO N'" + path + @"\IMPLANTACAO5PDVNET_" + nomedobancoZero + @"_AUXILIAR.ldf',  NOUNLOAD,  STATS = 5";
                        clsapoio.stringBD();
                        SqlCommand cmd = new SqlCommand(queryauxiliar, clsapoio.conn);
                        clsapoio.auditoriaTexto(queryauxiliar);
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
                    if (path != pathBuscar)
                    {
                        MessageBox.Show("Para Anexar o arquivo MDF o aquivo deve estar na mesma pasta que o diretorio de busca.");
                    }
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
                    if (!RbtnLocal.Checked)
                    {
                        RbtnLocal.Checked = true;
                        MessageBox.Show("Função somente para banco local");
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
                if (!RbtnLocal.Checked)
                {
                    RbtnLocal.Checked = true;
                    MessageBox.Show("Função somente para banco local");
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
                txtDiretorioBuscar.Text = fbd1.SelectedPath;
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
            lblCaminhoBak.Visible = true;
            txtDiretorioBuscar.Visible = true;
            btnDiretorioBuscar.Visible = true;

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
            lblCaminhoBak.Visible = false;
            txtDiretorioBuscar.Visible = false;
            btnDiretorioBuscar.Visible = false;
        }

        //instalacao de banco zero
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
                if (!RbtnLocal.Checked)
                {
                    RbtnLocal.Checked = true;
                    MessageBox.Show("Função somente para banco local");
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

        #endregion

        #region page_consultar_filial
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
            string queryfilial = "select fil_codigo,fil_razao_social,fil_franquia,fil_codigo_franquia,FIL_TRIBUTACAO from filial";
            string querytributo = "select tat_codigo,tat_descricao,tat_valor from tabelatributo";

            if (cmbBanco.SelectedItem == null)
            {
                MessageBox.Show("Campo Vazio !");
                cmbBanco.Focus();
            }
            else
            {
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



        #endregion




        // Balao informativo
        #region balaoinformativo
        private void txtDiretorio_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtDiretorio, "Aqui voce vai colocar o caminho em que o banco vai ser restaurado");
        }

        private void txtDiretorioBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtDiretorioBuscar, "Aqui voce vai colocar o caminho aonde esta o arquivo a ser restaurado");
        }

        private void txtArquivo_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtArquivo, "Arquivo do banco principal para o sistema Anexar ou restaurar");
        }

        private void txtArquivoAux_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtArquivo, "Arquivo do banco Auxiliar para o sistema Anexar ou restaurar");
        }

        private void cmbBanco_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.comboboxmensageminformativo(cmbBanco, "Combo Box para selecionar o banco para executar ou fazer consultas");
        }

        private void txtDiretorioBkp_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtDiretorioBkp, "Aqui voce vai colocar o caminho aonde vai ser feito backup");
        }

        private void txtCodigoEmpresa_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtCodigoEmpresa, "Codigo referente a tabela empresa ou tela rede no sistema");
        }

        private void txtNomeEmpresa_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtNomeEmpresa, "descricao referente a tabela empresa ou tela rede no sistema");
        }

        private void txtCodigoFilial_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtCodigoFilial, "Codigo referente a tabela filial, campo fil_codigo");
        }

        private void txtCodigoMatrizFranquia_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtCodigoFilial, "Codigo referente a tabela filial, campo fil_codigo_franquia");
        }

        private void txtCodTabTributo_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtCodTabTributo, "Codigo referente a tabela tributo, campo fit_codigo");
        }

        private void txtDescTabTributo_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtDescTabTributo, "descricao referente a tabela tributo, campo fit_descricao");
        }

        private void txtTriPercTabTributo_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.textomensageminformativo(txtTriPercTabTributo, "percentual referente a tabela tributo, campo fit_valor");
        }

        private void checkBoxInstZeroousembackup_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.checkboxmensageminformativo(checkBoxInstZeroousembackup, "Aqui voce vai poder inserir informacao para uma instalação do sistema");
        }

        private void checkBoxFranquia_MouseMove(object sender, MouseEventArgs e)
        {
            clsapoio.checkboxmensageminformativo(checkBoxInstZeroousembackup, "Aqui voce vai poder inserir informacao para uma instalação do sistema de franquia");
        }
        #endregion


        #region EncontroInicial_arquivo

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            mArquivoSalvar.Enabled = true;
        }


        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            mArquivoSalvar.Enabled = true;
            Text = Application.ProductName;
        }

        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir ...";
            dialog.Filter = "rich text file|*.rtf|texto|*.txt|todos|*.*";
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

                    StreamReader stream = null;
                    mArquivoSalvar.Enabled = true;
                    try
                    {
                        stream = new StreamReader(file.FullName, true);
                        txtConteudo.Text = stream.ReadToEnd();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Abrir Arquivo: \n" + ex.Message);
                    }
                    finally
                    {
                        stream.Close();
                    }


                }
            }
        }

        private void mArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salvar...";
                dialog.Filter = "rich text file|*.rtf|texto|*.txt|todos|*.*";
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;


                var result = dialog.ShowDialog();
                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SalvarArquivo(dialog.FileName);
                }
            }
        }

        private void mArquivoSalvarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Salvar...";
            dialog.Filter = "rich text file|*.rtf|texto|*.txt|todos|*.*";
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;

            var result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SalvarArquivo(dialog.FileName);
            }
        }
        private void SalvarArquivo(String path)
        {
            ///Objeto responsável oir escrever i arquivo
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path, false);
                writer.Write(txtConteudo.Text);

                FileInfo file = new FileInfo(path);
                Gerenciador.FolderPath = file.DirectoryName + "\\";
                Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                Gerenciador.FileExt = file.Extension;
                mArquivoSalvar.Enabled = false;

                Text = Application.ProductName + " - " + file.Name;


            }
            catch (Exception e)
            {
                MessageBox.Show("Erro Salvar Arquivo: \n" + e.Message);
            }
            finally
            {
                writer.Close();
            }

        }



        #endregion

        #region EncontroInicial_editar

        private void mEditarDesfazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Undo();

        }

        private void mEditarRefazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Redo();
        }

        private void mEditarRecortar_Click(object sender, EventArgs e)
        {
            txtConteudo.Cut();
        }

        private void mEditarCopiar_Click(object sender, EventArgs e)
        {
            txtConteudo.Copy();
        }

        private void mEditarColar_Click(object sender, EventArgs e)
        {
            txtConteudo.Paste();
        }

        private void mEditarExcluir_Click(object sender, EventArgs e)
        {
            txtConteudo.Text = txtConteudo.Text.Remove(txtConteudo.SelectionStart, txtConteudo.SelectedText.Length);
        }

        private void mEditarDataeHora_Click(object sender, EventArgs e)
        {
            int index = txtConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();
            if (txtConteudo.SelectionStart == txtConteudo.Text.Length)
            {
                txtConteudo.Text = txtConteudo.Text + dataHora;
                txtConteudo.SelectionStart = index + dataHora.Length;
                return;

            }

            string temp = "";
            for (int i = 0; i < txtConteudo.Text.Length; i++)
            {
                if (i == txtConteudo.SelectionStart)
                {
                    temp += dataHora;
                    temp += txtConteudo.Text[i];

                }
                else
                {
                    temp += txtConteudo.Text[i];
                }
            }
        }


        #endregion

        #region EncontroInicial_formatar

        private void mFormatarQuebra_Click(object sender, EventArgs e)
        {
            txtConteudo.WordWrap = mFormatarQuebra.Checked;
        }

        private void mFormatarFonte_Click(object sender, EventArgs e)
        {
            FontDialog fonte = new FontDialog();

            fonte.ShowColor = true;
            fonte.ShowEffects = true;
            fonte.Font = txtConteudo.Font;
            fonte.Color = txtConteudo.ForeColor;

            DialogResult result = fonte.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtConteudo.Font = fonte.Font;
                txtConteudo.ForeColor = fonte.Color;
            }



        }


        #endregion


        #region EncontroInicial_Exibir
        private void mExibirZoomApliar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor += 0.1f;
            atualizaZoomStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomReduzir_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor -= 0.1f;
            atualizaZoomStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomRestaurar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor = 1f;
            atualizaZoomStatusBar(txtConteudo.ZoomFactor);
        }
        private void mExibirBarraStatus_Click(object sender, EventArgs e)
        {
            statusBar.Visible = mExibirBarraStatus.Checked;
        }

        private void atualizaZoomStatusBar(float zoom)
        {
            statusBarLabel.Text = $"{Math.Round(zoom * 100)} %";
            //statusBarLabel.Text = (txtConteudo.ZoomFactor += 0.1f).ToString() + "%";
        }


        #endregion

        #region EncontroInicial_ajuda

        private void mAjudaExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IMPLANTACAO PDVNET \n" + "Tel (21) 2159-0606 ");
        }

        private void mAjudaSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvedor: Evandro  \n" + "Contato: Implantacao  \n" + "Versão 1.1.2");
        }

        private void mAjudaLerConfig_Click(object sender, EventArgs e)
        {

            //Depois criar uma classe para essa informação ficar menor
            string ConfigPath = @"c:\pdv\config\";
            string ConfigBase = "BASE.INI";
            string ConfigPDV = "PDV.INI";
            string FimdoArquivo = " \n";
            string TitledoArquivoPDV = "PDV.INI \n ";
            string TitledoArquivoBase = "BASE.INI \n ";



            try
            {
                StreamReader reader = new StreamReader(ConfigPath + ConfigPDV, Encoding.Default);
                string txtPDV = reader.ReadLine();
                //string txtBase += reader.ReadToEnd();

                txtConteudo.Text += TitledoArquivoPDV;

                while (txtPDV != null)
                {
                    txtConteudo.Text += txtPDV + "\n";
                    txtPDV = reader.ReadLine();

                }
                if (reader.EndOfStream)
                {
                    txtConteudo.Text += FimdoArquivo;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Abrir Arquivo: \n" + ex.Message);
            }

            try
            {
                StreamReader reader = new StreamReader(ConfigPath + ConfigBase, Encoding.Default);
                string txtBase = reader.ReadLine();
                //string txtBase += reader.ReadToEnd();
                txtConteudo.Text += TitledoArquivoBase;

                while (txtBase != null)
                {
                    txtConteudo.Text += txtBase + "\n";
                    txtBase = reader.ReadLine();
                }
                if (reader.EndOfStream)
                {
                    txtConteudo.Text += FimdoArquivo;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Abrir Arquivo: \n" + ex.Message);
            }
            //Depois criar uma classe para essa informação ficar menor
        }

        private void mAjudaConsultaBanco_Click(object sender, EventArgs e)
        {
            //Aqui vou chamar a configuração dos formulario e trabalhar com muitas querry
            clsapoio.nomeInstancia = txtInstancia.Text;
            clsapoio.nomeUsuario = txtUsuario.Text;
            clsapoio.nomeSenha = txtSenha.Text;
            clsapoio.Bdbanco = cmbBanco.Text;

            if (cmbBanco.SelectedItem == null)
            {
                MessageBox.Show("Campo Vazio !");
                cmbBanco.Focus();
            }
            else
            {
                if (txtConteudo.Text != "")
                {
                    var result = MessageBox.Show("Exite informação no Bloco de notas deseja apagar ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        txtConteudo.Clear();
                    }

                }


                Task[] exemplo =
            {
                    Task.Factory.StartNew(() =>
                    {
                        MessageBox.Show("Etapa 1");
                        clsapoio.auditoriaTextosubstituir("\n\n");

                    })

                    };

                Task.WaitAll(exemplo);
                toolStripProgressBar.Value = 10;

                Task[] qualTecnico =
                {
                    Task.Factory.StartNew(() =>
                    {
                        clsapoio.auditoriaTexto("Qual Técnico fez o Encontro Inicial");
                        frm_perguntaRelatorio frm = new frm_perguntaRelatorio();
                        frm.ShowDialog();

                    })

                    };

                Task.WaitAll(qualTecnico);
                toolStripProgressBar.Value = 20;

                Task[] nomeEmpresa =
                {
                    Task.Factory.StartNew(() =>
                    {
                        try
            {
                clsapoio.stringBDBD();
                SqlCommand Cmd = new SqlCommand("SELECT LEFT (EMP_RAZAO_SOCIAL,15) FROM EMPRESAS", clsapoio.conn);
                SqlDataReader dr = Cmd.ExecuteReader(); //executa a consulta e le os registros..
                if (dr.HasRows)
                {
                                clsapoio.auditoriaTexto(" \n");
                    while (dr.Read())
                    {

                        clsapoio.auditoriaTexto("Nome da Empresa? " + dr.GetString(0).ToString());

                    }
                    clsapoio.auditoriaTexto(" \n");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                clsapoio.desconectarBD();
                            MessageBox.Show("Criado Arquivo");

            }
                    })

                    };

                Task.WaitAll(nomeEmpresa);
                toolStripProgressBar.Value = 30;


                Task[] InformacaoFilial =
                {
                    Task.Factory.StartNew(() =>
                    {
                        try
            {
                clsapoio.stringBDBD();
                SqlCommand Cmd = new SqlCommand("select fil_codigo,rtrim(fil_razao_social),fil_cgc from filial order by FIL_CODIGO", clsapoio.conn);
                SqlDataReader dr = Cmd.ExecuteReader(); //executa a consulta e le os registros..
                if (dr.HasRows)
                {
                                clsapoio.auditoriaTexto("Quais Filiais estão cadastradas ?");
                    while (dr.Read())
                    {

                        clsapoio.auditoriaTexto("FILIAL:" + dr.GetInt16(0).ToString() + "                 NOME FANTASIA: " + dr.GetString(1) + "                   CNPJ OU CPF: " + dr.GetString(2));

                    }
                    clsapoio.auditoriaTexto("\n\n");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                clsapoio.desconectarBD();
                            MessageBox.Show("Etapa Filial");


            }
                    })

                    };

                Task.WaitAll(InformacaoFilial);
                toolStripProgressBar.Value = 40;

                Task[] entradadeNotas =
                {
                    Task.Factory.StartNew(() =>
                    {
                        MessageBox.Show("Etapa Entrada de notas /n Etapa Pedido de compra");
                        clsapoio.auditoriaTexto("\n\n");

                    })

                    };

                Task.WaitAll(entradadeNotas);
                toolStripProgressBar.Value = 50;

                Task[] regras =
                {
                    Task.Factory.StartNew(() =>
                    {
                        try
            {
                clsapoio.stringBDBD();
                SqlCommand Cmd = new SqlCommand("SELECT (reg_codigo) as CODIGO, left (REG_DESCRICAO, 40) ,CASE WHEN REG_STATUS = 0 THEN 'VAZIO' WHEN REG_STATUS = 1 THEN 'NAO ATIVA' WHEN REG_STATUS = 2 THEN 'ALERTAR' WHEN REG_STATUS = 4 THEN 'REGRA ATIVA' END FROM REGRAS  WHERE REG_STATUS = 4 ORDER BY REG_CODIGO", clsapoio.conn);
                SqlDataReader dr = Cmd.ExecuteReader(); //executa a consulta e le os registros..
                if (dr.HasRows)
                {
                                clsapoio.auditoriaTexto("REGRAS ATIVAS");
                    while (dr.Read())
                    {

                        clsapoio.auditoriaTexto("Codigo: " + dr.GetInt16(0).ToString()+ "   Descricao:  " +  dr.GetString(1) + "      Status:  " + dr.GetString(2));

                    }
                    clsapoio.auditoriaTexto("\n\n");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                clsapoio.desconectarBD();
                            MessageBox.Show("Etapa Regras");


            }
                        clsapoio.auditoriaTexto("\n\n");
                    })

                    };

                Task.WaitAll(regras);
                toolStripProgressBar.Value = 60;

                Task[] usuarios =
                {
                    Task.Factory.StartNew(() =>
                    {
                        try
            {
                clsapoio.stringBDBD();
                SqlCommand Cmd = new SqlCommand("SELECT US_ABREVIADO AS USUARIO, LEFT (FIL_RAZAO_SOCIAL,15) AS LOJA,  LEFT  (REPLACE (REPLACE(US_GERAL2,'0','NAO') ,'1','SIM') ,3) AS GERAL FROM USUARIOS INNER JOIN FILIAL ON (FIL_CODIGO = US_FILIAL)WHERE FIL_ATIVA <> 'M' ORDER BY LOJA", clsapoio.conn);
                SqlDataReader dr = Cmd.ExecuteReader(); //executa a consulta e le os registros..
                if (dr.HasRows)
                {
                                clsapoio.auditoriaTexto("Usuarios?");
                                clsapoio.auditoriaTexto("Atenção: O cadastro de usuários só pode ser realizado através do sistema Retaguarda e as senhas devem ser informadas ao usuários para que possam alterar a mesma caso tenham permissão");
                    while (dr.Read())
                    {

                        clsapoio.auditoriaTexto("Nome: " + dr.GetString(0) + "              Filial:  " +  dr.GetString(1) + "             Geral:  " + dr.GetString(2));

                    }
                    clsapoio.auditoriaTexto("\n\n");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "FACILITA IMPLANTAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                clsapoio.desconectarBD();
                            MessageBox.Show("Etapa Usuarios");


            }
                        clsapoio.auditoriaTexto("\n\n");
                    })

                    };

                Task.WaitAll(usuarios);
                toolStripProgressBar.Value = 70;

                Task[] obssobreRequisitos =
                {
                    Task.Factory.StartNew(() =>
                    {
                        MessageBox.Show("");
                        clsapoio.auditoriaTexto("REQUISITOS MINIMOS PARA FUNCIONAR O SISTEMA PDVNET");
                        clsapoio.auditoriaTexto("Windows 10 ou Superior.");
                        clsapoio.auditoriaTexto("Net Framework 4.5.2");
                        clsapoio.auditoriaTexto("Internet funcionando.");
                        clsapoio.auditoriaTexto("Usuário e senha com direito de administrador.");
                        clsapoio.auditoriaTexto("O Certificado Digital deve estar instalado. ");
                        clsapoio.auditoriaTexto("Todas as impressoras de etiqueta, fiscal ou não fiscal devem estar instaladas e testadas. ");
                        clsapoio.auditoriaTexto("Processador – Dual Core ou superior. ");
                        clsapoio.auditoriaTexto("HD - 120 GB livres.");
                        clsapoio.auditoriaTexto("Memória - 8 GB.  ");
                        clsapoio.auditoriaTexto("Resolução de Vídeo - igual ou superior a 1024x768(Não suporta netbook).  ");
                        clsapoio.auditoriaTexto("Porta de comunicação e USBs testadas.");
                        clsapoio.auditoriaTexto("\n");

                        clsapoio.auditoriaTexto("REQUISITOS MÍNIMOS PARA NFe / NFCe / Sistema");
                        clsapoio.auditoriaTexto("Certificado Digital tipo A1 ou A3 já instalados e testados no computador  (No certificado A3 a senha não fica gravada e sempre será solicitada). ");
                        clsapoio.auditoriaTexto("Estar credenciado para emissão de NFe junto a SEFAZ. ");
                        clsapoio.auditoriaTexto("Disponibilizar informações tributárias, Regime, Tributações (PIS e Cofins), CSOSN, CNAE, CSC, CFOP, Substituição tributária, etc. ");
                        clsapoio.auditoriaTexto("\n");

                        clsapoio.auditoriaTexto("DICAS IMPORTANTES");
                        clsapoio.auditoriaTexto("Atenção: Verifique sempre na Nota fiscal de compra se os produtos possuem substituição tributária e configure essa tributação no cadastro do produto. Mantendo a tributação correta no cadastro do produto, não acarretará encargos tributários desnecessários. Consulte sua contabilidade!  ");
                        clsapoio.auditoriaTexto("Atenção: Não deixe de fazer notas fiscais eletrônicas das mercadorias devolvidas pelos clientes para não acarretar encargos tributários desnecessários. Consulte sua contabilidade!");
                        clsapoio.auditoriaTexto("Não se esqueça de fazer sempre o Backup do sistema em mídia externa para garantir a disponibilidade dos seus dados.");
                        clsapoio.auditoriaTexto("Zele pelos equipamentos, fazendo uma manutenção preventiva contra vírus. ");
                        clsapoio.auditoriaTexto("Se precisar tirar alguma dúvida ou resolver algum problema, ligue para o Suporte (21) 2159-0606. ");

                        clsapoio.auditoriaTexto("Confira sempre se os requisitos mínimos estão atendendo antes de instalar o sistema nas lojas");
                        clsapoio.auditoriaTexto("");
                        clsapoio.auditoriaTexto("");
                        clsapoio.auditoriaTexto("");
                        clsapoio.auditoriaTexto("");
                        clsapoio.auditoriaTexto("");

                        clsapoio.auditoriaTexto("");
                        clsapoio.auditoriaTexto("");
                        clsapoio.auditoriaTexto("");
                        clsapoio.auditoriaTexto("");
                        clsapoio.auditoriaTexto("");
                        clsapoio.auditoriaTexto("");

                    })

                    };

                Task.WaitAll(obssobreRequisitos);
                toolStripProgressBar.Value = 80;

                Task[] infoharware =
                {
                    Task.Factory.StartNew(() =>
                    {

                        clsapoio.auditoriaTexto("INFORMAÇÕES TÉCNICAS DO SERVIDOR");
                        clsapoio.auditoriaTexto("Nunca deixe de executar e conferir se o backup do banco de dados está sendo realizado com sucesso, ele não é de autoria da PDV NET Sistemas.");
                        clsapoio.auditoriaTexto("Em caso de dúvidas de como fazer o backup, entre em contato com o nosso Suporte para esclarecimentos.");
                        clsapoio.auditoriaTexto("Informacoes relacionadas ao Nome do Computador : " + Environment.MachineName);
                        clsapoio.auditoriaTexto("Informacoes relacionadas ao Processador: " + Environment.ProcessorCount + "N de nucleo");
                        clsapoio.auditoriaTexto("Informacoes relacionadas ao Hard Disk");
                        string Consulta = "SELECT MaxCapacity FROM Win32_PhysicalMemoryArray";
                        int memoriaRam = 0;
                        ManagementObjectSearcher objetoPesquisado = new ManagementObjectSearcher(Consulta);
                        foreach (ManagementObject WniPART in objetoPesquisado.Get())
                            {
                             UInt32 tamanhoKB = Convert.ToUInt32(WniPART.Properties["MaxCapacity"].Value);
                             UInt32 tamanhoMB = tamanhoKB / 1024;
                             memoriaRam += Convert.ToInt32(tamanhoMB);
                            clsapoio.auditoriaTexto("Informacoes relacionadas a memoria Ram " + tamanhoMB + "Mb");
                            }

                        clsapoio.auditoriaTexto("\n\n");
                        MessageBox.Show("Etapa Info Hadware");

                    })

                    };

                Task.WaitAll(infoharware);
                toolStripProgressBar.Value = 90;

                Task[] finalcomestilo =
                {
                    Task.Factory.StartNew(() =>
                    {
                        clsapoio.auditoriaTexto("PDV NET LOCACAO DE SISTEMAS DE INFORMATICA LTDA - EPP");
                        clsapoio.auditoriaTexto(@"CNPJ: 06.910.563/0001-01");
                        clsapoio.auditoriaTexto("Endereço: Av. Rio Branco, 251/11º andar - Centro - Rio de Janeiro.");
                        clsapoio.auditoriaTexto("CEP: 20040-009");
                        clsapoio.auditoriaTexto("Tel: (21) 2159-0606");
                        clsapoio.auditoriaTexto("\n");
                        clsapoio.auditoriaTexto("Supervisor de Implantação: Evandro Barroso ");
                        clsapoio.auditoriaTexto("Email: implantacao@pdvnet.com.br");
                        clsapoio.auditoriaTexto("Tel: (21) 96775-4275 (Vivo) \n");

                    })

                    };

                Task.WaitAll(finalcomestilo);
                toolStripProgressBar.Value = 100;








                #region LerArquivo
                try
                {

                    clsapoio.lerauditoriaTexto(txtConteudo);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Abrir Arquivo: \n" + ex.Message);
                }
                finally
                {
                    MessageBox.Show("Arquivo concluido");
                }

                #endregion



            }

        }



        #endregion


    }
}



