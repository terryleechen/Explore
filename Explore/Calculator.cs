using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore
{
    /*
     * This is a calculator to calculate reservation price 
     */
    internal class Calculator
    {
        /*
         *  Field               Description
         *  number_days         days rented
         *  month               rented in month
         *  week                rented in weeks
         *  day                 rented in days
         *  price               total price
         *  change_fee          change branch fee
         *  car_type            selected car's type
         *  membership          membership status
         *  difference          if there is difference between pickup and return branch
         *  sql                 SQL class to access database
         */
        private int number_days, month, week, day, price, change_fee;
        private string car_type, membership;
        private bool difference;
        private SQL sql;

        /*
         * The constructor for calculator
         * 
         * Parameter                Description
         * number_days              days rented
         * car_type                 select car's type
         * difference               if there is difference between pickup and return branch
         * membership               membership status
         */
        public Calculator(double number_days, string car_type, bool difference, string membership)
        {
            this.number_days = (int) number_days;
            this.car_type = car_type;
            this.difference = difference;
            this.membership = membership;
            this.sql = new SQL();
        }

        public int calculate()
        {
            int price_day = 0, price_week = 0, price_month = 0;

            // calculate total in months
            this.month = this.number_days / 30;
            this.number_days = this.number_days - (this.month * 30);

            // calculate total in weeks
            this.week = this.number_days / 7;
            this.number_days = this.number_days - (this.week * 7);

            // reminder days
            this.day = this.number_days;

            this.sql.Query(
                "select Price_Per_Day, Price_Per_Week, Price_Per_Month " +
                "from Type T " +
                "where Type_Name = '" + car_type + "'");
            
            while(this.sql.Reader().Read())
            {
                price_day = Int32.Parse(this.sql.Reader()["Price_Per_Day"].ToString());
                price_week = Int32.Parse(this.sql.Reader()["Price_Per_Week"].ToString());
                price_month = Int32.Parse(this.sql.Reader()["Price_Per_Month"].ToString());
            }
            this.sql.Close();

            // check if change fee needed
            if(membership.Equals("Y") && difference == true)
            {
                this.change_fee = 0;
            }
            else if(difference == true)
            {
                // find the change fee amount
                this.sql.Query(
                    "select Change_Branch_Fee " +
                    "from Type T " +
                    "where Type_Name = '" + this.car_type + "'");

                while (this.sql.Reader().Read())
                {
                    this.change_fee = Int32.Parse(this.sql.Reader()["Change_Branch_Fee"].ToString());
                }
                this.sql.Close();
            }

            // calculate
            this.price = price_month * this.month + price_week * this.week + price_day * this.day
                + this.change_fee;

            return this.price;
        }

    }
}
