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
        private Return_detail return_detail;
        public Return(Return_detail return_detail)
        {
            InitializeComponent();
            sql = new SQL();
            this.return_detail = return_detail;
            this.button_next.Hide();
        }

        private void Button_search_click(object sender, EventArgs e)
        {
            bool check = false;
            this.button_next.Show();
            this.sql.Query("select CID from Rental_Transaction");
            while (this.sql.Reader().Read())
            {
                if (this.sql.Reader()["CID"].ToString().Equals(textBox1.Text))

                {
                    check = true;

                    break;


                }
            }
            this.sql.Close();
            if (check == false)
            {
                MessageBox.Show("CID not found ");

            }
            if (check)
            {
                try
                {
                    this.sql.Query("select Type_Requested, Car_Received_ID, Pickup_Branch_ID, Return_Branch_ID, Start_Date, " +
                        "End_Date, Reservation_Price, Return_Date, Total_Price from Rental_Transaction   where CID = '" + textBox1.Text + "'");




                    dataGridView1.Rows.Clear();
                    while (this.sql.Reader().Read())
                    {
                        dataGridView1.Rows.Add(
                            this.sql.Reader()["Type_Requested"].ToString(),
                            this.sql.Reader()["Car_Received_ID"].ToString(),
                            this.sql.Reader()["Return_Branch_ID"].ToString(),
                            this.sql.Reader()["Start_Date"].ToString(),
                            this.sql.Reader()["End_Date"].ToString(),
                            this.sql.Reader()["Reservation_Price"].ToString(),
                            this.sql.Reader()["Return_Date"].ToString(),
                            this.sql.Reader()["Total_Price"].ToString()
                            );




                    }
                    this.sql.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");

                }
                
            }
        }
        private void Button_next_click(object sender, EventArgs e)
        {
            this.return_detail.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
