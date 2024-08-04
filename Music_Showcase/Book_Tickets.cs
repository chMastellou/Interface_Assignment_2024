using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Showcase
{
    public partial class Book_Tickets : Form
    {
        public Book_Tickets()
        {
            InitializeComponent();
        }

        private void zoneSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatBox.Text = zoneSelection.Text + seatNo.Value;
        }

        private void seatNo_ValueChanged(object sender, EventArgs e)
        {
            seatBox.Text = zoneSelection.Text + seatNo.Value;
        }
    }
}
