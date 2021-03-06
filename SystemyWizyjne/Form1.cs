﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tesseract;
using Emgu;
using Emgu.CV.Structure;
using Emgu.CV;
using System.IO;

namespace SystemyWizyjne
{
    public partial class Form1 : Form
    {

        private Obraz wynik;
        private Image zrodlo;
        Image<Bgr, byte> imgInput;
        Image<Gray, byte> imgOutput;
        Image<Gray, byte> imgGray;
        Image<Gray, byte> imgBinarize;
        String fileName;

        public Form1()
        {

            InitializeComponent();
            comboBox1_Click(null, null);

        }

        private void wczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Otwórz obraz";
            dlg.Filter = "Obrazy (*.jpg;*.gif;*.png;*.bmp)|*.jpg;*.gif;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                imgInput = new Image<Bgr, byte>(dlg.FileName);//składowe facedetection i 
                picture.Image = imgInput.Bitmap;//składowe facedetection


                zrodlo = new Bitmap(dlg.OpenFile());
                picture.Image = new Bitmap(dlg.OpenFile());
                picture.Height = picture.Image.Height;
                picture.Width = picture.Image.Width;
                this.ClientSize = new System.Drawing.Size(Math.Max(picture.Width + 32, 300), picture.Height + 80);
            }
            dlg.Dispose();
        }
      
        private int[] calculateLUT(int[] values)
        {
            //poszukaj wartości minimalnej
            int minValue = 0;
            for (int i = 0; i < 256; i++)
            {
                if (values[i] != 0)
                {
                    minValue = i;
                    break;
                }
            }

            //poszukaj wartości maksymalnej
            int maxValue = 255;
            for (int i = 255; i >= 0; i--)
            {
                if (values[i] != 0)
                {
                    maxValue = i;
                    break;
                }
            }

            //przygotuj tablice zgodnie ze wzorem
            int[] result = new int[256];
            double a = 255.0 / (maxValue - minValue);
            for (int i = 0; i < 256; i++)
            {
                result[i] = (int)(a * (i - minValue));
            }

            return result;
        }

       
        private void comboBox1_Click(object sender, EventArgs e)
        {
            string selectedEmployee = (string)comboBox1.SelectedItem;
            switch (selectedEmployee)
            {
               
                case "Negatyw obrazu":

                    this.chart.Visible = false;
                    this.process.Visible = false;

                    this.label1.Visible = false;
                    this.suwak.Visible = false;
                    this.wykres.Visible = false;
                    //Nie rob nic jezeli obraz jest jeszcze niewczytany
                    if (picture.Image == null)
                    {
                        return;
                    }
                    //Pobierz wartosc wszystkich punktow obrazu

                    Obraz wynikowy6 = new Obraz();
                    wynikowy6.richTextBox1.Visible = false;
                    wynikowy6.obrazWynikowy.Visible = true;
                    wynikowy6.obrazWynikowy.Image = picture.Image;
                    wynikowy6.Height = picture.Image.Height;
                    wynikowy6.Width = picture.Image.Width;
                    wynikowy6.obrazWynikowy.Height = picture.Image.Height;
                    wynikowy6.obrazWynikowy.Width = picture.Image.Width;
                    wynikowy6.Show();
                    Bitmap bitmap = (Bitmap)wynikowy6.obrazWynikowy.Image;

                    BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, picture.Width, picture.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                    byte[] pixelValues = new byte[Math.Abs(bmpData.Stride) * picture.Height];
                    System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixelValues, 0, pixelValues.Length);

                    //Odwroc wartosc kazdego punktu dla kazdej skladowej
                    for (int i = 0; i < pixelValues.Length; i++)
                    {
                        pixelValues[i] = (byte)(255 - pixelValues[i]);
                    }

                    //Wczytaj przetworzony obraz
                    System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, bmpData.Scan0, pixelValues.Length);
                    bitmap.UnlockBits(bmpData);
                    //picture.Refresh();
                    break;
                ///////////////////////////////////////////////////////jasnosc////////////////////////
                case "Zmiana jasności":

                    this.chart.Visible = false;
                    this.process.Visible = false;
                   
                    //Przygotuj tablice LUT i pokaz ja na wykresie

                    this.label1.Visible = true;
                    this.suwak.Visible = true;
                  
                    byte[] LUT = new byte[256];
                    int b = suwak.Value;
                    
                    for (int i = 0; i < 256; i++)
                    {
                        if ((b + i) > 255)
                        {
                            LUT[i] = 255;
                        }
                        else if ((b + i) < 0)
                        {
                            LUT[i] = 0;
                        }
                        else
                        {
                            LUT[i] = (byte)(b + i);
                        }
                       
                    }

                    //Nie rob nic wiecej jezeli obraz jest jeszcze niewczytany
                    if (picture == null)
                    {
                        return;
                    }

                    //Kopiuj obrazek zrodlowy
                    Bitmap bitmapJo = (Bitmap)zrodlo.Clone();
                    picture.Image = bitmapJo;


                    //Pobierz wartosc wszystkich punktow obrazu
                    BitmapData bmpDataJo = bitmapJo.LockBits(new Rectangle(0, 0, bitmapJo.Width, bitmapJo.Height), ImageLockMode.ReadWrite, bitmapJo.PixelFormat);
                    byte[] pixelValuesJo = new byte[Math.Abs(bmpDataJo.Stride) * bitmapJo.Height];
                    System.Runtime.InteropServices.Marshal.Copy(bmpDataJo.Scan0, pixelValuesJo, 0, pixelValuesJo.Length);

                    //Zmien jasnosc kazdego punktu zgodnie z tablica LUT
                    for (int i = 0; i < pixelValuesJo.Length; i++)
                    {
                        pixelValuesJo[i] = LUT[pixelValuesJo[i]];
                    }

                    //Ustaw wartosc wszystkich punktow obrazu
                    System.Runtime.InteropServices.Marshal.Copy(pixelValuesJo, 0, bmpDataJo.Scan0, pixelValuesJo.Length);
                    bitmapJo.UnlockBits(bmpDataJo);

                    break;
                //////////////////////////////////////odcienie szarosci/////////////////////////////////////////////////
                case "Konwersja do odcieni szarości":

                    this.chart.Visible = false;
                    this.process.Visible = false;
                    //Nie rob nic jezeli obraz jest jeszcze niewczytany
                    if (picture.Image == null)
                    {
                        return;
                    }

                    //Sprawdz format obrazu - sprawdz czy obraz zawiera 3 kanały - RGB
                    if (picture.Image.PixelFormat != PixelFormat.Format24bppRgb)
                    {
                        MessageBox.Show("Nieobsługiwany format pliku!", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Pobierz wartosc wszystkich punktow obrazu
                    Obraz wynikowy = new Obraz();
                    wynikowy.richTextBox1.Visible = false;
                    wynikowy.obrazWynikowy.Visible = true;
                    wynikowy.obrazWynikowy.Image = picture.Image;
                    wynikowy.Height = picture.Image.Height;
                    wynikowy.Width = picture.Image.Width;
                    wynikowy.obrazWynikowy.Height = picture.Image.Height;
                    wynikowy.obrazWynikowy.Width = picture.Image.Width;
                    wynikowy.Show();
                    Bitmap bitmapKs = (Bitmap)wynikowy.obrazWynikowy.Image;
                    BitmapData bmpDataKs = bitmapKs.LockBits(new Rectangle(0, 0, picture.Width, picture.Height), ImageLockMode.ReadWrite, bitmapKs.PixelFormat);
                    byte[] pixelValuesKs = new byte[Math.Abs(bmpDataKs.Stride) * picture.Height];
                    System.Runtime.InteropServices.Marshal.Copy(bmpDataKs.Scan0, pixelValuesKs, 0, pixelValuesKs.Length);

                    //Dla kolejnych punktow obrazu
                    for (int i = 0; i < picture.Width * picture.Height; i++)
                    {
                        //Wartosci kolorow zapisane sa w kolejnosci Blue, Green, Red
                        byte value = (byte)(0.299 * pixelValuesKs[3 * i + 2] +
                                             0.587 * pixelValuesKs[3 * i + 1] +
                                             0.114 * pixelValuesKs[3 * i]);
                        pixelValuesKs[3 * i] = value;
                        pixelValuesKs[3 * i + 1] = value;
                        pixelValuesKs[3 * i + 2] = value;
                    }

                    //Wczytaj przetworzony obraz
                    System.Runtime.InteropServices.Marshal.Copy(pixelValuesKs, 0, bmpDataKs.Scan0, pixelValuesKs.Length);
                    bitmapKs.UnlockBits(bmpDataKs);
                    wynikowy.obrazWynikowy.Refresh();

                    break;
                ///////////////////////////////////normalizacja histogramu//////////////////////
                case "Normalizacja histogramu":

                    this.picture.Location = new System.Drawing.Point(24, 140);

                    int[] red = null;
                    int[] green = null;
                    int[] blue = null;
                    this.chart.Visible = true;
                    this.process.Visible = true;

                    Obraz obraz = new Obraz();
                    //Oblicz histogram


                    red = new int[256];
                    green = new int[256];
                    blue = new int[256];
                    for (int x = 0; x < picture.Width; x++)
                    {
                        for (int y = 0; y < picture.Height; y++)
                        {
                            Color pixel = ((Bitmap)picture.Image).GetPixel(x, y);
                            red[pixel.R]++;
                            green[pixel.G]++;
                            blue[pixel.B]++;
                        }
                    }

                    //Wyswietl histogram na wykresie
                    chart.Series["red"].Points.Clear();
                    chart.Series["green"].Points.Clear();
                    chart.Series["blue"].Points.Clear();
                    for (int i = 0; i < 256; i++)
                    {
                        chart.Series["red"].Points.AddXY(i, red[i]);
                        chart.Series["green"].Points.AddXY(i, green[i]);
                        chart.Series["blue"].Points.AddXY(i, blue[i]);
                    }
                    chart.Invalidate();

                    //Sprawdz czy wczytano obraz
                    if (red == null)
                    {
                        return;
                    }

                    //Tablice LUT dla skladowych
                    int[] LUTred = calculateLUT(red);
                    int[] LUTgreen = calculateLUT(green);
                    int[] LUTblue = calculateLUT(blue);

                    //Przetworz obraz i oblicz nowy histogram
                    red = new int[256];
                    green = new int[256];
                    blue = new int[256];
                    Bitmap oldBitmap = (Bitmap)picture.Image;
                    Bitmap newBitmap = new Bitmap(oldBitmap.Width, oldBitmap.Height, PixelFormat.Format24bppRgb);
                    for (int x = 0; x < picture.Width; x++)
                    {
                        for (int y = 0; y < picture.Height; y++)
                        {
                            Color pixel = oldBitmap.GetPixel(x, y);
                            Color newPixel = Color.FromArgb(LUTred[pixel.R], LUTgreen[pixel.G], LUTblue[pixel.B]);
                            newBitmap.SetPixel(x, y, newPixel);
                            red[newPixel.R]++;
                            green[newPixel.G]++;
                            blue[newPixel.B]++;
                        }
                    }
                    

                    obraz.richTextBox1.Visible = false;
                    obraz.obrazWynikowy.Visible = true;
                    obraz.obrazWynikowy.Image = newBitmap;
                    obraz.Height = picture.Image.Height;
                    obraz.Width = picture.Image.Width;
                    obraz.obrazWynikowy.Height = picture.Image.Height;
                    obraz.obrazWynikowy.Width = picture.Image.Width;
                    obraz.Show();

                    //Wyswietl histogram na wykresie
                    chart.Series["red"].Points.Clear();
                    chart.Series["green"].Points.Clear();
                    chart.Series["blue"].Points.Clear();
                    for (int i = 0; i < 256; i++)
                    {
                        chart.Series["red"].Points.AddXY(i, red[i]);
                        chart.Series["green"].Points.AddXY(i, green[i]);
                        chart.Series["blue"].Points.AddXY(i, blue[i]);
                    }
                    chart.Invalidate();
                    break;
                //////////////////////////////////////////Skalowanie/////////////////////////////////
                case "Skalowanie":
                    this.chart.Visible = false;
                    this.process.Visible = false;

                    this.label1.Visible = true;
                    this.suwak2.Visible = true;
                    int skala = suwak2.Value;
                    int newWidth = zrodlo.Width * skala;
                    int newHeight = zrodlo.Height * skala;


                    //Nie rob nic wiecej jezeli obraz jest jeszcze niewczytany
                    if (picture != null)
                    {
                        if (this.suwak2.Value > 0)
                        {
                            picture.Image = ResizeImage(zrodlo, newWidth, newHeight);
                        }
                    }



                    Bitmap ResizeImage(Image image, int width, int height)
                    {
                        var destRect = new Rectangle(0, 0, width, height);
                        var destImage = new Bitmap(width, height);

                        destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                        using (var graphics = Graphics.FromImage(destImage))
                        {
                            graphics.CompositingMode = CompositingMode.SourceCopy;
                            graphics.CompositingQuality = CompositingQuality.HighQuality;
                            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphics.SmoothingMode = SmoothingMode.HighQuality;
                            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                            using (var wrapMode = new ImageAttributes())
                            {
                                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                            }
                        }
                        picture.Width = width;
                        picture.Height = height;
                        return destImage;
                    }

                    break;
                //////////////////////////////////////////////Obrót///////////////////////////////////
                case "Obrót":
                    {
                        Bitmap bitmapRotate = (Bitmap)picture.Image;
                        if (bitmapRotate != null)
                        {
                            bitmapRotate.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            picture.Image = bitmapRotate;
                        }
                    }
                    break;
                ///////////////////////////////////////Detekcja krawędzi///////////////////////////////
                case "Detekcja krawędzi":
                    {
                        Image<Gray, byte> imgOutput = imgInput.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255));
                        Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
                        Mat hier = new Mat();

                        Image<Gray, byte> imgout = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));

                        CvInvoke.FindContours(imgOutput, contours, hier, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                        CvInvoke.DrawContours(imgout, contours, -1, new MCvScalar(255, 0, 0));


                        Obraz wynikowy1 = new Obraz();
                        wynikowy1.richTextBox1.Visible = false;
                        wynikowy1.obrazWynikowy.Visible = true;
                        wynikowy1.obrazWynikowy.Image = imgout.Bitmap;
                        wynikowy1.Height = picture.Image.Height;
                        wynikowy1.Width = picture.Image.Width;
                        wynikowy1.obrazWynikowy.Height = picture.Image.Height;
                        wynikowy1.obrazWynikowy.Width = picture.Image.Width;
                        wynikowy1.Show();
                    }
                    break;
                /////////////////////////////////////////// Segmentacja/////////////////////////////////////////
                case "Segmentacja":
                    {
                        try
                        {
                            imgOutput = imgInput.Convert<Gray, byte>().InRange(new Gray(20), new Gray(200)).Canny(10, 50);

                            picture.Invalidate();

                            Obraz wynikowy2 = new Obraz();
                            wynikowy2.richTextBox1.Visible = false;
                            wynikowy2.obrazWynikowy.Visible = true;
                            wynikowy2.obrazWynikowy.Image = imgOutput.Bitmap;
                            wynikowy2.Height = picture.Image.Height;
                            wynikowy2.Width = picture.Image.Width;
                            wynikowy2.obrazWynikowy.Height = picture.Image.Height;
                            wynikowy2.obrazWynikowy.Width = picture.Image.Width;
                            wynikowy2.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error " + ex.Message);
                        }
                    }
                    break;
                ///////////////////////////////////////////Erozja////////////////////////////////////
                case "Erozja":
                    {
                        if (imgInput==null)
                        {
                            return;
                        }
                        Obraz wynikowy3 = new Obraz();
                        wynikowy3.richTextBox1.Visible = false;
                        wynikowy3.obrazWynikowy.Visible = true;
                        wynikowy3.obrazWynikowy.Image = imgInput.Convert<Gray, byte>().ThresholdBinary(new Gray(120), new Gray(255)).Erode(1).Bitmap;
                        wynikowy3.Height = picture.Image.Height;
                        wynikowy3.Width = picture.Image.Width;
                        wynikowy3.obrazWynikowy.Height = picture.Image.Height;
                        wynikowy3.obrazWynikowy.Width = picture.Image.Width;
                        wynikowy3.Show();
                    }break;
                ///////////////////////////////////////////Dylatacja////////////////////////////////////
                case "Dylatacja":
                    {
                        if (imgInput == null)
                        {
                            return;
                        }


                        Obraz wynikowy4 = new Obraz();
                        wynikowy4.richTextBox1.Visible = false;
                        wynikowy4.obrazWynikowy.Visible = true;
                        wynikowy4.obrazWynikowy.Image = imgInput.Convert<Gray, byte>().ThresholdBinary(new Gray(120), new Gray(255)).Dilate(1).Bitmap;
                        wynikowy4.Height = picture.Image.Height;
                        wynikowy4.Width = picture.Image.Width;
                        wynikowy4.obrazWynikowy.Height = picture.Image.Height;
                        wynikowy4.obrazWynikowy.Width = picture.Image.Width;
                        wynikowy4.Show();
                    }
                    break;
                //////////////////////////////////////////Progowanie/////////////////////////////////
                case "Progowanie (binaryzacja)":
                    this.chart.Visible = false;
                    this.process.Visible = false;

                    this.label1.Visible = true;


                    //Nie rob nic wiecej jezeli obraz jest jeszcze niewczytany
                    if (picture != null)
                    {

                        imgInput = new Image<Bgr, byte>(fileName);
                        imgGray = imgInput.Convert<Gray, byte>();
                        //binaryzacja
                        imgBinarize = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));
                        CvInvoke.Threshold(imgGray, imgBinarize, 70, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                      
                    }
                    Obraz wynik = new Obraz();
                    wynik.richTextBox1.Visible = false;
                    wynik.obrazWynikowy.Visible = true;
                    wynik.obrazWynikowy.Image = imgBinarize.Bitmap;
                    wynik.Height = picture.Image.Height;
                    wynik.Width = picture.Image.Width;
                    wynik.obrazWynikowy.Height = picture.Image.Height;
                    wynik.obrazWynikowy.Width = picture.Image.Width;
                    wynik.Show();

                    break;
                /////////////////////////////////////////OCR - Tesseract/////////////////////////////
                case "OCR":

                    wynik = new Obraz();
                    Bitmap img = (Bitmap)zrodlo.Clone();
                    TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
                    Page page = engine.Process(img, PageSegMode.Auto);
                    string result = page.GetText();
                    wynik.richTextBox1.AppendText(result);
                    wynik.Show();
                    
                    break;
                /////////////////////////////////////////////Klasyfikator cech - DetectFaceHaar - ///////////////////////
                case "Klasyfikator cech":
                    {
                        try
                        {
                            string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");
                            string eyePath = Path.GetFullPath(@"../../data/haarcascade_eye.xml");


                            CascadeClassifier classifierFace = new CascadeClassifier(facePath);
                            CascadeClassifier classifierEye = new CascadeClassifier(eyePath);

                            var imgGray = imgInput.Convert<Gray, byte>().Clone();
                            Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, 1.1, 4);
                            foreach (var face in faces)
                            {
                                imgInput.Draw(face, new Bgr(0, 0, 255), 2);

                                imgGray.ROI = face;
                                Rectangle[] eyes = classifierEye.DetectMultiScale(imgGray, 1.1, 4);
                                foreach (var eye in eyes)
                                {
                                    var ey = eye;
                                    ey.X += face.X;
                                    ey.Y += face.Y;
                                    imgInput.Draw(ey, new Bgr(0, 255, 0), 2);
                                }
                            }
                            Obraz wynikowy5 = new Obraz();
                            wynikowy5.richTextBox1.Visible = false;
                            wynikowy5.obrazWynikowy.Visible = true;
                            wynikowy5.obrazWynikowy.Image = imgInput.Bitmap;
                            wynikowy5.Height = picture.Image.Height;
                            wynikowy5.Width = picture.Image.Width;
                            wynikowy5.obrazWynikowy.Height = picture.Image.Height;
                            wynikowy5.obrazWynikowy.Width = picture.Image.Width;
                            wynikowy5.Show();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    break;
            }

        }


    }
  }
