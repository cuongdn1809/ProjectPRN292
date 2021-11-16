using ProjectPRN292.DAL;
using ProjectPRN292.Entity;
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
            LoadCbbThang();
            LoadCbbNam();
        }

        private void LoadData()
        {
            DataTable dt = dal.GetData();
            dgvHoaDon.DataSource = dt;
            label4.Text = "";
        }
        private void LoadCbbThang()
        {
            var list = new List<string>();
            for (int i = 1; i <= 12; i++)
            {
                list.Add("Tháng "+i);
            }
            cbbThang.DataSource = list;
        }
        private void LoadCbbNam()
        {
            var list = new List<string>();
            for (int i = 2015; i <= 2021; i++)
            {
                list.Add("Năm " + i);
            }
            cbbNam.DataSource = list;
        }
        public void LoadKhachHang()
        {
            cbbKhachHang.DataSource = null;
            List<string> list = listKhach.GetKhachHangByName();
            list.Insert(0, "---Tất cả---");
            cbbKhachHang.DataSource = list;
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
            if (cbbKhachHang.Text.Equals("---Tất cả---"))
            {
                DataTable dt = dal.GetData();
                dgvHoaDon.DataSource = dt;
            }
            else
            {
                string name = cbbKhachHang.Text;
                DataTable dt = dal.GetDataByTenKH(name);
                dgvHoaDon.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thangStr = cbbThang.Text;
            int thang = Int32.Parse(thangStr.Substring(5));
            int nam = Int32.Parse(cbbNam.Text.Substring(3));
            string name = cbbKhachHang.Text;
            if (cbbKhachHang.Text.Equals("---Tất cả---"))
            {
                DataTable dt = dal.GetDataByNgay(thang,nam);
                dgvHoaDon.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.GetDataByNgayAndTen(name, thang, nam);
                dgvHoaDon.DataSource = dt;
            }
        }

        private int Sum()
        {
            int doanhThu = 0;
            int s = dgvHoaDon.Rows.Count;
            for(int i =0; i < s; i++)
            {
                doanhThu += Int32.Parse(dgvHoaDon.Rows[i].Cells["tongTiencol"].Value.ToString());
            }
            return doanhThu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = Sum();
            string thang = cbbThang.Text;
            string nam = cbbNam.Text;
            label4.Text = "Doanh thu là " + sum +" đồng"; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                frmTrangChu h = new frmTrangChu();
                Visible = false;
                h.ShowDialog();
            }
        }
    }
}
