<<<<<<< HEAD
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
    internal class ShiftRequestsDBAccess : SQLServerConeection
    {
        public List<ShiftRequests> GetShiftRequestList()
        {
            List<ShiftRequests> shiftRequestList = new List<ShiftRequests>();

            SqlConnection con = CreateConnection();
            string sql = "SELECT * FROM ShiftRequests";

            Debug.WriteLine("接続成功");
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int requestId = (int)reader["RequestID"];
                            int staffId = (int)reader["StaffID"];
                            int originalShiftId = (int)reader["OriginalShiftID"];
                            int requestedShiftId = (int)reader["RequestShiftID"];
                            string requestDate = (string)reader["RequestDate"];
                            string status = (string)reader["Status"];
                            ShiftRequest shiftrequest = new ShiftRequest(requestId, staffId, originalShiftId, requestedShiftId, requestDate, status);
                            shiftRequesList.Add(shiftrequest);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("取得に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                    return shiftRequestList;
                }
                Debug.WriteLine("取得に成功しました");

            }
            con.Close();
            return shiftRequestList;
        }
    }
=======
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
    internal class ShiftRequestsDBAccess : SQLServerConnection
    {
        public List<ShiftRequests> GetShiftRequestList()
        {
            List<ShiftRequests> shiftRequestList = new List<ShiftRequests>();

            SqlConnection con = CreateConnection();
            string sql = "SELECT * FROM ShiftRequests";

            Debug.WriteLine("接続成功");
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int requestId = (int)reader["RequestID"];
                            int staffId = (int)reader["StaffID"];
                            int originalShiftId = (int)reader["OriginalShiftID"];
                            int requestedShiftId = (int)reader["RequestShiftID"];
                            string requestDate = (string)reader["RequestDate"];
                            string status = (string)reader["Status"];
                            ShiftRequests shiftrequest = new ShiftRequests(requestId, staffId, originalShiftId, requestedShiftId, requestDate, status);
                            shiftRequestList.Add(shiftrequest);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("取得に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                    return shiftRequestList;
                }
                Debug.WriteLine("取得に成功しました");

            }
            con.Close();
            return shiftRequestList;
        }
    }
>>>>>>> 5715087d84f15c6637f96314c056c624b15859bb
}