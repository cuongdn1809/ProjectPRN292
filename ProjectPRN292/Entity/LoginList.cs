using ProjectPRN292.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectPRN292.Entity
{
    class LoginList
    {
        private string tenquanly;
        private string matkhau;

        public LoginList()
        {
        }

        public LoginList(string tenquanly, string matkhau)
        {
            Tenquanly = tenquanly;
            Matkhau = matkhau;
        }

        public string Tenquanly { get => tenquanly; set => tenquanly = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }

        internal static List<LoginList> checkAccount(string username, string password)
        {
            List<LoginList> logins = new List<LoginList>();
            DataTable dataTable = LoginDAL.checkAccount(username, password);
            foreach (DataRow dr in dataTable.Rows)
            {
                string user = dr["TenQuanLy"].ToString();
                string pass = dr["MatKhau"].ToString();
                LoginList  login = new LoginList(user, pass);
                logins.Add(login);
            }
            return logins;
        }
    }
}
