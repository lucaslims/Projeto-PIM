namespace ClutchKinetcs
{
    partial class FormAttLocacao
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
            this.gbLocacao = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataLocacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoLocacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxa_Extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seguro_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pessoa_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbLocacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLocacao
            // 
            this.gbLocacao.Controls.Add(this.dataGridView1);
            this.gbLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocacao.ForeColor = System.Drawing.Color.White;
            this.gbLocacao.Location = new System.Drawing.Point(12, 4);
            this.gbLocacao.Name = "gbLocacao";
            this.gbLocacao.Size = new System.Drawing.Size(878, 553);
            this.gbLocacao.TabIndex = 49;
            this.gbLocacao.TabStop = false;
            this.gbLocacao.Text = "Atualizar Locacoa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataLocacao,
            this.TempoLocacao,
            this.Custo,
            this.Taxa_Extra,
            this.Seguro_ID,
            this.Pessoa_ID,
            this.Veiculo_ID,
            this.Adicionar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(872, 525);
            this.dataGridView1.TabIndex = 0;
            // 
            // DataLocacao
            // 
            this.DataLocacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataLocacao.HeaderText = "Data Locacao";
            this.DataLocacao.Name = "DataLocacao";
            this.DataLocacao.Width = 161;
            // 
            // TempoLocacao
            // 
            this.TempoLocacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TempoLocacao.HeaderText = "Tempo Locação";
            this.TempoLocacao.Name = "TempoLocacao";
            this.TempoLocacao.Width = 169;
            // 
            // Custo
            // 
            this.Custo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Custo.HeaderText = "Custo";
            this.Custo.Name = "Custo";
            this.Custo.Width = 88;
            // 
            // Taxa_Extra
            // 
            this.Taxa_Extra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Taxa_Extra.HeaderText = "Taxa Extra";
            this.Taxa_Extra.Name = "Taxa_Extra";
            this.Taxa_Extra.Width = 123;
            // 
            // Seguro_ID
            // 
            this.Seguro_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Seguro_ID.HeaderText = "Seguro_ID";
            this.Seguro_ID.Name = "Seguro_ID";
            this.Seguro_ID.Width = 133;
            // 
            // Pessoa_ID
            // 
            this.Pessoa_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pessoa_ID.HeaderText = "Pessoa_ID";
            this.Pessoa_ID.Name = "Pessoa_ID";
            this.Pessoa_ID.Width = 133;
            // 
            // Veiculo_ID
            // 
            this.Veiculo_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Veiculo_ID.HeaderText = "Veiculo_ID";
            this.Veiculo_ID.Name = "Veiculo_ID";
            this.Veiculo_ID.Width = 136;
            // 
            // Adicionar
            // 
            this.Adicionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adicionar.HeaderText = "Adicionar";
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Width = 105;
            // 
            // FormAttLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(902, 561);
            this.Controls.Add(this.gbLocacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAttLocacao";
            this.Text = "FormAttLocacao";
            this.gbLocacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLocacao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLocacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoLocacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxa_Extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seguro_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pessoa_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Veiculo_ID;
        private System.Windows.Forms.DataGridViewImageColumn Adicionar;
    }
}