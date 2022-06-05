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
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        //private SQL_connection sql_connection;

        public Login_page(Employee_dashboard employee_dashboard, Customer_dashboard customer_page)
        {
            InitializeComponent();
            this.employee_dashboard = employee_dashboard;
            this.customer_page = customer_page;

            String connection_string = "Server = DESKTOP-781GNEK; Database = explore; Trusted_Connection = yes;";
            connection = new SqlConnection(connection_string);
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
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

            if (ID[0].ToString().ToUpper() == "E")
            {
                command.CommandText = "select EID from Employee";
                Console.WriteLine(command.ExecuteScalar());
                Console.WriteLine(user_textbox.Text);
                Console.WriteLine(command.ExecuteScalar().ToString() == user_textbox.Text);

                if(command.ExecuteScalar().ToString().Equals(user_textbox.Text))
                {
                    this.employee_dashboard.Show();
                }
                else
                {
                    MessageBox.Show("error");
                }
                
                /*
                command.CommandText = "select * from Employee";
                Console.WriteLine(command.CommandText);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["First_Name"].ToString());
                }
                */

            }
            else if (ID[0].ToString().ToUpper() == "C")
            {
                this.customer_page.Show();
            }
            this.user_textbox.Clear();
            //this.Hide();
        }
        
    }
}
