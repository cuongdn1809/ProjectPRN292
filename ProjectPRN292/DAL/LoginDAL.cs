using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectPRN292.DAL
{
    class LoginDAL
    {

        public static DataTable checkAccount(string tenquanly, string matkhau)
        {
            string sql = "select * from QuanLy where TenQuanLy = '"+tenquanly+"' and MatKhau = '"+matkhau+"'";
            return Database.GetDataBySQL(sql);
        }

    }
}
