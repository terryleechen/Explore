using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Explore
{
    /*
     * The main login for the application.
     * 
     * Author: Terry Leechen
     */
    public partial class Login_page : UserControl
    {
        /*
         * Field                    Description
         * employee_dashboard       main dashboard for the employee
         * customer_page            main dashboard for the customer
         * employee_ID              employee ID
         * customer_ID              customer ID
         * membership               customer's membership status
         */
        private Employee_dashboard employee_dashboard;
        private Customer_dashboard customer_page;
        private readonly SQL sql;
        private string employee_ID;
        private string customer_ID, membership;

        /*
         * The constructor for Login page
         */
        public Login_page(Employee_dashboard employee_dashboard, Customer_dashboard customer_page)
        {
            InitializeComponent();
            this.employee_dashboard = employee_dashboard;
            this.customer_page = customer_page;
            this.sql = new SQL();
        }

        /*
         * This is a getter method to get employee ID
         */
        public string Get_employee_id()
        {
            return employee_ID;
        }

        /*
         * This function actives when user click on button login
         */
        private void Button_login_click(object sender, EventArgs e)
        {
            // get user input
            String ID = user_textbox.Text;

            if(!ID.Equals(""))
            {
                error_check(ID);
            }
        }

        /*
         * This error checks user inputs
         */
        private void error_check(string ID)
        {
            bool check = false;

            // if user input starting with e as employee
            if (ID[0].ToString().ToUpper().Equals("E"))
            {
                this.sql.Query(
                    "select EID " +
                    "from Employee");

                while (this.sql.Reader().Read())
                {
                    if (this.sql.Reader()["EID"].ToString().Equals(user_textbox.Text))
                    {
                        check = true;
                        this.employee_ID = this.sql.Reader()["EID"].ToString();
                        break;

                    }
                    else
                    {
                        check = false;
                    }
                }

                if (check)
                {

                    this.employee_dashboard.Show();
                }
                this.sql.Close();
            }
            // if user input starting with c as customer
            else if (ID[0].ToString().ToUpper() == "C")
            {
                this.sql.Query(
                   "select CID, Membership " +
                   "from Customer");

                while (this.sql.Reader().Read())
                {
                    if (this.sql.Reader()["CID"].ToString().Equals(user_textbox.Text))
                    {
                        check = true;
                        this.customer_ID = this.sql.Reader()["CID"].ToString();
                        this.membership = this.sql.Reader()["Membership"].ToString();
                        this.customer_page.Set_customer_ID(this.customer_ID);
                        this.customer_page.Set_membership(this.membership);
                        break;

                    }
                    else
                    {
                        check = false;
                    }

                }

                if (check)
                {

                    this.customer_page.Show();
                }
                this.sql.Close();

            }
            // everything else that is not correct
            else
            {
                MessageBox.Show("Please enter the correct user ID!");
            }
            this.user_textbox.Clear();
        }
    }
}
