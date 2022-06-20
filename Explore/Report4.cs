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
    public partial class Report4 : UserControl

    {
        private SQL sql;
        private String DataType, Branch;
        public Report4()
        {
            InitializeComponent();
            sql = new SQL(); // Initialize the object and create the connection
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String year = comboBox1.Text;
            this.Branch = comboBox2.Text;
            this.dataGridView1.Rows.Clear();
            try 
            {
                this.sql.Query("select Type_Name ,total_rev_per_car_type,rev_from_returning_customers from " +
                    "(select Type_Requested, SUM(Total_Price) as total_rev_per_car_type from " +
                    "Rental_Transaction where Total_Price is not null and Start_Date like '" + this.DataType + "' " +
                    "and Pickup_Branch_ID = '" + this.Branch + "' " +
                    "group by Type_Requested) as temp,(select isnull(sum(Total_Price), 0) as " +
                    "rev_from_returning_customers, Type_Requested from Rental_Transaction as t where T.CID in (select  CID from " +
                    "Rental_Transaction where Total_Price is not null and Start_Date like '" + this.DataType + "' " +
                    " and Pickup_Branch_ID = '" + this.Branch + "' " +
                    "group by CID having COUNT(cid) > 1) and Total_Price is not null group by Type_Requested)as one,type " +
                    "where Type.Type_ID = temp.Type_Requested and temp.Type_Requested = one.Type_Requested");






                while (this.sql.Reader().Read())
                {

                    this.dataGridView1.Rows.Add(
                            this.sql.Reader()["Type_Name"].ToString(),
                            this.sql.Reader()["total_rev_per_car_type"].ToString(),
                              this.sql.Reader()["rev_from_returning_customers"].ToString());



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

        private void Report4_Load(object sender, EventArgs e)
        {
            this.sql.Query("select distinct  BID from Branch");
            while (this.sql.Reader().Read())
            {
                this.comboBox2.Items.Add(
                        this.sql.Reader()["BID"].ToString());

            }
            this.sql.Close();

        }
    }
}
