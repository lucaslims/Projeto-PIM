namespace ClutchKinetcs
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlOpcSW = new System.Windows.Forms.Panel();
            this.btnFecharSW = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMinimizarSW = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlOpcSW.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(47, 132);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(88, 29);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(33, 61);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 29);
            this.lblUsuario.TabIndex = 37;
            this.lblUsuario.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.White;
            this.txtUsuario.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtUsuario.BorderThickness = 3;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.isPassword = false;
            this.txtUsuario.Location = new System.Drawing.Point(157, 52);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(370, 44);
            this.txtUsuario.TabIndex = 38;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtSenha.BorderColorIdle = System.Drawing.Color.White;
            this.txtSenha.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtSenha.BorderThickness = 3;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.isPassword = true;
            this.txtSenha.Location = new System.Drawing.Point(157, 129);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(370, 44);
            this.txtSenha.TabIndex = 39;
            this.txtSenha.Tag = "";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.Maroon;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(234, 204);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(238, 44);
            this.btnLogin.TabIndex = 40;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pnlOpcSW
            // 
            this.pnlOpcSW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOpcSW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlOpcSW.Controls.Add(this.btnFecharSW);
            this.pnlOpcSW.Controls.Add(this.btnMinimizarSW);
            this.pnlOpcSW.Location = new System.Drawing.Point(-1, 0);
            this.pnlOpcSW.Name = "pnlOpcSW";
            this.pnlOpcSW.Size = new System.Drawing.Size(641, 29);
            this.pnlOpcSW.TabIndex = 41;
            this.pnlOpcSW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlOpcSW_MouseDown);
            this.pnlOpcSW.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlOpcSW_MouseMove);
            // 
            // btnFecharSW
            // 
            this.btnFecharSW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharSW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFecharSW.color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFecharSW.colorActive = System.Drawing.Color.Maroon;
            this.btnFecharSW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnFecharSW.ForeColor = System.Drawing.Color.White;
            this.btnFecharSW.Image = global::ClutchKinetcs.Properties.Resources.close2;
            this.btnFecharSW.ImagePosition = 3;
            this.btnFecharSW.ImageZoom = 90;
            this.btnFecharSW.LabelPosition = 0;
            this.btnFecharSW.LabelText = "";
            this.btnFecharSW.Location = new System.Drawing.Point(618, 0);
            this.btnFecharSW.Margin = new System.Windows.Forms.Padding(6);
            this.btnFecharSW.Name = "btnFecharSW";
            this.btnFecharSW.Size = new System.Drawing.Size(23, 29);
            this.btnFecharSW.TabIndex = 5;
            this.btnFecharSW.Click += new System.EventHandler(this.BtnFecharSW_Click);
            // 
            // btnMinimizarSW
            // 
            this.btnMinimizarSW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarSW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMinimizarSW.color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnMinimizarSW.colorActive = System.Drawing.Color.Maroon;
            this.btnMinimizarSW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnMinimizarSW.ForeColor = System.Drawing.Color.White;
            this.btnMinimizarSW.Image = global::ClutchKinetcs.Properties.Resources.minimize;
            this.btnMinimizarSW.ImagePosition = 3;
            this.btnMinimizarSW.ImageZoom = 90;
            this.btnMinimizarSW.LabelPosition = 0;
            this.btnMinimizarSW.LabelText = "";
            this.btnMinimizarSW.Location = new System.Drawing.Point(593, 0);
            this.btnMinimizarSW.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinimizarSW.Name = "btnMinimizarSW";
            this.btnMinimizarSW.Size = new System.Drawing.Size(23, 29);
            this.btnMinimizarSW.TabIndex = 4;
            this.btnMinimizarSW.Click += new System.EventHandler(this.BtnMinimizarSW_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(641, 272);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlOpcSW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlOpcSW.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsuario;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private System.Windows.Forms.Panel pnlOpcSW;
        private Bunifu.Framework.UI.BunifuTileButton btnFecharSW;
        private Bunifu.Framework.UI.BunifuTileButton btnMinimizarSW;
    }
}

