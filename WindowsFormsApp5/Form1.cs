using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging.ComplexFilters;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using AForge.Math;
using AForge.Controls;
using SVM;


namespace WindowsFormsApp5
{

    public partial class Form1 : Form
    {
        public Bitmap srcImg, dstImg;
        public Bitmap overlay;
        public string path = @"D:\Images";
        public IntPoint blob;
        private object pen;
        private object list;

        public object AI { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        public static Bitmap resize(Bitmap image, Size size)
        {
            return (Bitmap)(new Bitmap(image, size));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openDialog.FileName);
                Bitmap sampleImage = new Bitmap(openDialog.FileName);
                overlay = new Bitmap(openDialog.FileName);

            }

        }

        private void grayScaleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GrayscaleBT709 grayObject = new GrayscaleBT709();
            pictureBox2.Image = grayObject.Apply((Bitmap)pictureBox1.Image);
        }

        private void sepiaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Sepia sepiaobject = new Sepia();
            pictureBox2.Image = sepiaobject.Apply((Bitmap)pictureBox1.Image);
        }

        private void grayScaleRMYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleRMY rmyobject = new GrayscaleRMY();
            pictureBox2.Image = rmyobject.Apply((Bitmap)pictureBox1.Image);
        }

        private void hueModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HueModifier hue = new HueModifier();
            pictureBox2.Image = hue.Apply((Bitmap)pictureBox1.Image);

        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramEqualization hist = new HistogramEqualization();
            pictureBox2.Image = hist.Apply((Bitmap)pictureBox1.Image);
        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtractNormalizedRGBChannel rgb = new ExtractNormalizedRGBChannel();
            pictureBox2.Image = rgb.Apply((Bitmap)pictureBox1.Image);
        }

        private void skinToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Bitmap skin = new Bitmap(pictureBox1.Image);
            var rect = new Rectangle(0, 0, skin.Width, skin.Height);
            var data = skin.LockBits(rect, ImageLockMode.ReadWrite, skin.PixelFormat);
            var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8; //bytes per pixel

            var buffer = new byte[data.Width * data.Height * depth];

            //copy pixels to buffer
            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);

            System.Threading.Tasks.Parallel.Invoke(
                () =>
                {
                        //upper-left
                        Process(buffer, 0, 0, data.Width / 2, data.Height / 2, data.Width, depth);
                },
                () =>
                {
                        //upper-right
                        Process(buffer, data.Width / 2, 0, data.Width, data.Height / 2, data.Width, depth);
                },
                () =>
                {
                        //lower-left
                        Process(buffer, 0, data.Height / 2, data.Width / 2, data.Height, data.Width, depth);
                },
                () =>
                {
                        //lower-right
                        Process(buffer, data.Width / 2, data.Height / 2, data.Width, data.Height, data.Width, depth);
                }
            );

            //Copy the buffer back to image
            Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);

            skin.UnlockBits(data);
            pictureBox2.Image = skin;
        }

        void Process(byte[] buffer, int x, int y, int endx, int endy, int width, int depth)
        {
            for (int i = x; i < endx; i++)
            {
                for (int j = y; j < endy; j++)
                {
                    var offset = ((j * width) + i) * depth;
                    var B = buffer[offset + 0];
                    var G = buffer[offset + 1];
                    var R = buffer[offset + 2];
                    var a = Math.Max(R, Math.Max(B, G));
                    var b = Math.Min(R, Math.Min(B, G));
                    if (!((R > 95) && (G > 40) && (B > 20) && ((a - b) > 15) && (Math.Abs(R - G) > 15) && (R > G) && (R > B)))
                    {
                        buffer[offset + 0] = buffer[offset + 1] = buffer[offset + 2] = 0;

                    }
                    else
                    {
                        buffer[offset + 0] = buffer[offset + 1] = buffer[offset + 2] = 255;
                    }
                }
            }
        }


        /* private void skinToolStripMenuItem_Click(object sender, EventArgs e)
         {
             int x = 0, y = 0, Max = 0, Min = 0;
             int h=0, DR,DG,DB;
             pictureBox2.InitialImage = null;
             OpenFileDialog openDialog = new OpenFileDialog();
             if (openDialog.ShowDialog() == DialogResult.OK)
             {
                 pictureBox1.Image = new Bitmap(openDialog.FileName);
                 Bitmap skin = new Bitmap(openDialog.FileName);
                 //Bitmap sampleimage = new Bitmap(openDialog.FileName);                
                 for (x = 1; x < skin.Width - 1; x++)
                 {
                     for (y = 1; y < skin.Height - 1; y++)
                     {
                         System.Drawing.Color skinTestColor = skin.GetPixel(x, y);
                         Max = Math.Max(skinTestColor.R, Math.Max(skinTestColor.G, skinTestColor.B));
                         Min = Math.Min(skinTestColor.R, Math.Min(skinTestColor.G, skinTestColor.B));


                         DR = ((Max - skinTestColor.R) / 6) + (Max / 2) / Max;
                         DG = ((Max - skinTestColor.G) / 6) + (Max / 2) / Max;
                         DB = ((Max - skinTestColor.G) / 6) + (Max / 2) / Max;
                          if (Max == skinTestColor.R)
                          {
                             h =  DB - DG;
                          }
                          if (Max == skinTestColor.G)
                          {
                             h = (1 / 3) + DR - DB;
                          }
                          if(Max == skinTestColor.B)
                          {
                             h = (2 / 3) + DG - DR;
                          }                        
                          if (!((skinTestColor.R > 95 && skinTestColor.G > 40 && skinTestColor.B > 20 && (Max - Min) > 15 && Math.Abs(skinTestColor.R - skinTestColor.G) > 15 && skinTestColor.R > skinTestColor.G && skinTestColor.R > skinTestColor.B)   && (h>=0.05 && h<=0.17)))
                          {
                             skin.SetPixel(x, y, Color.Black);
                          }

                     }
                     pictureBox2.Image = skin; 
                 }
             }
         }*/




        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Browse save location";
            saveDialog.DefaultExt = "jpeg";
            saveDialog.Filter = "Jpeg files (*.jpeg)|*.jpeg|Png files (*.png)|*.png|Jpg files (*.jpg)|*.jpg";
            try
            {
                Bitmap resultImage = new Bitmap(pictureBox2.Image);
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    resultImage.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("No Image Found To Save");
            }
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opening filter = new Opening();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox1.Image);

        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create filter
            Closing filter = new Closing();
            // apply the filter
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox1.Image);
        }

        private void tophatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopHat filter = new TopHat();
            // apply the filter
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox1.Image);

        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erosion filter = new Erosion();
            // apply the filter
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox1.Image);
        }

        private void dilatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilatation filter = new Dilatation();
            // apply the filter
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox1.Image);
        }

        private void bottomHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BottomHat filter = new BottomHat();
            // apply the filter
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox1.Image);
        }

        private void blobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlobsFiltering filter = new BlobsFiltering();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox1.Image);
        }

        private void reapplyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Opening filter = new Opening();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);

        }

        private void reapplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erosion filter = new Erosion();
            // apply the filter
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void reapplyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dilatation filter = new Dilatation();
            // apply the filter
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void reapplyToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BottomHat filter = new BottomHat();
            // apply the filter
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox1.Image);
        }

        private void homogenityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 grayObject = new GrayscaleBT709();
            pictureBox2.Image = grayObject.Apply((Bitmap)pictureBox1.Image);
            HomogenityEdgeDetector filter = new HomogenityEdgeDetector();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);

        }

        private void sobolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 grayObject = new GrayscaleBT709();
            pictureBox2.Image = grayObject.Apply((Bitmap)pictureBox1.Image);
            SobelEdgeDetector filter = new SobelEdgeDetector();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 grayObject = new GrayscaleBT709();
            pictureBox2.Image = grayObject.Apply((Bitmap)pictureBox1.Image);
            CannyEdgeDetector filter = new CannyEdgeDetector();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void reapplyToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //GrayscaleBT709 grayObject = new GrayscaleBT709();
            //pictureBox2.Image = grayObject.Apply((Bitmap)pictureBox2.Image);
            HomogenityEdgeDetector filter = new HomogenityEdgeDetector();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void reapplyToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //GrayscaleBT709 grayObject = new GrayscaleBT709();
            //pictureBox2.Image = grayObject.Apply((Bitmap)pictureBox2.Image);
            SobelEdgeDetector filter = new SobelEdgeDetector();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void reapplyToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //GrayscaleBT709 grayObject = new GrayscaleBT709();
            //pictureBox2.Image = grayObject.Apply((Bitmap)pictureBox2.Image);
            CannyEdgeDetector filter = new CannyEdgeDetector();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap src = new Bitmap(pictureBox1.Image);
            Bitmap res = new Bitmap(pictureBox2.Image);
            src = resize(src, new Size(200, 200));
            res = resize(res, new Size(200, 200));
            pictureBox1.Image = src;
            pictureBox2.Image = res;
        }

        private void extractBiggestBlobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtractBiggestBlob filter = new ExtractBiggestBlob();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
            blob = filter.BlobPosition;
        }

        private void coToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectedComponentsLabeling filter = new ConnectedComponentsLabeling();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void differenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 grayObject = new GrayscaleBT709();
            pictureBox2.Image = grayObject.Apply((Bitmap)pictureBox1.Image);
            DifferenceEdgeDetector filter = new DifferenceEdgeDetector();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void binarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 grayoject = new GrayscaleBT709();
            pictureBox2.Image = grayoject.Apply((Bitmap)pictureBox1.Image);
            Threshold filter = new Threshold();
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void reapplyToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 grayoject = new GrayscaleBT709();
            pictureBox2.Image = grayoject.Apply((Bitmap)pictureBox2.Image);
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap src = new Bitmap(pictureBox1.Image);
            Bitmap res = new Bitmap(pictureBox2.Image);
            Bitmap newBmp = new Bitmap(src.Width, res.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);


            //Threshold t = new Threshold();
            //pictureBox2.Image = t.Apply((Bitmap)pictureBox2.Image); 
            for (int i = 0; i < res.Width; i++)
            {
                for (int j = 0; j < res.Height; j++)
                {
                    System.Drawing.Color srcColor = src.GetPixel(i + blob.X, j + blob.Y);
                    System.Drawing.Color dstColor = res.GetPixel(i, j);
                    if (!(dstColor.R >= 0 && dstColor.R <= 10 && dstColor.G >= 0 && dstColor.G <= 10 && dstColor.B >= 0 && dstColor.B <= 10))
                    {
                        newBmp.SetPixel(i, j, srcColor);
                    }
                    else
                    {
                        newBmp.SetPixel(i, j, Color.Black);
                    }


                }
            }
            res = newBmp;
            pictureBox2.Image = newBmp;
        }

        private void reapplyToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //create filter
            Closing filter = new Closing();
            // apply the filter
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
        }

        private void hOGToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<double> edgeCount = new List<double>();
            List<double> ratio = new List<double>();
            int pixelCount = 0;
            Bitmap Destimg = new Bitmap(pictureBox2.Image);
            GrayscaleBT709 go = new GrayscaleBT709();
            pictureBox2.Image = go.Apply((Bitmap)pictureBox2.Image);
            Destimg = go.Apply(Destimg);
            CannyEdgeDetector filter = new CannyEdgeDetector(0, 0, 1.4);
            pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
            Destimg = filter.Apply(Destimg);


            var imgarray = new System.Drawing.Image[36];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    pixelCount++;
                    var index = i * 6 + j;
                    imgarray[index] = new Bitmap(40, 40);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(Destimg, new Rectangle(0, 0, 40, 40), new Rectangle(i * 40, j * 40, 40, 40), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }
            for (int n = 0; n < 36; n++)
            {
                int counter = 0;


                Bitmap bufferImage = new Bitmap(imgarray[n]);
                for (int i = 0; i < 40; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        System.Drawing.Color hoefColor = bufferImage.GetPixel(i, j);
                        //if(hoefColor.R<=255 && hoefColor.R>=230 && hoefColor.G <= 255 && hoefColor.G >= 230 && hoefColor.B <= 255 && hoefColor.B >= 230)
                        if (!(hoefColor.R == 0 && hoefColor.G == 0 && hoefColor.B == 0))
                        {

                            counter++;
                        }
                    }

                }

                edgeCount.Add(counter);


                //HistogramEqualization 
                /*if (File.Exists(@"D:\AI.txt"))
                {
                    using (StreamWriter ssw = new StreamWriter(@"D:\AI.txt"))
                    {
                        ssw.Write(counter);
                        //tw.WriteLine(Lists.edgeCount);
                        //tw.Close();
                       

                    }
                }*/
            }
            double total = edgeCount.Sum();
            foreach (double x in edgeCount)
            {
                var a = (float)x / total;
                ratio.Add(a);
            }

            FileStream fs = new FileStream(@"D:\AI.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < ratio.Count; ++i)
            {
                sw.Write(i + ":" + ratio[i].ToString() + " ");
            }
            sw.WriteLine();
            sw.Close();
            fs.Close();

        }


        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sVMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Problem train = Problem.Read(@"D:\AI.txt");
            Problem test = Problem.Read(@"D:\test.txt");

            Parameter parameters = new Parameter();

            double C;
            double Gamma;

            parameters.C = 32; parameters.Gamma = 8;
            Model model = Training.Train(train, parameters);
            Prediction.Predict(test, @"D:\result.txt", model, false);
        }


        private void resultGestureToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int dir;
            int no;
            List<string> filedir = new List<string>(Directory.GetDirectories(path));
            for (dir = 0, no = 0; (dir < filedir.Count && no <=26); dir++, no++)
            {
                string[] filePaths = Directory.GetFiles(filedir[dir].ToString());
                List<Bitmap> y = new List<Bitmap>();
                foreach (var iI in filePaths)
                {
                    Bitmap Image = new Bitmap(iI);
                    y.Add(Image);
                }

                foreach (Bitmap img in y)
                {
                    pictureBox1.Image = img;
                    srcImg = img;
                    dstImg = img;
                    Bitmap skin = new Bitmap(pictureBox1.Image);
                    var rect = new Rectangle(0, 0, skin.Width, skin.Height);
                    var data = skin.LockBits(rect, ImageLockMode.ReadWrite, skin.PixelFormat);
                    var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8; //bytes per pixel

                    var buffer = new byte[data.Width * data.Height * depth];

                    //copy pixels to buffer
                    Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);

                    System.Threading.Tasks.Parallel.Invoke(
                        () =>
                        {
                            //upper-left
                            Process(buffer, 0, 0, data.Width / 2, data.Height / 2, data.Width, depth);
                        },
                        () =>
                        {
                            //upper-right
                            Process(buffer, data.Width / 2, 0, data.Width, data.Height / 2, data.Width, depth);
                        },
                        () =>
                        {
                            //lower-left
                            Process(buffer, 0, data.Height / 2, data.Width / 2, data.Height, data.Width, depth);
                        },
                        () =>
                        {
                            //lower-right
                            Process(buffer, data.Width / 2, data.Height / 2, data.Width, data.Height, data.Width, depth);
                        }
                    );

                    //Copy the buffer back to image
                    Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);

                    skin.UnlockBits(data);
                    pictureBox2.Image = skin;




                    Bitmap src = new Bitmap(pictureBox1.Image);
                    Bitmap res = new Bitmap(pictureBox2.Image);
                    src = resize(src, new Size(200, 200));
                    res = resize(res, new Size(200, 200));
                    pictureBox1.Image = src;
                    pictureBox2.Image = res;

                    GrayscaleBT709 grayoject = new GrayscaleBT709();
                    pictureBox2.Image = grayoject.Apply((Bitmap)pictureBox2.Image);

                    Dilatation filter = new Dilatation();
                    // apply the filter
                    pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);

                    ExtractBiggestBlob filter1 = new ExtractBiggestBlob();
                    pictureBox2.Image = filter.Apply((Bitmap)pictureBox2.Image);
                    blob = filter1.BlobPosition;

                    Bitmap src1 = new Bitmap(pictureBox1.Image);
                    Bitmap res1 = new Bitmap(pictureBox2.Image);
                    Bitmap newBmp = new Bitmap(src1.Width, res1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);


                    //Threshold t = new Threshold();
                    //pictureBox2.Image = t.Apply((Bitmap)pictureBox2.Image); 
                    for (int i = 0; i < res1.Width; i++)
                    {
                        for (int j = 0; j < res1.Height; j++)
                        {
                            System.Drawing.Color srcColor = src1.GetPixel(i + blob.X, j + blob.Y);
                            System.Drawing.Color dstColor = res1.GetPixel(i, j);
                            if (!(dstColor.R >= 0 && dstColor.R <= 10 && dstColor.G >= 0 && dstColor.G <= 10 && dstColor.B >= 0 && dstColor.B <= 10))
                            {
                                newBmp.SetPixel(i, j, srcColor);
                            }
                            else
                            {
                                newBmp.SetPixel(i, j, Color.Black);
                            }


                        }
                    }
                    res1 = newBmp;
                    pictureBox2.Image = newBmp;

                    List<double> edgeCount = new List<double>();
                    List<double> ratio = new List<double>();
                    int pixelCount = 0;
                    Bitmap Destimg = new Bitmap(pictureBox2.Image);
                    GrayscaleBT709 go = new GrayscaleBT709();
                    pictureBox2.Image = go.Apply((Bitmap)pictureBox2.Image);
                    Destimg = go.Apply(Destimg);
                    CannyEdgeDetector filter2 = new CannyEdgeDetector(0, 0, 1.4);
                    pictureBox2.Image = filter2.Apply((Bitmap)pictureBox2.Image);
                    Destimg = filter2.Apply(Destimg);


                    var imgarray = new System.Drawing.Image[36];

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            pixelCount++;
                            var index = i * 6 + j;
                            imgarray[index] = new Bitmap(40, 40);
                            var graphics = Graphics.FromImage(imgarray[index]);
                            graphics.DrawImage(Destimg, new Rectangle(0, 0, 40, 40), new Rectangle(i * 40, j * 40, 40, 40), GraphicsUnit.Pixel);
                            graphics.Dispose();
                        }
                    }

                    for (int n = 0; n < 36; n++)
                    {
                        int counter = 0;


                        Bitmap bufferImage = new Bitmap(imgarray[n]);
                        for (int i = 0; i < 40; i++)
                        {
                            for (int j = 0; j < 40; j++)
                            {
                                System.Drawing.Color hoefColor = bufferImage.GetPixel(i, j);
                                //if(hoefColor.R<=255 && hoefColor.R>=230 && hoefColor.G <= 255 && hoefColor.G >= 230 && hoefColor.B <= 255 && hoefColor.B >= 230)
                                if (!(hoefColor.R == 0 && hoefColor.G == 0 && hoefColor.B == 0))
                                {

                                    counter++;
                                }
                            }

                        }

                        edgeCount.Add(counter);



                    }

                    double total = edgeCount.Sum();
                    foreach (double x in edgeCount)
                    {
                        var a = (float)x / total;
                        ratio.Add(a);
                    }

                    FileStream fs = new FileStream(@"D:\AI.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);

                    
                    sw.Write((no) + " ");
                    for (int i = 0; i < ratio.Count; ++i)
                    {
                        sw.Write(i + ":" + ratio[i].ToString() + " ");
                    }
                    sw.WriteLine();
                    sw.Close();
                    fs.Close();

                    Problem train = Problem.Read(@"D:\AI.txt");
                    Problem test = Problem.Read(@"D:\test.txt");

                    Parameter parameters = new Parameter();

                    double C;
                    double Gamma;

                    parameters.C = 32; parameters.Gamma = 8;
                    Model model = Training.Train(train, parameters);
                    Prediction.Predict(test, @"D:\result.txt", model, false);
                }
            }

        }
    }
}




