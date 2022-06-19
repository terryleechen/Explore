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
    public partial class Report2 : UserControl
    {
        private String DataType;
        private SQL sql;
        public Report2()
        {
            InitializeComponent();
            sql = new SQL(); // Initialize the object and create the connection
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                this.dataGridView1.Rows.Clear();
                this.sql.Query("select BID, sum(Total_Price) as rev from Rental_Transaction, " +
                    "Branch where Rental_Transaction.Total_Price is not null and " +
                    "End_Date like '" + this.DataType + "' " +
                    " and Rental_Transaction.Pickup_Branch_ID = Branch.BID " +
                    "group by BID order by rev desc");




                
                while (this.sql.Reader().Read())
                {
                    this.dataGridView1.Rows.Add(
                           this.sql.Reader()["BID"].ToString(),
                           this.sql.Reader()["rev"].ToString());
                }
                this.sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Something Went Wrong");

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
