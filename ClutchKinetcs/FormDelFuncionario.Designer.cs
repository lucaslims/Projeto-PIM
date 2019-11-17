namespace ClutchKinetcs
{
    partial class FormDelFuncionario
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
            this.gbDepetarFuncionario = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Idpessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CARGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbDepetarFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDepetarFuncionario
            // 
            this.gbDepetarFuncionario.Controls.Add(this.dataGridView1);
            this.gbDepetarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepetarFuncionario.ForeColor = System.Drawing.Color.White;
            this.gbDepetarFuncionario.Location = new System.Drawing.Point(1, 4);
            this.gbDepetarFuncionario.Name = "gbDepetarFuncionario";
            this.gbDepetarFuncionario.Size = new System.Drawing.Size(882, 552);
            this.gbDepetarFuncionario.TabIndex = 55;
            this.gbDepetarFuncionario.TabStop = false;
            this.gbDepetarFuncionario.Text = "Deletar Funcionário";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idpessoa,
            this.Nome,
            this.Email,
            this.Celular,
            this.Status,
            this.ID_Departamento,
            this.Departamento,
            this.ID_CARGO,
            this.Cargo,
            this.Veiculo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // Idpessoa
            // 
            this.Idpessoa.HeaderText = "Id_pessoa";
            this.Idpessoa.Name = "Idpessoa";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 91;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.Width = 94;
            // 
            // Celular
            // 
            this.Celular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.Width = 101;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 91;
            // 
            // ID_Departamento
            // 
            this.ID_Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Departamento.HeaderText = "ID Departamento";
            this.ID_Departamento.Name = "ID_Departamento";
            this.ID_Departamento.Width = 173;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.Width = 165;
            // 
            // ID_CARGO
            // 
            this.ID_CARGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_CARGO.HeaderText = "ID Cargo";
            this.ID_CARGO.Name = "ID_CARGO";
            this.ID_CARGO.Width = 106;
            // 
            // Cargo
            // 
            this.Cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 91;
            // 
            // Veiculo
            // 
            this.Veiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Veiculo.HeaderText = "";
            this.Veiculo.Name = "Veiculo";
            this.Veiculo.Width = 21;
            // 
            // FormDelFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.gbDepetarFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDelFuncionario";
            this.Text = "FormDelFuncionario";
            this.Load += new System.EventHandler(this.FormDelFuncionario_Load);
            this.gbDepetarFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepetarFuncionario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idpessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewImageColumn Veiculo;
    }
}