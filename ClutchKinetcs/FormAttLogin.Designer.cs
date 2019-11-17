namespace ClutchKinetcs
{
    partial class FormAttLogin
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
            this.gbFuncionarioLog = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PESSOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_permissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbFuncionarioLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFuncionarioLog
            // 
            this.gbFuncionarioLog.Controls.Add(this.dataGridView1);
            this.gbFuncionarioLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionarioLog.ForeColor = System.Drawing.Color.White;
            this.gbFuncionarioLog.Location = new System.Drawing.Point(28, 12);
            this.gbFuncionarioLog.Name = "gbFuncionarioLog";
            this.gbFuncionarioLog.Size = new System.Drawing.Size(878, 553);
            this.gbFuncionarioLog.TabIndex = 48;
            this.gbFuncionarioLog.TabStop = false;
            this.gbFuncionarioLog.Text = "Atualizar Login";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.ID_PESSOA,
            this.Tipo_permissao,
            this.Adicionar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(872, 525);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.Width = 87;
            // 
            // ID_PESSOA
            // 
            this.ID_PESSOA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_PESSOA.HeaderText = "ID Pessoa";
            this.ID_PESSOA.Name = "ID_PESSOA";
            this.ID_PESSOA.Width = 128;
            // 
            // Tipo_permissao
            // 
            this.Tipo_permissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tipo_permissao.HeaderText = "Tipo de Permissão";
            this.Tipo_permissao.Name = "Tipo_permissao";
            this.Tipo_permissao.Width = 191;
            // 
            // Adicionar
            // 
            this.Adicionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adicionar.HeaderText = "Adicionar";
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Width = 105;
            // 
            // FormAttLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(918, 600);
            this.Controls.Add(this.gbFuncionarioLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAttLogin";
            this.Text = "FormAttLogin";
            this.gbFuncionarioLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFuncionarioLog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_permissao;
        private System.Windows.Forms.DataGridViewImageColumn Adicionar;
    }
}