using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19.dao
{
    internal class StaffDeleteDBAccess : SQLServerConnection
    {
        public void StaffDelete(int id) 
        {
            SqlConnection con = CreateConnection();
            string sql = "DELETE FROM Staff WHERE @staffId;";

            Debug.WriteLine("接続成功");
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@staffId", id);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    Debug.WriteLine($"rowsAffected: {rowsAffected}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("削除に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                    con.Close();
                }
                Debug.WriteLine("削除に成功しました");

            }
            con.Close();
        }
    }
}
