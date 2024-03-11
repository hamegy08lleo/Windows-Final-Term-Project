namespace Windows_Final_Term_Project
{
    partial class FCustomer
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
            this.ucSearch1 = new Windows_Final_Term_Project.UCSearch();
            this.lblNights = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.lblCheckOutValue = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // ucSearch1
            // 
            this.ucSearch1.Location = new System.Drawing.Point(-2, 0);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(979, 582);
            this.ucSearch1.TabIndex = 24;
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNights.Location = new System.Drawing.Point(489, 352);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(109, 37);
            this.lblNights.TabIndex = 31;
            this.lblNights.Text = "Nights";
            // 
            // nudDuration
            // 
            this.nudDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nudDuration.Location = new System.Drawing.Point(388, 352);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(95, 44);
            this.nudDuration.TabIndex = 30;
            this.nudDuration.ValueChanged += new System.EventHandler(this.nudDuration_ValueChanged);
            // 
            // lblCheckOutValue
            // 
            this.lblCheckOutValue.AutoSize = true;
            this.lblCheckOutValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutValue.Location = new System.Drawing.Point(678, 357);
            this.lblCheckOutValue.Name = "lblCheckOutValue";
            this.lblCheckOutValue.Size = new System.Drawing.Size(0, 37);
            this.lblCheckOutValue.TabIndex = 29;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(677, 307);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(162, 37);
            this.lblCheckOut.TabIndex = 28;
            this.lblCheckOut.Text = "Check-out";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(381, 307);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(139, 37);
            this.lblDuration.TabIndex = 27;
            this.lblDuration.Text = "Duration";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(46, 307);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(142, 37);
            this.lblCheckIn.TabIndex = 26;
            this.lblCheckIn.Text = "Check-in";
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckIn.Location = new System.Drawing.Point(53, 351);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtCheckIn.Size = new System.Drawing.Size(273, 44);
            this.dtCheckIn.TabIndex = 25;
            this.dtCheckIn.ValueChanged += new System.EventHandler(this.dtCheckIn_ValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSearch.Location = new System.Drawing.Point(338, 445);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(284, 122);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // FCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 594);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.lblCheckOutValue);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.ucSearch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FCustomer";
            this.Text = "FCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UCSearch ucSearch1;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lblCheckOutValue;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.Button btnSearch;
    }
}