        using System;
        using System.Drawing;
        using System.Windows.Forms;
        using Emgu.CV;
        using Emgu.CV.CvEnum;
        using Emgu.CV.Structure;
        using Emgu.CV.Util;
        using System.Data.SqlClient;

    // ... (Using statements)

    namespace test
    {
        public partial class Testb : Form
        {
            private Image<Bgr, byte> selectedImage;
            private Rectangle[] eyes;
            private string connectionString = "Server=tcp:projesdb.database.windows.net,1433;Initial Catalog=Bruckner;Persist Security Info=False;User ID=dbadmin;Password=98569856Mert;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            public Testb()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                    DetectEyes(openFileDialog.FileName);
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                if (eyes == null || eyes.Length == 0)
                {
                    MessageBox.Show("Gözler bulunamadı.");
                    return;
                }

                bool strabismusDetected = false;
                string ogrdurum = "";

                foreach (Rectangle eye in eyes)
                {
                    // Dikdörtgenin merkez koordinatlarını hesapla
                    int centerX = eye.X + eye.Width / 2;
                    int centerY = eye.Y + eye.Height / 2;

                    int imageCenterX = selectedImage.Width / 2;

                    // Gözün x koordinatını resmin merkezine göre karşılaştır
                    if (centerX > imageCenterX)
                    {
                        ogrdurum = "Sol gözde şaşılık";
                        MessageBox.Show($"Şaşılık tespit edildi! Sol gözde şaşılık bulundu.");
                        strabismusDetected = true;
                        break;
                    }
                    else
                    {
                        ogrdurum = "Sağ gözde şaşılık";
                        MessageBox.Show($"Şaşılık tespit edildi! Sağ gözde şaşılık bulundu.");
                        strabismusDetected = true;
                        break;
                    }
                }

                if (!strabismusDetected)
                {
                    MessageBox.Show("Şaşılık tespit edilmedi.");
                }

                if (!int.TryParse(textBox1.Text, out int id))
                {
                    MessageBox.Show("Lütfen geçerli bir öğrenci ID'si girin.");
                    return;
                }

                try
                {
                    using MemoryStream rightEyeMemoryStream = new MemoryStream();
                    selectedImage.Copy(eyes[0]).ToBitmap().Save(rightEyeMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] rightEyeBytes = rightEyeMemoryStream.ToArray();

                    using MemoryStream leftEyeMemoryStream = new MemoryStream();
                    selectedImage.Copy(eyes[1]).ToBitmap().Save(leftEyeMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] leftEyeBytes = leftEyeMemoryStream.ToArray();

                    SaveEyesToDatabase(rightEyeBytes, leftEyeBytes, id, ogrdurum);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gözleri veritabanına kaydederken hata oluştu: " + ex.Message);
                }
            }

            private void SaveEyesToDatabase(byte[] rightEyeBytes, byte[] leftEyeBytes, int id, string ogrdurum)
            {
                try
                {
                    using SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ogr_table SET saggoz = @rightEye, solgoz = @leftEye, ogrdurum = @ogrdurum WHERE ID = @id", connection);
                    cmd.Parameters.AddWithValue("@rightEye", rightEyeBytes);
                    cmd.Parameters.AddWithValue("@leftEye", leftEyeBytes);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ogrdurum", ogrdurum);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gözleri veritabanına kaydederken hata oluştu: " + ex.Message);
                }
            }

            private void DetectEyes(string imagePath)
            {
                int minSquareSize = 100;
                selectedImage = new Image<Bgr, byte>(imagePath);

                CascadeClassifier eyeClassifier = new CascadeClassifier("haarcascade_eye.xml");

                Image<Gray, byte> grayImage = selectedImage.Convert<Gray, byte>();

                eyes = eyeClassifier.DetectMultiScale(grayImage, 1.1, 4);

                MCvScalar color = new Bgr(Color.Yellow).MCvScalar;

                foreach (Rectangle eye in eyes)
                {
                    if (eye.Width < minSquareSize || eye.Height < minSquareSize)
                    {
                        continue;
                    }

                    int squareSize = Math.Min(eye.Width, eye.Height);
                    Rectangle square = new Rectangle(eye.X + eye.Width / 2 - squareSize / 2, eye.Y + eye.Height / 2 - squareSize / 2, squareSize, squareSize);

                    CvInvoke.Rectangle(selectedImage, square, color, 2);

                    int middleX = square.Left + (square.Width / 2);

                    CvInvoke.Line(selectedImage, new Point(middleX, square.Top), new Point(middleX, square.Bottom), color, 2);

                    CvInvoke.Line(selectedImage, new Point(square.Left, square.Top + square.Height / 2), new Point(square.Right, square.Top + square.Height / 2), color, 2);
                }
                pictureBox1.Image = selectedImage.ToBitmap();
            }
        }
    }