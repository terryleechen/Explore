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
    public partial class Booking_selection : UserControl
    {
        private Employee_dashboard employee_dashboard;
        private SQL sql;
        private string start_date, end_date, return_BID, pickup_BID, car_type, employee_ID, CID, type_ID;
        private string car_received_ID;
        private double number_days;
        private int reservation_price;

        public Booking_selection()
        {
            InitializeComponent();
            this.sql = new SQL();
        }

        public void Get_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }
        // ============ Getter methods ==============
        
        public void Get_all(string start_date, string end_date, string return_BID, string pickup_BID, string car_type, string CID, double number_days, string type_ID, int reservation_price)
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
        }

        public Label Get_estimated_price()
        {
            return this.estimated_cost;
        }
        
        public DataGridView Get_table()
        {
            return this.availability_table;
        }

        private void Selected_return_branch_changed(object sender, EventArgs e)
        {
            this.return_BID = Get_BID(selected_return_branch.Text);
        }

        private void Selected_pickup_branch_changed(object sender, EventArgs e)
        {
            this.pickup_BID = Get_BID(selected_pickup_branch.Text);
            Run_changes();
        }

        private void Button_book_click(object sender, EventArgs e)
        {
            this.car_received_ID = availability_table.CurrentRow.Cells["Car_ID"].Value.ToString();
            Console.WriteLine(this.car_received_ID);
            string TID = Create_transaction();
            this.sql.Insert(
                "insert into Rental_Transaction values(" +
                "'" + TID + "', " +
                "'" + this.type_ID + "', " +
                "'" + this.car_received_ID + "', " +
                "'" + this.CID + "', " +
                "'" + this.pickup_BID + "', " +
                "'" + this.return_BID + "', " +
                "'" + this.employee_ID + "', " +
                "'" + this.start_date + "', " +
                "'" + this.end_date + "', " +
                this.reservation_price + ",null,null)");
        }

        private void Selection_click(object sender, EventArgs e)
        {
            this.car_received_ID = availability_table.CurrentRow.Cells["Car_ID"].Value.ToString();
        }

        private string Create_transaction()
        {
            int index = 0;
            string TID = "", new_TID = "T";
            this.sql.Query("select TID from Rental_Transaction R order by TID desc");
            try
            {
                int row = 0;
                while (this.sql.Reader().Read())
                {
                    if (row == 0)
                    {
                        break;
                    }
                }

                TID = this.sql.Reader()["TID"].ToString();
                for (int i = 1; i < TID.Length; i++)
                {
                    if (Int32.Parse(TID[i].ToString()) > 0 && Int32.Parse(TID[i].ToString()) < 10)
                    {
                        index = i;
                        break;
                    }
                    new_TID += TID[i];
                }
                this.sql.Close();

                new_TID += Int32.Parse(TID.Substring(index, (TID.Length - index))) + 1;
                return new_TID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return null;
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

        private void Run_changes()
        {
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
        
        private void Button_previous_click(object sender, EventArgs e)
        {
            this.Hide();
            this.employee_dashboard.Get_booking().Show();
        }

        private void Booking_selection_load(object sender, EventArgs e)
        {
            this.employee_ID = this.employee_dashboard.Get_login().Get_employee_id();

            try
            {
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                while (this.sql.Reader().Read())
                {
                    this.selected_pickup_branch.Items.Add(this.sql.Reader()["Address"]);
                    this.selected_return_branch.Items.Add(this.sql.Reader()["Address"]);
                }
                this.sql.Close();
                this.selected_pickup_branch.Text = this.employee_dashboard.Get_booking().Get_pickup_branch();
                this.selected_return_branch.Text = this.employee_dashboard.Get_booking().Get_return_branch();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
