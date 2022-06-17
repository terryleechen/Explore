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
    /*
     * This is the main dashboard for employee
     * 
     * Author: Terry Leechen
     */
    public partial class Employee_dashboard : UserControl
    {
        /*
         *  Field               Description
         *  login_page          login page
         */
        private Login_page login_page;

        /*
         * The constructor for employee dashboard
         */
        public Employee_dashboard()
        {
            InitializeComponent();

            // set today's date
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

        /*
         * This is a Getter method to get login
         */
        public Login_page Get_login()
        {
            return login_page;
        }

        /*
         * This is a setter method for login
         */
        public void Set_login(Login_page login_page)
        {
            this.login_page = login_page;
        }
        
        /*
         * This is a getter method for customer management page
         */
        public Customer Get_Customer()
        {
            return this.employee_customer;
        }

        /*
         * This is a getter method for booking page
         */
        public Booking Get_booking()
        {
            return this.employee_booking;
        }

        /*
         * Thi is a getter method for inventory management page
         */
        public Inventory Get_inventory()
        {
            return this.employee_inventory;
        }

        /*
         * This is a getter method for return page
         */
        public Return Get_return()
        {
            return this.employee_return;
        }

        /*
         * This function will active when user click on button logout
         */
        private void logout_Click(object sender, EventArgs e)
        {
            this.login_page.Show();
            this.Hide();
        }

        /*
         * This function will active when user click on button report
         */
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

        /*
         * This function will active when user click on button customer
         */
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

        /*
         * This function will active when user click on button home
         */
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

        /*
         * This function will active when user click on button booking
         */
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

        /*
         * This function will active when user click on button return
         */
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

        /*
         * This function will active when user click on button inventory
         */
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
