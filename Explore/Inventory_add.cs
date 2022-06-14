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
    public partial class Inventory_add : UserControl
    {
        private Employee_dashboard employee_dashboard;
        private SQL sql;
        private string car_ID, BID, type_ID, year, brand, model, mileage;
        private string car_type;
        public Inventory_add()
        {
            InitializeComponent();
            this.sql = new SQL();
        }
        // ================== Getter method ==============================
        public string Get_car_ID_text()
        {
            return this.carID_textbox.Text;
        }

        public ComboBox Get_selected_branch_combobox()
        {
            return selected_branch_combobox;
        }

        public ComboBox Get_brand_combobox()
        {
            return brand_combo;
        }

        public ComboBox Get_car_type_combo()
        {
            return car_type_combo;
        }

        private void Mileage_keypress(object sender, KeyPressEventArgs e)
        {
            error_check(e);
        }

        private void Year_keypress(object sender, KeyPressEventArgs e)
        {
            error_check(e);
        }

        private void error_check(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ===============================================================

        // ================== Setter method ==============================
        public void Set_Car_ID(string car_ID)
        {
            this.carID_textbox.Text = car_ID;
            this.car_ID = car_ID;
        }
        // ===============================================================

        public void Set_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        private void Car_type_selection_changed(object sender, EventArgs e)
        {
            this.car_type = this.car_type_combo.Text;
        }

        private void Button_previous_click(object sender, EventArgs e)
        {
            this.Hide();
            this.employee_dashboard.Get_inventory().Show();
        }

        private void Brand_selection_changed(object sender, EventArgs e)
        {
            string selection = this.brand_combo.Text;

            if(selection.Equals("New"))
            {
                this.brand_panel.Show();
            }
        }

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
        
        private void Button_brand_add_click(object sender, EventArgs e)
        {
            this.brand = this.brand_textbox.Text;
            this.brand_combo.Items.Insert(0, this.brand);
            this.brand_combo.SelectedIndex = 0;

            // hide action
            this.brand_panel.Hide();
        }
    }   
}