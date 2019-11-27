namespace ClutchKinetcs
{
    partial class FormCadModelo
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
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtStatus = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtModelo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCepCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMarca = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.gbFuncionarioLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFuncionarioLog
            // 
            this.gbFuncionarioLog.Controls.Add(this.cmbTipo);
            this.gbFuncionarioLog.Controls.Add(this.cmbMarca);
            this.gbFuncionarioLog.Controls.Add(this.txtStatus);
            this.gbFuncionarioLog.Controls.Add(this.bunifuCustomLabel7);
            this.gbFuncionarioLog.Controls.Add(this.txtModelo);
            this.gbFuncionarioLog.Controls.Add(this.bunifuCustomLabel2);
            this.gbFuncionarioLog.Controls.Add(this.lblCepCadCli);
            this.gbFuncionarioLog.Controls.Add(this.txtMarca);
            this.gbFuncionarioLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionarioLog.ForeColor = System.Drawing.Color.White;
            this.gbFuncionarioLog.Location = new System.Drawing.Point(12, 12);
            this.gbFuncionarioLog.Name = "gbFuncionarioLog";
            this.gbFuncionarioLog.Size = new System.Drawing.Size(637, 376);
            this.gbFuncionarioLog.TabIndex = 50;
            this.gbFuncionarioLog.TabStop = false;
            this.gbFuncionarioLog.Text = "Dados do veiculo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(154, 172);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 32);
            this.cmbTipo.TabIndex = 64;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(136, 115);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 32);
            this.cmbMarca.TabIndex = 63;
            // 
            // txtStatus
            // 
            this.txtStatus.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtStatus.BorderColorIdle = System.Drawing.Color.White;
            this.txtStatus.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtStatus.BorderThickness = 3;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.White;
            this.txtStatus.isPassword = false;
            this.txtStatus.Location = new System.Drawing.Point(130, 232);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(280, 30);
            this.txtStatus.TabIndex = 62;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(16, 242);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(67, 20);
            this.bunifuCustomLabel7.TabIndex = 59;
            this.bunifuCustomLabel7.Text = "Status:";
            // 
            // txtModelo
            // 
            this.txtModelo.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtModelo.BorderColorIdle = System.Drawing.Color.White;
            this.txtModelo.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtModelo.BorderThickness = 3;
            this.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.White;
            this.txtModelo.isPassword = false;
            this.txtModelo.Location = new System.Drawing.Point(200, 49);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(419, 30);
            this.txtModelo.TabIndex = 20;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtModelo.OnValueChanged += new System.EventHandler(this.txtIDVeiculo_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 59);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(177, 20);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "Descrição do Modelo";
            // 
            // lblCepCadCli
            // 
            this.lblCepCadCli.AutoSize = true;
            this.lblCepCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepCadCli.ForeColor = System.Drawing.Color.White;
            this.lblCepCadCli.Location = new System.Drawing.Point(16, 178);
            this.lblCepCadCli.Name = "lblCepCadCli";
            this.lblCepCadCli.Size = new System.Drawing.Size(132, 20);
            this.lblCepCadCli.TabIndex = 2;
            this.lblCepCadCli.Text = "Tipo de Veiculo";
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = true;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(16, 127);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(114, 20);
            this.txtMarca.TabIndex = 17;
            this.txtMarca.Text = "Nome Marca:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 55);
            this.button1.TabIndex = 51;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCadModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(918, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbFuncionarioLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadModelo";
            this.Text = "FormCadModelo";
            this.Load += new System.EventHandler(this.FormCadModelo_Load);
            this.gbFuncionarioLog.ResumeLayout(false);
            this.gbFuncionarioLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFuncionarioLog;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtModelo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCepCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel txtMarca;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbMarca;
    }
}