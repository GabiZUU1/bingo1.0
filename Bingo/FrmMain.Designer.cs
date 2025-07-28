namespace Bingo
{
    partial class FrmMain
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
            this.nrales = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.prg1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // nrales
            // 
            this.nrales.BackColor = System.Drawing.Color.LightCoral;
            this.nrales.Dock = System.Windows.Forms.DockStyle.Top;
            this.nrales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrales.Location = new System.Drawing.Point(0, 0);
            this.nrales.Name = "nrales";
            this.nrales.Size = new System.Drawing.Size(1040, 30);
            this.nrales.TabIndex = 0;
            this.nrales.Text = "Click aici pt a da start";
            this.nrales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nrales.Click += new System.EventHandler(this.nrales_Click);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Peru;
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(0, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(1040, 30);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "lblScor";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prg1
            // 
            this.prg1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prg1.Location = new System.Drawing.Point(0, 528);
            this.prg1.Maximum = 250;
            this.prg1.Name = "prg1";
            this.prg1.Size = new System.Drawing.Size(1040, 34);
            this.prg1.Step = 1;
            this.prg1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prg1.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 562);
            this.Controls.Add(this.prg1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.nrales);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nrales;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar prg1;
    }
}

