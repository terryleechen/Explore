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
    public partial class Inventory_add : UserControl
    {
        private Employee_dashboard employee_dashboard;
        public Inventory_add()
        {
            InitializeComponent();
        }
        public void Get_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        private void Button_previous_click(object sender, EventArgs e)
        {
            this.Hide();
            this.employee_dashboard.Get_inventory().Show();
        }
    }

    
}
