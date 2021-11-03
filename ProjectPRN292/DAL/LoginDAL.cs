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
        SqlConnection connection;
        SqlCommand command;
        public static string quanLyTen;
        public SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["PRN292"].ToString();
            connection = new SqlConnection(strCon);
            return connection;
        }
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
                quanLyTen = dr["TenQuanLy"].ToString();
            }
            return logins;
        }
        public static DataTable checkAccount(string tenquanly, string matkhau)
        {
            string sql = "select * from QuanLy where TenQuanLy = '"+tenquanly+"' and MatKhau = '"+matkhau+"'";
            return Database.GetDataBySQL(sql);
        }

        public int getIDQuanLy()
        {
            int QuanLyID = 0;
            string sql = "select QuanLyID from QuanLy where TenQuanLy = @tenQuanLy";
            command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddWithValue("@tenQuanLy", quanLyTen);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        QuanLyID = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return QuanLyID;
        }

    }
}
