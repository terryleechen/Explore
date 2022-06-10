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
        private Employee_dashboard employee_dashbaord;
        public Inventory_add()
        {
            InitializeComponent();
        }
        public void Get_employee_dashboard(Employee_dashboard employee_dashbaord)
        {
            this.employee_dashbaord = employee_dashbaord;
        }

        private void Button_previous_click(object sender, EventArgs e)
        {
            this.Hide();
            this.employee_dashbaord.Get_inventory().Show();
        }
    }

    
}
