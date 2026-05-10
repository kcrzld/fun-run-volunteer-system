using System;
using System.Data.SqlClient;

namespace FunRunVolunteerSystem
{
    internal class DatabaseHelper
    {
        
        private static string connectionString =
        @"Data Source=(localdb)\MSSQLLocalDB;
        Initial Catalog=FunRunDB;
        Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
