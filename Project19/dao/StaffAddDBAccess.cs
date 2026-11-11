using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19.dao
{
    internal class StaffAddDBAccess : SQLServerConnection
    {
        public void StaffAdd(string hashPass, string userName, string fullName, string email, string phone, string employmentDate)
        {
            SqlConnection con = CreateConnection();
            string sql = "INSERT INTO Shifts (Username PasswordHash FullName Email PhoneNumber EmploymentDate) VALUES (@userName, @hashPass, @fullName, @email, @phone, @employmentDate);";

            Debug.WriteLine("接続成功");
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@hashPass", hashPass);
                command.Parameters.AddWithValue("@fullName", fullName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@employmentDate", employmentDate);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    Debug.WriteLine($"rowsAffected: {rowsAffected}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("追加に失敗しました");
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
