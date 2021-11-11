using ProjectPRN292.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectPRN292.DAL
{
    class SanPhamDAL
    {
        SqlConnection connection;
        SqlCommand command;
        public SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["PRN292"].ToString();
            connection = new SqlConnection(strCon);
            return connection;
        }

        public int InsertSanPam(Sanpham sanpham)
        {
            int result = 0;

            string sql = "insert into SanPham(TenSanPham,ThuongHieu,Gia,Note) values(@tensp,@thuonghieu,@gia,@note)";
            command = new SqlCommand(sql, GetConnection());

            command.Parameters.AddWithValue("@tensp", sanpham.TenSanPham);
            command.Parameters.AddWithValue("@thuonghieu", sanpham.ThuongHieu);
            command.Parameters.AddWithValue("@gia", sanpham.Gia);
            command.Parameters.AddWithValue("@note", sanpham.Note);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }
    }
}
