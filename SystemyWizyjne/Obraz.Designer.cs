namespace SystemyWizyjne
{
    partial class Obraz
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
            this.obrazWynikowy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWynikowy)).BeginInit();
            this.SuspendLayout();
            // 
            // obrazWynikowy
            // 
            this.obrazWynikowy.Location = new System.Drawing.Point(12, 12);
            this.obrazWynikowy.Name = "obrazWynikowy";
            this.obrazWynikowy.Size = new System.Drawing.Size(371, 194);
            this.obrazWynikowy.TabIndex = 1;
            this.obrazWynikowy.TabStop = false;
            // 
            // Obraz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 220);
            this.Controls.Add(this.obrazWynikowy);
            this.Name = "Obraz";
            this.Text = "Zmiana jasności - www.algorytm.org (c)2012 by Tomasz Lubinski";
            ((System.ComponentModel.ISupportInitialize)(this.obrazWynikowy)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.PictureBox obrazWynikowy;
    }
}