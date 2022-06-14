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
    public partial class Report4 : UserControl
    {
        public Report4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// goes to report page when clicked 
            this.Hide();
            Reports Reports = new Reports();
            Reports.Show();
        }
    }
}
