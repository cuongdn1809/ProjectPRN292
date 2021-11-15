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
        SqlCommand command;
        SqlConnection connection;
        public SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["PRN292"].ToString();
            connection = new SqlConnection(strCon);
            return connection;
        }

        public int InsertDonNhap(DonNhap donNhap)
        {
            int result = 0;

            string sql = "INSERT INTO [dbo].[NhapHang]([NgayNhapHang],[KhachHangID],[SoLuong],[GiaThue],[Note],[SanPhamID],[QuanLyID]) " +
                         "VALUES(@NgayNhapHang, @KhachHangID, @SoLuong, @GiaThue, @Note, @SanPhamID, @QuanLyID)";
            command = new SqlCommand(sql, GetConnection());

            command.Parameters.AddWithValue("@NgayNhapHang", donNhap.NgayNhapHang);
            command.Parameters.AddWithValue("@KhachHangID", donNhap.KhachHangID);
            command.Parameters.AddWithValue("@SoLuong", donNhap.SoLuong);
            command.Parameters.AddWithValue("@GiaThue", donNhap.GiaThue);
            command.Parameters.AddWithValue("@Note", donNhap.Note);
            command.Parameters.AddWithValue("@SanPhamID", donNhap.SanPhamID);
            command.Parameters.AddWithValue("@QuanLyID", donNhap.QuanLyID);
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

        public int getIDSanPham(string tenSanPham)
        {
            int SanPhamID = 0;
            string sql = "select SanPhamID from SanPham where TenSanPham = @tenSanPham";
            command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddWithValue("@tenSanPham", tenSanPham);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        SanPhamID = reader.GetInt32(0);
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
            return SanPhamID;
        }
    }
}
