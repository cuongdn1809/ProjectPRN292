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
    class KhachHangDAL
    {
        SqlConnection connection;
        SqlCommand command;
        public SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["PRN292"].ToString();
            connection = new SqlConnection(strCon);
            return connection;
        }
        public List<KhachHang> GetKhachHang()
        {
            List<KhachHang> categories = new List<KhachHang>();
            command = new SqlCommand("select * from KhachHang", GetConnection());
            // Sur dung Mo hinh Connected
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        categories.Add(new KhachHang
                        {
                            Khachhangid = reader.GetInt32(0),
                            Tenkhachhang = reader.GetString(1),
                            Diachi = reader.GetString(2),
                            Sdt = reader.GetString(3)
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
            return categories;
        }
        /*        public List<KhachHang> GetKhachHang()
                {
                    List<KhachHang> c = new List<KhachHang>();
                    DataTable dataTable = GetAllKhachHang();
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        int id = Convert.ToInt32(dr["KhachHangID"].ToString());
                        string firstName = dr["TenKhachHang"].ToString();
                        string lastName = dr["DiaChi"].ToString();
                        string phone = dr["Sdt"].ToString();

                        KhachHang khachhang = new KhachHang(id, firstName, lastName, phone);
                        c.Add(khachhang);
                    }
                    return c;
                }

                public static DataTable GetAllKhachHang()
                {
                    string sql = "select * from KhachHang";
                    return Database.GetDataBySQL(sql);
                }*/
        public int InsertKhachHang(KhachHang khachhang)
        {
            int result = 0;

            string sql = "insert into KhachHang(TenKhachHang, DiaChi, Sdt) values(@khName,@khdiachi,@khsdt)";
            command = new SqlCommand(sql, GetConnection());
            
            command.Parameters.AddWithValue("@khName", khachhang.Tenkhachhang);
            command.Parameters.AddWithValue("@khdiachi", khachhang.Diachi);
            command.Parameters.AddWithValue("@khsdt", khachhang.Sdt);
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

        public int UpdateKhachHang(KhachHang khachhang)
        {
            int result = 0;

            string sql = "update KhachHang set TenKhachHang=@khName, DiaChi= @khdiachi,Sdt= @khsdt where KhachHangID=@khID";
            command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddWithValue("@khID", khachhang.Khachhangid);
            command.Parameters.AddWithValue("@khName", khachhang.Tenkhachhang);
            command.Parameters.AddWithValue("@khdiachi", khachhang.Diachi);
            command.Parameters.AddWithValue("@khsdt", khachhang.Sdt);
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

        public int DeleteKhachHang(KhachHang khachhang)
        {
            int result = 0;

            string sql = "delete KhachHang where KhachHangID=@khID";
            command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddWithValue("@khID", khachhang.Khachhangid);
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
        public DataTable GetKhachHangByName(string name)
        {
            return Database.GetDataBySQL("SELECT * FROM KhachHang WHERE TenKhachHang like '%" + name + "%'");
        }
        public  List<KhachHang> SearchKhachHangByName(string name)
        {
            List<KhachHang> khachhang = new List<KhachHang>();
            DataTable dataTable = GetKhachHangByName(name);
            foreach (DataRow dr in dataTable.Rows)
            {
                int khachhangid = Convert.ToInt32(dr["KhachHangID"]);
                string Name = dr["TenKhachHang"].ToString();
                string diachi = dr["DiaChi"].ToString();
                string sdt = dr["Sdt"].ToString();
                KhachHang kh = new KhachHang(khachhangid, Name, diachi, sdt);
                khachhang.Add(kh);
            }
            return khachhang;
        }


    }
}
