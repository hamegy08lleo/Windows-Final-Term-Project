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
    public partial class FHotelOwner : Form
    {
        public FHotelOwner()
        {
            InitializeComponent();
            txtPrice.Text = "Enter price of room";
            txtPrice.ForeColor = Color.LightGray;
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == "Enter price of room")
            {
                txtPrice.Text = "";
                txtPrice.ForeColor = Color.Black;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                txtPrice.Text = "Enter price of room";
                txtPrice.ForeColor = Color.LightGray;
            }
        }
    }
}
