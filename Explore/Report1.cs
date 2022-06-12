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

        public Report1()
        {
            InitializeComponent();
            sql = new SQL();
        }

        private void DurationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurationBox.SelectedIndex == 0)
            {
                interval = DateTime.Today.AddDays(-7).ToString();
            }
            else if (DurationBox.SelectedIndex == 1)
            {
                interval = DateTime.Today.AddDays(-30).ToString();
            }
            else if (DurationBox.SelectedIndex == 2)
            {
                interval = DateTime.Today.AddYears(-1).ToString();
            }

            PopularTypeGrid.Rows.Clear();
            try
            {
                this.sql.Query(
                    "Select Type_Name, count(*) as NumberRequests from " +
                    "(select T.Type_Name, R.Start_Date from [type] T, rental_transaction R " +
                    "where T.Type_ID = R.Type_Requested " +
                    "and CAST(R.Start_Date as datetime) > CAST('" + interval + "' as datetime)) as temp " +
                    "Group By Type_Name " +
                    "Order By Count(*) DESC");
                while (this.sql.Reader().Read())
                {
                    this.PopularTypeGrid.Rows.Add(
                        this.sql.Reader()["Type_Name"].ToString(),
                        this.sql.Reader()["NumberRequests"].ToString());
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
