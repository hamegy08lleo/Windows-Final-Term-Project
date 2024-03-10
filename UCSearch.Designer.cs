namespace Windows_Final_Term_Project
{
    partial class UCSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckOutValue = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.lblNights = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlace
            // 
            this.txtPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlace.Location = new System.Drawing.Point(52, 105);
            this.txtPlace.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(854, 44);
            this.txtPlace.TabIndex = 0;
            this.txtPlace.Enter += new System.EventHandler(this.txtPlace_Enter);
            this.txtPlace.Leave += new System.EventHandler(this.txtPlace_Leave);
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(48, 55);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(458, 37);
            this.lblPlace.TabIndex = 1;
            this.lblPlace.Text = "City, destination, or hotel name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 151);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckIn.Location = new System.Drawing.Point(52, 230);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(275, 44);
            this.dtCheckIn.TabIndex = 4;
            this.dtCheckIn.ValueChanged += new System.EventHandler(this.dtCheckIn_ValueChanged);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(48, 185);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(142, 37);
            this.lblCheckIn.TabIndex = 6;
            this.lblCheckIn.Text = "Check-in";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(375, 186);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(139, 37);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "Duration";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // cbRoomType
            // 
            this.cbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "1 Single Bed",
            "2 Single Bed",
            "1 Couple Bed ",
            "2 Couple Bed"});
            this.cbRoomType.Location = new System.Drawing.Point(54, 375);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(275, 45);
            this.cbRoomType.TabIndex = 10;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(48, 328);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(181, 37);
            this.lblRoomType.TabIndex = 11;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(671, 186);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(162, 37);
            this.lblCheckOut.TabIndex = 12;
            this.lblCheckOut.Text = "Check-out";
            // 
            // lblCheckOutValue
            // 
            this.lblCheckOutValue.AutoSize = true;
            this.lblCheckOutValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutValue.Location = new System.Drawing.Point(672, 235);
            this.lblCheckOutValue.Name = "lblCheckOutValue";
            this.lblCheckOutValue.Size = new System.Drawing.Size(0, 37);
            this.lblCheckOutValue.TabIndex = 13;
            // 
            // nudDuration
            // 
            this.nudDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nudDuration.Location = new System.Drawing.Point(382, 230);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(95, 44);
            this.nudDuration.TabIndex = 15;
            this.nudDuration.ValueChanged += new System.EventHandler(this.nudDuration_ValueChanged);
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNights.Location = new System.Drawing.Point(483, 237);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(109, 37);
            this.lblNights.TabIndex = 16;
            this.lblNights.Text = "Nights";
            // 
            // UCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.lblCheckOutValue);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.txtPlace);
            this.Name = "UCSearch";
            this.Size = new System.Drawing.Size(1002, 646);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblDuration;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lblCheckOutValue;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lblNights;
    }
}
