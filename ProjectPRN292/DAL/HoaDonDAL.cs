using ProjectPRN292.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            string sql = @"INSERT INTO[dbo].[HoaDon]([NgayNhapHang],[NgayXuatHang],[TongTien],[KhachHangID],[SanPhamID])VALUES(@ngayNH,@ngayXH,@tongTien,@khID,@spID)";
            command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddWithValue("@ngayNH", bill.NgayNhapHang);
            command.Parameters.AddWithValue("@ngayXH", bill.NgayXuatHang);
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
    }
}


