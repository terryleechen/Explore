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
    public partial class Inventory : UserControl
    {
        /*SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;*/

        private SQL sql;
        private Inventory_add inventory_add;
        private Inventory_update inventory_update;
        private string selected_branch, car_ID, type_ID, brand, year, mileage; //need this for update
        public static string SetVal_branchcombobox = "";
        public static string SetVal_car_ID = "";
        public static string SetVal_type_name = "";
        public static string SetVal_brand = "";
        public static string SetVal_year = "";
        public static string SetVal_mileage = "";
        public static string SetVal_model = "";



        public Inventory(Inventory_add inventory_add, Inventory_update inventory_update)
        {
            InitializeComponent();
            this.inventory_add = inventory_add;
            this.inventory_update = inventory_update;
            sql = new SQL();
        }

        private void RowClick(object sender, EventArgs e)
        {
            this.car_ID = dataGridView_inventory.CurrentRow.Cells["Car_ID"].Value.ToString();
            this.type_ID = dataGridView_inventory.CurrentRow.Cells["Type_ID"].Value.ToString();
            this.brand = dataGridView_inventory.CurrentRow.Cells["Brand"].Value.ToString();
            this.year = dataGridView_inventory.CurrentRow.Cells["Year"].Value.ToString();
            this.mileage = dataGridView_inventory.CurrentRow.Cells["Mileage"].Value.ToString();
        }

        private void Button_update_click(object sender, EventArgs e)
        {
            this.Hide();
            this.inventory_update.Show();

            SetVal_branchcombobox = inventory_branch_select_combobox.Text.ToString();
            SetVal_car_ID = dataGridView_inventory.CurrentRow.Cells[0].Value.ToString();
            SetVal_type_name = dataGridView_inventory.CurrentRow.Cells[1].Value.ToString();
            SetVal_brand = dataGridView_inventory.CurrentRow.Cells[2].Value.ToString();
            SetVal_year = dataGridView_inventory.CurrentRow.Cells[3].Value.ToString();
            SetVal_model = dataGridView_inventory.CurrentRow.Cells[4].Value.ToString();
            SetVal_mileage = dataGridView_inventory.CurrentRow.Cells[5].Value.ToString();
            this.inventory_update.Set_Info();

        }

        private void inventory_show_records_button_Click(object sender, EventArgs e)
        {
            /*SqlConnection conn = new SqlConnection("Server = DESKTOP-VR20H8R; Database = explore; Trusted_Connection = yes;");
            sda = new SqlDataAdapter(@"SELECT Car_ID, Type_ID, Brand, Model, Year, Mileage FROM Car", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView_inventory.DataSource = dt;*/
            try
            {
                sql.Query("SELECT Car_ID, Type_ID, Brand, Model, Year, Mileage FROM Car");
                dataGridView_inventory.Rows.Clear();
                while (sql.Reader().Read())
                {
                    dataGridView_inventory.Rows.Add(sql.Reader()["Car_ID"].ToString(),
                        sql.Reader()["Type_ID"].ToString(),
                        sql.Reader()["Brand"].ToString(),
                        sql.Reader()["Model"].ToString(),
                        sql.Reader()["Year"].ToString(),
                        sql.Reader()["Mileage"].ToString());
                }
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

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
                    if(index == 0)
                    {
                        default_branch = this.sql.Reader()["Address"].ToString();
                        index++;
                    }
                    inventory_branch_select_combobox.Items.Add(this.sql.Reader()["Address"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            this.sql.Close();

            // set default to branch 1
            // bug
            this.inventory_add.Get_selected_branch_combobox().Text = default_branch;

            // set up brand combo
            try
            {
                this.sql.Query(
                    "select distinct Brand from Car C");

                while(this.sql.Reader().Read())
                {
                    this.inventory_add.Get_brand_combobox().Items.Add(this.sql.Reader()["Brand"]);
                }
                this.sql.Close();
                this.inventory_add.Get_brand_combobox().Items.Add("New");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void dataGridView_inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_add_click(object sender, EventArgs e)
        {
            // set car ID
            string car_ID = this.inventory_add.Get_car_ID_text();
            car_ID = Create_car_ID();
            this.inventory_add.Set_Car_ID(car_ID);

            // set car type and selected branch
            Load_info_add();

            this.Hide();
            this.inventory_add.Show();
        }

        private string Create_car_ID()
        {
            int index = 0;
            string car_ID = "", new_car_ID = "CR";
            this.sql.Query("select Car_ID from Car C order by Car_ID desc");
            try
            {
                int row = 0;
                while (this.sql.Reader().Read())
                {
                    if (row == 0)
                    {
                        break;
                    }
                }
                car_ID = this.sql.Reader()["Car_ID"].ToString();
                for (int i = 2; i < car_ID.Length; i++)
                {
                    if (Int32.Parse(car_ID[i].ToString()) > 0 && Int32.Parse(car_ID[i].ToString()) < 10)
                    {
                        index = i;
                        break;
                    }
                    new_car_ID += car_ID[i];
                }
                this.sql.Close();
                new_car_ID += Int32.Parse(car_ID.Substring(index, (car_ID.Length - index))) + 1;
                return new_car_ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            this.sql.Close();
            return null;
        }

        private void Load_info_add()
        {
            // set car type combo
            try
            {
                this.sql.Query("select DISTINCT [Type_Name] from [Type]");

                while (this.sql.Reader().Read())
                {
                    this.inventory_add.Get_car_type_combo().Items.Add(this.sql.Reader()["Type_Name"]);
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
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                while (this.sql.Reader().Read())
                {
                    this.inventory_add.Get_selected_branch_combobox().Items.Add(this.sql.Reader()["Address"]);
                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void User_select(object sender, EventArgs e)
        {
            selected_branch = inventory_branch_select_combobox.Text;
            this.inventory_add.Get_selected_branch_combobox().Text = inventory_branch_select_combobox.Text;
            string BID = Get_BID(selected_branch);
            
            try
            {
                this.sql.Query("select C.Car_ID, T.Type_Name, Brand, Model, Year, Mileage " +
                    "from Car C, Type T " +
                    "where C.Type_ID = T.Type_ID and BID = '" + BID + "'");
                dataGridView_inventory.Rows.Clear();
                while (this.sql.Reader().Read())
                {
                    dataGridView_inventory.Rows.Add(
                        this.sql.Reader()["Car_ID"],
                        this.sql.Reader()["Type_Name"],
                        this.sql.Reader()["Brand"],
                        this.sql.Reader()["Model"],
                        this.sql.Reader()["Year"],
                        this.sql.Reader()["Mileage"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            this.sql.Close();
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
    }
}
