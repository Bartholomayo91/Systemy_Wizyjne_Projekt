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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWynikowy)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.richTextBox1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.vScrollBar1)).BeginInit();
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(315, 165);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(325, 22);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 168);
            this.vScrollBar1.TabIndex = 3;
            // 
            // Obraz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 220);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.obrazWynikowy);
            this.Name = "Obraz";
            this.Text = "Zmiana jasności - www.algorytm.org (c)2012 by Tomasz Lubinski";
            ((System.ComponentModel.ISupportInitialize)(this.obrazWynikowy)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.richTextBox1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.vScrollBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox obrazWynikowy;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}