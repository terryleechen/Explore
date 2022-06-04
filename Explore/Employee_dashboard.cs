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
    public partial class Employee_dashboard : UserControl
    {
        private Login_page login_page;
        public Employee_dashboard()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            employee_date.Text = today.ToString("D");
        }

        public void Get_login(Login_page login_page)
        {
            this.login_page = login_page;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.login_page.Show();
            this.Hide();
        }
    }
}
