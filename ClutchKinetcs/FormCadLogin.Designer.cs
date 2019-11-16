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
            this.txtCepCadCli = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNomeCadCli = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblNomeCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCepCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gbFuncionarioLog = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbGeralCadCli = new System.Windows.Forms.GroupBox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dplTipoPermissao = new Bunifu.Framework.UI.BunifuDropdown();
            this.gbFuncionarioLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbGeralCadCli.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCepCadCli
            // 
            this.txtCepCadCli.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtCepCadCli.BorderColorIdle = System.Drawing.Color.White;
            this.txtCepCadCli.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtCepCadCli.BorderThickness = 3;
            this.txtCepCadCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCepCadCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepCadCli.ForeColor = System.Drawing.Color.White;
            this.txtCepCadCli.isPassword = false;
            this.txtCepCadCli.Location = new System.Drawing.Point(90, 109);
            this.txtCepCadCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCepCadCli.Name = "txtCepCadCli";
            this.txtCepCadCli.Size = new System.Drawing.Size(439, 45);
            this.txtCepCadCli.TabIndex = 16;
            this.txtCepCadCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNomeCadCli
            // 
            this.txtNomeCadCli.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtNomeCadCli.BorderColorIdle = System.Drawing.Color.White;
            this.txtNomeCadCli.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtNomeCadCli.BorderThickness = 3;
            this.txtNomeCadCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCadCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCadCli.ForeColor = System.Drawing.Color.White;
            this.txtNomeCadCli.isPassword = false;
            this.txtNomeCadCli.Location = new System.Drawing.Point(87, 42);
            this.txtNomeCadCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCadCli.Name = "txtNomeCadCli";
            this.txtNomeCadCli.Size = new System.Drawing.Size(442, 44);
            this.txtNomeCadCli.TabIndex = 15;
            this.txtNomeCadCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblNomeCadCli
            // 
            this.lblNomeCadCli.AutoSize = true;
            this.lblNomeCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadCli.ForeColor = System.Drawing.Color.White;
            this.lblNomeCadCli.Location = new System.Drawing.Point(17, 54);
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
            this.lblCepCadCli.Location = new System.Drawing.Point(16, 124);
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
            this.gbFuncionarioLog.Size = new System.Drawing.Size(522, 277);
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
            this.gbGeralCadCli.Controls.Add(this.bunifuMetroTextbox1);
            this.gbGeralCadCli.Controls.Add(this.bunifuCustomLabel1);
            this.gbGeralCadCli.Controls.Add(this.groupBox2);
            this.gbGeralCadCli.Controls.Add(this.txtCepCadCli);
            this.gbGeralCadCli.Controls.Add(this.txtNomeCadCli);
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
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Maroon;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.White;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(159, 175);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(370, 45);
            this.bunifuMetroTextbox1.TabIndex = 38;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 189);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(141, 20);
            this.bunifuCustomLabel1.TabIndex = 37;
            this.bunifuCustomLabel1.Text = "Confirmar senha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dplTipoPermissao);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(567, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 73);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissão";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dplTipoPermissao
            // 
            this.dplTipoPermissao.BackColor = System.Drawing.Color.Transparent;
            this.dplTipoPermissao.BorderRadius = 3;
            this.dplTipoPermissao.ForeColor = System.Drawing.Color.Black;
            this.dplTipoPermissao.Items = new string[0];
            this.dplTipoPermissao.Location = new System.Drawing.Point(12, 31);
            this.dplTipoPermissao.Margin = new System.Windows.Forms.Padding(6);
            this.dplTipoPermissao.Name = "dplTipoPermissao";
            this.dplTipoPermissao.NomalColor = System.Drawing.Color.White;
            this.dplTipoPermissao.onHoverColor = System.Drawing.Color.Maroon;
            this.dplTipoPermissao.selectedIndex = -1;
            this.dplTipoPermissao.Size = new System.Drawing.Size(297, 25);
            this.dplTipoPermissao.TabIndex = 3;
            // 
            // FormCadLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(918, 600);
            this.Controls.Add(this.gbFuncionarioLog);
            this.Controls.Add(this.gbGeralCadCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadLogin";
            this.Text = "FormCadLogin";
            this.gbFuncionarioLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbGeralCadCli.ResumeLayout(false);
            this.gbGeralCadCli.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtCepCadCli;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNomeCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNomeCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCepCadCli;
        private System.Windows.Forms.GroupBox gbFuncionarioLog;
        private System.Windows.Forms.GroupBox gbGeralCadCli;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuDropdown dplTipoPermissao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewImageColumn Adicionar;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}