namespace ClutchKinetcs
{
    partial class FormConVeiculo
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
            this.gbVeiculoLoc = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbVeiculoLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVeiculoLoc
            // 
            this.gbVeiculoLoc.Controls.Add(this.groupBox1);
            this.gbVeiculoLoc.Controls.Add(this.dataGridView1);
            this.gbVeiculoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVeiculoLoc.ForeColor = System.Drawing.Color.White;
            this.gbVeiculoLoc.Location = new System.Drawing.Point(12, 74);
            this.gbVeiculoLoc.Name = "gbVeiculoLoc";
            this.gbVeiculoLoc.Size = new System.Drawing.Size(894, 514);
            this.gbVeiculoLoc.TabIndex = 51;
            this.gbVeiculoLoc.TabStop = false;
            this.gbVeiculoLoc.Text = "ConsultaVeiculo";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 512);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 64);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Placa,
            this.Chassi,
            this.Descricao,
            this.Cor,
            this.Marca,
            this.Modelo,
            this.Tipo,
            this.Veiculo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(888, 486);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AtualizarData);
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 91;
            // 
            // Placa
            // 
            this.Placa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Width = 86;
            // 
            // Chassi
            // 
            this.Chassi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Chassi.HeaderText = "Chassi";
            this.Chassi.Name = "Chassi";
            this.Chassi.Width = 97;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 128;
            // 
            // Cor
            // 
            this.Cor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.Width = 68;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 92;
            // 
            // Modelo
            // 
            this.Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 105;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 77;
            // 
            // Veiculo
            // 
            this.Veiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Veiculo.HeaderText = "";
            this.Veiculo.Name = "Veiculo";
            this.Veiculo.Width = 21;
            // 
            // FormConVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(918, 600);
            this.Controls.Add(this.gbVeiculoLoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConVeiculo";
            this.Text = "FormConsultaVeiculo";
            this.gbVeiculoLoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVeiculoLoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewImageColumn Veiculo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}