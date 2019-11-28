namespace ClutchKinetcs
{
    partial class FormSplash
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
            this.components = new System.ComponentModel.Container();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bckGroudWrkSplash = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(12, 12);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(612, 18);
            this.bunifuProgressBar1.TabIndex = 0;
            this.bunifuProgressBar1.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(620, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bckGroudWrkSplash
            // 
            this.bckGroudWrkSplash.WorkerReportsProgress = true;
            this.bckGroudWrkSplash.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckGroudWrkSplash_DoWork);
            this.bckGroudWrkSplash.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bckGroudWrkSplash_ProgressChanged);
            this.bckGroudWrkSplash.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckGroudWrkSplash_RunWorkerCompleted);
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(724, 69);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplash";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bckGroudWrkSplash;
    }
}