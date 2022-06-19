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
        private String DataType;
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
            this.dataGridView1.Rows.Clear();
            try 
            {
                this.sql.Query("select one.Type_Requested, total_rev_per_car_type, rev_from_returning_customers " +
                    "from(select Type_Requested,SUM(Total_Price) as total_rev_per_car_type " +
                    "from Rental_Transaction where Total_Price is not null and Start_Date like '"+ this.DataType +"' " +
                    " group by Type_Requested) as one, " +
                    "(select Type_Requested, sum(Total_Price) as rev_from_returning_customers from Rental_Transaction as t where t.CID in " +
                    "(select  CID from Rental_Transaction where Total_Price is not null and Start_Date like '" + this.DataType + "' " +
                    "group by CID having COUNT(cid) > 1) and " +
                    "Total_Price is not null group by Type_Requested) as two where one.Type_Requested = two.Type_Requested");








                while (this.sql.Reader().Read())
                {

                    this.dataGridView1.Rows.Add(
                            this.sql.Reader()["Type_Requested"].ToString(),
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
    }
}
