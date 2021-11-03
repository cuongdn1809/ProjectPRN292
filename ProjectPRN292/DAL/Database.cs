using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectPRN292.DAL
{
    class Database
    {
        public static SqlConnection getConnection()
        {
            string conStr = ConfigurationManager.ConnectionStrings["PRN292"].ConnectionString;
            return new SqlConnection(conStr);
        }

        /// <summary>
        /// Phuong thuc lay du lieu tu CSDL
        /// </summary>
        /// <param name="sql">Truy van can lay du lieu</param>
        /// <returns>DataTable</returns>
        public static DataTable GetDataBySQL(string sql)
        {
            // Tao doi tuong SqlCommand de thuc thi truy van
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            // Tao doi tuong cau noi voi CSDL
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            // Tao doi tuong DataSet de chua du lieu duoc tra ve
            DataSet ds = new DataSet(); // Data cache
            da.Fill(ds);
            return ds.Tables[0];
        }

        /// <summary>
        /// Phuong thuc cho thuc thi: Insert, update, delete
        /// </summary>
        /// <param name="sql">Truy van can thuc hien</param>
        /// <param name="para">Danh sach tham so truyen cho truy van</param>
        /// <returns>int</returns>
        public static int ExecuteSQL(string sql, params SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            cmd.Parameters.AddRange(para);
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        public static DataTable ExecuteQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            //SqlDataReader reader = command.ExecuteReader();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, getConnection());
            command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int count = command.ExecuteNonQuery();
            command.Connection.Close();
            return count;
        }
    }
}
