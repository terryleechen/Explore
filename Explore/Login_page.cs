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
    public partial class Login_page : UserControl
    {
        private Employee_dashboard employee_dashboard;
        private Customer_page customer_page;
        public Login_page(Employee_dashboard employee_dashboard, Customer_page customer_page)
        {
            InitializeComponent();
            this.employee_dashboard = employee_dashboard;
            this.customer_page = customer_page;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_login_click(object sender, EventArgs e)
        {
            String ID = user_textbox.Text;

            if (ID[0].ToString().ToUpper() == "E")
            {
                this.employee_dashboard.Show();
            }
            else if (ID[0].ToString().ToUpper() == "C")
            {
                this.customer_page.Show();
            }
            this.user_textbox.Clear();
            this.Hide();
        }
        
    }
}
