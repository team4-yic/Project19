using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19.dao
{
    internal class ShiftListDBAccess : SQLServerConeection
    {
        public List<Shift> GetShiftList()
        {
            List<Shift> shiftList = new List<Shift>();

            SqlConnection con = CreateConnection();
            string sql = "SELECT * FROM Shifts";

            Debug.WriteLine("接続成功");
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int shiftId = (int)reader["ShiftID"];
                            int staffId = (int)reader["StaffID"];
                            string shiftDate = (string)reader["ShiftID"];
                            string startTime = (string)reader["StartTime"];
                            string endTime = (string)reader["EndTime"];
                            string status = (string)reader["Status"];
                            Shift shift = new Shift(shiftId, staffId, shiftDate, startTime, endTime, status);

                            shiftList.Add(shift);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("取得に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                    return shiftList;
                }
                Debug.WriteLine("取得に成功しました");
            }
            con.Close();
            return shiftList;
        }
    }
}
