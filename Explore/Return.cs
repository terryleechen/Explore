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
    public partial class Return : UserControl
    {
        private SQL sql;
        private int milage;
        private string TID, pickup_branch;
        private Return_detail return_detail;
        public Return(Return_detail return_detail)
        {
            InitializeComponent();
            sql = new SQL();
            this.return_detail = return_detail;
        }

        private void Button_search_click(object sender, EventArgs e)
        {
            try
            {
                this.sql.Query(
                    "select R.TID, R.Start_Date, R.End_Date, R.Reservation_Price, R.Type_Requested, C.First_Name, C.Last_Name " +
                    "from Rental_Transaction R, Customer C " +
                    "where R.CID = C.CID and C.Driver_License = " + Int32.Parse(this.customer_driver_license.Text));

                while (this.sql.Reader().Read())
                {
                    this.transactions.Rows.Add(
                        this.sql.Reader()["TID"].ToString(),
                        this.sql.Reader()["Start_Date"].ToString(),
                        this.sql.Reader()["End_Date"].ToString(),
                        this.sql.Reader()["Reservation_Price"].ToString(),
                        this.sql.Reader()["Type_Requested"].ToString());

                    this.customer_firstname.Text = this.sql.Reader()["First_Name"].ToString();
                    this.customer_lastname.Text = this.sql.Reader()["Last_Name"].ToString();
                }

                this.panel_info.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.sql.Close();
        }

        private void Button_next_click(object sender, EventArgs e)
        {
            this.return_detail.Show();
            this.Hide();
        }

        private void Return_load(object sender, EventArgs e)
        {
            this.panel_info.Hide();
        }
    }
}
