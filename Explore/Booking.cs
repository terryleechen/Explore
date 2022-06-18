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
     * This is the booking panel in employee dashboard
     * 
     * Author: Terry Leechen
     */
    public partial class Booking : UserControl
    {
        /*
         * Field                Description
         * booking_selection    booking selection page
         * driver_license       select customer's driver license
         * reservation price    reservation based on the selected type id and number of days
         * number_days          days rented
         * first_name           selected customer's first name
         * last_name            selected customer's last name
         * start_date           formmated start date
         * end_date             formmated end date
         * return_BID           return branch ID
         * pickup_BID           pickup branch ID
         * pickup_branch        address of pickup branch
         * return_branch        address of return branch
         * car_type             selected car type name
         * CID                  customer CID
         * type_ID              car type ID
         * membership           customer membership status
         * upgraded             bool to see if customer gets free upgrade
         * sql                  SQL class to access database
         */
        private Booking_selection booking_selection;
        private int driver_license, reservation_price;
        private double number_days;
        private string first_name, last_name, start_date = "", end_date = "",
            return_BID, pickup_BID, pickup_branch, return_branch, car_type,
            CID, type_ID, membership;
        private bool upgraded = false;
        private SQL sql;

        /*
         * The constructor of booking selection
         * 
         * Parameter                Description
         * booking_selection        booking selection page
         */
        public Booking(Booking_selection booking_selection)
        {
            InitializeComponent();
            this.booking_selection = booking_selection;
            this.sql = new SQL();
        }

        /*
         * The function clears infomation that entered ont he page
         */
        public void Clear_info()
        {
            this.customer_driver_license.Clear();
            this.customer_firstname.Clear();
            this.customer_lastname.Clear();
            this.pickup_combo.Text = "";
            this.return_combo.Text = "";
            this.car_type_combo.Text = "";
        }

        /*
         * This function will active when button next click
         */
        private void Button_next_click(object sender, EventArgs e)
        {
            if(this.customer_driver_license.Text.Equals("") ||
                this.start_date_picker.Text.Equals("") || this.return_date_picker.Text.Equals("") ||
                this.pickup_combo.Text.Equals("") || this.return_combo.Text.Equals("") ||
                this.car_type_combo.Text.Equals(""))
            {
                MessageBox.Show("Error! all fields must be entered");
            }
            else
            {
                // calculate number of days
                this.number_days = Math.Round((this.return_date_picker.Value - this.start_date_picker.Value).TotalDays);

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

                // set up booking selection page
                int check = Initial_availability();
              
                // check if the selected dates are within the same day
                if((this.return_date_picker.Value - this.start_date_picker.Value).TotalDays < 0)
                {
                    check = 2;
                }

                // everything is good
                if(check == 0)
                {
                    // check if change branch fee needed
                    bool difference = !(this.pickup_BID.Equals(this.return_BID));

                    // calculate reservation price
                    Calculator calculator = new Calculator(this.number_days, this.car_type, difference, this.membership.ToUpper());
                    this.reservation_price = calculator.calculate();

                    // set up pickup and return combo box
                    Setup_booking_selection();

                    // display price on booking selection
                    this.booking_selection.Get_estimated_price().Text = "$" + this.reservation_price.ToString();
                    
                    // pass over all the info needed for booking selection
                    this.booking_selection.Get_all(start_date, end_date, return_BID, pickup_BID, car_type, CID, number_days, type_ID, reservation_price, membership);
                    

                    // when upgrade is avaivable for gold member
                    if(this.upgraded)
                    {
                        MessageBox.Show("No results found for your search, however, the customer " +
                            "is a Gold Member. Please select a free upgrade from the displayed cars.");
                    }
                    this.Hide();
                    this.booking_selection.Show();
                }
                // renting car less than 1 day
                else if(check == 2)
                {
                    MessageBox.Show("Rental car must be rented at least one day!");
                }
                // non-gold member when no availvable car type selected
                else
                {
                    MessageBox.Show("Sorry!\nNo results found for your search, please select " +
                        "another car type or choose from a different branch.");
                }
            }
        }

        /*
         * This function set up booking selection combo boxes
         */
        private void Setup_booking_selection()
        {
            try
            {
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                this.booking_selection.Get_pickup().Items.Clear();
                this.booking_selection.Get_return().Items.Clear();

                while (this.sql.Reader().Read())
                {
                    this.booking_selection.Get_pickup().Items.Add(this.sql.Reader()["Address"]);
                    this.booking_selection.Get_return().Items.Add(this.sql.Reader()["Address"]);
                }
                this.sql.Close();
                this.booking_selection.Get_pickup().SelectedItem = this.pickup_combo.Text;
                this.booking_selection.Get_return().SelectedItem = this.return_combo.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        /*
         * This function determines the branch ID from branch address
         */
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

        /*
         * This function get type ID from type name
         */
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            this.sql.Close();
        }
        
        /*
         * This function set up the data grid table in booking selection
         */
        private int Initial_availability()
        {
            DataGridView availability_table = this.booking_selection.Get_table();
            availability_table.Rows.Clear();

            try
            {
                this.sql.Query(
                    "select TT.Car_ID, TT.Brand, TT.Model, TT.Year, TT.Mileage, TT.Type_Name, TT.Type_ID " +
                    "from ((select C.Car_ID, C.Brand, C.Model, C.Year, C.Mileage,T.Type_Name, T.Type_ID " +
                    "from Car C, Branch B, Type T " +
                    "where C.BID = B.BID and T.Type_ID = C.Type_ID and B.BID = '" + pickup_BID + "') " +
                    "except " +
                    "(select C.Car_ID, C.Brand, C.Model, C.Year, C.Mileage, T.Type_Name, T.Type_ID " +
                    "from Rental_Transaction R, Car C, Type T " +
                    "where C.Car_ID = R.Car_Received_ID and T.Type_ID = C.Type_ID and " +
                    "R.Return_Branch_ID = '" + pickup_BID + "' and " +
                    "R.Start_Date >= convert(datetime,'" + start_date + "') and " +
                    "R.End_Date <= convert(datetime,'" + end_date + "'))) as TT " +
                    "where TT.Type_ID = '" + type_ID + "'");
                
                // change if any available cars
                if(!this.sql.Reader().HasRows)
                {
                    // if no available rental and gold member
                    if(this.membership.ToUpper().Equals("Y"))
                    {
                        this.type_ID = (Int32.Parse(this.type_ID) + 1).ToString();

                        // when no more upgradable car type
                        if (this.car_type.Equals("5"))
                        {
                            this.sql.Close();
                            return 1;
                        }
                        else
                        {
                            this.sql.Close();
                            this.upgraded = true;

                            this.sql.Query(
                                "select TT.Car_ID, TT.Brand, TT.Model, TT.Year, TT.Mileage, TT.Type_Name, TT.Type_ID " +
                                "from ((select C.Car_ID, C.Brand, C.Model, C.Year, C.Mileage,T.Type_Name, T.Type_ID " +
                                "from Car C, Branch B, Type T " +
                                "where C.BID = B.BID and T.Type_ID = C.Type_ID and B.BID = '" + pickup_BID + "') " +
                                "except " +
                                "(select C.Car_ID, C.Brand, C.Model, C.Year, C.Mileage, T.Type_Name, T.Type_ID " +
                                "from Rental_Transaction R, Car C, Type T " +
                                "where C.Car_ID = R.Car_Received_ID and T.Type_ID = C.Type_ID and " +
                                "R.Return_Branch_ID = '" + pickup_BID + "' and " +
                                "R.Start_Date >= convert(datetime,'" + start_date + "') and " +
                                "R.End_Date <= convert(datetime,'" + end_date + "'))) as TT " +
                                "where TT.Type_ID = '" + type_ID + "'");
                        }
                    }
                    else
                    {
                        this.sql.Close();
                        return 1;
                    }

                }

                // display info on to the availability table on booking selection page
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
                return 0;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return 1;
            }
        }
        
        /*
         * This function auto fill first name and last name when driver license entered
         */
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

        /*
         * This function actives when user enters key then goes through error checking
         */
        private void Driver_license_keypress(object sender, KeyPressEventArgs e)
        {
            error_check(e);
        }

        /*
         * This function error check the user inputs
         */
        private void error_check(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*
         * This function setup up the booking page when program is loaded
         */
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

            // type name
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

        /*
         * This function auto fills first name and last name when driver license
         */
        private void Driver_license_leave(object sender, EventArgs e)
        {   
            try
            {
                this.sql.Query("select First_Name, Last_Name, CID, Membership from Customer where Driver_License =" + Int32.Parse(customer_driver_license.Text));

                while (this.sql.Reader().Read())
                {
                    first_name = (string) this.sql.Reader()["First_Name"];
                    last_name = (string) this.sql.Reader()["Last_Name"];
                    CID = (string)this.sql.Reader()["CID"];
                    membership = (string)this.sql.Reader()["Membership"];
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
