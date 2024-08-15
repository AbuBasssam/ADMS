namespace CollageProjectUI
{
    partial class frmShowTest
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
            this.lblSimlarPercentage = new System.Windows.Forms.Label();
            this.pbSimlarityImage = new System.Windows.Forms.PictureBox();
            this.lblSimlarityImage = new System.Windows.Forms.Label();
            this.pbSample = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTestID = new System.Windows.Forms.Label();
            this.lblTestDate = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSimlarityImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSample)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSimlarPercentage
            // 
            this.lblSimlarPercentage.AutoSize = true;
            this.lblSimlarPercentage.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimlarPercentage.Location = new System.Drawing.Point(362, 356);
            this.lblSimlarPercentage.Name = "lblSimlarPercentage";
            this.lblSimlarPercentage.Size = new System.Drawing.Size(287, 28);
            this.lblSimlarPercentage.TabIndex = 30;
            this.lblSimlarPercentage.Text = " Matching Percentage : ";
            // 
            // pbSimlarityImage
            // 
            this.pbSimlarityImage.Location = new System.Drawing.Point(676, 75);
            this.pbSimlarityImage.Name = "pbSimlarityImage";
            this.pbSimlarityImage.Size = new System.Drawing.Size(250, 250);
            this.pbSimlarityImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSimlarityImage.TabIndex = 29;
            this.pbSimlarityImage.TabStop = false;
            // 
            // lblSimlarityImage
            // 
            this.lblSimlarityImage.AutoSize = true;
            this.lblSimlarityImage.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimlarityImage.Location = new System.Drawing.Point(671, 30);
            this.lblSimlarityImage.Name = "lblSimlarityImage";
            this.lblSimlarityImage.Size = new System.Drawing.Size(155, 28);
            this.lblSimlarityImage.TabIndex = 28;
            this.lblSimlarityImage.Text = "Matching with";
            // 
            // pbSample
            // 
            this.pbSample.Location = new System.Drawing.Point(369, 75);
            this.pbSample.Name = "pbSample";
            this.pbSample.Size = new System.Drawing.Size(250, 250);
            this.pbSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSample.TabIndex = 27;
            this.pbSample.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sample ";
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestID.Location = new System.Drawing.Point(12, 39);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(109, 28);
            this.lblTestID.TabIndex = 31;
            this.lblTestID.Text = "Test ID : ";
            // 
            // lblTestDate
            // 
            this.lblTestDate.AutoSize = true;
            this.lblTestDate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDate.Location = new System.Drawing.Point(12, 126);
            this.lblTestDate.Name = "lblTestDate";
            this.lblTestDate.Size = new System.Drawing.Size(125, 28);
            this.lblTestDate.TabIndex = 32;
            this.lblTestDate.Text = "Test Date :";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(12, 210);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(130, 28);
            this.lblPatientID.TabIndex = 33;
            this.lblPatientID.Text = "Patient ID :";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(12, 263);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(126, 28);
            this.lblDoctorID.TabIndex = 34;
            this.lblDoctorID.Text = "Doctor ID :";
            // 
            // frmShowTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 422);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblTestDate);
            this.Controls.Add(this.lblTestID);
            this.Controls.Add(this.lblSimlarPercentage);
            this.Controls.Add(this.pbSimlarityImage);
            this.Controls.Add(this.lblSimlarityImage);
            this.Controls.Add(this.pbSample);
            this.Controls.Add(this.label1);
            this.Name = "frmShowTest";
            this.Text = "frmShowTest";
            this.Load += new System.EventHandler(this.frmShowTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSimlarityImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSimlarPercentage;
        private System.Windows.Forms.PictureBox pbSimlarityImage;
        private System.Windows.Forms.Label lblSimlarityImage;
        private System.Windows.Forms.PictureBox pbSample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.Label lblTestDate;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblDoctorID;
    }
}