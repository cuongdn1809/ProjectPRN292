using ProjectPRN292.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectPRN292
{
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        SqlConnection connection;
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


        private void WareHouseDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you really want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                frmTrangChu h = new frmTrangChu();
                Visible = false;
                h.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (InsertDonNhap())
            //    {
            //        MessageBox.Show("Add successful!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Add fail!");
            //    }
            //    /*MessageBox.Show(donNhap.NgayNhapHang);*/
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddSanPham sp = new frmAddSanPham();
            Visible = false;
            sp.ShowDialog();
        }

        //    public Boolean InsertDonNhap()
        //    {
        //        //bac edit
        //        LoginDAL login = new LoginDAL();
        //        string format = "dd/MM/yyyy";
        //        string NgayNhapHang = dtpNgayNhap.Value.ToString(format);
        //        int KhachHangID = getIDKhachHang(txtTenKhachHang.Text);
        //        int SoLuong = Int32.Parse(nSoLuong.Value.ToString());
        //        string Note = txtNote.Text;
        //        int SanPhamID = getIDSanPham(txtTenSanPham.Text);
        //        int QuanLyID = login.getIDQuanLy();

        //        string sql = "INSERT INTO [dbo].[NhapHang]([NgayNhapHang],[KhachHangID],[SoLuong],[Note],[SanPhamID],[QuanLyID]) " +
        //                                        "VALUES(@ngayNhapHang, @KhachHangID, @soLuong, @note, @SanPhamID, @QuanLyID)";
        //        command = new SqlCommand(sql, GetConnection());
        //        SqlParameter param1 = new SqlParameter("@ngayNhapHang", SqlDbType.VarChar);
        //        param1.Value = NgayNhapHang;
        //        SqlParameter param2 = new SqlParameter("@KhachHangID", SqlDbType.Int);
        //        param2.Value = KhachHangID;
        //        SqlParameter param3 = new SqlParameter("@soLuong", SqlDbType.Int);
        //        param3.Value = SoLuong;
        //        SqlParameter param4 = new SqlParameter("@note", SqlDbType.VarChar);
        //        param4.Value = Note;
        //        SqlParameter param5 = new SqlParameter("@SanPhamID", SqlDbType.Int);
        //        param5.Value = SanPhamID;
        //        SqlParameter param6 = new SqlParameter("@QuanLyID", SqlDbType.Int);
        //        param6.Value = QuanLyID;
        //        try
        //        {
        //            connection.Open();
        //            return Database.ExecuteNonQuery(sql, param1, param2, param3, param4, param5, param6) > 0;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //        return false;
        //    }

    }
}
