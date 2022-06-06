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
    public partial class Customer_detail : UserControl
    {
        private Employee_dashboard employee_dashboard;
        public Customer_detail()
        {
            InitializeComponent();
        }

        public void Get_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        private void Button_previous_click(object sender, EventArgs e)
        {
            this.employee_dashboard.Get_Customer().Show();
            this.Hide();
        }

        private void Button_save_click(object sender, EventArgs e)
        {

        }
    }
}
