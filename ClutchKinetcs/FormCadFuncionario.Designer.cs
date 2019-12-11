namespace ClutchKinetcs
{
    partial class FormCadFuncionario
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
            this.gbPessoaFisicaCadCli = new System.Windows.Forms.GroupBox();
            this.lblCpfPessFisiCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIdPessFisiCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gbGeralCadCli = new System.Windows.Forms.GroupBox();
            this.lblNomeCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.gbPessoaFisicaCadCli.SuspendLayout();
            this.gbGeralCadCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPessoaFisicaCadCli
            // 
            this.gbPessoaFisicaCadCli.Controls.Add(this.cmbCargo);
//            this.gbPessoaFisicaCadCli.Controls.Add(this.lblCpfPessFisiCadCli);
            this.gbPessoaFisicaCadCli.Controls.Add(this.cmbDepartamento);
            this.gbPessoaFisicaCadCli.Controls.Add(this.lblIdPessFisiCadCli);
            this.gbPessoaFisicaCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPessoaFisicaCadCli.ForeColor = System.Drawing.Color.White;
            this.gbPessoaFisicaCadCli.Location = new System.Drawing.Point(20, 107);
            this.gbPessoaFisicaCadCli.Name = "gbPessoaFisicaCadCli";
            this.gbPessoaFisicaCadCli.Size = new System.Drawing.Size(439, 145);
            this.gbPessoaFisicaCadCli.TabIndex = 45;
            this.gbPessoaFisicaCadCli.TabStop = false;
            this.gbPessoaFisicaCadCli.Text = "Dados do Funcionario:";
            // 
            // lblCpfPessFisiCadCli
            // 
            this.lblCpfPessFisiCadCli.AutoSize = true;
            this.lblCpfPessFisiCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfPessFisiCadCli.ForeColor = System.Drawing.Color.White;
            this.lblCpfPessFisiCadCli.Location = new System.Drawing.Point(6, 78);
            this.lblCpfPessFisiCadCli.Name = "lblCpfPessFisiCadCli";
            this.lblCpfPessFisiCadCli.Size = new System.Drawing.Size(62, 20);
            this.lblCpfPessFisiCadCli.TabIndex = 6;
            this.lblCpfPessFisiCadCli.Text = "Cargo:";
            // 
            // lblIdPessFisiCadCli
            // 
            this.lblIdPessFisiCadCli.AutoSize = true;
            this.lblIdPessFisiCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPessFisiCadCli.ForeColor = System.Drawing.Color.White;
            this.lblIdPessFisiCadCli.Location = new System.Drawing.Point(6, 34);
            this.lblIdPessFisiCadCli.Name = "lblIdPessFisiCadCli";
            this.lblIdPessFisiCadCli.Size = new System.Drawing.Size(129, 20);
            this.lblIdPessFisiCadCli.TabIndex = 5;
            this.lblIdPessFisiCadCli.Text = "Departamento:";
            // 
            // gbGeralCadCli
            // 
            this.gbGeralCadCli.Controls.Add(this.cmbNome);
            this.gbGeralCadCli.Controls.Add(this.gbPessoaFisicaCadCli);
            this.gbGeralCadCli.Controls.Add(this.lblNomeCadCli);
            this.gbGeralCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeralCadCli.ForeColor = System.Drawing.Color.White;
            this.gbGeralCadCli.Location = new System.Drawing.Point(15, 21);
            this.gbGeralCadCli.Name = "gbGeralCadCli";
            this.gbGeralCadCli.Size = new System.Drawing.Size(475, 558);
            this.gbGeralCadCli.TabIndex = 44;
            this.gbGeralCadCli.TabStop = false;
            this.gbGeralCadCli.Text = "Cadastro de Funcionários";
            // 
            // lblNomeCadCli
            // 
            this.lblNomeCadCli.AutoSize = true;
            this.lblNomeCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadCli.ForeColor = System.Drawing.Color.White;
            this.lblNomeCadCli.Location = new System.Drawing.Point(28, 67);
            this.lblNomeCadCli.Name = "lblNomeCadCli";
            this.lblNomeCadCli.Size = new System.Drawing.Size(60, 20);
            this.lblNomeCadCli.TabIndex = 1;
            this.lblNomeCadCli.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbNome
            // 
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(150, 61);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(291, 32);
            this.cmbNome.TabIndex = 46;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(142, 28);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(291, 32);
            this.cmbDepartamento.TabIndex = 47;
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(142, 72);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(291, 32);
            this.cmbCargo.TabIndex = 48;
            // 
            // FormCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(918, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbGeralCadCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadFuncionario";
            this.Text = "FormCadFuncionario";
        //    this.Load += new System.EventHandler(this.FormCadFuncionario_Load);
            this.gbPessoaFisicaCadCli.ResumeLayout(false);
            this.gbPessoaFisicaCadCli.PerformLayout();
            this.gbGeralCadCli.ResumeLayout(false);
            this.gbGeralCadCli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPessoaFisicaCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCpfPessFisiCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIdPessFisiCadCli;
        private System.Windows.Forms.GroupBox gbGeralCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNomeCadCli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbNome;
    }
}