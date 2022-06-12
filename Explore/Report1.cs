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
        private String ReqRec;

        public Report1()
        {
            InitializeComponent();
            sql = new SQL();
            RequestedRecieved.SelectedIndex = 0;
            DurationBox.SelectedIndex = 0;
            UpdatePopularity();
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

            UpdatePopularity();
        }

        private void RequestedRecieved_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RequestedRecieved.SelectedIndex == 0)
            {
                this.ReqRec = "Select Type_Name, count(*) as NumberOfType from " +
                    "(select T.Type_Name, R.Start_Date from [type] T, rental_transaction R " +
                    "where T.Type_ID = R.Type_Requested ";
            } else if (RequestedRecieved.SelectedIndex == 1)
            {
                this.ReqRec = "Select Type_Name, count(*) as NumberOfType from " +
                    "(Select T.Type_Name, R.Start_Date from Rental_Transaction R, car C, [type] T " +
                    "Where R.Car_Received_ID = C.Car_ID AND C.Type_ID = T.Type_ID ";
            }

            UpdatePopularity();
        }

        private void UpdatePopularity()
        {
            PopularTypeGrid.Rows.Clear();
            try
            {
                this.sql.Query(
                    this.ReqRec +
                    "and CAST(R.Start_Date as datetime) > CAST('" + interval + "' as datetime)) as temp " +
                    "Group By Type_Name " +
                    "Order By Count(*) DESC");
                while (this.sql.Reader().Read())
                {
                    this.PopularTypeGrid.Rows.Add(
                        this.sql.Reader()["Type_Name"].ToString(),
                        this.sql.Reader()["NumberOfType"].ToString());
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Something Went Wrong");
            }
        }

    }
}
