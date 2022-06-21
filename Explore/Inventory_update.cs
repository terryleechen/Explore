using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Explore
{
    /*
     * This is inentory update panel after inventory panel
     * 
     * Author: Terry Leechen, Carter Sieben
     */
    public partial class Inventory_update : UserControl
    {
        /*
         * Field                    Description
         * employee dashboard       employee dashboard page
         * sql                      SQL calss to access the database
         * selected_branch          the branch that the selected car is located
         * car_ID                   the selected car ID
         * type_ID                  the selected car type ID
         * year                     the selected car model year
         * brand                    the selected car brand
         * model                    the selected car model
         * mileage                  the selected car mileage
         * type_name                the selected car type name
         * BID                      the selected branch ID
         */
        private Employee_dashboard employee_dashboard;
        private SQL sql;
        private string selected_branch, car_ID, type_ID, brand, year, mileage, model, type_name, BID;


        /*
         * The constructor of inventory update
         */
        public Inventory_update()
        {
            InitializeComponent();
            sql = new SQL();
        }

        /*
         * This function active when key press on mileage textbox
         */
        private void Mileage_keypress(object sender, KeyPressEventArgs e)
        {
            Error_check(e);
        }

        /*
         * This function active when key press on year textbox
         */
        private void Year_keypress(object sender, KeyPressEventArgs e)
        {
            Error_check(e);
        }
        
        /*
         * This function active when button update click
         */
        private void Button_update_click(object sender, EventArgs e)
        {
            this.selected_branch = this.selected_branch_combobox.Text;
            this.BID = Get_BID(this.selected_branch_combobox.Text);
            this.car_ID = this.carID_textbox.Text;
            this.brand = this.brand_combo.Text;
            this.year = this.year_textbox.Text;
            this.model = this.model_textbox.Text;
            this.mileage = this.mileage_textbox.Text;

            try {
                this.sql.Update(
               "Update Car " +
               "Set Car_ID = '" + this.car_ID + "', " +
               "BID = '" + this.BID + "', " +
               "Type_ID = '" + this.type_ID + "', " +
               "Year = " + Int32.Parse(this.year) + ", " +
               "Brand = '" + this.brand + "', " +
               "Model = '" + this.model + "', " +
               "Mileage = " + Int32.Parse(this.mileage) + " " +
               "Where Car_ID = '" + this.car_ID + "'");

                // clear info
                this.selected_branch_combobox.Text = "";
                this.brand_combo.Text = "";
                this.carID_textbox.Text = "";
                this.brand_combo.Text = "";
                this.year_textbox.Text = "";
                this.model_textbox.Text = "";
                this.mileage_textbox.Text = "";

                // set front end
                this.Hide();
                this.employee_dashboard.Get_inventory().Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SQL Error");
            }
            this.sql.Close();


        }

        /*
         * This function active when button add click
         */
        private void Button_add_click(object sender, EventArgs e)
        {
            this.brand = this.brand_textbox.Text;
            this.brand_combo.Items.Insert(0, this.brand);
            this.brand_combo.SelectedIndex = 0;

            // hide action
            this.brand_panel.Hide();
        }

        /*
         * This function active when user select "new" in brand combo box
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
         * This fucntion active when button previous click
         */
        private void Button_previous_click(object sender, EventArgs e)
        {
            this.employee_dashboard.Get_inventory().Show();
            this.Hide();
        }

        /*
         * This a setter method for employee dashboard
         */
        public void Set_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        /*
         * This function set all the info needed for updating a car
         */
        public void Set_Info() {
            // carry values over
            this.selected_branch_combobox.SelectedItem = Inventory.SetVal_branchcombobox;
            this.carID_textbox.Text = Inventory.SetVal_car_ID;
            this.car_type_combo.SelectedItem = Inventory.SetVal_type_name;
            this.brand_combo.SelectedItem = Inventory.SetVal_brand;
            this.year_textbox.Text = Inventory.SetVal_year;
            this.model_textbox.Text = Inventory.SetVal_model;
            this.mileage_textbox.Text = Inventory.SetVal_mileage;

            // set values to be run through quary
            this.selected_branch = Inventory.SetVal_branchcombobox;
            this.BID = Get_BID(Inventory.SetVal_branchcombobox);
            this.car_ID = Inventory.SetVal_car_ID;
            this.type_name = Inventory.SetVal_type_name;
            Get_type_ID();
            this.brand = Inventory.SetVal_brand;
            this.year = Inventory.SetVal_year;
            this.model = Inventory.SetVal_model;
            this.mileage = Inventory.SetVal_mileage;
        }

        /*
         * This function active at the start of the program
         */
        private void Load_event(object sender, EventArgs e)
        {
            // set up selected branch
            string default_branch = "";
            int index = 0;

            try
            {
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                while (this.sql.Reader().Read())
                {
                    if (index == 0)
                    {
                        default_branch = this.sql.Reader()["Address"].ToString();
                        index++;
                    }
                    selected_branch_combobox.Items.Add(this.sql.Reader()["Address"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error");
            }
            this.sql.Close();
            
            // set up car type
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
                MessageBox.Show("SQL Error");
            }

            // set up brand
            try
            {
                this.sql.Query(
                    "select distinct Brand from Car C");

                while (this.sql.Reader().Read())
                {
                    this.brand_combo.Items.Add(this.sql.Reader()["Brand"].ToString().Trim());
                }
                this.sql.Close();
                this.brand_combo.Items.Add("New");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error");
            }
        }

        /*
         * This function get type ID from type name
         */
        private void Get_type_ID()
        {
            this.sql.Query(
                "select Type_ID " +
                "from Type T " +
                "where Type_Name = '" + this.car_type_combo.Text + "'");

            try
            {
                while (this.sql.Reader().Read())
                {
                    this.type_ID = this.sql.Reader()["Type_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error");
            }
            this.sql.Close();
        }

        /*
         * This function error checks for non numercial entries
         */
        private void Error_check(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*
         * This function active after selection of car type combo box
         */
        private void Car_type_leave(object sender, EventArgs e)
        {
            this.type_name = car_type_combo.Text;
            Get_type_ID();
        }
        
        /*
         * This function gets branch ID from branch address
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
                MessageBox.Show("SQL Error");
            }
            return null;
        }
    }
}
