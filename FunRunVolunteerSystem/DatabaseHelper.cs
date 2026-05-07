using System;
using System.Data.SqlClient;

namespace FunRunVolunteerSystem
{
    internal class DatabaseHelper
    {
        
        private static string connectionString =
        @"Data Source=DESKTOP-EOUBALT\SQLEXPRESS;
        Initial Catalog=FunRunDB;
        Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
