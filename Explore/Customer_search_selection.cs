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
    public partial class Customer_search_selection : UserControl
    {
        private SQL sql;
        private string pickup_branch, return_branch;
        public Customer_search_selection()
        {
            InitializeComponent();
            this.sql = new SQL();
        }

        private void Load_event(object sender, EventArgs e)
        {
            try
            {
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                while (this.sql.Reader().Read())
                {
                    this.selected_pickup_branch.Items.Add(this.sql.Reader()["Address"]);
                    this.selected_return_branch.Items.Add(this.sql.Reader()["Address"]);
                }
                this.sql.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        
        public void Set_pickup_branch(string pickup_branch)
        {
            this.selected_pickup_branch.Text = pickup_branch.Trim();
        }

        public void Set_return_branch(string return_branch)
        {
            this.selected_return_branch.Text = return_branch.Trim();
        }
    }
}
