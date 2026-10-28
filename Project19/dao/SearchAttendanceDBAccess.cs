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
    internal class SearchAttendanceDBAccess : SQLServerConnection
    {
        public string[,] SearchAttendance(string id, string date)
        {
            UtilityArrayConverter converter = new UtilityArrayConverter();

            List<List<string>> list = new List<List<string>>();
            SqlConnection con = CreateConnection();
            string sql = "SELECT Staff.StaffID , Staff.FullName , Shifts.ShiftDate , Attendance.CheckInTime , Attendance.CheckOutTime FROM Attendance JOIN Staff ON Attendance.StaffID = Staff.StaffID JOIN Shifts ON Attendance.ShiftID = Shifts.ShiftID";

            if (id != null || date != null)
            {
                sql += " WHERE";
            }
            if (id != null)
            {
                sql += " Attendance.StaffID = @staffId";
            }
            if (date != null)
            {
                sql += " Shifts.ShiftDate = @shiftDate";
            }
            Debug.WriteLine("接続成功");

            using (SqlCommand command = new SqlCommand(sql, con))
            {
                if (id != null)
                {
                    command.Parameters.AddWithValue("@staffId", id);
                }
                if (date != null)
                {
                    command.Parameters.AddWithValue("@shiftDate", date);
                }

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<string> row = new List<string>();
                            row.Add((string)reader["StaffID"]);
                            row.Add((string)reader["FullName"]);
                            row.Add((string)reader["ShiftDate"]);
                            row.Add((string)reader["CheckInTime"]);
                            row.Add((string)reader["CheckOutTime"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("取得に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                }
                Debug.WriteLine("取得に成功しました");
            }
            con.Close();

            string[,] array = converter.ArrayConvert(list);

            return array;
        }
    }
}
