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

        public Inventory(Inventory_add inventory_add)
        {
            InitializeComponent();
            this.inventory_add = inventory_add;
            sql = new SQL();
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
            try
            {
                this.sql.Query("select Trim(Address_1) + ' ' + Trim(Address_2) as Address from branch");

                while (this.sql.Reader().Read())
                {
                    inventory_branch_select_combobox.Items.Add(this.sql.Reader()["Address"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            this.sql.Close();
        }

        private void Button_add_click(object sender, EventArgs e)
        {
            this.Hide();
            this.inventory_add.Show();
        }
    }
}
