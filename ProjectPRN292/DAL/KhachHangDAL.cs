using ProjectPRN292.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectPRN292.DAL
{
    class KhachHangDAL
    {
        SqlConnection connection;
        SqlCommand command;

        public List<KhachHang> GetKhachHang()
        {
            List<KhachHang> categories = new List<KhachHang>();
            command = new SqlCommand("select CategotyID, CategoryName from Category", Database.getConnection());
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

    
    }
}
