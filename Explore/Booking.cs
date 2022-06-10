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
    public partial class Booking : UserControl
    {
        private Booking_selection booking_selection;
        private int driver_license;
        private string first_name, last_name, start_date, return_date, return_BID, pickup_BID, pickup_branch, return_branch, car_type;
        private SQL sql;
        public Booking(Booking_selection booking_selection)
        {
            InitializeComponent();
            this.booking_selection = booking_selection;
            this.sql = new SQL();
        }

        // Get pickup_branch
        public string Get_pickup_branch()
        {
            return this.pickup_branch;
        }

        private void Button_next_click(object sender, EventArgs e)
        {
            // format start date
            this.start_date = this.start_date_picker.Value.Year.ToString() + "/" +
                this.start_date_picker.Value.Month.ToString() + "/" +
                this.start_date_picker.Value.Day.ToString();

            // format return date
            this.return_date = this.return_date_picker.Value.Year.ToString() + "/" +
                this.return_date_picker.Value.Month.ToString() + "/" +
                this.return_date_picker.Value.Day.ToString();

            // set up all the info needed for selection
            this.car_type = this.car_type_combo.Text;
            this.pickup_branch = this.pickup_combo.Text;
            this.return_branch = this.return_combo.Text;
            this.pickup_BID = Get_BID(this.pickup_combo.Text);
            this.return_BID = Get_BID(this.return_combo.Text);
            this.booking_selection.Get_all(start_date, return_date, return_BID, pickup_BID, car_type);
            this.Hide();
            this.booking_selection.Show();
        }

        private string Get_BID(string address)
        {
            string BID = "";
            this.sql.Query("select BID, Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

            try
            {
                while(this.sql.Reader().Read())
                {
                    if(address.Equals(this.sql.Reader()["Address"]))
                    {
                        BID = this.sql.Reader()["BID"].ToString();
                    }
                }
                this.sql.Close();
                return BID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return null;
        }

        private void Initial_availability()
        {
            DataGridView availability_table = this.booking_selection.Get_table();
            availability_table.Rows.Clear();
            //this.sql.Query("")
        }
        private void Driver_license_keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                try
                {
                    this.sql.Query("select First_Name, Last_Name from Customer where Driver_License =" + Int32.Parse(customer_driver_license.Text));

                    while (this.sql.Reader().Read())
                    {
                        first_name = (String)this.sql.Reader()["First_Name"];
                        last_name = (String)this.sql.Reader()["Last_Name"];
                    }
                    this.sql.Close();

                    this.driver_license = Int32.Parse(customer_driver_license.Text);
                    this.customer_firstname.Text = first_name;
                    this.customer_lastname.Text = last_name;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
        }

        private void Booking_load(object sender, EventArgs e)
        {
            try
            {
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                while (this.sql.Reader().Read())
                {
                    pickup_combo.Items.Add(this.sql.Reader()["Address"]);
                    return_combo.Items.Add(this.sql.Reader()["Address"]);
                }
                this.sql.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            try
            {
                this.sql.Query("select DISTINCT [Type_Name] from [Type]");
                
                while (this.sql.Reader().Read())
                {
                    car_type_combo.Items.Add(this.sql.Reader()["Type_Name"]);
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Driver_license_leave(object sender, EventArgs e)
        {
            
            try
            {
                this.sql.Query("select First_Name, Last_Name from Customer where Driver_License =" + Int32.Parse(customer_driver_license.Text));

                while (this.sql.Reader().Read())
                {
                    first_name = (String) this.sql.Reader()["First_Name"];
                    last_name = (String)this.sql.Reader()["Last_Name"];
                }
                this.sql.Close();
                customer_firstname.Text = first_name;
                customer_lastname.Text = last_name;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
