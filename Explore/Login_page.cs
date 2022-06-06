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
    public partial class Login_page : UserControl
    {
        private Employee_dashboard employee_dashboard;
        private Customer_dashboard customer_page;
        /*
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        */
        private SQL sql;

        public Login_page(Employee_dashboard employee_dashboard, Customer_dashboard customer_page)
        {
            InitializeComponent();
            this.employee_dashboard = employee_dashboard;
            this.customer_page = customer_page;

            // sql
            this.sql = new SQL();

            // make sure to change the server to yours computer name
            // first time running this will need to create the database name it explore
            // ensure run explore.sql then exlpore_insert.sql
            // to login type "E0001" as employee
            // to login type "C000001" as customer
            /*
            String connection_string = "Server = DESKTOP-781GNEK; Database = explore; Trusted_Connection = yes;";
            connection = new SqlConnection(connection_string);
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            */

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_login_click(object sender, EventArgs e)
        {
            String ID = user_textbox.Text;

            if (ID[0].ToString().ToUpper().Equals("E"))
            {
                this.sql.Command().CommandText = "select EID from Employee";
                Console.WriteLine(this.sql.Command().ExecuteScalar());

                if(this.sql.Command().ExecuteScalar().ToString().Equals(user_textbox.Text))
                {
                    this.employee_dashboard.Show();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else if (ID[0].ToString().ToUpper() == "C")
            {
                // not started
                this.customer_page.Show();
            }
            this.user_textbox.Clear();
        }
        
    }
}
