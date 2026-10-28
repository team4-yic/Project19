using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19.dao
{
    internal class SearchAttendanceDBAccess : SQLServerConnection
    {
        public string[][] SearchAttendance()
        {
            SqlConnection con = CreateConnection();
            return null;
        }
    }
}
