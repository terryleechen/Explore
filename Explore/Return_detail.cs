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
    
    public partial class Return_detail : UserControl
    {
        private Employee_dashboard employee_dashboard;
        public Return_detail()
        {
            InitializeComponent();
        }

        public void Get_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.employee_dashboard.Get_return().Show();
        }
    }
}
