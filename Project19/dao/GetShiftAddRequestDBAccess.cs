using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Resources.ResXFileRef;

namespace Project19.dao
{
    internal class GetShiftAddRequestDBAccess : SQLServerConnection
    {
        UtilityArrayConverter converter = new UtilityArrayConverter();
        public string[,] GetShiftAddRequest(string staffId, string staffName, string date)
        {
            List<List<string>> list = new List<List<string>>();
            SqlConnection con = CreateConnection();
            string sql = "SELECT R.RequestShiftID R.ShiftDate, R.StartTime, R.EndTime, S.StaffID, S.FullName, S.EmpoymentDate" +
                "From Request AS R JOIN Staff AS S ON R.StaffID = S.StaffID WHERE Status = N'シフト追加'";
            if (staffId != null)
            {
                sql += " AND S.StaffId = @staffId";
            }
            if (staffName != null)
            {
                sql += " AND S.FullName = @staffName";
            }
            if (date != null)
            {
                sql += " AND R.ShiftDate = @date";
            }

            Debug.WriteLine("接続成功");
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<string> row = new List<string>();
                            for (int i = 0; i < 7; i++)
                            {
                                row.Add(reader.GetString(i));
                            }

                            list.Add(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("取得に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                    return null;
                }
                Debug.WriteLine("取得に成功しました");
            }
            con.Close();

            string[,] array = converter.ArrayConvert(list);
            return array;

        }
    }
}
