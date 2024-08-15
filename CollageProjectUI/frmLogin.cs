using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CollageProjectUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsDoctor Doctor = clsDoctor.Find(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (Doctor != null)
            {

               
               

                this.Hide();
                frmAnalysis frm = new frmAnalysis(Doctor);
                frm.ShowDialog();
               
                this.Show();



            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
