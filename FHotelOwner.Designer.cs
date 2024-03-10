namespace Windows_Final_Term_Project
{
    partial class FHotelOwner
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
            this.lblRoonms = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.lblNumOfRooms = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // ucSearch1
            // 
            this.ucSearch1.Location = new System.Drawing.Point(0, 0);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(966, 533);
            this.ucSearch1.TabIndex = 0;
            // 
            // lblRoonms
            // 
            this.lblRoonms.AutoSize = true;
            this.lblRoonms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoonms.Location = new System.Drawing.Point(162, 343);
            this.lblRoonms.Name = "lblRoonms";
            this.lblRoonms.Size = new System.Drawing.Size(118, 37);
            this.lblRoonms.TabIndex = 34;
            this.lblRoonms.Text = "Rooms";
            // 
            // nudDuration
            // 
            this.nudDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nudDuration.Location = new System.Drawing.Point(61, 343);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(95, 44);
            this.nudDuration.TabIndex = 33;
            // 
            // lblNumOfRooms
            // 
            this.lblNumOfRooms.AutoSize = true;
            this.lblNumOfRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfRooms.Location = new System.Drawing.Point(54, 298);
            this.lblNumOfRooms.Name = "lblNumOfRooms";
            this.lblNumOfRooms.Size = new System.Drawing.Size(278, 37);
            this.lblNumOfRooms.TabIndex = 32;
            this.lblNumOfRooms.Text = "Number of Rooms";
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(169)))), ((int)(((byte)(83)))));
            this.btnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnPost.Location = new System.Drawing.Point(312, 411);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(284, 122);
            this.btnPost.TabIndex = 35;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(506, 298);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 37);
            this.lblPrice.TabIndex = 32;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(513, 343);
            this.txtPrice.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(389, 44);
            this.txtPrice.TabIndex = 36;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // FHotelOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 594);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblRoonms);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNumOfRooms);
            this.Controls.Add(this.ucSearch1);
            this.Name = "FHotelOwner";
            this.Text = "FHotelOwner";
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCSearch ucSearch1;
        private System.Windows.Forms.Label lblRoonms;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lblNumOfRooms;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
    }
}