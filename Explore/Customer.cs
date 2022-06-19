using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Explore
{
    /// <summary>
    /// Customer detail landing page. From here the user chooses whether they want to view,
    /// edit, or add customer information to the database. If view or edit is chosen, the
    /// class queries the database based on the customer's driver's license number.
    /// </summary>
    public partial class Customer : UserControl
    {
        private Customer_detail customer_detail;
        private SQL sql;

        /// <summary>
        /// Initializes the page
        /// </summary>
        /// <param name="customer_detail"></param>
        public Customer(Customer_detail customer_detail)
        {
            InitializeComponent();
            this.customer_detail = customer_detail;
            this.sql = new SQL();
        }

        /// <summary>
        /// Brings up the customer detail page in the Add state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_add_click(object sender, EventArgs e)
        {
            this.customer_detail.AddCustomer();
            this.customer_detail.Show();
        }

        /// <summary>
        /// Queries the database for the customer's information bassed on the driver's license
        /// number in order to edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_edit_click(object sender, EventArgs e)
        {
            String driver_license = customer_driver_license.Text;
            bool check = false;
            this.customer_driver_license.Clear();

            // Makes sure the driver's license number is valid
            if (!ValidateDriverLicense(driver_license))
            {
                MessageBox.Show("Please enter a valid driver's license number");
            }
            else
            {
                // Query the database for all customer driver's licenses
                this.sql.Query("select Driver_License from Customer");
                while (this.sql.Reader().Read())
                {
                    // If Driver's License is in the selected relation, exit the loop and set
                    // check to true, otherwise show error message
                    if (this.sql.Reader()["Driver_License"].ToString().Equals(driver_license))
                    {
                        check = true;
                        this.sql.Close();
                        break;
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("No such customer exists");
                    this.sql.Close();
                }
                // Query the database for all information where the driver's license equals Driver_License.
                // Clear the table, insert the information into the page, and show the Customer_Detail page.
                if (check == true)
                {
                    this.sql.Query("select * from Customer where Driver_License = " + driver_license);
                    this.customer_detail.Clear();
                    while (this.sql.Reader().Read())
                    {
                        this.customer_detail.EditCustomer(
                            this.sql.Reader()["CID"].ToString().Trim(),
                            this.sql.Reader()["First_Name"].ToString().Trim(),
                            this.sql.Reader()["Last_Name"].ToString().Trim(),
                            this.sql.Reader()["Driver_License"].ToString().Trim(),
                            this.sql.Reader()["Address_1"].ToString().Trim(),
                            this.sql.Reader()["Address_2"].ToString().Trim(),
                            this.sql.Reader()["City"].ToString().Trim(),
                            this.sql.Reader()["Postal_code"].ToString().Trim(),
                            this.sql.Reader()["Email"].ToString().Trim(),
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
                        this.customer_detail.UpdatePhoneNumber(this.sql.Reader()["Phone_Number"].ToString().Trim());
                    }
                    this.customer_detail.Show();
                }
                
                this.sql.Close();
            }
        }

        /// <summary>
        /// Queries the database for the customer's information bassed on the driver's license
        /// number in order to view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_view_click(object sender, EventArgs e)
        {
            String driver_license = customer_driver_license.Text;
            bool check = false;
            this.customer_driver_license.Clear();


            // Makes sure the driver's license number is valid
            if (!ValidateDriverLicense(driver_license))
            {
                MessageBox.Show("Please enter a valid driver's license number");
            }
            else
            {
                // Query the database for all customer driver's licenses
                this.sql.Query("select Driver_License from Customer");
                while (this.sql.Reader().Read())
                {
                    // If Driver's License is in the selected relation, exit the loop and set
                    // check to true, otherwise show error message
                    if (this.sql.Reader()["Driver_License"].ToString().Equals(driver_license))
                    {
                        check = true;
                        this.sql.Close();
                        break;
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("No such customer exists");
                    this.sql.Close();
                }

                if (check == true)
                {
                    // Query the database for all information where the driver's license equals Driver_License.
                    // Clear the table, insert the information into the page, and show the Customer_Detail page.
                    this.sql.Query("select * from Customer where Driver_License = " + driver_license);
                    this.customer_detail.Clear();
                    while (this.sql.Reader().Read())
                    {
                        this.customer_detail.ViewCustomer(
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
                        this.customer_detail.UpdatePhoneNumber(this.sql.Reader()["Phone_Number"].ToString());
                    }
                    this.customer_detail.Show();
                } 

                this.sql.Close();
                
            }
        }

        /// <summary>
        /// Validates Driver's License
        /// </summary>
        /// <param name="dl">String with potential driver's license</param>
        /// <returns>bool true/false</returns>
        public static bool ValidateDriverLicense(string dl)
        {
            string pattern = @"^\d+$";
            Regex reg = new Regex(pattern);
            if (!reg.IsMatch(dl) || dl.Length < 9)
                return false;
            return true;
        }
    }
}
