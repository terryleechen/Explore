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
     * This is the main dashboard for customer
     */
    public partial class Customer_dashboard : UserControl
    {
        /*
         *  Field               Description
         *  login_page          login page
         */
        private Login_page login_page;

        /*
         * The constructor for customer dashboard
         */
        public Customer_dashboard()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            customer_date.Text = today.ToString("D");
        }

        /*
         * This is a setter method for login
         */
        public void Set_login(Login_page login_page)
        {
            this.login_page = login_page;
        }

        /*
         * This is a setter method for customer ID
         */
        public void Set_customer_ID(string customer_ID)
        {
            this.customer_search.Set_CID(customer_ID);
        }

        /*
         * This is a setter method for membership status
         */
        public void Set_membership(string membership)
        {
           this.customer_search.Set_membership(membership);
        }

        /*
         * This is a getter method for customer search panel
         */
        public Customer_search Get_customer_search()
        {
            return this.customer_search;
        }

        /*
         * This fuction active when customer click logout
         */
        private void Customer_logut_click(object sender, EventArgs e)
        {
            this.login_page.Show();
            this.Hide();
        }

        /*
         * This function active when button search click
         */
        private void Customer_search_click(object sender, EventArgs e)
        {
            this.customer_home.Hide();
            this.customer_search.Show();
        }

        /*
         * This function active when button home click
         */
        private void Customer_home_click(object sender, EventArgs e)
        {
            this.customer_home.Show();
            this.customer_search.Hide();
        }
    }
}
