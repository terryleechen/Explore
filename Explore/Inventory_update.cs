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
    public partial class Inventory_update : UserControl
    {
        private Employee_dashboard employee_dashboard;
        public Inventory_update()
        {
            InitializeComponent();
        }

        public void Set_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }
    }
}
