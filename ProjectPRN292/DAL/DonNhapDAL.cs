using ProjectPRN292.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectPRN292.DAL
{
    class DonNhapDAL
    {
        /*SqlConnection connection;
        SqlCommand command;
        public SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["PRN292"].ToString();
            connection = new SqlConnection(strCon);
            return connection;
        }

        public int getIDKhachHang(string tenKhachHang)
        {
            int KhachHangID = 0;
            string sql = "select KhachHangID from KhachHang where TenKhachHang = @tenKhachHang";
            command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddWithValue("@tenKhachHang", tenKhachHang);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        KhachHangID = reader.GetInt32(0);
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
            return KhachHangID;
        }
        public int InsertDonNhap(DonNhap donNhap)
        {
            int n = 0;
            string sql = "INSERT INTO [dbo].[NhapHang]([NgayNhapHang],[KhachHangID],[SoLuong],[Note],[SanPhamID],[QuanLyID]) "+
                                            "VALUES(@ngayNhapHang, @KhachHangID, @soLuong, @note, @SanPhamID, @QuanLyID)";
            command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddWithValue("@ngayNhapHang", donNhap.ngayNhapHang);
            command.Parameters.AddWithValue("@KhachHangID", );
            command.Parameters.AddWithValue("@soLuong", donNhap.soLuong);
            command.Parameters.AddWithValue("@note", donNhap.note);
            command.Parameters.AddWithValue("@SanPhamID", donNhap.SanPhamID);
            command.Parameters.AddWithValue("@QuanLyID", donNhap.QuanLyID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return n;
        }*/
    }
}
