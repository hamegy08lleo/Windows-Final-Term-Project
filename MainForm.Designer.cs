namespace Windows_Final_Term_Project
{
    partial class MainForm
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
            this.penalTop = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.bthPanership = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.penalTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // penalTop
            // 
            this.penalTop.Controls.Add(this.btnRegister);
            this.penalTop.Controls.Add(this.btnLogin);
            this.penalTop.Controls.Add(this.btnBooking);
            this.penalTop.Controls.Add(this.bthPanership);
            this.penalTop.Controls.Add(this.pictureBox1);
            this.penalTop.Controls.Add(this.lblLogo);
            this.penalTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.penalTop.Location = new System.Drawing.Point(0, 0);
            this.penalTop.Name = "penalTop";
            this.penalTop.Size = new System.Drawing.Size(1500, 169);
            this.penalTop.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 169);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1500, 831);
            this.panelCenter.TabIndex = 0;
            this.panelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCenter_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Windows_Final_Term_Project.Properties.Resources.HorizonTrailLogo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLogo.Location = new System.Drawing.Point(160, 76);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(297, 37);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Horizon Trail Travel";
            // 
            // bthPanership
            // 
            this.bthPanership.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bthPanership.Location = new System.Drawing.Point(860, 30);
            this.bthPanership.Name = "bthPanership";
            this.bthPanership.Size = new System.Drawing.Size(186, 73);
            this.bthPanership.TabIndex = 1;
            this.bthPanership.Text = "Parnership";
            this.bthPanership.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnLogin.Location = new System.Drawing.Point(1080, 30);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(186, 73);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRegister.Location = new System.Drawing.Point(1287, 30);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(186, 73);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBooking.Location = new System.Drawing.Point(631, 30);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(186, 73);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.penalTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.penalTop.ResumeLayout(false);
            this.penalTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel penalTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button bthPanership;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBooking;
    }
}