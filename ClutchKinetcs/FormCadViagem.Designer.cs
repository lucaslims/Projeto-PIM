namespace ClutchKinetcs
{
    partial class FormCadViagem
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
            this.gbMotoViag = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbMotorista = new System.Windows.Forms.ComboBox();
            this.cmbPlaca = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.gbVeiculoLoc = new System.Windows.Forms.GroupBox();
            this.txtCombustivel = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDestino = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtOrigemVia = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblCepCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCompCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gbGeralCadViag = new System.Windows.Forms.GroupBox();
            this.lblRuaCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gbMotoViag.SuspendLayout();
            this.gbVeiculoLoc.SuspendLayout();
            this.gbGeralCadViag.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMotoViag
            // 
            this.gbMotoViag.Controls.Add(this.bunifuCustomLabel1);
            this.gbMotoViag.Controls.Add(this.cmbMotorista);
            this.gbMotoViag.Controls.Add(this.button1);
            this.gbMotoViag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMotoViag.ForeColor = System.Drawing.Color.White;
            this.gbMotoViag.Location = new System.Drawing.Point(15, 278);
            this.gbMotoViag.Name = "gbMotoViag";
            this.gbMotoViag.Size = new System.Drawing.Size(465, 311);
            this.gbMotoViag.TabIndex = 49;
            this.gbMotoViag.TabStop = false;
            this.gbMotoViag.Text = "Motorista";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 89);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(171, 20);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "Combustivel Viagem";
            // 
            // cmbMotorista
            // 
            this.cmbMotorista.FormattingEnabled = true;
            this.cmbMotorista.Location = new System.Drawing.Point(194, 83);
            this.cmbMotorista.Name = "cmbMotorista";
            this.cmbMotorista.Size = new System.Drawing.Size(121, 32);
            this.cmbMotorista.TabIndex = 54;
            // 
            // cmbPlaca
            // 
            this.cmbPlaca.FormattingEnabled = true;
            this.cmbPlaca.Location = new System.Drawing.Point(79, 56);
            this.cmbPlaca.Name = "cmbPlaca";
            this.cmbPlaca.Size = new System.Drawing.Size(252, 32);
            this.cmbPlaca.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 55);
            this.button1.TabIndex = 52;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(716, 520);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 51;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // gbVeiculoLoc
            // 
            this.gbVeiculoLoc.Controls.Add(this.bunifuCustomLabel3);
            this.gbVeiculoLoc.Controls.Add(this.cmbPlaca);
            this.gbVeiculoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVeiculoLoc.ForeColor = System.Drawing.Color.White;
            this.gbVeiculoLoc.Location = new System.Drawing.Point(495, 21);
            this.gbVeiculoLoc.Name = "gbVeiculoLoc";
            this.gbVeiculoLoc.Size = new System.Drawing.Size(396, 251);
            this.gbVeiculoLoc.TabIndex = 50;
            this.gbVeiculoLoc.TabStop = false;
            this.gbVeiculoLoc.Text = "Veiculo";
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtCombustivel.BorderColorIdle = System.Drawing.Color.White;
            this.txtCombustivel.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtCombustivel.BorderThickness = 3;
            this.txtCombustivel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCombustivel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustivel.ForeColor = System.Drawing.Color.White;
            this.txtCombustivel.isPassword = false;
            this.txtCombustivel.Location = new System.Drawing.Point(184, 188);
            this.txtCombustivel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(264, 37);
            this.txtCombustivel.TabIndex = 20;
            this.txtCombustivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDestino
            // 
            this.txtDestino.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtDestino.BorderColorIdle = System.Drawing.Color.White;
            this.txtDestino.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtDestino.BorderThickness = 3;
            this.txtDestino.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.ForeColor = System.Drawing.Color.White;
            this.txtDestino.isPassword = false;
            this.txtDestino.Location = new System.Drawing.Point(101, 118);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(347, 34);
            this.txtDestino.TabIndex = 18;
            this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOrigemVia
            // 
            this.txtOrigemVia.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtOrigemVia.BorderColorIdle = System.Drawing.Color.White;
            this.txtOrigemVia.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtOrigemVia.BorderThickness = 3;
            this.txtOrigemVia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrigemVia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigemVia.ForeColor = System.Drawing.Color.White;
            this.txtOrigemVia.isPassword = false;
            this.txtOrigemVia.Location = new System.Drawing.Point(169, 44);
            this.txtOrigemVia.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrigemVia.Name = "txtOrigemVia";
            this.txtOrigemVia.Size = new System.Drawing.Size(279, 37);
            this.txtOrigemVia.TabIndex = 16;
            this.txtOrigemVia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblCepCadCli
            // 
            this.lblCepCadCli.AutoSize = true;
            this.lblCepCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepCadCli.ForeColor = System.Drawing.Color.White;
            this.lblCepCadCli.Location = new System.Drawing.Point(6, 56);
            this.lblCepCadCli.Name = "lblCepCadCli";
            this.lblCepCadCli.Size = new System.Drawing.Size(156, 20);
            this.lblCepCadCli.TabIndex = 2;
            this.lblCepCadCli.Text = "Origem da Viagem";
            // 
            // lblCompCadCli
            // 
            this.lblCompCadCli.AutoSize = true;
            this.lblCompCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompCadCli.ForeColor = System.Drawing.Color.White;
            this.lblCompCadCli.Location = new System.Drawing.Point(6, 200);
            this.lblCompCadCli.Name = "lblCompCadCli";
            this.lblCompCadCli.Size = new System.Drawing.Size(171, 20);
            this.lblCompCadCli.TabIndex = 6;
            this.lblCompCadCli.Text = "Combustivel Viagem";
            // 
            // gbGeralCadViag
            // 
            this.gbGeralCadViag.Controls.Add(this.txtCombustivel);
            this.gbGeralCadViag.Controls.Add(this.txtDestino);
            this.gbGeralCadViag.Controls.Add(this.txtOrigemVia);
            this.gbGeralCadViag.Controls.Add(this.lblCepCadCli);
            this.gbGeralCadViag.Controls.Add(this.lblRuaCadCli);
            this.gbGeralCadViag.Controls.Add(this.lblCompCadCli);
            this.gbGeralCadViag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeralCadViag.ForeColor = System.Drawing.Color.White;
            this.gbGeralCadViag.Location = new System.Drawing.Point(15, 21);
            this.gbGeralCadViag.Name = "gbGeralCadViag";
            this.gbGeralCadViag.Size = new System.Drawing.Size(465, 251);
            this.gbGeralCadViag.TabIndex = 48;
            this.gbGeralCadViag.TabStop = false;
            this.gbGeralCadViag.Text = "Viagem";
            // 
            // lblRuaCadCli
            // 
            this.lblRuaCadCli.AutoSize = true;
            this.lblRuaCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuaCadCli.ForeColor = System.Drawing.Color.White;
            this.lblRuaCadCli.Location = new System.Drawing.Point(6, 132);
            this.lblRuaCadCli.Name = "lblRuaCadCli";
            this.lblRuaCadCli.Size = new System.Drawing.Size(71, 20);
            this.lblRuaCadCli.TabIndex = 3;
            this.lblRuaCadCli.Text = "Destino";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(6, 62);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(58, 20);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "Placa:";
            // 
            // FormCadViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(918, 600);
            this.Controls.Add(this.gbMotoViag);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.gbVeiculoLoc);
            this.Controls.Add(this.gbGeralCadViag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadViagem";
            this.Text = "FormCadViagem";
            this.Load += new System.EventHandler(this.FormCadViagem_Load);
            this.gbMotoViag.ResumeLayout(false);
            this.gbMotoViag.PerformLayout();
            this.gbVeiculoLoc.ResumeLayout(false);
            this.gbVeiculoLoc.PerformLayout();
            this.gbGeralCadViag.ResumeLayout(false);
            this.gbGeralCadViag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbMotoViag;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.GroupBox gbVeiculoLoc;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCombustivel;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDestino;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOrigemVia;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCepCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCompCadCli;
        private System.Windows.Forms.GroupBox gbGeralCadViag;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRuaCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cmbMotorista;
        private System.Windows.Forms.ComboBox cmbPlaca;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}