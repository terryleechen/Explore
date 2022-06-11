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
        private SQL sql;
        private string employee_ID;

        public Login_page(Employee_dashboard employee_dashboard, Customer_dashboard customer_page)
        {
            InitializeComponent();
            this.employee_dashboard = employee_dashboard;
            this.customer_page = customer_page;

            // sql
            this.sql = new SQL();
        }

        // ============== Getter method ======================
        public string Get_employee_id()
        {
            return employee_ID;
        }
        // ===================================================

        private void Button_login_click(object sender, EventArgs e)
        {
            String ID = user_textbox.Text;
            bool check = false;

            if (ID[0].ToString().ToUpper().Equals("E"))
            {
                this.sql.Query("select EID from Employee");

                while(this.sql.Reader().Read())
                {
                    if(this.sql.Reader()["EID"].ToString().Equals(user_textbox.Text))
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
            else if (ID[0].ToString().ToUpper() == "C")
            {
                // not started
                this.customer_page.Show();
            }
            else
            {
                MessageBox.Show("error");
            }
            this.user_textbox.Clear();
        }

        private void enter_press(object sender, EventArgs e)
        {
            
        }
    }
}
