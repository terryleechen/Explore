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
    
    public partial class Return_detail : UserControl

    {
        private SQL sql;
        private string Total, Return_branch,date;
        private Employee_dashboard employee_dashboard;
        public Return_detail()
        {
            sql = new SQL();
            InitializeComponent();
        }

        public void Get_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.employee_dashboard.Get_return().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_detail_Load(object sender, EventArgs e)
        {
            this.sql.Query("select BID from Branch");
            while (this.sql.Reader().Read())
            {
                comboBox1.Items.Add(
                    this.sql.Reader()["BID"].ToString());

            }
            this.sql.Close();

        }

        private void button1_Click(object sender, EventArgs e)
            // the check btn 

        {
            this.sql.Query("select TID from Rental_Transaction");
            while (this.sql.Reader().Read())
            {
                if (this.sql.Reader()["TID"].ToString().Equals(textBox3.Text))
                    // tid found 
                {
                    string TID = textBox3.Text;
                    break;
                
                
                }



            }
            this.sql.Close();

            this.sql.Query("select distinct Start_Date, End_Date,Pickup_Branch_ID,Reservation_Price,Membership,Late_Fee,Change_Branch_Fee" +
                " from Rental_Transaction , Type, Branch, Customer " +
                "where Total_Price is null and Customer.CID = Rental_Transaction.CID and " +
                "Type.Type_ID = Rental_Transaction.Type_Requested and TID = '" + textBox3.Text + "'");

            while (this.sql.Reader().Read())
            {   // rev price 
                textBox10.Text = this.sql.Reader()["Reservation_Price"].ToString();
                // change_price_fee
                textBox9.Text = this.sql.Reader()["Change_Branch_Fee"].ToString();
                // Late fee 
                textBox4.Text = this.sql.Reader()["Reservation_Price"].ToString();
                // Member ship 
                textBox2.Text = this.sql.Reader()["Membership"].ToString();
                // End date 
                textBox11.Text = this.sql.Reader()["End_Date"].ToString();
                // strat date 
                textBox13.Text = this.sql.Reader()["Start_Date"].ToString();
                // pickup 
                textBox5.Text = this.sql.Reader()["Pickup_Branch_ID"].ToString();

            }
            this.sql.Close();
            string membership = textBox2.Text;
            string end_date = textBox11.Text;
            string return_date = textBox6.Text;
            // compares time 
            
            DateTime d1, d2;
            d1 = DateTime.Parse(end_date);
            d2 = DateTime.Parse(return_date);
            if (d1 < d2)
            // if end date less than return date 
            {
                textBox1.Text = "Yes";


                
              
            }
            else
            {
                textBox1.Text = "No";
            
            }



        }

        private void return_confirm_Click(object sender, EventArgs e)
            // confrim btn 
        {
            this.date = this.textBox6.Text;
            this.Total = this.textBox8.Text;
            this.Return_branch = this.comboBox1.Text;
            try
            {
                this.sql.Query("Update Rental_Transaction " +
               "Set Total_Price = '" + this.Total + "', " +
               "Return_Branch_ID = '" + this.Return_branch+ "', "+
               "Return_Date = '" + this.date + "'"+
               "where TID = '" + textBox3.Text+ "' ");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");

            }
            this.sql.Close();
            MessageBox.Show("Updated!");

        }
    }
}
