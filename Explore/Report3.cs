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
    public partial class Report3 : UserControl
    {
        public Report3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// button goes to reports page when clicked 
            this.Hide();
            Reports Reports = new Reports();
            Reports.Show();
        }
    }
}
