using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageProjectUI
{
    public partial class frmPatientRecords : Form
    {
        public frmPatientRecords()
        {
            InitializeComponent();
        }
        static DataTable GetRecords(int FileNumber)
        {
            string ConnectionString = "Server=.;Database=ProjectDB;User Id=sa;Password=sa123456;";


            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = @"Select * From Tests where PatientID=@PatientID";




            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PatientID", FileNumber);

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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt= GetRecords((Convert.ToInt32(textBox1.Text.Trim())));
            dataGridView1.DataSource = dt;
        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);// Number only
        }

        private void showTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestID=(int)dataGridView1.CurrentRow.Cells[0].Value;
            int PatientID = (int)dataGridView1.CurrentRow.Cells[1].Value;
            int DoctorID = (int)dataGridView1.CurrentRow.Cells[2].Value;
            DateTime TestDate= (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            string Sample= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string SimlarImage= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            double Percentage= Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value);

            frmShowTest frm = new frmShowTest(TestID, PatientID, DoctorID, TestDate, Sample, SimlarImage, Percentage);
            frm.ShowDialog();
        }
    }
}
