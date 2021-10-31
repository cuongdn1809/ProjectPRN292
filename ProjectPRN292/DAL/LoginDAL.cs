using ProjectPRN292.Entity;
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
        public static List<QuanLy> IsAccountValid(string username, string password)
        {
            List<QuanLy> logins = new List<QuanLy>();
            DataTable dataTable = checkAccount(username, password);
            foreach (DataRow dr in dataTable.Rows)
            {
                string user = dr["TenQuanLy"].ToString();
                string pass = dr["MatKhau"].ToString();
                QuanLy login = new QuanLy(user, pass);
                logins.Add(login);
            }
            return logins;
        }
        public static DataTable checkAccount(string tenquanly, string matkhau)
        {
            string sql = "select * from QuanLy where TenQuanLy = '"+tenquanly+"' and MatKhau = '"+matkhau+"'";
            return Database.GetDataBySQL(sql);
        }

    }
}
