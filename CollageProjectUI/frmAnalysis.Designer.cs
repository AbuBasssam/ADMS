namespace CollageProjectUI
{
    partial class frmAnalysis
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
            this.lblPersentage = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbSample = new System.Windows.Forms.PictureBox();
            this.pbDtabaseSample = new System.Windows.Forms.PictureBox();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectSample = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDtabaseSample)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersentage
            // 
            this.lblPersentage.AutoSize = true;
            this.lblPersentage.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersentage.Location = new System.Drawing.Point(835, 404);
            this.lblPersentage.Name = "lblPersentage";
            this.lblPersentage.Size = new System.Drawing.Size(47, 28);
            this.lblPersentage.TabIndex = 13;
            this.lblPersentage.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(326, 395);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(490, 37);
            this.progressBar1.TabIndex = 12;
            // 
            // pbSample
            // 
            this.pbSample.Location = new System.Drawing.Point(372, 56);
            this.pbSample.Name = "pbSample";
            this.pbSample.Size = new System.Drawing.Size(250, 250);
            this.pbSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSample.TabIndex = 11;
            this.pbSample.TabStop = false;
            // 
            // pbDtabaseSample
            // 
            this.pbDtabaseSample.Location = new System.Drawing.Point(999, 56);
            this.pbDtabaseSample.Name = "pbDtabaseSample";
            this.pbDtabaseSample.Size = new System.Drawing.Size(250, 250);
            this.pbDtabaseSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDtabaseSample.TabIndex = 10;
            this.pbDtabaseSample.TabStop = false;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(1068, 376);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(152, 56);
            this.btnAnalysis.TabIndex = 9;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(994, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Compare with";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sample";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Welcome Docotr : ";
            // 
            // btnSelectSample
            // 
            this.btnSelectSample.Location = new System.Drawing.Point(17, 77);
            this.btnSelectSample.Name = "btnSelectSample";
            this.btnSelectSample.Size = new System.Drawing.Size(152, 56);
            this.btnSelectSample.TabIndex = 15;
            this.btnSelectSample.Text = "import Sample";
            this.btnSelectSample.UseVisualStyleBackColor = true;
            this.btnSelectSample.Click += new System.EventHandler(this.btnSelectSample_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(158, 185);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 32);
            this.textBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "File Number : ";
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 471);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelectSample);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPersentage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbSample);
            this.Controls.Add(this.pbDtabaseSample);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAnalysis";
            this.Text = "Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.pbSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDtabaseSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersentage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pbSample;
        private System.Windows.Forms.PictureBox pbDtabaseSample;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectSample;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

