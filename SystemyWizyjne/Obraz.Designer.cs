﻿namespace SystemyWizyjne
{
    partial class Obraz
    {
       
        private System.ComponentModel.IContainer components = null;

           protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            this.obrazWynikowy = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWynikowy)).BeginInit();
           
            this.SuspendLayout();
            // 
            // obrazWynikowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.obrazWynikowy.Location = new System.Drawing.Point(12, 12);
            this.obrazWynikowy.Name = "obrazWynikowy";
            this.obrazWynikowy.Size = new System.Drawing.Size(371, 194);
            this.obrazWynikowy.TabIndex = 1;
            this.obrazWynikowy.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(315, 165);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Obraz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 220);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.obrazWynikowy);
            this.Name = "Obraz";
            this.Text = "Wynik";
            ((System.ComponentModel.ISupportInitialize)(this.obrazWynikowy)).EndInit();
           
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox obrazWynikowy;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}