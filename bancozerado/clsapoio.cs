using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace bancozerado
{
    class clsapoio
    {


        //String de Conexao
        public string nomeInstancia;
        public string nomeUsuario;
        public string nomeSenha;
        public string Bdbanco;

        //CONEXÃO COM BANCO DE DADOS
        public SqlConnection conn = new SqlConnection();

        //COMANDO DE CONEXÃO AO BANCO DE DADOS
        public void stringBD()
        {
            conn.ConnectionString = (@"Data Source=" + nomeInstancia + ";"
                   + "User id=" + nomeUsuario + ";"
                   + "Password=" + nomeSenha + ";");
            conn.Open();
        }
        public void stringBDBD()
        {
            conn.ConnectionString = (
               @"Data Source=" + nomeInstancia + ";" +
                   "User id=" + nomeUsuario + ";" +
                "Database = " + Bdbanco + ";" +
                "Password = " + nomeSenha + "; ");
            conn.Open();
        }

        //DESCONECTAR BANCO DE DADOS
        public void desconectarBD()
        {
            conn.Close();
        }

        //ROTINA PARA ENCERRAR SISTEMA
        public void encerraSistema()
        {
            if (MessageBox.Show("Deseja encerrar o sistema?", "Ultilitario BD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void textomensageminformativo(TextBox txt, string c)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(txt, c);

        }
        public void checkboxmensageminformativo(CheckBox txt, string c)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(txt, c);

        }

        public void comboboxmensageminformativo(ComboBox txt, string c)
        {
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.AutoPopDelay = 4000;
            t_Tip.InitialDelay = 600;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.SetToolTip(txt, c);

        }


        public void auditoriaTexto(string c)
        {
            //string path = @"C:\curso\sistemas\sistemaemc\file.txt";
            string path = @"C:\PDV\";
            bool res = Directory.Exists(path + "Audit_app");
            if (!res)
            {
                Directory.CreateDirectory(path + "Audit_app");
            }
            string path1 = @"C:\PDV\Audit_app\audit.txt";
            StreamWriter writer = new StreamWriter(path1, true, Encoding.UTF8);
            writer.WriteLine(c);
            writer.Close();
        }
    }
}
