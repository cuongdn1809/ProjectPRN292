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
    public partial class frmHoaDon : Form
    {
        HoaDonDAL dal = new HoaDonDAL();
        KhachHangDAL listKhach = new KhachHangDAL();
        public frmHoaDon()
        {
            InitializeComponent();
            SetUpDataTable();
            LoadData();
            LoadKhachHang();
        }

        private void LoadData()
        {
            DataTable dt = dal.GetData();
            dgvHoaDon.DataSource = dt;

        }
        public void LoadKhachHang()
        {
            cbbKhachHang.DataSource = null;
            cbbKhachHang.DataSource = listKhach.GetKhachHang();
            cbbKhachHang.DisplayMember = "TenKhachHang";
        }
        private void SetUpDataTable()
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.Columns.Add("ngayNhapHangcol", "Ngày Nhập Hàng");
            dgvHoaDon.Columns["ngayNhapHangcol"].DataPropertyName = "NgayNhapHang";

            dgvHoaDon.Columns.Add("ngayXuatHangcol", "Ngày Xuất Hàng");
            dgvHoaDon.Columns["ngayXuatHangcol"].DataPropertyName = "NgayXuatHang";

            dgvHoaDon.Columns.Add("tongTiencol", "Tổng Tiền");
            dgvHoaDon.Columns["tongTiencol"].DataPropertyName = "TongTien";

            dgvHoaDon.Columns.Add("tenKhachHangcol", "Tên Khách Hàng");
            dgvHoaDon.Columns["tenKhachHangcol"].DataPropertyName = "TenKhachHang";

            dgvHoaDon.Columns.Add("tenSanPhamcol", "Tên Sản Phẩm");
            dgvHoaDon.Columns["tenSanPhamcol"].DataPropertyName = "TenSanPham";

            dgvHoaDon.Columns.Add("thuongHieucol", "Thương Hiệu");
            dgvHoaDon.Columns["thuongHieucol"].DataPropertyName = "ThuongHieu";

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Chi tiết";
            button.Text = "Chi tiết";
            button.Name = "detailbutton";
            button.UseColumnTextForButtonValue = true;
            dgvHoaDon.Columns.Add(button);
        }

        private void edit_Close(object sender, EventArgs e)
        {
            LoadData();
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.Columns[e.ColumnIndex].Name.Equals("detailbutton"))
            {
                DataRowView data = (DataRowView)dgvHoaDon.Rows[e.RowIndex].DataBoundItem;
                frmBillDetail f = new frmBillDetail(data);
                f.FormClosed += edit_Close;
                f.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = cbbKhachHang.Text;
            DataTable dt = dal.GetDataByTenKH(name);
            dgvHoaDon.DataSource = dt;
        }
    }
}
