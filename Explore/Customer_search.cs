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
    public partial class Customer_search : UserControl
    {
        private SQL sql;
        private Customer_search_selection customer_search_selection;
        public Customer_search(Customer_search_selection customer_search_selection)
        {
            InitializeComponent();
            sql = new SQL();
            this.customer_search_selection = customer_search_selection;
        }

        private void Customer_search_load(object sender, EventArgs e)
        {
            // load pickup and return branch
            try
            {
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                while (this.sql.Reader().Read())
                {
                    pickup_combo.Items.Add(this.sql.Reader()["Address"].ToString().Trim());
                    return_combo.Items.Add(this.sql.Reader()["Address"].ToString().Trim());
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            try
            {
                this.sql.Query("select DISTINCT [Type_Name] from [Type]");

                while (this.sql.Reader().Read())
                {
                    car_type_combo.Items.Add(this.sql.Reader()["Type_Name"].ToString().Trim());
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Button_next_click(object sender, EventArgs e)
        {
            if (this.start_date_picker.Text.Equals("") || this.return_date_picker.Text.Equals("") ||
                this.pickup_combo.Text.Equals("") || this.return_combo.Text.Equals("") ||
                this.car_type_combo.Text.Equals(""))
            {
                MessageBox.Show("Error! all fields must be entered");
            }
            else
            {
                this.Hide();
                this.customer_search_selection.Show();
            }
        }

        private void Pickup_selection_picked(object sender, EventArgs e)
        {
            this.customer_search_selection.Set_pickup_branch(this.pickup_combo.Text.ToString().Trim());
        }

        private void Return_selection_picked(object sender, EventArgs e)
        {
            this.customer_search_selection.Set_return_branch(this.return_combo.Text.ToString().Trim());
        }
    }
}
