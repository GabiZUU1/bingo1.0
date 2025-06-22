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
            this.SuspendLayout();
            // 
            // nrales
            // 
            this.nrales.AutoSize = true;
            this.nrales.Location = new System.Drawing.Point(404, 76);
            this.nrales.Name = "nrales";
            this.nrales.Size = new System.Drawing.Size(35, 13);
            this.nrales.TabIndex = 0;
            this.nrales.Text = "label1";
            this.nrales.Click += new System.EventHandler(this.nrales_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 562);
            this.Controls.Add(this.nrales);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nrales;
    }
}

