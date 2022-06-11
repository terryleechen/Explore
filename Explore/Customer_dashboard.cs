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
    public partial class Customer_dashboard : UserControl
    {
        private Login_page login_page;
        public Customer_dashboard()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            customer_date.Text = today.ToString("D");
        }

        public void Set_login(Login_page login_page)
        {
            this.login_page = login_page;
        }

        private void Customer_logut_click(object sender, EventArgs e)
        {
            this.login_page.Show();
            this.Hide();
        }

        private void Customer_search_click(object sender, EventArgs e)
        {
            
        }
    }
}
