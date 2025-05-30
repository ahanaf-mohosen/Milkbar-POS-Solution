using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkbarPOS.Data
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
            "Server=MSI\\SQLEXPRESS;Database=MilkbarDB;Integrated Security=true;";
        // this is your database connection string
        // Adjust the server name, database name, and security settings as needed
        // MSI\\SQLEXPRESS this is the server name
        // this you find from your sql server management studio
        // like MSI\SQLEXPRESS ........
        // in your system it may be different
        // if you dont write the correct name it will not work
        // so be careful with that
        // and one thing remember my system name is MSI\SQLEXPRESS but when i writ it in "" commas it that time it will be MSI\\SQLEXPRESS type
        // so i use my system name like this MSI\\SQLEXPRESS
        //now run the project and it will work

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
