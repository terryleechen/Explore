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
        private int driver_license, reservation_price;
        private double number_days;
        private string first_name, last_name, start_date = "", end_date = "", return_BID, pickup_BID, pickup_branch, return_branch, car_type, CID, type_ID;
        private SQL sql;

        public Booking(Booking_selection booking_selection)
        {
            InitializeComponent();
            this.booking_selection = booking_selection;
            this.sql = new SQL();
        }

        public string Get_pickup_branch()
        {
            return this.pickup_branch;
        }

        public string Get_return_branch()
        {
            return this.return_branch;
        }

        private void Button_next_click(object sender, EventArgs e)
        {
            Console.WriteLine("1 " + this.customer_driver_license.Text);
            Console.WriteLine("2 " +this.start_date_picker.Text);
            Console.WriteLine("3 " + this.return_date_picker.Text);
            Console.WriteLine("4 " + this.pickup_combo.Text);
            Console.WriteLine("5 " + this.return_combo.Text);
            Console.WriteLine("6 " + this.car_type_combo.Text);

            if(this.customer_driver_license.Text.Equals("") ||
                this.start_date_picker.Text.Equals("") || this.return_date_picker.Text.Equals("") ||
                this.pickup_combo.Text.Equals("") || this.return_combo.Text.Equals("") ||
                this.car_type_combo.Text.Equals(""))
            {
                MessageBox.Show("Error! all fields must entered");
            }
            else
            {
                // calculate number of days
                this.number_days = (this.return_date_picker.Value - this.start_date_picker.Value).TotalDays;

                // format start date
                this.start_date = this.start_date_picker.Value.Year.ToString() + "/" +
                    this.start_date_picker.Value.Month.ToString() + "/" +
                    this.start_date_picker.Value.Day.ToString();

                // format return date
                this.end_date = this.return_date_picker.Value.Year.ToString() + "/" +
                    this.return_date_picker.Value.Month.ToString() + "/" +
                    this.return_date_picker.Value.Day.ToString();

                // set up all the info needed for selection
                this.car_type = this.car_type_combo.Text;
                Get_type_ID();
                this.pickup_branch = this.pickup_combo.Text;
                this.return_branch = this.return_combo.Text;
                this.pickup_BID = Get_BID(this.pickup_combo.Text);
                this.return_BID = Get_BID(this.return_combo.Text);

                Initial_availability();
                Calculator calculator = new Calculator(this.number_days, this.car_type);
                this.reservation_price = calculator.calculate();

                this.booking_selection.Get_estimated_price().Text = "$" + this.reservation_price.ToString();
                this.booking_selection.Get_all(start_date, end_date, return_BID, pickup_BID, car_type, CID, number_days, type_ID, reservation_price);
                this.Hide();
                this.booking_selection.Show();
            }
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
            this.sql.Close();
            return null;
        }

        private void Get_type_ID()
        {
            this.sql.Query(
                "select Type_ID " +
                "from Type T " +
                "where Type_Name = '" + this.car_type + "'");

            try
            {
                while (this.sql.Reader().Read())
                {
                    this.type_ID = this.sql.Reader()["Type_ID"].ToString();
                }
                this.sql.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        
        private void Initial_availability()
        {
            DataGridView availability_table = this.booking_selection.Get_table();
            availability_table.Rows.Clear();

            try
            {
                this.sql.Query(
                    "select TT.Car_ID, TT.Brand, TT.Model, TT.Year, TT.Mileage, TT.Type_Name " +
                    "from ((select C.Car_ID, C.Brand, C.Model, C.Year, C.Mileage,T.Type_Name " +
                    "from Car C, Branch B, Type T " +
                    "where C.BID = B.BID and T.Type_ID = C.Type_ID and B.BID = '" + pickup_BID + "') " +
                    "except " +
                    "(select C.Car_ID, C.Brand, C.Model, C.Year, C.Mileage, T.Type_Name " +
                    "from Rental_Transaction R, Car C, Type T " +
                    "where C.Car_ID = R.Car_Received_ID and T.Type_ID = C.Type_ID and " +
                    "R.Return_Branch_ID = '" + pickup_BID + "' and " +
                    "R.Start_Date >= convert(datetime,'" + start_date + "') and " +
                    "R.End_Date <= convert(datetime,'" + end_date + "'))) as TT " +
                    "where TT.Type_Name = '" + car_type + "'");

                while (this.sql.Reader().Read())
                {
                    availability_table.Rows.Add(
                        this.sql.Reader()["Car_ID"].ToString(),
                        this.sql.Reader()["Type_Name"].ToString(),
                        this.sql.Reader()["Brand"].ToString(),
                        this.sql.Reader()["Model"].ToString(),
                        this.sql.Reader()["Year"].ToString(),
                        this.sql.Reader()["Mileage"].ToString());
                }
                this.sql.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
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
                this.sql.Query("select First_Name, Last_Name, CID from Customer where Driver_License =" + Int32.Parse(customer_driver_license.Text));

                while (this.sql.Reader().Read())
                {
                    first_name = (String) this.sql.Reader()["First_Name"];
                    last_name = (String) this.sql.Reader()["Last_Name"];
                    CID = (String)this.sql.Reader()["CID"];
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
