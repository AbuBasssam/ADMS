using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CollageProjectUI
{
    public partial class frmAnalysis : Form
    {
        
        private clsDoctor _Doctor;
        string Sample;
      
        /* static void AddMalariaDataSet(int ID, string ImageName, string ImagePath)
        {
            //this function will return the new person id if succeeded and -1 if not.
            string ConnectionString = "Server=.;Database=DB1;User Id=sa;Password=sa123456;";
            SqlConnection connection = new SqlConnection(ConnectionString);
            int rowsAffected = 0;
            string query = @"INSERT INTO DBmalaria (ID,ImageName,ImagePath)
                               VALUES (@ID, @ImageName,@ImagePath)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@ImageName", ImageName);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0) { Counter++; }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);


            }

            finally
            {
                connection.Close();
            }

        }*/

        /*static void AddTheDataSetToDatabase()
        {
            string imageFolderPath2 = @"C:\Users\Hp\Desktop\College Project\malaria-segmentation-DatasetNinja\ds\img";

            string[] imageFiles = Directory.GetFiles(imageFolderPath2, "*.png");

            for (int i = 0; i < imageFiles.Length; i++)
            {
                int ID = i + 1;
                string ImagePath = imageFiles[i];

                string ImageName = imageFiles[i].Remove(0, 77);
                ImageName = ImageName.Replace(".png", "");
                AddMalariaDataSet(ID, ImageName, ImagePath);
            }


        }*/
        static DataTable GetImages()
        {
            string ConnectionString = "Server=.;Database=ProjectDB;User Id=sa;Password=sa123456;";


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = @"Select * From DBmalaria";




            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        static async Task< double> CompareImages(Bitmap image1, Bitmap image2)
         {
           
            // Make sure the images have the same dimensions
            if (image1.Width != image2.Width || image1.Height != image2.Height)
            {
                
                throw new ArgumentException("Images must have the same dimensions");
            }

            double difference = 0;

            // Compare pixels
            await Task.Run(() =>
            {
                // Compare pixels
                for (int y = 0; y < image1.Height; y++)
                {
                    for (int x = 0; x < image1.Width; x++)
                    {
                        Color pixel1 = image1.GetPixel(x, y);
                        Color pixel2 = image2.GetPixel(x, y);

                        // Compute the absolute difference between pixel values
                        int deltaR = Math.Abs(pixel1.R - pixel2.R);
                        int deltaG = Math.Abs(pixel1.G - pixel2.G);
                        int deltaB = Math.Abs(pixel1.B - pixel2.B);

                        // Accumulate the differences
                        difference += deltaR + deltaG + deltaB;
                    }
                }

            });

            // Normalize the difference by the maximum possible difference
            double maxDifference = 3 * 255 * image1.Width * image1.Height; // Assuming 8-bit color channels (0-255)
            double similarity = 1 - (difference / maxDifference);

            return similarity;
        }

        public Bitmap ResizeImage(string sourcePath, int newWidth, int newHeight)
        {
            // Load the source image
            using (System.Drawing.Image sourceImage = System.Drawing.Image.FromFile(sourcePath))
            {
                // Create a new bitmap with the desired dimensions
                using (Bitmap resizedImage = new Bitmap(newWidth, newHeight))
                {
                    // Create a graphics object to perform the resizing
                    using (Graphics graphics = Graphics.FromImage(resizedImage))
                    {
                        // Set the interpolation mode to high quality bicubic
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                        // Draw the resized image
                       graphics.DrawImage(sourceImage, 0, 0, newWidth, newHeight);
                    }

                    // Save the resized image to the destination path
                     return resizedImage;
                }
            }
        }
        
        async void AnalysisOpreation(string Sample, int DoctorID, int FileNumber)
         {
            Bitmap DatabaseImage;
            double Percentage = 0;
            string SimliarImage = "";
            DataTable dt = GetImages();
            progressBar1.Maximum=dt.Rows.Count;
            Bitmap targetImage = new Bitmap(pbSample.Image,new Size(1382,1030));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatabaseImage = new Bitmap(dt.Rows[i]["ImagePath"].ToString());
                pbDtabaseSample.ImageLocation = dt.Rows[i]["ImagePath"].ToString();
                Task<double>Compare= CompareImages(targetImage, DatabaseImage);
                double ComparePercentage = await  Compare;
                if (ComparePercentage > Percentage)
                {
                   
                    Percentage = ComparePercentage;
                    SimliarImage = dt.Rows[i]["ImagePath"].ToString();
                    

                }
                
               
                    progressBar1.Value ++ ;
                double Value =((double)(progressBar1.Value)/(double)(dt.Rows.Count)) * 100;

                lblPersentage.Text = Value.ToString("0.00") + " %";

                
                

            }

            int Result = AddNewTest(FileNumber, DoctorID, Sample, SimliarImage, Percentage);
            if (Result != -1)
            {
                MessageBox.Show($"Add Sucessfully with test ID= {Result}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Wrong Data", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        static int AddNewTest(int FileNumber, int DoctorID, string Sample, string SimalirImage, double SimilarPercentage)
        {
            //this function will return the new person id if succeeded and -1 if not.
            int TestID = -1;
            string ConnectionString = "Server=.;Database=ProjectDB;User Id=sa;Password=sa123456;";

            SqlConnection connection = new SqlConnection(ConnectionString);
            
            string query = @"INSERT INTO Tests (PatientID, DoctorID, TestDate,Sample,SimalirImage,SimilarPercentage)
                             VALUES (@PatientID, @DoctorID, @TestDate,@Sample,@SimalirImage,@SimilarPercentage);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PatientID", FileNumber);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);
            command.Parameters.AddWithValue("@TestDate", DateTime.Now);
            command.Parameters.AddWithValue("@Sample", Sample);
            command.Parameters.AddWithValue("@SimalirImage", SimalirImage);
            command.Parameters.AddWithValue("@SimilarPercentage", (SimilarPercentage * 100));

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return TestID;
        }

        void SetSample()
        {
            string folderPath = @"C:\Users\Hp\Desktop\Samples";
            string[] files = Directory.GetFiles(folderPath);

            if (files.Length > 0)
            {
                string lastFilePath = files.OrderByDescending(f => new FileInfo(f).LastWriteTime).First();
                Sample = lastFilePath;
                pbSample.Load(lastFilePath);
               
               
            }
           
        }
        public frmAnalysis(clsDoctor Doctor)
        {
            InitializeComponent();
            _Doctor = Doctor;
            label3.Text += Doctor.Name;
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "") { return; }
            AnalysisOpreation(Sample, _Doctor.DoctorID,Convert.ToInt16( textBox1.Text.Trim()));

        }

        private void btnSelectSample_Click(object sender, EventArgs e)
        {
            SetSample();
        }
    }
}
