using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Final_Term_Project
{
    public partial class UCSearch : UserControl
    {
        public UCSearch()
        {
            InitializeComponent();
            txtPlace.Text = "City, Hotel, Place to go";
            txtPlace.ForeColor = Color.LightGray;
            cbDuration.SelectedIndex = 0;
            cbRoomType.SelectedIndex = 0;
            dtCheckIn.MinDate = DateTime.Now;
            dtCheckIn.MaxDate = DateTime.Now.AddYears(1); 
            lblCheckOutValue_Load(); 
        }

        private void txtPlace_Enter(object sender, EventArgs e)
        {
            if (txtPlace.Text == "City, Hotel, Place to go")
            {
                txtPlace.Text = "";
                txtPlace.ForeColor = Color.Black;
            }
        }
        private void txtPlace_Leave(object sender, EventArgs e)
        {
            if (txtPlace.Text == "")
            {
                txtPlace.Text = "City, Hotel, Place to go";
                txtPlace.ForeColor = Color.LightGray;
            }
        }
        private void lblCheckOutValue_Load()
        {
            int nights = (cbDuration.SelectedIndex + 1);
            DateTime dateCheckout = dtCheckIn.Value.AddDays(nights);
            lblCheckOutValue.Text = dateCheckout.ToShortDateString();
        }

        private void cbDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCheckOutValue_Load();
        }

        private void dtCheckIn_ValueChanged(object sender, EventArgs e)
        {
            lblCheckOutValue_Load();
        }
    }
}
