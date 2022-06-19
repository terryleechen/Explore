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
    /// The Customer_detail form receives information from the database and displays it in an
    /// easy to read format. Depending on what the user has selected, they will either be able
    /// to simply view the data or edit the data. If viewing only, no changes to the data
    /// will be allowed to be made. If editing, every field will be editable except for the
    /// Customer ID field.
    /// 
    /// The User also has the option to add a new customer into the database. In this case,
    /// the page will be brought up with all fields empty, except for the Customer ID field
    /// which is automatically generated and not editable.
    /// </summary>
    /// 
    /// Author: Josh Coss
    public partial class Customer_detail : UserControl
    {
        private Employee_dashboard employee_dashboard;
        private SQL sql;
        private String state;

        /// <summary>
        /// Initialized Customer_detal
        /// </summary>
        public Customer_detail()
        {
            InitializeComponent();
            this.sql = new SQL();
            state = "Waiting";
        }

        /// <summary>
        /// Gets the information from the database from the Customer.cs page and changes
        /// the current state to View, allowing the user to view the customer's details
        /// but not change any information
        /// </summary>
        /// <param name="CID">Customer ID number</param>
        /// <param name="First_Name">Customer's Firt Name</param>
        /// <param name="Last_Name">Customer's Last Name</param>
        /// <param name="Driver_License">Customer's Driver's License Number</param>
        /// <param name="Address_1">First line of customer's address</param>
        /// <param name="Address_2">Second line of customer's address</param>
        /// <param name="City">Customer's city</param>
        /// <param name="Postal_Code">Customer's Postal Code (Canadian Only)</param>
        /// <param name="Email">Customer's Email Address</param>
        /// <param name="Membership">Customer's gold membership status</param>
        /// <param name="DOB">Customer's date of birth</param>
        /// <param name="Province">Province the customer lives in</param>
        /// <param name="Gender">Customer's gender</param>
        public void ViewCustomer(String CID, String First_Name, String Last_Name, String Driver_License,
            String Address_1, String Address_2, String City, String Postal_Code, String Email,
            String Membership, String DOB, String Province, String Gender)
        {
            /// Set the state to view
            state = "View";
           
            /// Disable the save button and set all fields to read only
            customer_save.Enabled = false;
            this.ReadOnly(true);
            
            /// Populate the customer data fields
            this.Populate(CID, First_Name, Last_Name, Driver_License, Address_1,
                Address_2, City, Postal_Code, Email, Membership, DOB, Province, Gender);
        }

        /// <summary>
        /// Gets the information from the database from the Customer.cs page and changes
        /// the current state to Edit, allowing the user to edit the customer's details
        /// </summary>
        /// <param name="CID">Customer ID number</param>
        /// <param name="First_Name">Customer's Firt Name</param>
        /// <param name="Last_Name">Customer's Last Name</param>
        /// <param name="Driver_License">Customer's Driver's License Number</param>
        /// <param name="Address_1">First line of customer's address</param>
        /// <param name="Address_2">Second line of customer's address</param>
        /// <param name="City">Customer's city</param>
        /// <param name="Postal_Code">Customer's Postal Code (Canadian Only)</param>
        /// <param name="Email">Customer's Email Address</param>
        /// <param name="Membership">Customer's gold membership status</param>
        /// <param name="DOB">Customer's date of birth</param>
        /// <param name="Province">Province the customer lives in</param>
        /// <param name="Gender">Customer's gender</param>
        public void EditCustomer(String CID, String First_Name, String Last_Name, String Driver_License,
            String Address_1, String Address_2, String City, String Postal_Code, String Email,
            String Membership, String DOB, String Province, String Gender)
        {
            /// Set the state to Edit
            state = "Edit";

            /// Enable the save button and set all field's readonly status to false except for CID
            customer_save.Enabled = true;
            this.ReadOnly(false);
            this.CID.ReadOnly = true;

            /// Populate the customer data fields
            this.Populate(CID, First_Name, Last_Name, Driver_License, Address_1,
                Address_2, City, Postal_Code, Email, Membership, DOB, Province, Gender);
        }

        /// <summary>
        /// Sets the state to Add and allows the user to fill out information for a new customer.
        /// </summary>
        public void AddCustomer()
        {
            /// Set the state to Add
            state = "Add";

            /// Enable the save button and set all field's readonly status to false except for CID
            customer_save.Enabled = true;
            this.ReadOnly(false);
            this.CID.ReadOnly = true;

            /// Query the database for the last CID in the Customer table, then increments it by 1
            this.sql.Query("select max(CID) as last from Customer");
            String newCID = "";
            while (this.sql.Reader().Read())
            {
                newCID = this.sql.Reader()["last"].ToString().Trim();
            }
            this.sql.Close();
            String digits = new string(newCID.Where(char.IsDigit).ToArray());
            String letters = new string(newCID.Where(char.IsLetter).ToArray());
            int number;
            if (!int.TryParse(digits, out number))
            {
                return;
            }
            String finalCID = letters + (++number).ToString("D6");
            this.CID.Text = finalCID;
        }

        /// <summary>
        /// Sets PhoneNumber
        /// </summary>
        /// <param name="Phone_Number">Customer's Phone Number</param>
        public void UpdatePhoneNumber(string Phone_Number)
        {
            this.PhoneNumber.Text = Phone_Number;
        }

        /// <summary>
        /// Resets all fields to blank
        /// </summary>
        public void Clear()
        {
            this.CID.Text = null; this.FirstName.Text = null;
            this.LastName.Text = null; this.Driver_License.Text = null;
            this.Address_1.Text = null; this.Address_2.Text = null;
            this.City.Text = null; this.PostalCode.Text = null;
            this.Email.Text = null; this.Membership.Checked = false;
            this.PhoneNumber.Text = null; this.DOB.Value = DateTime.Today;
        }

        /// <summary>
        /// Sets all fields readonly status
        /// </summary>
        /// <param name="set">bool true/false</param>
        public void ReadOnly(bool set)
        {
            this.CID.ReadOnly = set; this.FirstName.ReadOnly = set;
            this.LastName.ReadOnly = set; this.Driver_License.ReadOnly = set;
            this.Address_1.ReadOnly = set; this.PhoneNumber.ReadOnly = set;
            this.Address_2.ReadOnly = set; this.City.ReadOnly = set;
            this.PostalCode.ReadOnly = set; this.Email.ReadOnly = set;
            this.Membership.Enabled = !set;
            this.DOB.Enabled = !set; this.Province.Enabled = !set;
            this.M.Enabled = !set; this.F.Enabled = !set; this.N.Enabled = !set;
        }

        /// <summary>
        /// Gets the employee dashboard page
        /// </summary>
        /// <param name="employee_dashboard"></param>
        public void Get_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        /// <summary>
        /// Clears the fields and goes back to the Customer page, then hides the current page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_previous_click(object sender, EventArgs e)
        {
            this.ReadOnly(false);
            this.Clear();
            this.employee_dashboard.Get_Customer().Show();
            this.Hide();
        }

        /// <summary>
        /// Does a series of validation checks, then adds/edits information in the customer table in
        /// the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_save_click(object sender, EventArgs e)
        {
            // Empty strings for the non-text fields on the page
            String mem = ""; String gen = ""; String newNumber;

            // Checks whether the membership button is checked and stores a string accordingly
            if (this.Membership.Checked) { mem = "Y"; } else { mem = "N"; }

            // Checks which gender button is checked and stores a string accordingly
            if (this.M.Checked) { gen = "M"; }
            else if (this.F.Checked) { gen = "F"; }
            else if (this.N.Checked) { gen = "N"; }

            // Deformats the phone number in the PhoneNumber text box for storage
            newNumber = string.Concat(this.PhoneNumber.Text.ToString().Where(i => !new[] { '-', '(', ')', ' ' }.Contains(i)));
            // Validates the postal code, email, and driver's license, showing a error box if invalidated
            if (!ValidatePostalCode(this.PostalCode.Text))
                MessageBox.Show("Please enter a valid postal code");
            if (!ValidateEmail(this.Email.Text))
                MessageBox.Show("Please enter a valid email");
            if (!ValidateDriverLicense(this.Driver_License.Text))
                MessageBox.Show("Please enter a valid driver's license number");

            // Runs if all validation checks pass
            if (ValidatePostalCode(this.PostalCode.Text) && ValidateEmail(this.Email.Text) && ValidateDriverLicense(this.Driver_License.Text))
            {
                // Edit the customer information
                if (this.state == "Edit")
                {
                    this.sql.Update("Update Customer " +
                        "Set First_Name = '" + this.FirstName.Text + "', " +
                        "CID = '" + this.CID.Text + "', " +
                        "Last_Name = '" + this.LastName.Text + "', " +
                        "Driver_License = '" + this.Driver_License.Text + "', " +
                        "Address_1 = '" + this.Address_1.Text + "', " +
                        "Membership = '" + mem + "', " +
                        "City = '" + this.City.Text + "', " +
                        "Postal_code = '" + this.PostalCode.Text + "', " +
                        "Email = '" + this.Email.Text + "', " +
                        "Gender = '" + gen + "', " +
                        "Province = '" + this.Province.SelectedItem + "', " +
                        "DOB = '" + this.DOB.Value.ToString("yyyy/MM/dd") + "', " +
                        "Address_2 = '" + this.Address_2.Text + "' " +
                        "Where CID = '" + this.CID.Text + "'");
                    this.sql.Update("Update Customer_Phone " +
                        "Set Phone_Number = '" + newNumber + "' " +
                        "Where CID = '" + this.CID.Text + "'");
                }
                // Adds new row for new customer information
                else if (this.state == "Add")
                {
                    this.sql.Insert("Insert Into Customer " +
                        "(CID, First_Name, Last_Name, Driver_License, Address_1, Address_2, " +
                        "Membership, City, Postal_code, Email, Gender, Province, DOB) " +
                        "Values ('" + this.CID.Text + "', " +
                        "'" + this.FirstName.Text + "', " +
                        "'" + this.LastName.Text + "', " +
                        "'" + this.Driver_License.Text + "', " +
                        "'" + this.Address_1.Text + "', " +
                        "'" + this.Address_2.Text + "', " +
                        "'" + mem + "', " +
                        "'" + this.City.Text + "', " +
                        "'" + this.PostalCode.Text + "', " +
                        "'" + this.Email.Text + "', " +
                        "'" + gen + "', " +
                        "'" + this.Province.SelectedItem + "', " +
                        "'" + this.DOB.Value.ToString("yyyy/MM/dd") + "')");
                    this.sql.Insert("Insert Into Customer_Phone " +
                        "(CID, Phone_Number) " +
                        "Values ('" + this.CID.Text + "', '" + this.PhoneNumber.Text + "')");

                }
            
                this.state = "Waiting";
                this.Clear();
                this.employee_dashboard.Get_Customer().Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Populates all fields on the customer detail page 
        /// </summary>
        /// <param name="CID">Customer ID number</param>
        /// <param name="First_Name">Customer's Firt Name</param>
        /// <param name="Last_Name">Customer's Last Name</param>
        /// <param name="Driver_License">Customer's Driver's License Number</param>
        /// <param name="Address_1">First line of customer's address</param>
        /// <param name="Address_2">Second line of customer's address</param>
        /// <param name="City">Customer's city</param>
        /// <param name="Postal_Code">Customer's Postal Code (Canadian Only)</param>
        /// <param name="Email">Customer's Email Address</param>
        /// <param name="Membership">Customer's gold membership status</param>
        /// <param name="DOB">Customer's date of birth</param>
        /// <param name="Province">Province the customer lives in</param>
        /// <param name="Gender">Customer's gender</param>
        private void Populate(String CID, String First_Name, String Last_Name, String Driver_License,
            String Address_1, String Address_2, String City, String Postal_Code, String Email,
            String Membership, String DOB, String Province, String Gender)
        {
            this.CID.Text = CID;
            this.FirstName.Text = First_Name;
            this.LastName.Text = Last_Name;
            this.Driver_License.Text = Driver_License;
            this.Address_1.Text = Address_1;
            this.Address_2.Text = Address_2;
            this.City.Text = City;
            this.PostalCode.Text = Postal_Code;
            this.Email.Text = Email;

            if (Membership == "Y")
            {
                this.Membership.Checked = true;
            }
            else
            {
                this.Membership.Checked = false;
            }

            this.DOB.Value = DateTime.Parse(DOB);

            this.Province.SelectedItem = Province;

            if (Gender == "M") { this.M.Checked = true; this.M.Enabled = true; }
            else if (Gender == "F") { this.F.Checked = true; this.F.Enabled = true; }
            else if (Gender == "N") { this.N.Checked = true; this.N.Enabled = true; }
        }

        /// <summary>
        /// Validates the postal code based on Canada Post's postal code perameters
        /// Code found at https://blog.platformular.com/2012/03/03/how-to-validate-canada-postal-code-in-c/
        /// </summary>
        /// <param name="PCode">String with potential postal code</param>
        /// <returns>bool true/false</returns>
        public static bool ValidatePostalCode(string PCode)
        {
            string pattern = "^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$";
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            return reg.IsMatch(PCode);
        }

        /// <summary>
        /// Validates email address
        /// </summary>
        /// <param name="email">String with potential email address</param>
        /// <returns>bool true/false</returns>
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase);
            return reg.IsMatch(email);
        }

        /// <summary>
        /// Validates Driver's License
        /// </summary>
        /// <param name="dl">String with potential driver's license</param>
        /// <returns></returns>
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
