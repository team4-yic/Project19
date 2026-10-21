using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19.dao
{
    public class SQLServerConnection
    {
        public static SqlConnection CreateConnection()
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Project19DB;User Id=login;Password=pass;";
            SqlConnection con = new SqlConnection(connectionString); string sql = "SELECT PasswordHash From Admins Where UserName = @userName";
            try
            {
                con.Open();
            }
            catch
            {
                Debug.WriteLine("接続失敗");
            }
            return con;
        }
    }
}
