using ProjectPRN292.Entity;
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
    public partial class frmWareHouseDetail : Form
    {
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
        public int InsertDonNhap()
        {
            DonNhap donNhap = new DonNhap();
            int n = 0;
            string sql = "INSERT INTO [dbo].[NhapHang]([NgayNhapHang],[KhachHangID],[SoLuong],[Note],[SanPhamID],[QuanLyID]) " +
                                            "VALUES(@ngayNhapHang, @KhachHangID, @soLuong, @note, @SanPhamID, @QuanLyID)";
            command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddWithValue("@ngayNhapHang", donNhap.ngayNhapHang);
            command.Parameters.AddWithValue("@KhachHangID", donNhap.KhachHangID);
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
        }
        public frmWareHouseDetail()
        {
            InitializeComponent();
        }

        private void WareHouseDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you really want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                frmHome h = new frmHome();
                Visible = false;
                h.ShowDialog();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var donNhap = new DonNhap()
                {
                    ngayNhapHang = dtpNgayNhap.Value,
                    KhachHangID = getIDKhachHang(txtTenKhachHang.Text),
                    soLuong = Int32.Parse(nSoLuong.Value.ToString()),
                    note = txtNote.Text,
                    SanPhamID = getIDSanPham(txtTenSanPham.Text),
                    QuanLyID = 1
                };
                if (InsertDonNhap() != 0)
                {
                    MessageBox.Show("Add successful!");
                }
                else
                {
                    MessageBox.Show("Add fail!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
