using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explore
{
    public partial class Booking : UserControl
    {
        private Booking_selection booking_selection;
        public Booking(Booking_selection booking_selection)
        {
            InitializeComponent();
            this.booking_selection = booking_selection;
        }

        private void button_next_click(object sender, EventArgs e)
        {
            this.Hide();
            this.booking_selection.Show();
        }
    }
}
