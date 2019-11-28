namespace ClutchKinetcs
{
    partial class FormCadLogin
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
            this.txtSenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtLogin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblNomeCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCepCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gbFuncionarioLog = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbGeralCadCli = new System.Windows.Forms.GroupBox();
            this.txtSenha2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTipoVeicu = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFunc = new System.Windows.Forms.ComboBox();
            this.gbFuncionarioLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbGeralCadCli.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtSenha.BorderColorIdle = System.Drawing.Color.White;
            this.txtSenha.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtSenha.BorderThickness = 3;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.isPassword = false;
            this.txtSenha.Location = new System.Drawing.Point(165, 167);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(439, 45);
            this.txtSenha.TabIndex = 16;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtLogin.BorderColorIdle = System.Drawing.Color.White;
            this.txtLogin.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtLogin.BorderThickness = 3;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.isPassword = false;
            this.txtLogin.Location = new System.Drawing.Point(162, 115);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(442, 44);
            this.txtLogin.TabIndex = 15;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblNomeCadCli
            // 
            this.lblNomeCadCli.AutoSize = true;
            this.lblNomeCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadCli.ForeColor = System.Drawing.Color.White;
            this.lblNomeCadCli.Location = new System.Drawing.Point(17, 115);
            this.lblNomeCadCli.Name = "lblNomeCadCli";
            this.lblNomeCadCli.Size = new System.Drawing.Size(58, 20);
            this.lblNomeCadCli.TabIndex = 1;
            this.lblNomeCadCli.Text = "Login:";
            // 
            // lblCepCadCli
            // 
            this.lblCepCadCli.AutoSize = true;
            this.lblCepCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepCadCli.ForeColor = System.Drawing.Color.White;
            this.lblCepCadCli.Location = new System.Drawing.Point(17, 192);
            this.lblCepCadCli.Name = "lblCepCadCli";
            this.lblCepCadCli.Size = new System.Drawing.Size(66, 20);
            this.lblCepCadCli.TabIndex = 2;
            this.lblCepCadCli.Text = "Senha:";
            // 
            // gbFuncionarioLog
            // 
            this.gbFuncionarioLog.Controls.Add(this.dataGridView1);
            this.gbFuncionarioLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionarioLog.ForeColor = System.Drawing.Color.White;
            this.gbFuncionarioLog.Location = new System.Drawing.Point(15, 311);
            this.gbFuncionarioLog.Name = "gbFuncionarioLog";
            this.gbFuncionarioLog.Size = new System.Drawing.Size(529, 277);
            this.gbFuncionarioLog.TabIndex = 47;
            this.gbFuncionarioLog.TabStop = false;
            this.gbFuncionarioLog.Text = "Dados do Funcionario:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionario,
            this.Cargo,
            this.Adicionar});
            this.dataGridView1.Location = new System.Drawing.Point(6, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // Funcionario
            // 
            this.Funcionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Funcionario.HeaderText = "Funcionário";
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.Width = 147;
            // 
            // Cargo
            // 
            this.Cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 91;
            // 
            // Adicionar
            // 
            this.Adicionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adicionar.HeaderText = "Adicionar";
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Width = 105;
            // 
            // gbGeralCadCli
            // 
            this.gbGeralCadCli.Controls.Add(this.groupBox1);
            this.gbGeralCadCli.Controls.Add(this.txtSenha2);
            this.gbGeralCadCli.Controls.Add(this.bunifuCustomLabel1);
            this.gbGeralCadCli.Controls.Add(this.groupBox2);
            this.gbGeralCadCli.Controls.Add(this.txtSenha);
            this.gbGeralCadCli.Controls.Add(this.txtLogin);
            this.gbGeralCadCli.Controls.Add(this.lblNomeCadCli);
            this.gbGeralCadCli.Controls.Add(this.lblCepCadCli);
            this.gbGeralCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeralCadCli.ForeColor = System.Drawing.Color.White;
            this.gbGeralCadCli.Location = new System.Drawing.Point(15, 21);
            this.gbGeralCadCli.Name = "gbGeralCadCli";
            this.gbGeralCadCli.Size = new System.Drawing.Size(891, 284);
            this.gbGeralCadCli.TabIndex = 46;
            this.gbGeralCadCli.TabStop = false;
            this.gbGeralCadCli.Text = "Login de Usuário";
            // 
            // txtSenha2
            // 
            this.txtSenha2.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtSenha2.BorderColorIdle = System.Drawing.Color.White;
            this.txtSenha2.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtSenha2.BorderThickness = 3;
            this.txtSenha2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha2.ForeColor = System.Drawing.Color.White;
            this.txtSenha2.isPassword = false;
            this.txtSenha2.Location = new System.Drawing.Point(165, 220);
            this.txtSenha2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(439, 45);
            this.txtSenha2.TabIndex = 38;
            this.txtSenha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(17, 233);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(141, 20);
            this.bunifuCustomLabel1.TabIndex = 37;
            this.bunifuCustomLabel1.Text = "Confirmar senha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTipoVeicu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(567, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 73);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissão";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbTipoVeicu
            // 
            this.cmbTipoVeicu.FormattingEnabled = true;
            this.cmbTipoVeicu.Location = new System.Drawing.Point(27, 28);
            this.cmbTipoVeicu.Name = "cmbTipoVeicu";
            this.cmbTipoVeicu.Size = new System.Drawing.Size(121, 32);
            this.cmbTipoVeicu.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 51);
            this.button1.TabIndex = 48;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFunc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(72, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 73);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissão";
            // 
            // cmbFunc
            // 
            this.cmbFunc.FormattingEnabled = true;
            this.cmbFunc.Location = new System.Drawing.Point(27, 28);
            this.cmbFunc.Name = "cmbFunc";
            this.cmbFunc.Size = new System.Drawing.Size(121, 32);
            this.cmbFunc.TabIndex = 39;
            // 
            // FormCadLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(918, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbFuncionarioLog);
            this.Controls.Add(this.gbGeralCadCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadLogin";
            this.Text = "pas";
            this.Load += new System.EventHandler(this.FormCadLogin_Load);
            this.gbFuncionarioLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbGeralCadCli.ResumeLayout(false);
            this.gbGeralCadCli.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNomeCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCepCadCli;
        private System.Windows.Forms.GroupBox gbFuncionarioLog;
        private System.Windows.Forms.GroupBox gbGeralCadCli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewImageColumn Adicionar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSenha2;
        private System.Windows.Forms.ComboBox cmbTipoVeicu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFunc;
    }
}