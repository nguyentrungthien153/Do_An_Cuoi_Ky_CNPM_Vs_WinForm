using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DXApplication1;


namespace DXApplication1
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;
        SqlDataReader reader;
        public List<TaiKhoan> TaiKhoans ( string query )
        {
            List<TaiKhoan> taiKhoans  = new List<TaiKhoan>();
            using (SqlConnection conn = Connection.GetSqlConnection() )
            {
                conn.Open();
                sqlCommand = new SqlCommand(query, conn);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                }    

                conn.Close();
            }    
            return taiKhoans;
        }

        public List<TaiKhoan> TaiKhoanss(string query1)
        {
            List<TaiKhoan> taiKhoanss = new List<TaiKhoan>();
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                sqlCommand = new SqlCommand(query1, conn);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    taiKhoanss.Add(new TaiKhoan(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                }

                conn.Close();
            }
            return taiKhoanss;
        }

    }
}
