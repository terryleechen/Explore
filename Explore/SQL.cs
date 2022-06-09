using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Explore
{
    internal class SQL
    {
        private SqlConnection my_connection;
        private SqlCommand my_command;
        private SqlDataReader my_reader;

        public SQL() 
        {
            // make sure to change the server to yours computer name
            // first time running this will need to create the database name it explore
            // ensure run explore.sql then exlpore_insert.sql
            // to login type "E0001" as employee
            // to login type "C000001" as customer
            String connection_string = "Server = DESKTOP-VR20H8R; Database = explore; Trusted_Connection = yes;";
            my_connection = new SqlConnection(connection_string); // Timeout in seconds
            
            try
            {
                this.my_connection.Open();
                this.my_command = new SqlCommand();
                this.my_command.Connection = my_connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void Insert(String statement)
        {
            this.my_command.CommandText = statement;
            this.my_command.ExecuteNonQuery(); 
        }


        public void Query(String query)
        {
            this.my_command.CommandText = query;
            this.my_reader = this.my_command.ExecuteReader();
        }

        public SqlDataReader Reader()
        {
            return this.my_reader;
        }

        public void Close()
        {
            this.my_reader.Close();
        }
    }
}
