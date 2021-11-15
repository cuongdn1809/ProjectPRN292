
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
    class HoaDonDAL
    {
        SqlCommand command;
        SqlConnection connection;
        public SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["PRN292"].ToString();
            connection = new SqlConnection(strCon);
            return connection;
        }

        public int InsertBill(HoaDon bill)
        {
            int result = 0;
            string sql = @"INSERT INTO[dbo].[HoaDon]([NgayNhapHang],[NgayXuatHang],[GiaThue],[TongTien],[KhachHangID],[SanPhamID])VALUES(@ngayNH,@ngayXH,@giaThue,@tongTien,@khID,@spID)";
            command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddWithValue("@ngayNH", bill.NgayNhapHang);           
            command.Parameters.AddWithValue("@ngayXH", bill.NgayXuatHang);
            command.Parameters.AddWithValue("@giaThue", bill.GiaThue);
            command.Parameters.AddWithValue("@tongTien", bill.TongTien);
            command.Parameters.AddWithValue("@khID", bill.KhachHangId);
            command.Parameters.AddWithValue("@spID", bill.SanPhamId);
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

        public DataTable GetData()
        {
            string sql = "select h.NgayNhapHang, h.NgayXuatHang, h.TongTien, h.HoaDonID, k.TenKhachHang, s.TenSanPham, s.ThuongHieu " +
                        "from HoaDon h, KhachHang k, SanPham s " +
                        "where h.KhachHangID = k.KhachHangID and s.SanPhamID = h.SanPhamID";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable GetDataByTenKH(string name)
        {
            string sql = "select h.NgayNhapHang, h.NgayXuatHang, h.TongTien, h.HoaDonID, k.TenKhachHang, s.TenSanPham, s.ThuongHieu " +
                        "from HoaDon h, KhachHang k, SanPham s " +
                        "where h.KhachHangID = k.KhachHangID and s.SanPhamID = h.SanPhamID and k.TenKhachHang = '" + name+"'";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}


