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
    public partial class Booking_selection : UserControl
    {
        private Employee_dashboard employee_dashboard;
        private SQL sql;
        public Booking_selection()
        {
            InitializeComponent();
            this.sql = new SQL();
        }

        public void Get_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        public void Get_availability()
        {

        }

        private void Button_previous_click(object sender, EventArgs e)
        {
            this.Hide();
            this.employee_dashboard.Get_booking().Show();
        }

        private void Booking_selection_load(object sender, EventArgs e)
        {
            try
            {
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                while (this.sql.Reader().Read())
                {
                    this.selected_branch.Items.Add(this.sql.Reader()["Address"]);
                }
                this.selected_branch.Text = this.employee_dashboard.Get_booking().Get_pickup_branch();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
