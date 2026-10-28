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
        public List<Staff> GetSearchStaffList(string userName, string fullName, string email, string phoneNumber)
        {
            List<Staff> SearchStaffList = new List<Staff>();

            SqlConnection con = CreateConnection();
            string sql = "SELECT DISTINCT * FROM Staff WHERE 0 = 0";

            {
                Debug.WriteLine("接続成功");
                if (userName == null && fullName == null && email == null && phoneNumber == null)
                {
                }
                else
                {

                    if (userName != null)
                    {
                        sql += "AND useName = Username ";
                    }
                    if (fullName != null)
                    {
                        sql += "AND fullName = FullName ";
                    }
                    if (email != null)
                    {
                        sql += "AND email = Email ";
                    }
                    if (phoneNumber != null)
                    {
                        sql += "AND phoneNumber = PhoneNumber ";
                    }
                }
            }
            try
            {

                using (SqlCommand command = new SqlCommand(sql, con))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int staffId = (int)reader["StaffID"];
                            string username = (string)reader["Username"];
                            string passwordHash = (string)reader["passwordHash"];
                            string fullname = (string)reader["FullName"];
                            string staffEmail = (string)reader["Email"];
                            string phonenumber = (string)reader["PhoneNumber"];
                            string emproymentDate = (string)reader["EmproymentDate"];
                            Staff serchStaff = new Staff(staffId, username, passwordHash, fullname, staffEmail, phonenumber, emproymentDate);
                            SearchStaffList.Add(serchStaff);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("取得に失敗しました");
                Debug.WriteLine(ex.Message.ToString());
                return SearchStaffList;
            }
            Debug.WriteLine("取得に成功しました");
            con.Close();
            return SearchStaffList;

        }
    }
}