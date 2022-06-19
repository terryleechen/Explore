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
        private String DataType, Province, City;
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
                this.Province = this.comboBox2.Text;
                this.City = this.comboBox3.Text;
                this.dataGridView1.Rows.Clear();
                
                this.sql.Query("select distinct BID,Address_1,city,Province,sum(Total_Price) as rev " +
                    "from Rental_Transaction, Branch " +
                    "where Rental_Transaction.Total_Price is not null and End_Date like '" + this.DataType + "'" +
                    "and Rental_Transaction.Pickup_Branch_ID = Branch.BID and Province = '"+ this.Province + "'" +
                    "and City = '" + this.City + "'" +
                    "group by BID, Address_1, city, Province order by rev desc");



                while (this.sql.Reader().Read())
                {
                    this.dataGridView1.Rows.Add(
                           this.sql.Reader()["BID"].ToString(),
                           this.sql.Reader()["Address_1"].ToString(),
                           this.sql.Reader()["city"].ToString(),
                           this.sql.Reader()["Province"].ToString(),
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
            // year 
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
           
        {


        }

        private void Report2_Load(object sender, EventArgs e)
        {
            // fill combobox 
            this.sql.Query("select distinct Province from Branch");
            while (this.sql.Reader().Read())
            {
                this.comboBox2.Items.Add(
                    this.sql.Reader()["Province"].ToString());
            }
            this.sql.Close();

            this.sql.Query("select distinct city from Branch");
            while (this.sql.Reader().Read())
            {
                this.comboBox3.Items.Add(
                        this.sql.Reader()["city"].ToString());
            }
            this.sql.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
 }
