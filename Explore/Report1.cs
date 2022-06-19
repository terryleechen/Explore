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
        private String query;

        public Report1()
        {
            InitializeComponent();
            sql = new SQL();
            DurationBox.SelectedIndex = 0;
            CarData.SelectedIndex = 0;

            PopularTypeGrid.Columns[0].HeaderCell.Value = "Branch Name";
            PopularTypeGrid.Columns[1].HeaderCell.Value = "Most Rented";
            PopularTypeGrid.Columns[2].HeaderCell.Value = "Least Rented";


        }

        private void DurationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurationBox.SelectedIndex == 0)
            {
                this.interval = "7";
                if (CarData.SelectedIndex == 3) { this.SetTypeQuery(); } else { this.SetOtherQuery(); }
            }
            else if (DurationBox.SelectedIndex == 1)
            {
                this.interval = "30";
                if (CarData.SelectedIndex == 3) { this.SetTypeQuery(); } else { this.SetOtherQuery(); }
            }
            else if (DurationBox.SelectedIndex == 2)
            {
                this.interval = "365";
                if (CarData.SelectedIndex == 3) { this.SetTypeQuery(); } else { this.SetOtherQuery(); }
            }

        }

        private void CarData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarData.SelectedIndex == 0)
            {
                this.DataType = "Year";
                this.SetOtherQuery();
            } else if (CarData.SelectedIndex == 1)
            {
                this.DataType = "Brand";
                this.SetOtherQuery();
            } else if (CarData.SelectedIndex == 2)
            {
                this.DataType = "Model";
                this.SetOtherQuery();
            } else if (CarData.SelectedIndex == 3)
            {
                this.DataType = "Type_ID";
                this.SetTypeQuery();
                
            }
        }


        private void UpdatePopularity()
        {
            PopularTypeGrid.Rows.Clear();

            try
            {
                this.sql.Query(this.query);

                while (this.sql.Reader().Read())
                {

                    this.PopularTypeGrid.Rows.Add(
                        this.sql.Reader()["BranchName"].ToString(),
                        this.sql.Reader()["Most Rented"].ToString(),
                        this.sql.Reader()["Least Rented"].ToString());
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

        private void SetOtherQuery()
        {
            this.query = "select temp1.branchname, temp1.[Most Rented], temp2.[Least Rented] from " +
                    "(select t1.branchname, t1." + this.DataType + " as [Most Rented] from Rental_Transaction R, " +
                    "(select (trim(b.address_1) + ' ' + trim (b.address_2)) " +
                    "as BranchName, c." + this.DataType + ", count(*) NumberOfType from " +
                    "Branch B, Car C, Rental_Transaction R where R.Pickup_Branch_ID = B.BID and " +
                    "C.Car_ID = R.Car_Received_ID group by c." + this.DataType + ", (trim(b.Address_1) + ' ' + trim(b.address_2))) t1, " +
                    "(select BranchName, max(total) maximum from " +
                    "(select trim(b.address_1) + ' ' + trim(b.address_2) as " +
                    "BranchName, count(*) total from Branch B, Car C, Rental_Transaction R " +
                    "where R.Pickup_Branch_ID = B.BID and C.Car_ID = R.Car_Received_ID" +
                    " group by (trim(b.address_1) + ' ' + trim(b.address_2)), " + this.DataType + ") t group by t.BranchName) t2 " +
                    "where t1.NumberOfType = t2.maximum and t1.BranchName = t2.BranchName " +
                    "and DATEDIFF(day, CAST(R.Start_Date as date), GETDATE()) <= " + this.interval + " " +
                    "group by t1." + this.DataType + ", t1.BranchName) temp1 " +
                    "join " +
                    "(select t3.BranchName, t3." + this.DataType + " as [Least Rented] from Rental_transaction R, " +
                    "(select (trim(address_1) + ' '+  trim(address_2)) as BranchName, c." + this.DataType + ", " +
                    "count(*) NumberOfType from Branch B, Car C, Rental_Transaction R " +
                    "where R.Pickup_Branch_ID = B.BID and C.Car_ID = R.Car_Received_ID " +
                    "group by C." + this.DataType + ", (trim(b.address_1) + ' ' + trim(b.address_2))) t3, " +
                    "(select BranchName, min(total) minimum from (select trim(b.address_1) + ' ' + trim(b.address_2) as " +
                    "BranchName, count(*) total from Branch B, Car C, Rental_Transaction R where " +
                    "R.Pickup_Branch_ID = B.BID and C.Car_ID = R.Car_Received_ID " +
                    "group by (trim(b.address_1) + ' ' + trim(b.address_2)), c." + this.DataType + ") t group by t.branchName) t4 " +
                    "where t3.NumberOfType = t4.minimum and t3.BranchName = t4.BranchName " +
                    "and DATEDIFF(day, CAST(R.Start_Date as date), GETDATE()) <= " + this.interval + " " +
                    "group by t3." + this.DataType + ", t3.branchname) temp2 " +
                    "on temp1.branchname = temp2.branchname";
        }

        private void SetTypeQuery()
        {
            this.query = "select temp1.branchname, temp1.[Most Rented], temp2.[least rented] from " +
                    "(select t1.BranchName, t1.type_name as 'Most Rented' from Rental_Transaction R, Type T, " +
                    "(select(trim(b.address_1) + ' ' + trim(b.address_2)) " +
                    "as BranchName, c." + this.DataType + ", t.type_name, count(*) NumberOfType from " +
                    "Branch B, Car C, Rental_Transaction R, Type T where R.Pickup_Branch_ID = B.BID and " +
                    "C.Car_ID = R.Car_Received_ID and T." + this.DataType + " = c." + this.DataType + " group by t.type_name, c." + this.DataType + ", (trim(b.address_1) + ' ' + trim(b.address_2))) t1,  " +
                    "(select BranchName, max(total) maximum from(select trim(b.address_1) +' ' + trim(b.address_2) as " +
                    "BranchName, count(*) total from Branch B, Car C, Rental_Transaction R where R.Pickup_Branch_ID = B.BID and C.Car_ID = " +
                    "R.Car_Received_ID group by(trim(b.address_1) +' ' + trim(b.address_2)), " + this.DataType + ") t group by t.BranchName) t2 " +
                    "where t1.NumberOfType = t2.maximum " +
                    "and t1.BranchName = t2.BranchName " +
                    "and DATEDIFF(day, CAST(R.Start_Date as date), GETDATE()) <= " + this.interval + " " +
                    "group by t1.type_name, t1.BranchName) as temp1 " +
                    "join " +
                    "(select t3.BranchName, t3.type_name as 'least rented' from rental_transaction R, Type T, " +
                    "(select(trim(b.address_1) + ' ' + trim(b.address_2)) " +
                    "as BranchName, c." + this.DataType + ", t.type_name, count(*) NumberOfType from " +
                    "Branch B, Car C, Rental_Transaction R, Type T where R.Pickup_Branch_ID = B.BID and " +
                    "C.Car_ID = R.Car_Received_ID and t." + this.DataType + " = c." + this.DataType + " " +
                    "group by t.type_name, c." + this.DataType + ", (trim(b.address_1) + ' ' + trim(b.address_2))) t3,  " +
                    "(select BranchName, min(total) minimum from(select trim(b.address_1) +' ' + trim(b.address_2) as " +
                    "BranchName, count(*) total from Branch B, Car C, Rental_Transaction R where R.Pickup_Branch_ID = B.BID and C.Car_ID = " +
                    "R.Car_Received_ID group by(trim(b.address_1) +' ' + trim(b.address_2)), c." + this.DataType + ") t group by t.BranchName) t4 " +
                    "where t3.NumberOfType = t4.minimum " +
                    "and t3.BranchName = t4.BranchName " +
                    "and DATEDIFF(day, CAST(R.Start_Date as date), GETDATE()) <= " + this.interval + " " +
                    "group by t3.type_name, t3.BranchName) temp2 " +
                    "on temp1.BranchName = temp2.BranchName ";
        }

    }
}
