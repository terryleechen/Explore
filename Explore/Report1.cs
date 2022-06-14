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
    public partial class Report1 : UserControl
    {

        private SQL sql;
        private String interval;
        private String DataType;

        public Report1()
        {
            InitializeComponent();
            sql = new SQL();
            DurationBox.SelectedIndex = 0;
            CarData.SelectedIndex = 0;

            PopularTypeGrid.Columns[0].HeaderCell.Value = "Branch Name";
            PopularTypeGrid.Columns[1].HeaderCell.Value = "Most Rented";
            PopularTypeGrid.Columns[2].HeaderCell.Value = "Least Rented";


            //UpdatePopularity();
        }

        private void DurationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurationBox.SelectedIndex == 0)
            {
                this.interval = DateTime.Today.AddDays(-7).ToString();
            }
            else if (DurationBox.SelectedIndex == 1)
            {
                this.interval = DateTime.Today.AddDays(-30).ToString();
            }
            else if (DurationBox.SelectedIndex == 2)
            {
                this.interval = DateTime.Today.AddYears(-1).ToString();
            }

        }

        private void CarData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarData.SelectedIndex == 0)
            {
                this.DataType = "Year";
            } else if (CarData.SelectedIndex == 1)
            {
                this.DataType = "Brand";
            } else if (CarData.SelectedIndex == 2)
            {
                this.DataType = "Model";
            } else if (CarData.SelectedIndex == 3)
            {
                this.DataType = "Type_ID";
            }
        }


        private void UpdatePopularity()
        {
            PopularTypeGrid.Rows.Clear();

            try
            {
                this.sql.Query("select t1.BranchName, t1." + this.DataType + ", t1.NumberOfType from Rental_Transaction R, (" +
                    "select trim(b.address_1) + ' ' + trim(b.address_2) as BranchName, C." + this.DataType + ", " +
                    "count(*) NumberOfType from Branch B, Car C, Rental_Transaction R " +
                    "where C.BID = B.BID and C.Car_ID = R.Car_Received_ID " +
                    "group by C." + this.DataType + ", (trim(b.address_1) + ' ' + trim(b.address_2))) t1, " +
                    "(select BranchName, max(total) maximum from " +
                    "(select trim(b.address_1) + ' ' + trim(b.address_2) as BranchName, " +
                    "count(*) total from Branch B, Car C, Rental_Transaction R " +
                    "where C.BID = B.BID and C.Car_ID = R.Car_Received_ID " +
                    "group by (trim(b.address_1) + ' ' + trim(b.address_2)), C." + this.DataType + ") t " +
                    "group by t.BranchName) t2 " +
                    "where t1.BranchName = t2.BranchName and t1.NumberOfType = t2.maximum " +
                    "and CAST(R.Start_Date as datetime) > CAST('" + this.interval + "' as datetime) " +
                    "group by t1.BranchName, t1." + this.DataType + ", t1.NumberOfType");

                while (this.sql.Reader().Read())
                {
                    this.PopularTypeGrid.Rows.Add(
                        this.sql.Reader()["BranchName"].ToString(),
                        this.sql.Reader()[this.DataType].ToString(),
                        this.sql.Reader()["NumberOfType"].ToString());
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Something Went Wrong");

            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.UpdatePopularity();
        }
    }
}
