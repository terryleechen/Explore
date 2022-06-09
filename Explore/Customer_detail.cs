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
    public partial class Customer_detail : UserControl
    {
        private Employee_dashboard employee_dashboard;
        public Customer_detail()
        {
            InitializeComponent();
        }

        public void UpdateView(String CID, String First_Name, String Last_Name, String Driver_License,
            String Address_1, String Address_2, String City, String Postal_Code, String Email,
            String Membership, String DOB, String Province, String Gender)
        {
            customer_save.Enabled = false;
            this.ReadOnly(true);

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
            } else
            {
                this.Membership.Checked = false;
            }

            char[] parseChars = DOB.ToCharArray();
            DateTime DateTimeDOB = DateTime.Parse(parseChars[0].ToString() + 
                parseChars[1] + parseChars[2] + parseChars[3] + "-" +
                parseChars[5] + parseChars[6] + '-' + parseChars[8] + parseChars[9]);
            this.DOB.Value = DateTimeDOB;

            this.Province.SelectedItem = Province;

            if (Gender == "M")
            {
                this.M.Checked = true; this.M.Enabled = true;
            } else if (Gender == "F")
            {
                this.F.Checked = true; this.F.Enabled = true;
            } else if (Gender == "N")
            {
                this.N.Checked = true; this.N.Enabled = true;
            }
        }

        public void UpdateView(string Phone_Number)
        {
            this.PhoneNumber.Text = Phone_Number;
        }

        public void Clear()
        {
            this.CID.Text = null; this.FirstName.Text = null;
            this.LastName.Text = null; this.Driver_License.Text = null;
            this.Address_1.Text = null; this.Address_2.Text = null;
            this.City.Text = null; this.PostalCode.Text = null;
            this.Email.Text = null; this.Membership.Checked = false;
        }

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

        public void Get_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        private void Button_previous_click(object sender, EventArgs e)
        {
            this.ReadOnly(false);
            this.employee_dashboard.Get_Customer().Show();
            this.Hide();
        }

        private void Button_save_click(object sender, EventArgs e)
        {

        }

    }
}
