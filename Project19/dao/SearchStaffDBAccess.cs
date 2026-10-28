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
    internal class SearchStaffDBAccess : SQLServerConnection
    {
        public List<SearchStaff> GetSearchStaffList(string userName, string fullName, string email, int phoneNumber)
        {
            List<SearchStaff> SearchStaffList = new List<SearchStaff>();

            SqlConnection con = CreateConnection();
            string sql = "SELECT * FROM Staff WHERE ";

            {
                try
                {
                    Debug.WriteLine("接続成功");
                    if (userName == null && fullName == null && eMail == null && phoneNumber == null)
                    {
                        sql += "1 = 1";
                        using (SqlCommand command = new SqlCommand(sql, con));

                        using (SqlDataReader reader = command.ExecuteReader()) ;
                        while (reader.Read())
                        {
                            int staffId = (int)reader["StaffID"];
                            string username = (string)reader["Username"];
                            string fullname = (string)reader["FullName"];
                            string email = (string)reader["Email"];
                            int phonenumber = (int)reader["PhoneNumber"];
                            SearchStaff serchStaff = new SearchStaff(staffId, username, fullname, email, phonenumber);
                            SearchStaffList.Add(serchStaff);
                        }
                    } else
                    {

                        if (userName != null)
                        {
                            sql = "useName = Username "
                        }
                        if (fullName != null)
                        {
                            sql = "fullName = FullName "
                        }
                        if (eMail != null)
                        {
                            sql = "email = Email "
                        }
                        if (phoneNumber != null)
                        {
                            sql = "phoneNumber = PhoneNumber "
                        }
                        using (SqlCommand command = new SqlCommand(sql, con));
                        using (SqlDataReader reader = command.ExecuteReader()) ;
                        while (reader.Read())
                        {
                            int staffId = (int)reader["StaffID"];
                            string userName = (string)reader["Username"];
                            string fullName = (string)reader["FullName"];
                            string email = (string)reader["Email"];
                            int phoneNumber = (int)reader["PhoneNumber"];
                            SearchStaff serchStaff = new SearchStaff(staffId, userName, fullName, email, phoneNumber);
                            SearchStaffList.Add(serchStaff);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("取得に失敗しました");
                    Debug.WriteLine(ex.Message.ToString());
                    return attendanceList;
                }
                Debug.WriteLine("取得に成功しました");

            }
            con.Close();
            return SearchStaffList;
        }
    }
}