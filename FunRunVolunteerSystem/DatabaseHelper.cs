using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunRunVolunteerSystem
{
    class DatabaseHelper
    {
        public static string connectionString = @"Data Source=DESKTOP-EOUBALT\SQLEXPRESS;Initial Catalog=FunRunDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
