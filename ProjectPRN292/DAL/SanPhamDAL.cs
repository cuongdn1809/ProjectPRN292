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
        public List<Sanpham> GetSanPham()
        {
            List<Sanpham> sp = new List<Sanpham>();
            command = new SqlCommand("select * from SanPham", GetConnection());
            // Sur dung Mo hinh Connected
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        sp.Add(new Sanpham
                        {
                            SanPhamID = reader.GetInt32(0),
                            TenSanPham = reader.GetString(1),
                            ThuongHieu = reader.GetString(2),
                            Gia = reader.GetInt32(3),
                            Note = reader.GetString(4)
                        });
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
            return sp;
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
