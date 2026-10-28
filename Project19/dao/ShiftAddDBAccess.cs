using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project19.dao
{
    internal class ShiftAddDBAccess : SQLServerConnection
    {
        public void ShiftAdd(string staffId, string date, string startTime, string endTime)
        {
            SqlConnection con = CreateConnection();
            string sql = "INSERT INTO Shifts (StaffId, ShiftDate, StartTime, EndDate, Status) VALUES (@staffId, @shiftDate, @startTime, @endTime, '申請中')";

            Debug.WriteLine("接続成功");
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@staffId", staffId);
                command.Parameters.AddWithValue("@shiftId", date);
                command.Parameters.AddWithValue("@startTime", startTime);
                command.Parameters.AddWithValue("@endTime", endTime);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    Debug.WriteLine($"rowsAffected: {rowsAffected}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("取得に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                    con.Close();
                    return;
                }
                Debug.WriteLine("追加に成功しました");

            }
            con.Close();
        }
    }
}
