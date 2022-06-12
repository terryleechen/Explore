using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore
{
    internal class Calculator
    {
        private int number_days, month, week, day, price, change_fee;
        private string car_type, membership;
        private bool difference;
        private SQL sql;

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

            this.month = this.number_days / 30;
            this.number_days = this.number_days - (this.month * 30);
            this.week = this.number_days / 7;
            this.number_days = this.number_days - (this.week * 7);
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

            if(membership.Equals("Y") && difference == true)
            {
                this.change_fee = 0;
            }
            else if(difference == true)
            {
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
