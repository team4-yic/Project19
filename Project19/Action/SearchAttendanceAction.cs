using Project19.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19.Action
{
    internal class SearchAttendanceAction
    {
        SearchAttendanceDBAccess sadba = new SearchAttendanceDBAccess();

        public List<List<string>> execute(string id, string date)
        {
            List<List<string>> list = sadba.SearchAttendance(id, date);
            return list;
        }
    }
}
