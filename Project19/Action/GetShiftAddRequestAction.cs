using Project19.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19.Action
{
    internal class GetShiftAddRequestAction
    {
        GetShiftAddRequestDBAccess gsardba = new GetShiftAddRequestDBAccess();
        public List<List<string>> excute(string staffId, string staffName, string date)
        {
            List<List<string>> list = gsardba.GetShiftAddRequest(staffId, staffName, date);
            return list;
        }
    }
}
