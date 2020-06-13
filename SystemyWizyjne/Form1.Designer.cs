namespace SystemyWizyjne
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5  = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.suwak = new System.Windows.Forms.TrackBar();
            this.suwak2 = new System.Windows.Forms.TrackBar();
            this.wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.picture = new System.Windows.Forms.PictureBox();
         //   this.wynik = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.process = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.suwak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suwak2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.wynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            //this.label1.Location = new System.Drawing.Point(0, 0);
            //this.label1.Name = "label1";
            //this.label1.Size = new System.Drawing.Size(100, 23);
            //this.label1.TabIndex = 5;
            //this.label1.Visible = false;
            // 
            // suwak
            // 
            this.suwak.LargeChange = 10;
            this.suwak.Location = new System.Drawing.Point(64, 50);
            this.suwak.Maximum = 255;
            this.suwak.Minimum = -255;
            this.suwak.Name = "suwak";
            this.suwak.Size = new System.Drawing.Size(318, 45);
            this.suwak.TabIndex = 3;
            this.suwak.TickFrequency = 10;
            this.suwak.Visible = false;
            this.suwak.ValueChanged += new System.EventHandler(this.comboBox1_Click);
            //
            // suwak2
            //
            this.suwak2.LargeChange = 1;
            this.suwak2.Location = new System.Drawing.Point(64, 50);
            this.suwak2.Maximum = 4;
            this.suwak2.Minimum = 1;
            this.suwak2.Name = "suwak";
            this.suwak2.Size = new System.Drawing.Size(318, 45);
            this.suwak2.TabIndex = 3;
            this.suwak2.TickFrequency = 1;
            this.suwak2.Visible = false;
            this.suwak2.ValueChanged += new System.EventHandler(this.comboBox1_Click);
            // 
            // wykres
            // 
            //chartArea5.AxisX.IsLabelAutoFit = false;
            //chartArea5.AxisX.LabelStyle.Interval = 50D;
            //chartArea5.AxisX.LabelStyle.IntervalOffset = 0D;
            //chartArea5.AxisX.MajorGrid.Interval = 50D;
            //chartArea5.AxisX.MajorTickMark.Interval = 50D;
            //chartArea5.AxisX.Maximum = 256D;
            //chartArea5.AxisX.Minimum = 0D;
            //chartArea5.AxisX.ScaleView.Zoomable = false;
            //chartArea5.AxisY.IsLabelAutoFit = false;
            //chartArea5.AxisY.LabelStyle.Interval = 50D;
            //chartArea5.AxisY.LabelStyle.IntervalOffset = 0D;
            //chartArea5.AxisY.MajorGrid.Interval = 50D;
            //chartArea5.AxisY.MajorTickMark.Interval = 50D;
            //chartArea5.AxisY.Maximum = 256D;
            //chartArea5.AxisY.Minimum = 0D;
            //chartArea5.AxisY.ScaleView.Zoomable = false;
            //chartArea5.Name = "ChartArea1";
            //this.wykres.ChartAreas.Add(chartArea5);
            //legend3.Enabled = false;
            //legend3.Name = "Legend1";
            //this.wykres.Legends.Add(legend3);
            //this.wykres.Location = new System.Drawing.Point(150, 60);
            //this.wykres.Name = "wykres";
            //series9.ChartArea = "ChartArea1";
            //series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //series9.Legend = "Legend1";
            //series9.Name = "wartosciLUT";
            //this.wykres.Series.Add(series9);
            //this.wykres.Size = new System.Drawing.Size(232, 198);
            //this.wykres.TabIndex = 4;
            //this.wykres.Text = "chart1";
            //title3.Name = "Tablica LUT";
            //title3.Text = "Tablica LUT";
            //title3.ToolTip = "Tablica LUT";
            //this.wykres.Titles.Add(title3);
            //this.wykres.Visible = false;
            ////////////////////////////////////////////elemety histogramu///////////////////////////////
            ///// 
            // chart
            // 
            chartArea6.AxisX.Interval = 50D;
            chartArea6.AxisX.IsMarginVisible = false;
            chartArea6.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.AxisY.LabelAutoFitMaxFontSize = 6;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 100F;
            chartArea6.Position.Width = 100F;
            this.chart.ChartAreas.Add(chartArea6);
            this.chart.Location = new System.Drawing.Point(360, 30);
            this.chart.Name = "chart";
            series10.BorderColor = System.Drawing.Color.Red;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Red;
            series10.Name = "red";
            series10.ShadowColor = System.Drawing.Color.Transparent;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Lime;
            series11.Name = "green";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Blue;
            series12.Name = "blue";
            this.chart.Series.Add(series10);
            this.chart.Series.Add(series11);
            this.chart.Series.Add(series12);
            this.chart.Size = new System.Drawing.Size(319, 100);
            this.chart.TabIndex = 2;
            this.chart.Visible = false;
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(450, 5);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(143, 23);
            this.process.TabIndex = 3;
            this.process.Text = "Rozciagnij histogram";
            this.process.UseVisualStyleBackColor = true;
            this.process.Visible = false;
            this.process.Click += new System.EventHandler(this.comboBox1_Click);




            ////// 
            ////// wynik
            ////// 
            //this.wynik.Location = new System.Drawing.Point(24, 83);
            //this.wynik.Name = "wynik";
            //this.wynik.Size = new System.Drawing.Size(500, 500);
            //this.wynik.TabIndex = 0;
            //this.wynik.TabStop = false;



            ///////////////////////////Głowny oprzycisk, picture, comboBox i Form//////////////////////////////////////////
            ///// 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(24, 83);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(500, 500);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wczytaj plik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.wczytaj_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Negatyw obrazu - działa",
            "Konwersja do odcieni szarości - działa",
            "Normalizacja histogramu - działa",
            "Skalowanie",
            "Progowanie (binaryzacja)",
            "Filtry",
            "Transformacja pomiędzy przestrzeniami barw",
            "Obrót",
            "Zmiana jasności - działa",
            "Detekcja krawędzi",
            "Segmentacja",
            "Szkieletyzacja",
            "Erozja/dylatacja",
            "OCR",
            "Klasyfikator cech"});
            this.comboBox1.Location = new System.Drawing.Point(131, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Wybierz funkcję";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_Click);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
           // this.Controls.Add(this.wynik);
            this.Controls.Add(this.process);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture);
           // this.Controls.Add(this.wykres);
            this.Controls.Add(this.suwak);
            this.Controls.Add(this.suwak2);
            // this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "Form1";
            this.Text = "Systemy Wizyjne";
            ((System.ComponentModel.ISupportInitialize)(this.suwak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suwak2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.wynik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar suwak;
        private System.Windows.Forms.TrackBar suwak2;
        private System.Windows.Forms.DataVisualization.Charting.Chart wykres;
       // private System.Windows.Forms.PictureBox wynik;
    }
}

