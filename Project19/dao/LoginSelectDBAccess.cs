using Azure.Identity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19.dao
{
    public class LoginSelectDBAccess : SQLServerConnection
    {
        public string PasswordSelect(string userName) {
            string passHash = "";
            SqlConnection con = CreateConnection();
            string sql = "SELECT PasswordHash From Admins Where UserName = @userName";
            
            Debug.WriteLine("接続成功");
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@userName", userName);
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            passHash = (string)reader["PasswordHash"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("取得に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                    return passHash;
                }
                Debug.WriteLine("取得に成功しました");

            }
            con.Close();
            return passHash;
        }
    }
}
