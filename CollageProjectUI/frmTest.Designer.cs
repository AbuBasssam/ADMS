namespace CollageProjectUI
{
    partial class frmTest
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
            this.txtSearchResult = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.circulePictureBox1 = new CollageProjectUI.CirculePictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circulePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchResult
            // 
            this.txtSearchResult.BorderThickness = 0;
            this.txtSearchResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchResult.DefaultText = "";
            this.txtSearchResult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchResult.DisabledState.Parent = this.txtSearchResult;
            this.txtSearchResult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchResult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchResult.FocusedState.Parent = this.txtSearchResult;
            this.txtSearchResult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchResult.HoverState.Parent = this.txtSearchResult;
            this.txtSearchResult.Location = new System.Drawing.Point(4, 4);
            this.txtSearchResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchResult.Name = "txtSearchResult";
            this.txtSearchResult.PasswordChar = '\0';
            this.txtSearchResult.PlaceholderText = "";
            this.txtSearchResult.SelectedText = "";
            this.txtSearchResult.ShadowDecoration.Parent = this.txtSearchResult;
            this.txtSearchResult.Size = new System.Drawing.Size(282, 30);
            this.txtSearchResult.TabIndex = 0;
            this.txtSearchResult.TextChanged += new System.EventHandler(this.txtSearchResult_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtSearchResult);
            this.guna2Panel1.Location = new System.Drawing.Point(224, 80);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(290, 40);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(520, 80);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(117, 40);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Search";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(224, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 100);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // circulePictureBox1
            // 
            this.circulePictureBox1.Location = new System.Drawing.Point(69, 126);
            this.circulePictureBox1.Name = "circulePictureBox1";
            this.circulePictureBox1.Size = new System.Drawing.Size(68, 50);
            this.circulePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circulePictureBox1.TabIndex = 4;
            this.circulePictureBox1.TabStop = false;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circulePictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circulePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearchResult;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CirculePictureBox circulePictureBox1;
    }
}