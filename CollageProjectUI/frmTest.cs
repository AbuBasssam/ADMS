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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            //circulePictureBox1.ImageLocation=@"C:\Users\Hp\Desktop\Person1.png";
        }

        private void txtSearchResult_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchResult.TextLength >= 1)
            {
                flowLayoutPanel1.Controls.Clear();
                ctrlSearchResult result = new ctrlSearchResult();
                flowLayoutPanel1.Height = flowLayoutPanel1.Controls.Count * 50;
                //flowLayoutPanel1.Height++;
            }
            else
            {
                flowLayoutPanel1.Height = 0;
            }
        }
    }
}
