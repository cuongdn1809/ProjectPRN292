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
    public partial class frmTrangChu : Form
    {

        KhachHangDAL kh = new KhachHangDAL();
        public frmTrangChu()
        {
            InitializeComponent();
            txtTim.Focus();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            Visible = false;
            kh.ShowDialog();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            frmNhapHang f = new frmNhapHang();
            this.Visible = false;
            f.ShowDialog();
        }
        private void SetUpDataTableForWareHouse()
        {
            dgvHome.AutoGenerateColumns = false;
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.HeaderText = "Chọn";
            check.Name = "checkBox";
            dgvHome.Columns.Add(check);

            dgvHome.Columns.Add("Khocol", "Kho");
            dgvHome.Columns["Khocol"].DataPropertyName = "NhapHangID";

            dgvHome.Columns.Add("tenKhachHangcol", "Tên Khách Hàng");
            dgvHome.Columns["tenKhachHangcol"].DataPropertyName = "TenKhachHang";

            dgvHome.Columns.Add("thuongHieucol", "Thương Hiệu");
            dgvHome.Columns["thuongHieucol"].DataPropertyName = "ThuongHieu";

            dgvHome.Columns.Add("tenSanPhamcol", "Tên Sản Phẩm");
            dgvHome.Columns["tenSanPhamcol"].DataPropertyName = "TenSanPham";

            dgvHome.Columns.Add("ngayNhapcol", "Ngày Nhập Kho ");
            dgvHome.Columns["ngayNhapcol"].DataPropertyName = "NgayNhapHang";

            dgvHome.Columns.Add("Giatiencol", "Giá Sản Phẩm");
            dgvHome.Columns["Giatiencol"].DataPropertyName = "Gia";

            dgvHome.Columns.Add("soLuongcol", "Số Lượng");
            dgvHome.Columns["soLuongcol"].DataPropertyName = "SoLuong";

            dgvHome.Columns.Add("giacol", "Giá Thuê");
            dgvHome.Columns["giacol"].DataPropertyName = "GiaThue";

            dgvHome.Columns.Add("notecol", "Ghi Chú");
            dgvHome.Columns["notecol"].DataPropertyName = "Note";

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Chỉnh sửa";
            button.Text = "Chỉnh sửa";
            button.Name = "editbutton";
            button.UseColumnTextForButtonValue = true;
            dgvHome.Columns.Add(button);
        }

        public void LoadWarehouse()
        {
            string sql = "select n.NhapHangID, k.TenKhachHang,s.ThuongHieu,s.TenSanPham,n.NgayNhapHang,s.Gia, n.SoLuong,n.GiaThue,n.Note from KhachHang k, NhapHang n, " +
                "SanPham s where k.KhachHangID = n.KhachHangID and n.SanPhamID = s.SanPhamID";
            DataTable dt = Database.ExecuteQuery(sql);
            dgvHome.DataSource = null;
            dgvHome.DataSource = dt;
            dgvHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadWarehouseByKhachHang(string kh)
        {
            string sql = "select n.NhapHangID, k.TenKhachHang,s.ThuongHieu,s.TenSanPham,n.NgayNhapHang,s.Gia, n.SoLuong,n.GiaThue,n.Note from KhachHang k, NhapHang n, " +
                "SanPham s where k.KhachHangID = n.KhachHangID and n.SanPhamID = s.SanPhamID and k.TenKhachHang like '%" + kh + "%'";
            DataTable dt = Database.ExecuteQuery(sql);
            dgvHome.DataSource = null;
            dgvHome.DataSource = dt;
            dgvHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadWarehouseBySanPham(string sp)
        {
            string sql = "select n.NhapHangID, k.TenKhachHang,s.ThuongHieu,s.TenSanPham,n.NgayNhapHang,s.Gia, n.SoLuong,n.GiaThue,n.Note from KhachHang k, NhapHang n, " +
                "SanPham s where k.KhachHangID = n.KhachHangID and n.SanPhamID = s.SanPhamID and s.TenSanPham like '%" + sp + "%'";
            DataTable dt = Database.ExecuteQuery(sql);
            dgvHome.DataSource = null;
            dgvHome.DataSource = dt;
            dgvHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadWarehouseByThuongHieu(string th)
        {
            string sql = "select n.NhapHangID, k.TenKhachHang,s.ThuongHieu,s.TenSanPham,n.NgayNhapHang,s.Gia, n.SoLuong,n.GiaThue,n.Note from KhachHang k, NhapHang n, " +
               "SanPham s where k.KhachHangID = n.KhachHangID and n.SanPhamID = s.SanPhamID and s.ThuongHieu like '%" + th + "%'";
            DataTable dt = Database.ExecuteQuery(sql);
            dgvHome.DataSource = null;
            dgvHome.DataSource = dt;
            dgvHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            try
            {
                cbTimkiem.SelectedIndex = 0;
                SetUpDataTableForWareHouse();
                LoadWarehouse();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {

            int count = 0;
            foreach (DataGridViewRow dgr in dgvHome.Rows)
            {
                var obj = dgr.Cells["checkBox"].Value;
                if (obj != null && (bool)obj == true)
                {
                    count++;
                }
            }

            switch (count)
            {
                case 0:
                    MessageBox.Show("Bạn chưa chọn kho hàng");
                    break;
                case 1:

                    frmXuatKho.id = int.Parse(dgvHome.CurrentRow.Cells["khocol"].Value.ToString());
                    frmXuatKho.date = Convert.ToDateTime(dgvHome.CurrentRow.Cells["ngayNhapcol"].Value);
                    frmXuatKho.tenKH = dgvHome.CurrentRow.Cells["tenKhachHangcol"].Value.ToString();
                    frmXuatKho.tenSP = dgvHome.CurrentRow.Cells["tenSanPhamcol"].Value.ToString();
                    frmXuatKho.GiaThue = int.Parse(dgvHome.CurrentRow.Cells["giacol"].Value.ToString());
                    frmXuatKho frm = new frmXuatKho();
                    Visible = false;
                    // Show                  
                    frm.ShowDialog();

                    break;
                default:
                    MessageBox.Show("Bạn chỉ được chọn một kho hàng");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (cbTimkiem.SelectedIndex)
            {
                case 0:
                    if (txtTim.Text.Length != 0)
                    {
                        if (kh.SearchKhachHangByName(txtTim.Text.Trim()).Count > 0)
                        {
                            LoadWarehouseByKhachHang(txtTim.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng!");
                            LoadWarehouse();
                            txtTim.Text = "";
                            txtTim.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập tên khách hàng!");
                        LoadWarehouse();
                        txtTim.Focus();
                    }
                    break;


                case 1:

                    if (txtTim.Text.Length != 0)
                    {
                        WareHouseDAL home = new WareHouseDAL();
                        if (home.GetWareHousebyTenSanPham(txtTim.Text.Trim()).Count > 0)
                        {
                            LoadWarehouseBySanPham(txtTim.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm!");
                            LoadWarehouse();
                            txtTim.Text = "";
                            txtTim.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập tên sản phẩm!");
                        LoadWarehouse();
                        txtTim.Focus();
                    }
                    break;
                case 2:
                    if (txtTim.Text.Length != 0)
                    {
                        WareHouseDAL home = new WareHouseDAL();
                        if (home.GetWareHousebyTenThuongHieu(txtTim.Text.Trim()).Count > 0)
                        //if (home.GetWareHousebyTenThuongHieu(txtTim.Text.Trim()).Count > 0)
                        {
                            LoadWarehouseByThuongHieu(txtTim.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thương hiệu!");
                            LoadWarehouse();
                            txtTim.Text = "";
                            txtTim.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập tên thương hiệu!");
                        LoadWarehouse();
                        txtTim.Focus();
                    }
                    break;
            }
        }

        private void btnExitt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn  muốn thoát không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dgvHome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHome.Columns[e.ColumnIndex].Name.Equals("editbutton"))
            {

                frmKhoHang.id = int.Parse(dgvHome.CurrentRow.Cells["khocol"].Value.ToString());
                frmKhoHang.date = Convert.ToDateTime(dgvHome.CurrentRow.Cells["ngayNhapcol"].Value);
                frmKhoHang.tenKH = dgvHome.CurrentRow.Cells["tenKhachHangcol"].Value.ToString();
                frmKhoHang.tenSP = dgvHome.CurrentRow.Cells["tenSanPhamcol"].Value.ToString();
                frmKhoHang.tenTH = dgvHome.CurrentRow.Cells["thuongHieucol"].Value.ToString();
                frmKhoHang.GiaThue = int.Parse(dgvHome.CurrentRow.Cells["giacol"].Value.ToString());
                frmKhoHang.soluong = int.Parse(dgvHome.CurrentRow.Cells["soluongcol"].Value.ToString());
                frmKhoHang.GiaSP = int.Parse(dgvHome.CurrentRow.Cells["Giatiencol"].Value.ToString());
                frmKhoHang.Note = dgvHome.CurrentRow.Cells["notecol"].Value.ToString();
                frmKhoHang frm = new frmKhoHang();
                // Show
                this.Visible = false;
                frm.ShowDialog();
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham kh = new frmSanPham();
            Visible = false;
            kh.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon kh = new frmHoaDon();
            Visible = false;
            kh.ShowDialog();
        }
    }
}

