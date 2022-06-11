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

        public ComboBox Get_car_type_combo()
        {
            return car_type_combo;
        }
        // ===============================================================

        // ================== Setter method ==============================
        public void Set_Car_ID(string Car_ID)
        {
            this.carID_textbox.Text = Car_ID;
        }
        // ===============================================================

        public void Set_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        private void Button_previous_click(object sender, EventArgs e)
        {
            this.Hide();
            this.employee_dashboard.Get_inventory().Show();
        }
    }

    
}
