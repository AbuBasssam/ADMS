using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageProjectUI
{
    public partial class frmShowTest : Form
    {
        public frmShowTest(int TestID,int PatientID,int DoctorID,DateTime TestDate, string Sample, string SimlarImage,double Percentage)
        {
            InitializeComponent();
            lblTestID.Text += TestID;
            lblPatientID.Text += PatientID;
            lblDoctorID.Text += DoctorID;
            lblTestDate.Text += TestDate;
            pbSample.ImageLocation = Sample;
            pbSimlarityImage.ImageLocation = SimlarImage;
            lblSimlarPercentage.Text += Percentage.ToString() + " %";

                

        }

        private void frmShowTest_Load(object sender, EventArgs e)
        {

        }
    }
}
