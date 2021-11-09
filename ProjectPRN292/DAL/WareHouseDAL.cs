using ProjectPRN292.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectPRN292.DAL
{
    class WareHouseDAL
    {
        SqlCommand command;
        SqlConnection connection;
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
        public List<WareHouse> GetWareHouse()
        {
            List<WareHouse> wareHouses = new List<WareHouse>();
            command = new SqlCommand("select n.NhapHangID, k.TenKhachHang,s.TenSanPham,n.NgayNhapHang, n.SoLuong,n.GiaThue,n.Note from KhachHang k, NhapHang n, SanPham s where k.KhachHangID = n.KhachHangID and n.SanPhamID = s.SanPhamID", GetConnection());
            // Sử dụng mô hình: Connected
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        wareHouses.Add(new WareHouse
                        {
                            NhapHangID = reader.GetInt32(0),
                            TenKhachHang = reader.GetString(1),
                            TenSanPham = reader.GetString(2),
                            NgayNhapKho = reader.GetDateTime(3),
                            Soluong = reader.GetInt32(4),                          
                            Giathue = reader.GetInt32(5),
                            Note = reader.GetString(6),

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
            return wareHouses;
        }
        public List<WareHouse> GetWareHousebyTenKhachHang(string tenKhachHang)
        {
            List<WareHouse> wareHouses = new List<WareHouse>();
            command = new SqlCommand("select n.NhapHangID, k.TenKhachHang,s.TenSanPham, n.SoLuong,n.NgayNhapHang,n.GiaThue,n.Note from KhachHang k, NhapHang n, SanPham s where k.KhachHangID = n.KhachHangID and n.SanPhamID = s.SanPhamID and k.TenKhachHang like '%" + tenKhachHang + "%'", GetConnection());
            // Sử dụng mô hình: Connected
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
              
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        wareHouses.Add(new WareHouse
                        {
                            NhapHangID = reader.GetInt32(0),
                            TenKhachHang = reader.GetString(1),
                            TenSanPham = reader.GetString(2),
                            Soluong = reader.GetInt32(3),
                            NgayNhapKho = reader.GetDateTime(4),
                            Giathue = reader.GetInt32(5),
                            Note = reader.GetString(6),

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
            return wareHouses;
        }
        public List<WareHouse> GetWareHousebyTenSanPham(string tenSP)
        {
            List<WareHouse> wareHouses = new List<WareHouse>();
            command = new SqlCommand("select n.NhapHangID, k.TenKhachHang,s.TenSanPham, n.SoLuong,n.NgayNhapHang,n.GiaThue,n.Note from KhachHang k, NhapHang n, SanPham s where k.KhachHangID = n.KhachHangID and n.SanPhamID = s.SanPhamID and s.TenSanPham like '%"+tenSP+"%'", GetConnection());
            // Sử dụng mô hình: Connected
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
               
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        wareHouses.Add(new WareHouse
                        {
                            NhapHangID = reader.GetInt32(0),
                            TenKhachHang = reader.GetString(1),
                            TenSanPham = reader.GetString(2),
                            Soluong = reader.GetInt32(3),
                            NgayNhapKho = reader.GetDateTime(4),
                            Giathue = reader.GetInt32(5),
                            Note = reader.GetString(6),

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
            return wareHouses;
        }
       
        //public int DeleteWareHouse(KhachHang khachhang)
        //{
        //    int result = 0;

        //    string sql = "delete KhachHang where KhachHangID=@khID";
        //    command = new SqlCommand(sql, GetConnection());
        //    command.Parameters.AddWithValue("@khID", khachhang.Khachhangid);
        //    try
        //    {
        //        connection.Open();
        //        result = command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return result;
        //}

    }
}

