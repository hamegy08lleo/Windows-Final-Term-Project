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
    public partial class FCustomer : Form
    {
        public FCustomer()
        {
            InitializeComponent();
            nudDuration.Value = 1;
            nudDuration.Minimum = 1;
            nudDuration.Maximum = 30;
            dtCheckIn.MinDate = DateTime.Now;
            dtCheckIn.MaxDate = DateTime.Now.AddYears(1);
            lblCheckOutValue_Load();
        }
        private void lblCheckOutValue_Load()
        {
            int nights = (int)nudDuration.Value;
            DateTime dateCheckout = dtCheckIn.Value.AddDays(nights);
            lblCheckOutValue.Text = dateCheckout.ToShortDateString();
        }

        private void dtCheckIn_ValueChanged(object sender, EventArgs e)
        {
            lblCheckOutValue_Load();
        }

        private void nudDuration_ValueChanged(object sender, EventArgs e)
        {
            lblCheckOutValue_Load();
        }
    }
}
