using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project19.dao
{
    internal class ChangeRequestStatusDBAccess : SQLServerConnection
    {
        public void ChangeRequestStatus(int requestId, int statusType)
        {
            string status = "";
            switch (statusType)
            {
                case 0:
                    status = "承認済み";
                    break;
                case 1:
                    status = "申請中";
                    break;
                case 2:
                    status = "変更中";
                    break;
                default:
                    status = "申請中";
                    break;
            }
            SqlConnection con = CreateConnection();
            string sql = "UPDATE Requests SET Status = @status";

            Debug.WriteLine("接続成功");
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@status", status);
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        Debug.WriteLine($"rowsAffected: {rowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("更新に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                    return;
                }
                Debug.WriteLine("更新に成功しました");

            }
            con.Close();
        }
    }
}
