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
            cbTimkiem.SelectedIndex = 0;
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
            dgvHome.DataSource = dt;
        }
        private void SetUpDataTableForHoaDon()
        {
            dgvHome.AutoGenerateColumns = false;
            dgvHome.Columns.Add("ngayNhapHangcol", "Ngày Nhập Hàng");
            dgvHome.Columns["ngayNhapHangcol"].DataPropertyName = "NgayNhapHang";

            dgvHome.Columns.Add("ngayXuatHangcol", "Ngày Xuất Hàng");
            dgvHome.Columns["ngayXuatHangcol"].DataPropertyName = "NgayXuatHang";

            dgvHome.Columns.Add("tongTiencol", "Tổng Tiền");
            dgvHome.Columns["tongTiencol"].DataPropertyName = "TongTien";

            dgvHome.Columns.Add("tenKhachHangcol", "Tên Khách Hàng");
            dgvHome.Columns["tenKhachHangcol"].DataPropertyName = "TenKhachHang";

            dgvHome.Columns.Add("tenSanPhamcol", "Tên Sản Phẩm");
            dgvHome.Columns["tenSanPhamcol"].DataPropertyName = "TenSanPham";

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Chỉnh sửa";
            button.Text = "Chỉnh sửa";
            button.Name = "editbutton";
            button.UseColumnTextForButtonValue = true;
            dgvHome.Columns.Add(button);
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

            dgvHome.Columns.Add("tenSanPhamcol", "Tên Sản Phẩm");
            dgvHome.Columns["tenSanPhamcol"].DataPropertyName = "TenSanPham";
            dgvHome.Columns.Add("ngayNhapcol", "Ngày Nhập Kho ");
            dgvHome.Columns["ngayNhapcol"].DataPropertyName = "NgayNhapHang";

            dgvHome.Columns.Add("soLuongcol", "Số Lượng");
            dgvHome.Columns["soLuongcol"].DataPropertyName = "SoLuong";

            dgvHome.Columns.Add("giacol", "Giá Thuê");
            dgvHome.Columns["giacol"].DataPropertyName = "GiaThue";

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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        WareHouseDAL home = new WareHouseDAL();
        private void LoadWarehouse()
        {
            dgvHome.DataSource = null;
            dgvHome.DataSource = home.GetWareHouse();
            dgvHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            try
            {
                SetUpDataTableForWareHouse();
                LoadWarehouse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
                    MessageBox.Show("You must select one ");
                    break;
                case 1:
                    int ID = int.Parse(dgvHome.CurrentRow.Cells["khocol"].Value.ToString());
                    string date = "2";
                        //= dgvHome.CurrentRow.Cells["ngayNhapcol"].Value.ToString();
                    string tenKH = dgvHome.CurrentRow.Cells["tenKhachHangcol"].Value.ToString();
                    string tenSP = dgvHome.CurrentRow.Cells["tenSanPhamcol"].Value.ToString();
                    int giathue = int.Parse(dgvHome.CurrentRow.Cells["giacol"].Value.ToString());
                    frmXuatKho frm = new frmXuatKho(date, ID, tenKH, tenSP,giathue);
                    Visible = false;
                    // Show                  
                    frm.ShowDialog();
                  
                    break;
                default:
                    MessageBox.Show("You must only select one");
                    break;
                  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTimkiem.SelectedIndex == 0)
            {
                if (txtTim.Text.Length != 0)
                {
                    if (home.GetWareHousebyTenKhachHang(txtTim.Text.Trim()).Count > 0)
                    {
                        dgvHome.DataSource = null;
                        dgvHome.DataSource = home.GetWareHousebyTenKhachHang(txtTim.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng!");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập tên khách hàng!");
                    dgvHome.DataSource = null;
                    dgvHome.DataSource = home.GetWareHouse();
                    dgvHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    txtTim.Focus();
                }
            }
            else
            {
                if (txtTim.Text.Length != 0)
                {
                    if (home.GetWareHousebyTenSanPham(txtTim.Text.Trim()).Count > 0)
                    {
                        dgvHome.DataSource = null;
                        dgvHome.DataSource = home.GetWareHousebyTenSanPham(txtTim.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm!");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập tên sản phẩm!");
                    dgvHome.DataSource = null;
                    dgvHome.DataSource = home.GetWareHouse();
                    dgvHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    txtTim.Focus();
                }
            }
        }

    }
}

