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
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
            this.report_combo.Items.Add("Car Type Popularity");
            this.report_combo.Items.Add("Report 2");
            this.report_combo.Items.Add("Report 3");
            this.report_combo.Items.Add("Report 4");
        }

        private void Button_show_click(object sender, EventArgs e)
        {
            if(this.report_combo.Text != "")
            {
                string report_type = this.report_combo.Text;
            }

            switch(this.report_combo.Text)
            {
                case "Car Type Popularity":
                    this.report1.Show();
                    this.report2.Hide();
                    this.report3.Hide();
                    this.report4.Hide();
                    break;
                case "Report 2":
                    this.report1.Hide();
                    this.report2.Show();
                    this.report3.Hide();
                    this.report4.Hide();
                    break;
                case "Report 3":
                    this.report1.Hide();
                    this.report2.Hide();
                    this.report3.Show();
                    this.report4.Hide();
                    break;
                case "Report 4":
                    this.report1.Hide();
                    this.report2.Hide();
                    this.report3.Hide();
                    this.report4.Show();
                    break;
            }
            
        }
    }
}
