using ProjectPRN292.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectPRN292
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            Visible = false;
            kh.ShowDialog();
        }
        private void LoadDataHoaDon()
        {
            string sql = "select h.NgayNhapHang, h.NgayXuatHang, h.TongTien, h.HoaDonID, k.TenKhachHang, s.TenSanPham  " +
                            "from HoaDon h, KhachHang k, SanPham s " +
                            "where h.KhachHangID = k.KhachHangID and s.SanPhamID = h.SanPhamID";
            DataTable dt = Database.ExecuteQuery(sql);
            dataGridView1.DataSource = dt;
        }
        private void SetUpDataTableForHoaDon()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("ngayNhapHangcol", "Ngày Nhập Hàng");
            dataGridView1.Columns["ngayNhapHangcol"].DataPropertyName = "NgayNhapHang";

            dataGridView1.Columns.Add("ngayXuatHangcol", "Ngày Xuất Hàng");
            dataGridView1.Columns["ngayXuatHangcol"].DataPropertyName = "NgayXuatHang";

            dataGridView1.Columns.Add("tongTiencol", "Tổng Tiền");
            dataGridView1.Columns["tongTiencol"].DataPropertyName = "TongTien";

            dataGridView1.Columns.Add("tenKhachHangcol", "Tên Khách Hàng");
            dataGridView1.Columns["tenKhachHangcol"].DataPropertyName = "TenKhachHang";

            dataGridView1.Columns.Add("tenSanPhamcol", "Tên Sản Phẩm");
            dataGridView1.Columns["tenSanPhamcol"].DataPropertyName = "TenSanPham";

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Chỉnh sửa";
            button.Text = "Edit";
            button.Name = "editbutton";
            button.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(button);
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            SetUpDataTableForHoaDon();
            LoadDataHoaDon();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            frmWareHouseDetail f = new frmWareHouseDetail();
            this.Visible = false;
            f.ShowDialog();
        }

        private void edit_Close(object sender, EventArgs e)
        {
            LoadDataHoaDon();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("editbutton"))
            {
                DataRowView data = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                frmBillDetail f = new frmBillDetail(data);
                f.FormClosed += edit_Close;
                f.Show();
            }
        }
    }
}
