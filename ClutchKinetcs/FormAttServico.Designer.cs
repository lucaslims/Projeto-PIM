namespace ClutchKinetcs
{
    partial class FormAttServico
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
            this.ID_SERVICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_estacionamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Pedagio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbFuncionarioLog.Location = new System.Drawing.Point(51, 24);
            this.gbFuncionarioLog.Name = "gbFuncionarioLog";
            this.gbFuncionarioLog.Size = new System.Drawing.Size(878, 553);
            this.gbFuncionarioLog.TabIndex = 49;
            this.gbFuncionarioLog.TabStop = false;
            this.gbFuncionarioLog.Text = "Atualizar Serviço";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SERVICO,
            this.Total_estacionamento,
            this.Total_Pedagio,
            this.Adicionar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(872, 525);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_SERVICO
            // 
            this.ID_SERVICO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_SERVICO.HeaderText = "ID_Servico";
            this.ID_SERVICO.Name = "ID_SERVICO";
            this.ID_SERVICO.Width = 135;
            // 
            // Total_estacionamento
            // 
            this.Total_estacionamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total_estacionamento.HeaderText = "Total estacionamento";
            this.Total_estacionamento.Name = "Total_estacionamento";
            this.Total_estacionamento.Width = 213;
            // 
            // Total_Pedagio
            // 
            this.Total_Pedagio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total_Pedagio.HeaderText = "Total Pedagio";
            this.Total_Pedagio.Name = "Total_Pedagio";
            this.Total_Pedagio.Width = 150;
            // 
            // Adicionar
            // 
            this.Adicionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adicionar.HeaderText = "Adicionar";
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Width = 105;
            // 
            // FormAttServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.gbFuncionarioLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAttServico";
            this.Text = "FormAttServico";
            this.Load += new System.EventHandler(this.FormAttServico_Load);
            this.gbFuncionarioLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFuncionarioLog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SERVICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_estacionamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Pedagio;
        private System.Windows.Forms.DataGridViewImageColumn Adicionar;
    }
}