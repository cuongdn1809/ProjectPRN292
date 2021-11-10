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
    public partial class frmBillDetail : Form
    {
        DataRowView currentData;
        public frmBillDetail()
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
        public frmBillDetail(DataRowView data)
        {
            InitializeComponent();
            currentData = data;
            LoadData();
        }

        private void LoadData()
        {
            txtMaHoaDon.Text = currentData["HoaDonID"].ToString();
            txtKhachHang.Text = currentData["TenKhachHang"].ToString();
            txtSanPham.Text = currentData["TenSanPham"].ToString();
            txtTongGia.Text = currentData["TongTien"].ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you really want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                frmTrangChu h = new frmTrangChu();
                Visible = false;
                h.ShowDialog();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int KhachHangID = getIDKhachHang(txtKhachHang.Text);
            int SanPhamID = getIDSanPham(txtSanPham.Text);
            string NgayNhapHang = dtpNgayNhapHang.Value.ToString();
            string NgayXuatHang = dtpNgayXuatHang.Value.ToString();
            float TongTien = Convert.ToSingle(txtTongGia.Text);
            int HoaDonID = Convert.ToInt32(txtMaHoaDon.Text);

            string sql = "UPDATE [dbo].[HoaDon] " +
                         "SET [NgayNhapHang] = @NgayNhapHang " +
                         ",[NgayXuatHang] = @NgayXuatHang " +
                         ",[TongTien] = @TongTien " +
                         ",[KhachHangID] = @KhachHangID " +
                         ",[SanPhamID] = @SanPhamID " +
                         "WHERE [HoaDonID] = @HoaDonID ";
            SqlParameter param1 = new SqlParameter("@NgayNhapHang", SqlDbType.VarChar);
            param1.Value = NgayNhapHang;

            SqlParameter param2 = new SqlParameter("@NgayXuatHang", SqlDbType.VarChar);
            param2.Value = NgayXuatHang;

            SqlParameter param3 = new SqlParameter("@TongTien", SqlDbType.Float);
            param3.Value = TongTien;

            SqlParameter param4 = new SqlParameter("@KhachHangID", SqlDbType.Int);
            param4.Value = KhachHangID;

            SqlParameter param5 = new SqlParameter("@SanPhamID", SqlDbType.Int);
            param5.Value = SanPhamID;

            SqlParameter param6 = new SqlParameter("@HoaDonID", SqlDbType.Int);
            param6.Value = HoaDonID;

            if (Database.ExecuteNonQuery(sql, param1, param2, param3, param4, param5, param6) > 0)
            {
                MessageBox.Show("Sửa hóa đơn thành công");
            }
            this.Close();
        }
    }
}
