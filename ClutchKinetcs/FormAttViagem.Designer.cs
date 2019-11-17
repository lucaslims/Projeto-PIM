namespace ClutchKinetcs
{
    partial class FormAttViagem
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
            this.gbViagem = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_VIAGEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIAMGE_ORIGEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIAGEM_DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIAGEM_KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTORISTA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEICULO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVICOS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbViagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbViagem
            // 
            this.gbViagem.Controls.Add(this.dataGridView1);
            this.gbViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbViagem.ForeColor = System.Drawing.Color.White;
            this.gbViagem.Location = new System.Drawing.Point(43, 4);
            this.gbViagem.Name = "gbViagem";
            this.gbViagem.Size = new System.Drawing.Size(878, 553);
            this.gbViagem.TabIndex = 50;
            this.gbViagem.TabStop = false;
            this.gbViagem.Text = "Atualizar Viagem";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_VIAGEM,
            this.VIAMGE_ORIGEM,
            this.VIAGEM_DESTINO,
            this.VIAGEM_KM,
            this.MOTORISTA_ID,
            this.VEICULO_ID,
            this.SERVICOS_ID,
            this.Adicionar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(872, 525);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_VIAGEM
            // 
            this.ID_VIAGEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_VIAGEM.HeaderText = "ID_VIAGEM";
            this.ID_VIAGEM.Name = "ID_VIAGEM";
            this.ID_VIAGEM.Width = 144;
            // 
            // VIAMGE_ORIGEM
            // 
            this.VIAMGE_ORIGEM.HeaderText = "VIAGEM ORIGEM";
            this.VIAMGE_ORIGEM.Name = "VIAMGE_ORIGEM";
            // 
            // VIAGEM_DESTINO
            // 
            this.VIAGEM_DESTINO.HeaderText = "VIAGEM DESTINO";
            this.VIAGEM_DESTINO.Name = "VIAGEM_DESTINO";
            // 
            // VIAGEM_KM
            // 
            this.VIAGEM_KM.HeaderText = "VIAGEM_KM_CONSUMO";
            this.VIAGEM_KM.Name = "VIAGEM_KM";
            // 
            // MOTORISTA_ID
            // 
            this.MOTORISTA_ID.HeaderText = "MOTORISTA_ID";
            this.MOTORISTA_ID.Name = "MOTORISTA_ID";
            // 
            // VEICULO_ID
            // 
            this.VEICULO_ID.HeaderText = "VEICULO_ID";
            this.VEICULO_ID.Name = "VEICULO_ID";
            // 
            // SERVICOS_ID
            // 
            this.SERVICOS_ID.HeaderText = "SERVICOS_ID";
            this.SERVICOS_ID.Name = "SERVICOS_ID";
            // 
            // Adicionar
            // 
            this.Adicionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adicionar.HeaderText = "Adicionar";
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Width = 105;
            // 
            // FormAttViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.gbViagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAttViagem";
            this.Text = "FormAttViagem";
            this.Load += new System.EventHandler(this.FormAttViagem_Load);
            this.gbViagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbViagem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VIAGEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIAMGE_ORIGEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIAGEM_DESTINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIAGEM_KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTORISTA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEICULO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVICOS_ID;
        private System.Windows.Forms.DataGridViewImageColumn Adicionar;
    }
}