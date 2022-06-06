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
    public partial class Customer : UserControl
    {
        private Customer_detail customer_detail;

        public Customer(Customer_detail customer_detail)
        {
            InitializeComponent();
            this.customer_detail = customer_detail;
        }

        private void Button_add_click(object sender, EventArgs e)
        {
            this.customer_detail.Show();
        }

        private void Button_edit_click(object sender, EventArgs e)
        {

        }
    }
}
