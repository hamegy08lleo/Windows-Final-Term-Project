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
            cbRoomType.SelectedIndex = 0;
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
        
    }
}
