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
        private string Total, Return_branch,date,result;
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

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            // the check btn 
        {
            bool check = false;

            this.sql.Query("select TID from Rental_Transaction where Total_Price is null");
            while (this.sql.Reader().Read())
            {
                if (this.sql.Reader()["TID"].ToString().Equals(textBox3.Text))
                // tid found 
                {
                    MessageBox.Show("TID found ");
                    check = true; 
                    
                    
                    


                }

                 
            }
            this.sql.Close();
            if (check == false)
            {
                MessageBox.Show("TID not found");
            
            
            
            }
            try
            {
                this.sql.Query("select distinct Start_Date,Customer.CID, End_Date,Pickup_Branch_ID,Reservation_Price,Membership,Late_Fee,Change_Branch_Fee" +
                    " from Rental_Transaction , Type, Branch, Customer " +
                    "where Total_Price is null and Customer.CID = Rental_Transaction.CID and " +
                    "Type.Type_ID = Rental_Transaction.Type_Requested and TID = '" + textBox3.Text + "'");

                while (this.sql.Reader().Read())
                {   // rev price 
                    textBox10.Text = this.sql.Reader()["Reservation_Price"].ToString();
                    // change_price_fee
                    textBox9.Text = this.sql.Reader()["Change_Branch_Fee"].ToString();
                    // Late fee 
                    textBox4.Text = this.sql.Reader()["Late_Fee"].ToString();
                    // Member ship 
                    textBox2.Text = this.sql.Reader()["Membership"].ToString();
                    // End date 
                    textBox11.Text = this.sql.Reader()["End_Date"].ToString();
                    // strat date 
                    textBox13.Text = this.sql.Reader()["Start_Date"].ToString();
                    // pickup 
                    textBox5.Text = this.sql.Reader()["Pickup_Branch_ID"].ToString();
                    // CID
                    textBox7.Text = this.sql.Reader()["CID"].ToString();

                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "rror");
            }
            string membership = textBox2.Text;
            string end_date = textBox11.Text;
            string return_date = textBox6.Text;
            // compares time 
            if (!return_date.Equals(""))
            {
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

                string temp = textBox13.Text;
                string year = temp.Substring(0, 4);

                
 
                
            }
        }

        private void return_confirm_Click(object sender, EventArgs e)
        // confrim btn 
        {

            this.date = this.textBox6.Text;
            this.Total = this.textBox8.Text;
            this.Return_branch = this.comboBox1.Text;
            





            if (!this.Return_branch.Equals("") & !this.Total.Equals("") & !this.date.Equals(""))

            {

                string temp = textBox13.Text;
                string year = temp.Substring(0, 4) + "%"; 




                try
                {
                    this.sql.Query("Update Rental_Transaction " +
                   "Set Total_Price = '" + this.Total + "'," +
                   "Return_Branch_ID = '" + this.Return_branch + "', " +
                   "Return_Date = '" + this.date + "'" +
                   "where TID = '" + textBox3.Text + "' ");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "E");

                }
                this.sql.Close();
                MessageBox.Show("Updated!");
                // update customer ICD = textbox7.text

                try

                {
                    
                   

                    this.sql.Query("select COUNT(TID) as times_per_year from Rental_Transaction, " +
                      "Customer where Rental_Transaction.CID = Customer.CID and Total_Price is not null and Customer.CID = '" + textBox7.Text + "'" +
                      "and Start_Date  like '" +year + "'" +
                      "and End_Date like '" + year + "'");
                    while (this.sql.Reader().Read())
                    {

                        this.result = this.sql.Reader()["times_per_year"].ToString();

                    }
                    this.sql.Close();

                    if (Convert.ToInt32(result) >= 3)
                    // updae to gold
                    {
                        this.sql.Query("update Customer set Membership = 'Y' where CID = '" + textBox7.Text + "' ");

                        MessageBox.Show("New gold-Member ");
                        this.sql.Close();


                    }
                    else
                    {

                        MessageBox.Show("pls rent more non-gold-mmeber");
                        this.sql.Close();

                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }

            }
        }



      }

  }

