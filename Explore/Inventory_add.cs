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
    /*
     * This is the inventory add panel after inventory panel
     * 
     * Author: Terry Leechen, Carter Sieben
     */
    public partial class Inventory_add : UserControl
    {
        /*
         * Field                    Description
         * employee_dashboard       employee dashboard panel
         * sql                      SQL class to access database
         * car_ID                   new car ID
         * BID                      branch ID
         * type_ID                  car type ID
         * year                     new car model year
         * brand                    new car brand
         * model                    new car model
         * mileage                  new car mileage
         * car_type                 new car type name
         */
        private Employee_dashboard employee_dashboard;
        private SQL sql;
        private string car_ID, BID, type_ID, year, brand, model, mileage, car_type;
        
        /*
         * The constructor for inventory add
         */
        public Inventory_add()
        {
            InitializeComponent();
            this.sql = new SQL();
        }

        /*
         * This is a getter method for Car ID
         */
        public string Get_car_ID_text()
        {
            return this.carID_textbox.Text;
        }

        /*
         * This is a getter method for selected branch combo box
         */
        public ComboBox Get_selected_branch_combobox()
        {
            return selected_branch_combobox;
        }

        /*
         * This is a getter method for brand combo box
         */
        public ComboBox Get_brand_combobox()
        {
            return brand_combo;
        }

        /*
         * This is a getter method for car type combo box
         */
        public ComboBox Get_car_type_combo()
        {
            return car_type_combo;
        }

        /*
         * This function active when key press in mileage textbox
         */
        private void Mileage_keypress(object sender, KeyPressEventArgs e)
        {
            error_check(e);
        }

        /*
         * This function active when key press in year textbox
         */
        private void Year_keypress(object sender, KeyPressEventArgs e)
        {
            error_check(e);
        }

        /*
         * This fucntion check user input
         */
        private void error_check(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*
         * This is a setter method for Car ID
         */
        public void Set_Car_ID(string car_ID)
        {
            this.carID_textbox.Text = car_ID;
            this.car_ID = car_ID;
        }

        /*
         * This is a setter method for employee dashboard
         */
        public void Set_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        /*
         * This function active when car type selection changes
         */
        private void Car_type_selection_changed(object sender, EventArgs e)
        {
            this.car_type = this.car_type_combo.Text;
        }

        /*
         * This function active when brand selection changes
         */
        private void Brand_selection_changed(object sender, EventArgs e)
        {
            string selection = this.brand_combo.Text;

            if (selection.Equals("New"))
            {
                this.brand_panel.Show();
            }
        }

        /*
         * This function active when buttone previous click
         */
        private void Button_previous_click(object sender, EventArgs e)
        {
            this.Hide();
            this.employee_dashboard.Get_inventory().Show();
        }

        /*
         * This function active when buttone previous click
         */
        private void Button_add_click(object sender, EventArgs e)
        {
            this.BID = Get_BID(this.selected_branch_combobox.Text);
            this.brand = this.brand_combo.Text;
            this.model = this.model_textbox.Text;
            Get_type_ID();
            this.year = this.year_textbox.Text;
            this.mileage = this.mileage_textbox.Text;

            this.sql.Insert(
                "insert into Car values(" +
                "'" + this.car_ID + "', " +
                "'" + this.BID + "', " +
                Int32.Parse(this.type_ID) + ", " +
                Int32.Parse(this.year) + ", " +
                "'" + this.brand.Trim() + "', " +
                "'" + this.model + "', " +
                Int32.Parse(this.mileage) + ")");

            // reset after add
            Clear_info();
            Refresh_combo();
            this.Hide();
            this.employee_dashboard.Get_inventory().Show();
        }

        /*
         * This function active when button brand add click
         */
        private void Button_brand_add_click(object sender, EventArgs e)
        {
            this.brand = this.brand_textbox.Text;
            this.brand_combo.Items.Insert(0, this.brand);
            this.brand_combo.SelectedIndex = 0;

            // hide action
            this.brand_panel.Hide();
        }
        /*
         * This reset the combo box
         */
        private void Refresh_combo()
        {
            // reset combo info
            this.brand_combo.Items.Clear();
            this.car_type_combo.Items.Clear();

            // set car type combo
            try
            {
                this.sql.Query("select DISTINCT [Type_Name] from [Type]");

                while (this.sql.Reader().Read())
                {
                    this.car_type_combo.Items.Add(this.sql.Reader()["Type_Name"]);
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            // set selected combo
            try
            {
                this.sql.Query(
                    "select Brand " +
                    "from Car C ");

                while (this.sql.Reader().Read())
                {
                    this.brand_combo.Items.Add(this.sql.Reader()["Brand"]);
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        /*
         * this funciton reset all text box
         */
        private void Clear_info()
        {
            this.selected_branch_combobox.Text = "";
            this.brand_combo.Text = "";
            this.car_type_combo.Text = "";
            this.selected_branch_combobox.Text = "";
            this.model_textbox.Clear();
            this.year_textbox.Clear();
            this.mileage_textbox.Clear();
            this.brand_textbox.Clear();
        }

        /*
         * This function determines the branch ID from branch address
         */
        private string Get_BID(string address)
        {
            string BID = "";
            this.sql.Query("select BID, Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

            try
            {
                while (this.sql.Reader().Read())
                {
                    if (address.Equals(this.sql.Reader()["Address"]))
                    {
                        BID = this.sql.Reader()["BID"].ToString();
                    }
                }
                this.sql.Close();
                return BID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return null;
        }

        /*
         * This function get type ID from type name
         */
        private void Get_type_ID()
        {
            this.sql.Query(
                "select Type_ID " +
                "from Type T " +
                "where Type_Name = '" + this.car_type + "'");

            try
            {
                while (this.sql.Reader().Read())
                {
                    this.type_ID = this.sql.Reader()["Type_ID"].ToString();
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }   
}