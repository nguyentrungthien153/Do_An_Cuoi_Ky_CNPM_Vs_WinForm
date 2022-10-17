using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DXApplication1
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=LAPTOP-CLBQB420\SQLEXPRESS;Initial Catalog=QuanLyPhongNet;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
