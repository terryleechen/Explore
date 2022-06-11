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
        private string employee_ID;
        public Employee_dashboard()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            employee_date.Text = today.ToString("D");

            //set up panels
            this.employee_home.Show();
            this.employee_customer.Hide();
            this.customer_detail.Hide();
            this.employee_booking.Hide();
            this.booking_selection.Hide();
            this.employee_inventory.Hide();
            this.inventory_add.Hide();
            this.inventory_update.Hide();
            this.employee_return.Hide();
            this.return_detail.Hide();
            this.employee_reports.Hide();


        }
        //====================== Getter methods ==============================================
        public Login_page Get_login()
        {
            return login_page;
        }

        public void Set_login(Login_page login_page)
        {
            this.login_page = login_page;
        }
        
        public Customer Get_Customer()
        {
            return this.employee_customer;
        }

        public Booking Get_booking()
        {
            return this.employee_booking;
        }

        public Inventory Get_inventory()
        {
            return this.employee_inventory;
        }

        public Return Get_return()
        {
            return this.employee_return;
        }

        //====================================================================================

        private void logout_Click(object sender, EventArgs e)
        {
            this.login_page.Show();
            this.Hide();
        }

        private void button_report_click(object sender, EventArgs e)
        {
            this.employee_home.Hide();
            this.employee_customer.Hide();
            this.customer_detail.Hide();
            this.employee_booking.Hide();
            this.booking_selection.Hide();
            this.employee_inventory.Hide();
            this.inventory_add.Hide();
            this.inventory_update.Hide();
            this.employee_return.Hide();
            this.return_detail.Hide();
            this.employee_reports.Show();
        }

        private void button_customer_click(object sender, EventArgs e)
        {
            this.employee_home.Hide();
            this.employee_customer.Show();
            this.customer_detail.Hide();
            this.employee_booking.Hide();
            this.booking_selection.Hide();
            this.employee_inventory.Hide();
            this.inventory_add.Hide();
            this.inventory_update.Hide();
            this.employee_return.Hide();
            this.return_detail.Hide();
            this.employee_reports.Hide();

        }

        private void button_home_click(object sender, EventArgs e)
        {
            this.employee_home.Show();
            this.employee_customer.Hide();
            this.customer_detail.Hide();
            this.employee_booking.Hide();
            this.booking_selection.Hide();
            this.employee_inventory.Hide();
            this.inventory_add.Hide();
            this.inventory_update.Hide();
            this.employee_return.Hide();
            this.return_detail.Hide();
            this.employee_reports.Hide();
        }

        private void button_booking_click(object sender, EventArgs e)
        {
            this.employee_home.Hide();
            this.employee_customer.Hide();
            this.customer_detail.Hide();
            this.employee_booking.Show();
            this.booking_selection.Hide();
            this.employee_inventory.Hide();
            this.inventory_add.Hide();
            this.inventory_update.Hide();
            this.employee_return.Hide();
            this.return_detail.Hide();
            this.employee_reports.Hide();
        }

        private void button_return_click(object sender, EventArgs e)
        {
            this.employee_home.Hide();
            this.employee_customer.Hide();
            this.customer_detail.Hide();
            this.employee_booking.Hide();
            this.booking_selection.Hide();
            this.employee_inventory.Hide();
            this.inventory_add.Hide();
            this.inventory_update.Hide();
            this.employee_return.Show();
            this.return_detail.Hide();
            this.employee_reports.Hide();
        }

        private void button_inventory_click(object sender, EventArgs e)
        {
            this.employee_home.Hide();
            this.employee_customer.Hide();
            this.customer_detail.Hide();
            this.employee_booking.Hide();
            this.booking_selection.Hide();
            this.employee_inventory.Show();
            this.inventory_add.Hide();
            this.inventory_update.Hide();
            this.employee_return.Hide();
            this.return_detail.Hide();
            this.employee_reports.Hide();
        }
    }
}
