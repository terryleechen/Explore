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
    public partial class Customer : UserControl
    {
        private Customer_detail customer_detail;
        private SQL sql;

        public Customer(Customer_detail customer_detail)
        {
            InitializeComponent();
            this.customer_detail = customer_detail;
            this.sql = new SQL();
        }

        private void Button_add_click(object sender, EventArgs e)
        {
            
        }

        private void Button_edit_click(object sender, EventArgs e)
        {

        }

        private void Button_view_click(object sender, EventArgs e)
        {
            String driver_license = customer_driver_license.Text;
            bool check = false;
            

            if (driver_license == null)
            {
                MessageBox.Show("Please enter a valid driver's license number");
                this.sql.Close();
            } 
            else
            {
                this.sql.Query("select Driver_License from Customer");
                while (this.sql.Reader().Read())
                {
                    if (this.sql.Reader()["Driver_License"].ToString().Equals(driver_license))
                    {
                        check = true;
                        this.sql.Close();
                        break;
                    } 
                }
                
                if (check == true)
                {
                    this.sql.Query("select * from Customer where Driver_License = " + driver_license);
                    this.customer_detail.Clear();
                    while (this.sql.Reader().Read())
                    {
                        this.customer_detail.UpdateView(
                            this.sql.Reader()["CID"].ToString(),
                            this.sql.Reader()["First_Name"].ToString(),
                            this.sql.Reader()["Last_Name"].ToString(),
                            this.sql.Reader()["Driver_License"].ToString(),
                            this.sql.Reader()["Address_1"].ToString(),
                            this.sql.Reader()["Address_2"].ToString(),
                            this.sql.Reader()["City"].ToString(),
                            this.sql.Reader()["Postal_code"].ToString(),
                            this.sql.Reader()["Email"].ToString(),
                            this.sql.Reader()["Membership"].ToString(),
                            this.sql.Reader()["DOB"].ToString(),
                            this.sql.Reader()["Province"].ToString(),
                            this.sql.Reader()["Gender"].ToString());
                    }
                    this.sql.Close();
                    this.sql.Query("select Phone_Number from Customer, Customer_Phone " +
                        "where Customer.CID = Customer_Phone.CID and Customer.Driver_License = " + driver_license);
                    while (this.sql.Reader().Read())
                    {
                        this.customer_detail.UpdateView(this.sql.Reader()["Phone_Number"].ToString());
                    }
                    this.customer_detail.Show();
                } 
                else
                {
                    MessageBox.Show("No such customer exists");
                    
                }
                this.sql.Close();
                
            }
        }
    }
}
