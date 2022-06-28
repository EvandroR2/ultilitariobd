
namespace bancozerado
{
    partial class frm_codigodarede
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
            this.btn_ok_rede = new System.Windows.Forms.Button();
            this.dGV_empresa = new System.Windows.Forms.DataGridView();
            this.emp_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_razao_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_empresa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok_rede
            // 
            this.btn_ok_rede.Location = new System.Drawing.Point(305, 203);
            this.btn_ok_rede.Name = "btn_ok_rede";
            this.btn_ok_rede.Size = new System.Drawing.Size(151, 47);
            this.btn_ok_rede.TabIndex = 0;
            this.btn_ok_rede.Text = "OK";
            this.btn_ok_rede.UseVisualStyleBackColor = true;
            this.btn_ok_rede.Click += new System.EventHandler(this.btn_ok_rede_Click);
            // 
            // dGV_empresa
            // 
            this.dGV_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_empresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emp_codigo,
            this.emp_razao_social});
            this.dGV_empresa.Location = new System.Drawing.Point(13, 13);
            this.dGV_empresa.Name = "dGV_empresa";
            this.dGV_empresa.Size = new System.Drawing.Size(443, 157);
            this.dGV_empresa.TabIndex = 1;
            // 
            // emp_codigo
            // 
            this.emp_codigo.HeaderText = "ID";
            this.emp_codigo.Name = "emp_codigo";
            // 
            // emp_razao_social
            // 
            this.emp_razao_social.HeaderText = "NOME";
            this.emp_razao_social.Name = "emp_razao_social";
            this.emp_razao_social.Width = 300;
            // 
            // frm_codigodarede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 264);
            this.ControlBox = false;
            this.Controls.Add(this.dGV_empresa);
            this.Controls.Add(this.btn_ok_rede);
            this.Name = "frm_codigodarede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_codigodarede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_empresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok_rede;
        private System.Windows.Forms.DataGridView dGV_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_razao_social;
    }
}