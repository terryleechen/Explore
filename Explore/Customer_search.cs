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
    public partial class Customer_search : UserControl
    {
        private SQL sql;
        private Customer_search_selection customer_search_selection;
        private int reservation_price;
        private double number_days;
        private string start_date, end_date, CID, pickup_branch, return_branch, pickup_BID, return_BID;
        private string type_name, type_ID, membership, car_type;
        private bool upgraded = false;

        public Customer_search(Customer_search_selection customer_search_selection)
        {
            InitializeComponent();
            sql = new SQL();
            this.customer_search_selection = customer_search_selection;
        }

        public void Set_CID(string CID)
        {
            this.CID = CID;
        }

        public void Set_membership(string membership)
        {
            this.membership = membership;
        }
        
        private void Customer_search_load(object sender, EventArgs e)
        {
            // load pickup and return branch
            try
            {
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                while (this.sql.Reader().Read())
                {
                    pickup_combo.Items.Add(this.sql.Reader()["Address"].ToString().Trim());
                    return_combo.Items.Add(this.sql.Reader()["Address"].ToString().Trim());
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            try
            {
                this.sql.Query("select DISTINCT [Type_Name] from [Type]");

                while (this.sql.Reader().Read())
                {
                    car_type_combo.Items.Add(this.sql.Reader()["Type_Name"].ToString().Trim());
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Button_next_click(object sender, EventArgs e)
        {
            if (this.start_date_picker.Text.Equals("") || this.return_date_picker.Text.Equals("") ||
                this.pickup_combo.Text.Equals("") || this.return_combo.Text.Equals("") ||
                this.car_type_combo.Text.Equals(""))
            {
                MessageBox.Show("Error! all fields must be entered");
            }
            else
            {
                // format start date
                this.start_date = this.start_date_picker.Value.Year.ToString() + "/" +
                    this.start_date_picker.Value.Month.ToString() + "/" +
                    this.start_date_picker.Value.Day.ToString();

                // format return date
                this.end_date = this.return_date_picker.Value.Year.ToString() + "/" +
                    this.return_date_picker.Value.Month.ToString() + "/" +
                    this.return_date_picker.Value.Day.ToString();

                // calculate number of days
                this.number_days = Math.Round((this.return_date_picker.Value - this.start_date_picker.Value).TotalDays);
               
                // get branch
                this.pickup_branch = this.pickup_combo.Text;
                this.return_branch = this.return_combo.Text;

                // get type name
                // set up all the info needed for selection
                this.car_type = this.car_type_combo.Text;
                Get_type_ID();
                this.pickup_branch = this.pickup_combo.Text;
                this.return_branch = this.return_combo.Text;
                this.pickup_BID = Get_BID(this.pickup_combo.Text);
                this.return_BID = Get_BID(this.return_combo.Text);

                this.customer_search_selection.Get_all(start_date, end_date, return_BID, pickup_BID, car_type, CID, number_days, type_ID, reservation_price, membership);

                int check = Initial_availability();

                // check if the selected dates are within the same day
                if ((this.return_date_picker.Value - this.start_date_picker.Value).TotalDays < 0)
                {
                    check = 2;
                }

                if (check == 0)
                {
                    // get customer ID for calculation;
                    
                    // check if change branch fee needed
                    bool difference = !(this.pickup_BID.Equals(this.return_BID));


                    Calculator calculator = new Calculator(this.number_days, this.car_type, difference, this.membership.ToUpper());
                    this.reservation_price = calculator.calculate();
                    Console.WriteLine(this.reservation_price);

                    this.customer_search_selection.Get_estimated_price().Text = "$" + this.reservation_price.ToString();
                    this.customer_search_selection.Get_all(start_date, end_date, return_BID, pickup_BID, car_type, CID, number_days, type_ID, reservation_price, membership);

                    if (this.upgraded)
                    {
                        MessageBox.Show("No results found for your search, however, the customer " +
                            "is a Gold Member. Please select a free upgrade from the displayed cars.");
                    }

                    this.Hide();
                    this.customer_search_selection.Show();
                }
                else if (check == 2)
                {
                    MessageBox.Show("Rental car must be rented at least one day!");
                }
                else
                {
                    MessageBox.Show("Sorry!\nNo results found for your search, please select " +
                        "another car type or choose from a different branch.");
                } 
            }
        }

        private void Pickup_selection_picked(object sender, EventArgs e)
        {
            this.customer_search_selection.Set_pickup_branch(this.pickup_combo.Text.ToString().Trim());
        }

        private void Return_selection_picked(object sender, EventArgs e)
        {
            this.customer_search_selection.Set_return_branch(this.return_combo.Text.ToString().Trim());
        }

        private int Initial_availability()
        {
            DataGridView availability_table = this.customer_search_selection.Get_table();
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
                if (!this.sql.Reader().HasRows)
                {
                    // if no available rental and gold member
                    if (this.membership.ToUpper().Equals("Y"))
                    {
                        this.type_ID = (Int32.Parse(this.type_ID) + 1).ToString();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return 1;
            }
        }

        private string Get_BID(string address)
        {
            string BID = "";
            this.sql.Query("select BID, Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

            try
            {
                while (this.sql.Reader().Read())
                {
                    if (address.Equals(this.sql.Reader()["Address"]))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            this.sql.Close();
        }
    }
}
