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
        public Report2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {// back button goes to report page 
            this.Hide();
            Reports Reports = new Reports();
            Reports.Show();
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sql = new SQL();

            //retrieve the SQL Server instance version
            sql.Query.(trytry {@"select Pickup_Branch_ID,sum (Total_Price) as rev
                from [Test Data - Rental Transaction]
                where Total_Price is not null and Pickup_Branch_ID is not null
                group by Pickup_Branch_ID"} 

             

                //Set the SqlDataAdapter object
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                //define dataset
                DataSet ds = new DataSet();

                //fill dataset with query results
                dAdapter.Fill(ds);

                //set DataGridView control to read-only
                grdData.ReadOnly = true;

                //set the DataGridView control's data source/data table
                grdData.DataSource = ds.Tables[0];


