namespace ClutchKinetcs
{
    partial class FormCadLocacao
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dplTipoPessoa = new Bunifu.Framework.UI.BunifuDropdown();
            this.gbGeralCadLoc = new System.Windows.Forms.GroupBox();
            this.txtTaxaExtra = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtComplCadCli = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTempLoc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNumLoc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblNomeCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCepCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRuaCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTaxaExtra = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCompCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.gbVeiculoLoc = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDataLoc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.gbClienteLoc = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adicionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2.SuspendLayout();
            this.gbGeralCadLoc.SuspendLayout();
            this.gbVeiculoLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbClienteLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dplTipoPessoa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(20, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 73);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seguro:";
            this.groupBox2.Visible = false;
            // 
            // dplTipoPessoa
            // 
            this.dplTipoPessoa.BackColor = System.Drawing.Color.Transparent;
            this.dplTipoPessoa.BorderRadius = 3;
            this.dplTipoPessoa.ForeColor = System.Drawing.Color.Black;
            this.dplTipoPessoa.Items = new string[0];
            this.dplTipoPessoa.Location = new System.Drawing.Point(12, 31);
            this.dplTipoPessoa.Margin = new System.Windows.Forms.Padding(6);
            this.dplTipoPessoa.Name = "dplTipoPessoa";
            this.dplTipoPessoa.NomalColor = System.Drawing.Color.White;
            this.dplTipoPessoa.onHoverColor = System.Drawing.Color.Maroon;
            this.dplTipoPessoa.selectedIndex = -1;
            this.dplTipoPessoa.Size = new System.Drawing.Size(144, 25);
            this.dplTipoPessoa.TabIndex = 3;
            // 
            // gbGeralCadLoc
            // 
            this.gbGeralCadLoc.Controls.Add(this.groupBox2);
            this.gbGeralCadLoc.Controls.Add(this.txtTaxaExtra);
            this.gbGeralCadLoc.Controls.Add(this.txtComplCadCli);
            this.gbGeralCadLoc.Controls.Add(this.txtTempLoc);
            this.gbGeralCadLoc.Controls.Add(this.txtDataLoc);
            this.gbGeralCadLoc.Controls.Add(this.txtNumLoc);
            this.gbGeralCadLoc.Controls.Add(this.lblNomeCadCli);
            this.gbGeralCadLoc.Controls.Add(this.lblCepCadCli);
            this.gbGeralCadLoc.Controls.Add(this.lblRuaCadCli);
            this.gbGeralCadLoc.Controls.Add(this.lblTaxaExtra);
            this.gbGeralCadLoc.Controls.Add(this.lblCompCadCli);
            this.gbGeralCadLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeralCadLoc.ForeColor = System.Drawing.Color.White;
            this.gbGeralCadLoc.Location = new System.Drawing.Point(7, 6);
            this.gbGeralCadLoc.Name = "gbGeralCadLoc";
            this.gbGeralCadLoc.Size = new System.Drawing.Size(465, 558);
            this.gbGeralCadLoc.TabIndex = 43;
            this.gbGeralCadLoc.TabStop = false;
            this.gbGeralCadLoc.Text = "Locação";
            // 
            // txtTaxaExtra
            // 
            this.txtTaxaExtra.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtTaxaExtra.BorderColorIdle = System.Drawing.Color.White;
            this.txtTaxaExtra.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtTaxaExtra.BorderThickness = 3;
            this.txtTaxaExtra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaxaExtra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaExtra.ForeColor = System.Drawing.Color.White;
            this.txtTaxaExtra.isPassword = false;
            this.txtTaxaExtra.Location = new System.Drawing.Point(145, 220);
            this.txtTaxaExtra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxaExtra.Name = "txtTaxaExtra";
            this.txtTaxaExtra.Size = new System.Drawing.Size(205, 25);
            this.txtTaxaExtra.TabIndex = 21;
            this.txtTaxaExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtComplCadCli
            // 
            this.txtComplCadCli.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtComplCadCli.BorderColorIdle = System.Drawing.Color.White;
            this.txtComplCadCli.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtComplCadCli.BorderThickness = 3;
            this.txtComplCadCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComplCadCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplCadCli.ForeColor = System.Drawing.Color.White;
            this.txtComplCadCli.isPassword = false;
            this.txtComplCadCli.Location = new System.Drawing.Point(146, 167);
            this.txtComplCadCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplCadCli.Name = "txtComplCadCli";
            this.txtComplCadCli.Size = new System.Drawing.Size(204, 25);
            this.txtComplCadCli.TabIndex = 20;
            this.txtComplCadCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTempLoc
            // 
            this.txtTempLoc.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtTempLoc.BorderColorIdle = System.Drawing.Color.White;
            this.txtTempLoc.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtTempLoc.BorderThickness = 3;
            this.txtTempLoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTempLoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempLoc.ForeColor = System.Drawing.Color.White;
            this.txtTempLoc.isPassword = false;
            this.txtTempLoc.Location = new System.Drawing.Point(148, 121);
            this.txtTempLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempLoc.Name = "txtTempLoc";
            this.txtTempLoc.Size = new System.Drawing.Size(202, 25);
            this.txtTempLoc.TabIndex = 18;
            this.txtTempLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNumLoc
            // 
            this.txtNumLoc.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtNumLoc.BorderColorIdle = System.Drawing.Color.White;
            this.txtNumLoc.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtNumLoc.BorderThickness = 3;
            this.txtNumLoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumLoc.Enabled = false;
            this.txtNumLoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumLoc.ForeColor = System.Drawing.Color.White;
            this.txtNumLoc.isPassword = false;
            this.txtNumLoc.Location = new System.Drawing.Point(145, 29);
            this.txtNumLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumLoc.Name = "txtNumLoc";
            this.txtNumLoc.Size = new System.Drawing.Size(205, 26);
            this.txtNumLoc.TabIndex = 15;
            this.txtNumLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblNomeCadCli
            // 
            this.lblNomeCadCli.AutoSize = true;
            this.lblNomeCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadCli.ForeColor = System.Drawing.Color.White;
            this.lblNomeCadCli.Location = new System.Drawing.Point(16, 30);
            this.lblNomeCadCli.Name = "lblNomeCadCli";
            this.lblNomeCadCli.Size = new System.Drawing.Size(76, 20);
            this.lblNomeCadCli.TabIndex = 1;
            this.lblNomeCadCli.Text = "Número:";
            // 
            // lblCepCadCli
            // 
            this.lblCepCadCli.AutoSize = true;
            this.lblCepCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepCadCli.ForeColor = System.Drawing.Color.White;
            this.lblCepCadCli.Location = new System.Drawing.Point(16, 76);
            this.lblCepCadCli.Name = "lblCepCadCli";
            this.lblCepCadCli.Size = new System.Drawing.Size(115, 20);
            this.lblCepCadCli.TabIndex = 2;
            this.lblCepCadCli.Text = "Data locação";
            // 
            // lblRuaCadCli
            // 
            this.lblRuaCadCli.AutoSize = true;
            this.lblRuaCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuaCadCli.ForeColor = System.Drawing.Color.White;
            this.lblRuaCadCli.Location = new System.Drawing.Point(16, 125);
            this.lblRuaCadCli.Name = "lblRuaCadCli";
            this.lblRuaCadCli.Size = new System.Drawing.Size(135, 20);
            this.lblRuaCadCli.TabIndex = 3;
            this.lblRuaCadCli.Text = "Tempo locação:";
            // 
            // lblTaxaExtra
            // 
            this.lblTaxaExtra.AutoSize = true;
            this.lblTaxaExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxaExtra.ForeColor = System.Drawing.Color.White;
            this.lblTaxaExtra.Location = new System.Drawing.Point(16, 222);
            this.lblTaxaExtra.Name = "lblTaxaExtra";
            this.lblTaxaExtra.Size = new System.Drawing.Size(97, 20);
            this.lblTaxaExtra.TabIndex = 4;
            this.lblTaxaExtra.Text = "Taxa extra:";
            // 
            // lblCompCadCli
            // 
            this.lblCompCadCli.AutoSize = true;
            this.lblCompCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompCadCli.ForeColor = System.Drawing.Color.White;
            this.lblCompCadCli.Location = new System.Drawing.Point(16, 171);
            this.lblCompCadCli.Name = "lblCompCadCli";
            this.lblCompCadCli.Size = new System.Drawing.Size(61, 20);
            this.lblCompCadCli.TabIndex = 6;
            this.lblCompCadCli.Text = "Custo:";
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(708, 505);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 47;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // gbVeiculoLoc
            // 
            this.gbVeiculoLoc.Controls.Add(this.dataGridView1);
            this.gbVeiculoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVeiculoLoc.ForeColor = System.Drawing.Color.White;
            this.gbVeiculoLoc.Location = new System.Drawing.Point(489, 6);
            this.gbVeiculoLoc.Name = "gbVeiculoLoc";
            this.gbVeiculoLoc.Size = new System.Drawing.Size(396, 242);
            this.gbVeiculoLoc.TabIndex = 45;
            this.gbVeiculoLoc.TabStop = false;
            this.gbVeiculoLoc.Text = "Veiculo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Tipo,
            this.Veiculo});
            this.dataGridView1.Location = new System.Drawing.Point(6, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtDataLoc
            // 
            this.txtDataLoc.BorderColorFocused = System.Drawing.Color.Maroon;
            this.txtDataLoc.BorderColorIdle = System.Drawing.Color.White;
            this.txtDataLoc.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.txtDataLoc.BorderThickness = 3;
            this.txtDataLoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataLoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLoc.ForeColor = System.Drawing.Color.White;
            this.txtDataLoc.isPassword = false;
            this.txtDataLoc.Location = new System.Drawing.Point(146, 76);
            this.txtDataLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataLoc.Name = "txtDataLoc";
            this.txtDataLoc.Size = new System.Drawing.Size(204, 25);
            this.txtDataLoc.TabIndex = 16;
            this.txtDataLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gbClienteLoc
            // 
            this.gbClienteLoc.Controls.Add(this.dataGridView2);
            this.gbClienteLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClienteLoc.ForeColor = System.Drawing.Color.White;
            this.gbClienteLoc.Location = new System.Drawing.Point(489, 262);
            this.gbClienteLoc.Name = "gbClienteLoc";
            this.gbClienteLoc.Size = new System.Drawing.Size(406, 274);
            this.gbClienteLoc.TabIndex = 44;
            this.gbClienteLoc.TabStop = false;
            this.gbClienteLoc.Text = "Cliente";
            this.gbClienteLoc.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Tipo_Cliente,
            this.Adicionar});
            this.dataGridView2.Location = new System.Drawing.Point(6, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(390, 211);
            this.dataGridView2.TabIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Tipo_Cliente
            // 
            this.Tipo_Cliente.HeaderText = "Tipo Cliente";
            this.Tipo_Cliente.Name = "Tipo_Cliente";
            // 
            // Adicionar
            // 
            this.Adicionar.HeaderText = "Adicionar";
            this.Adicionar.Name = "Adicionar";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 91;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Veiculo
            // 
            this.Veiculo.HeaderText = "Adicionar";
            this.Veiculo.Name = "Veiculo";
            // 
            // FormCadLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(902, 561);
            this.Controls.Add(this.gbGeralCadLoc);
            this.Controls.Add(this.gbClienteLoc);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.gbVeiculoLoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadLocacao";
            this.Text = "FormCadLocacao";
            this.groupBox2.ResumeLayout(false);
            this.gbGeralCadLoc.ResumeLayout(false);
            this.gbGeralCadLoc.PerformLayout();
            this.gbVeiculoLoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbClienteLoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuDropdown dplTipoPessoa;
        private System.Windows.Forms.GroupBox gbGeralCadLoc;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTaxaExtra;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtComplCadCli;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTempLoc;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNumLoc;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNomeCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCepCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRuaCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTaxaExtra;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCompCadCli;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.GroupBox gbVeiculoLoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDataLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewImageColumn Veiculo;
        private System.Windows.Forms.GroupBox gbClienteLoc;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Cliente;
        private System.Windows.Forms.DataGridViewImageColumn Adicionar;
    }
}