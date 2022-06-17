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
     * Thi sis the
     */
    public partial class Customer_search_selection : UserControl
    {
        private SQL sql;
        private double number_days;
        private string pickup_branch, return_branch, start_date, end_date, car_type, pickup_BID, return_BID, type_ID;
        private string CID, membership;
        private int reservation_price;
        private Customer_dashboard customer_dashboard;

        public Customer_search_selection()
        {
            InitializeComponent();
            this.sql = new SQL();
        }

        private void Selected_pickup_branch_changed(object sender, EventArgs e)
        {
            this.pickup_BID = Get_BID(selected_pickup_branch.Text);

            bool difference = !(this.pickup_BID.Equals(this.return_BID));
            Calculator calculator = new Calculator(this.number_days, this.car_type, difference, this.membership.ToUpper());

            this.estimated_cost.Text = "$" + calculator.calculate().ToString();
            Run_changes();
        }

        public void Get_all(string start_date, string end_date, string return_BID, string pickup_BID, string car_type, string CID, double number_days, string type_ID, int reservation_price, string membership)
        {
            this.start_date = start_date;
            this.end_date = end_date;
            this.return_BID = return_BID;
            this.pickup_BID = pickup_BID;
            this.car_type = car_type;
            this.CID = CID;
            this.number_days = number_days;
            this.type_ID = type_ID;
            this.reservation_price = reservation_price;
            this.membership = membership;
        }

        private void Load_event(object sender, EventArgs e)
        {
            try
            {
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                while (this.sql.Reader().Read())
                {
                    this.selected_pickup_branch.Items.Add(this.sql.Reader()["Address"]);
                    this.selected_return_branch.Items.Add(this.sql.Reader()["Address"]);
                }
                this.sql.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Selected_return_branch_changed(object sender, EventArgs e)
        {
            this.return_BID = Get_BID(selected_return_branch.Text);
            // check if change branch fee needed
            bool difference = !(this.pickup_BID.Equals(this.return_BID));

            Calculator calculator = new Calculator(this.number_days, this.car_type, difference, this.membership.ToUpper());
            this.estimated_cost.Text = "$" + calculator.calculate().ToString();
        }

        public void Set_pickup_branch(string pickup_branch)
        {
            this.selected_pickup_branch.Text = pickup_branch.Trim();
        }

        public void Set_return_branch(string return_branch)
        {
            this.selected_return_branch.Text = return_branch.Trim();
        }

        public Label Get_estimated_price()
        {
            return this.estimated_cost;
        }

        public DataGridView Get_table()
        {
            return this.availability_table;
        }

        private void Run_changes()
        {
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

                while (this.sql.Reader().Read())
                {
                    this.availability_table.Rows.Add(
                        this.sql.Reader()["Car_ID"].ToString(),
                        this.sql.Reader()["Type_Name"].ToString(),
                        this.sql.Reader()["Brand"].ToString(),
                        this.sql.Reader()["Model"].ToString(),
                        this.sql.Reader()["Year"].ToString(),
                        this.sql.Reader()["Mileage"].ToString());
                }
                this.sql.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
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
            return null;
        }

        private void Button_previous_clicked(object sender, EventArgs e)
        {
            this.customer_dashboard.Get_customer_search().Show();
            this.Hide();
        }

        public void  Set_customer_dashboard(Customer_dashboard customer_dashboard)
        {
            this.customer_dashboard = customer_dashboard;
        }
    }
}
