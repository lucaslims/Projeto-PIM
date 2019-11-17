namespace ClutchKinetcs
{
    public partial class CaixaDialogoPersonalizada
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
        public void InitializeComponent()
        {
            this.btnSqlServer = new System.Windows.Forms.Button();
            this.btnMySql = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSqlServer
            // 
            this.btnSqlServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSqlServer.BackColor = System.Drawing.Color.Maroon;
            this.btnSqlServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSqlServer.ForeColor = System.Drawing.Color.White;
            this.btnSqlServer.Location = new System.Drawing.Point(12, 86);
            this.btnSqlServer.Name = "btnSqlServer";
            this.btnSqlServer.Size = new System.Drawing.Size(130, 33);
            this.btnSqlServer.TabIndex = 0;
            this.btnSqlServer.Text = "SQL SERVER";
            this.btnSqlServer.UseVisualStyleBackColor = false;
            this.btnSqlServer.Click += new System.EventHandler(this.btnSqlServer_Click);
            // 
            // btnMySql
            // 
            this.btnMySql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMySql.BackColor = System.Drawing.Color.Maroon;
            this.btnMySql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMySql.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnMySql.ForeColor = System.Drawing.Color.White;
            this.btnMySql.Location = new System.Drawing.Point(153, 86);
            this.btnMySql.Name = "btnMySql";
            this.btnMySql.Size = new System.Drawing.Size(130, 33);
            this.btnMySql.TabIndex = 1;
            this.btnMySql.Text = "MYSQL";
            this.btnMySql.UseVisualStyleBackColor = false;
            this.btnMySql.Click += new System.EventHandler(this.btnMySql_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Há duas conexões ativas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(90, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qual delas deseja utilizar?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClutchKinetcs.Properties.Resources.confirmation_verification_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CaixaDialogoPersonalizada
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(294, 131);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMySql);
            this.Controls.Add(this.btnSqlServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CaixaDialogoPersonalizada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATENÇÃO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSqlServer;
        private System.Windows.Forms.Button btnMySql;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}