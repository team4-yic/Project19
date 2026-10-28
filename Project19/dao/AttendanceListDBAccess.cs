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
    internal class AttendanceListDBAccess : SQLServerConnection
    {
        public List<Attendance> GetAttendancesList()
        {
            List<Attendance> attendanceList = new List<Attendance>();

            SqlConnection con = CreateConnection();
            string sql = "SELECT * FROM Attendance";

            Debug.WriteLine("接続成功");
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int attendaceId = (int)reader["AttecdanceID"];
                            int staffId = (int)reader["StaffID"];
                            int shiftId = (int)reader["ShiftId"];
                            string checkInTime = (string)reader["CheckInTime"];
                            string checkOutTime = (string)reader["CheckOutTime"];
                            Attendance attendance = new Attendance(attendaceId, staffId, shiftId, checkInTime, checkOutTime);
                            attendanceList.Add(attendance);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("取得に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                    con.Close();
                    return attendanceList;
                }
                Debug.WriteLine("取得に成功しました");

            }
            con.Close();
            return attendanceList;
        }
    }
}