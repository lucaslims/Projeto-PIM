﻿namespace ClutchKinetcs
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbMotoViag = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.gbVeiculoLoc = new System.Windows.Forms.GroupBox();
            this.txtComplCadCli = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDestino = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtOrigemVia = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblCepCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCompCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gbGeralCadViag = new System.Windows.Forms.GroupBox();
            this.lblRuaCadCli = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidadeCnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaCnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMotorista = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbMotoViag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbVeiculoLoc.SuspendLayout();
            this.gbGeralCadViag.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Motorista,
            this.cnh,
            this.ValidadeCnh,
            this.CategoriaCnh,
            this.AddMotorista});
            this.dataGridView2.Location = new System.Drawing.Point(6, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(545, 277);
            this.dataGridView2.TabIndex = 0;
            // 
            // gbMotoViag
            // 
            this.gbMotoViag.Controls.Add(this.dataGridView2);
            this.gbMotoViag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMotoViag.ForeColor = System.Drawing.Color.White;
            this.gbMotoViag.Location = new System.Drawing.Point(15, 278);
            this.gbMotoViag.Name = "gbMotoViag";
            this.gbMotoViag.Size = new System.Drawing.Size(556, 311);
            this.gbMotoViag.TabIndex = 49;
            this.gbMotoViag.TabStop = false;
            this.gbMotoViag.Text = "Motorista";
            this.gbMotoViag.Visible = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(384, 189);
            this.dataGridView1.TabIndex = 0;
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
            this.gbVeiculoLoc.Controls.Add(this.dataGridView1);
            this.gbVeiculoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVeiculoLoc.ForeColor = System.Drawing.Color.White;
            this.gbVeiculoLoc.Location = new System.Drawing.Point(495, 21);
            this.gbVeiculoLoc.Name = "gbVeiculoLoc";
            this.gbVeiculoLoc.Size = new System.Drawing.Size(396, 251);
            this.gbVeiculoLoc.TabIndex = 50;
            this.gbVeiculoLoc.TabStop = false;
            this.gbVeiculoLoc.Text = "Veiculo";
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
            this.txtComplCadCli.Location = new System.Drawing.Point(184, 188);
            this.txtComplCadCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplCadCli.Name = "txtComplCadCli";
            this.txtComplCadCli.Size = new System.Drawing.Size(264, 37);
            this.txtComplCadCli.TabIndex = 20;
            this.txtComplCadCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.gbGeralCadViag.Controls.Add(this.txtComplCadCli);
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
            // Motorista
            // 
            this.Motorista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Motorista.HeaderText = "Motorista";
            this.Motorista.Name = "Motorista";
            this.Motorista.ReadOnly = true;
            this.Motorista.Width = 119;
            // 
            // cnh
            // 
            this.cnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cnh.HeaderText = "CNH";
            this.cnh.Name = "cnh";
            this.cnh.ReadOnly = true;
            this.cnh.Width = 79;
            // 
            // ValidadeCnh
            // 
            this.ValidadeCnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ValidadeCnh.HeaderText = "Val.";
            this.ValidadeCnh.Name = "ValidadeCnh";
            this.ValidadeCnh.ReadOnly = true;
            this.ValidadeCnh.Width = 71;
            // 
            // CategoriaCnh
            // 
            this.CategoriaCnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CategoriaCnh.HeaderText = "Cat.";
            this.CategoriaCnh.Name = "CategoriaCnh";
            this.CategoriaCnh.ReadOnly = true;
            this.CategoriaCnh.Width = 71;
            // 
            // AddMotorista
            // 
            this.AddMotorista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddMotorista.HeaderText = "";
            this.AddMotorista.Name = "AddMotorista";
            this.AddMotorista.Width = 21;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbMotoViag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbVeiculoLoc.ResumeLayout(false);
            this.gbGeralCadViag.ResumeLayout(false);
            this.gbGeralCadViag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gbMotoViag;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.GroupBox gbVeiculoLoc;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtComplCadCli;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDestino;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOrigemVia;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCepCadCli;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCompCadCli;
        private System.Windows.Forms.GroupBox gbGeralCadViag;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRuaCadCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidadeCnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaCnh;
        private System.Windows.Forms.DataGridViewImageColumn AddMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewImageColumn Veiculo;
    }
}