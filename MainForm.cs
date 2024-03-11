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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            FCustomer fcustomer = new FCustomer();
            fcustomer.Show();
        }

        private void bthPanership_Click(object sender, EventArgs e)
        {
            FHotelOwner fHotelOwner = new FHotelOwner();
            fHotelOwner.Show();
        }
    }
}
