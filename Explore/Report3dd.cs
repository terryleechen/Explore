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
    public partial class Report3 : UserControl

    {
        private SQL sql;
        private String DataType;
        public Report3()
        {

            InitializeComponent();
            sql = new SQL(); // Initialize the object and create the connection
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                this.sql.Query("select * from(select sum(Change_Branch_Fee) as fee_income " +
                    "from Customer, Rental_Transaction, Type where Customer.CID = Rental_Transaction.CID  and Total_Price is not null and Membership = 'N' " +
                    "and Type.Type_ID = Rental_Transaction.Type_Requested and " +
                    "Pickup_Branch_ID != Return_Branch_ID  and End_Date like '" + this.DataType + "' " +
                    ") as temp," +
                    "(select sum(Change_Branch_Fee) as fee_income_lost from Customer, Rental_Transaction, Type where Customer.CID = Rental_Transaction.CID  " +
                    "and Total_Price is not null and Membership = 'y' and Type.Type_ID = Rental_Transaction.Type_Requested " +
                    "and Pickup_Branch_ID != Return_Branch_ID and  End_Date like '" + this.DataType + "' " +
                    ") temp1");

                dataGridView1.Rows.Clear();
                while (this.sql.Reader().Read())
                {
                    this.dataGridView1.Rows.Add(
                         this.sql.Reader()["fee_income"].ToString(),
                           this.sql.Reader()["fee_income_lost"].ToString());

                }
                this.sql.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (comboBox1.SelectedIndex == 0)
            {
                this.DataType = "2022%";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.DataType = "2021%";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                this.DataType = "2020%";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                this.DataType = "2019%";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
