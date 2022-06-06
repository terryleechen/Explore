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
        private readonly SqlConnection my_connection;
        private SqlCommand my_command;
        private readonly SqlDataReader my_reader;

        public SQL() 
        {
            // make sure to change the server to yours computer name
            // first time running this will need to create the database name it explore
            // ensure run explore.sql then exlpore_insert.sql
            // to login type "E0001" as employee
            // to login type "C000001" as customer
            String connection_string = "Server = DESKTOP-781GNEK; Database = explore; Trusted_Connection = yes;";

            SqlConnection my_connection = new SqlConnection(connection_string); // Timeout in seconds
            my_connection.Open(); // Open connection

            my_command = new SqlCommand();
            my_command.Connection = my_connection;

           
        }

        public SqlCommand Command()
        {
            return my_command;
        }

        public SqlDataReader Reader()
        {
            return my_reader;
        }
    }
}
