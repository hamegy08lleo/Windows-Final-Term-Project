using System.Diagnostics;
using System.Windows.Forms;

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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
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
            this.cbRoomType.Location = new System.Drawing.Point(54, 223);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(852, 45);
            this.cbRoomType.TabIndex = 10;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(48, 173);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(181, 37);
            this.lblRoomType.TabIndex = 11;
            this.lblRoomType.Text = "Room Type";
            // 
            // UCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.txtPlace);
            this.Name = "UCSearch";
            this.Size = new System.Drawing.Size(990, 533);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cbRoomType;

        public TextBox TxtPlace { get => txtPlace; set => txtPlace = value; }
        public Label LblPlace { get => lblPlace; set => lblPlace = value; }
        public EventLog EventLog1 { get => eventLog1; set => eventLog1 = value; }
        public Label LblRoomType { get => lblRoomType; set => lblRoomType = value; }
        public ComboBox CbRoomType { get => cbRoomType; set => cbRoomType = value; }
    }
}
