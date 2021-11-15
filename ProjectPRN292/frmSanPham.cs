using ProjectPRN292.DAL;
using ProjectPRN292.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjectPRN292
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
            cbTimkiem.SelectedIndex = 0;
        }
        bool addNew = true;
        SanPhamDAL listsp = new SanPhamDAL();
        void loadSP()
        {
            List<Sanpham> kh = listsp.GetSanPham();
            dgvSanPham.DataSource = kh;
            dgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns[1].HeaderText = "Thương Hiệu";
            dgvSanPham.Columns[2].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns[3].HeaderText = "Giá Sản Phẩm";
            dgvSanPham.Columns[4].HeaderText = "Ghi Chú";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            loadSP();
        }

        public void LoadWarehouseBySanPham(string sp)
        {
            string sql = "select SanPhamID as  'Mã Sản Phẩm',ThuongHieu as 'Thương Hiệu',TenSanPham as'Tên Sản Phẩm',Gia as 'Giá Sản Phẩm', Note as 'Ghi Chú' from SanPham where TenSanPham like '%" + sp + "%'";
            DataTable dt = Database.ExecuteQuery(sql);
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = dt;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadWarehouseByThuongHieu(string th)
        {
            string sql = "select SanPhamID as  'Mã Sản Phẩm',ThuongHieu as 'Thương Hiệu',TenSanPham as'Tên Sản Phẩm',Gia as 'Giá Sản Phẩm', Note as 'Ghi Chú' from SanPham where ThuongHieu like '%" + th + "%'";
            DataTable dt = Database.ExecuteQuery(sql);
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = dt;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (cbTimkiem.SelectedIndex)
            {
                case 1:
                    if (txtTim.Text.Length != 0)
                    {
                        SanPhamDAL listSanPham = new SanPhamDAL();
                        if (listSanPham.SearchSanPhamByName(txtTim.Text.Trim()).Count > 0)
                        {
                            LoadWarehouseBySanPham(txtTim.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm!");
                            loadSP();
                            txtTim.Text = "";
                            txtTim.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập tên sản phẩm!");
                        loadSP();
                        txtTim.Focus();
                    }
                    break;
                case 0:
                    if (txtTim.Text.Length != 0)
                    {
                        SanPhamDAL listSanPham = new SanPhamDAL();
                        if (listSanPham.SearchSanPhamByThuongHieu(txtTim.Text.Trim()).Count > 0)
                        {
                            LoadWarehouseByThuongHieu(txtTim.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thương hiệu!");
                            loadSP();
                            txtTim.Text = "";
                            txtTim.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập tên thương hiệu!");
                        loadSP();
                        txtTim.Focus();
                    }
                    break;
            }
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            if (addNew == false)
            {
                try
                {
                    var kh = new Sanpham()
                    {
                        SanPhamID = int.Parse(txtIdSanPham.Text),
                        TenSanPham = txtTenSP.Text,
                        ThuongHieu = txtThuongHieu.Text,
                        Gia = int.Parse(nGiaSP.Value.ToString()),
                        Note = txtNote.Text
                    };
                    if (listsp.UpdateSanPham(kh) > 0)
                    {
                        MessageBox.Show("Chỉnh sửa thành công.");
                        loadSP();
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Chương trình lỗi.");
                }
            }
            else
            {
                MessageBox.Show("Chọn một sản phẩm để chỉnh sửa.");
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {

            
            var sp = new Sanpham()
            {
                TenSanPham = txtTenSP.Text,
                ThuongHieu = txtThuongHieu.Text,
                Gia = int.Parse(nGiaSP.Value.ToString()),
                Note = txtNote.Text
            };
            if (ValidData())
            {
                listsp.InsertSanPam(sp);
                MessageBox.Show("Thêm sản phẩm thành công.");
                loadSP();
                txtIdSanPham.Text = "";
                txtTenSP.Text = "";
                txtThuongHieu.Text = "";
                nGiaSP.Value = 0;
                txtNote.Text = "";
            }
           
          
        }
        private bool ValidData()
        {
            bool flag = true;
            // Lấy dữ liệu từ các control trên Form
          //  int SanPhamID = int.Parse(txtIdSanPham.Text);
            string TenSanPham = txtTenSP.Text;
            string ThuongHieu = txtThuongHieu.Text;
            string Gia = nGiaSP.Text;
            string strError = "";
       

            if (TenSanPham.Equals(""))
            {
                flag = false;
                strError += "Tên sản phẩm không được để trống.\n";
                txtTenSP.Focus();
            }
            if (ThuongHieu.Equals(""))
            {
                flag = false;
                strError += "Tên thương hiệu không được để trống.\n";
                txtThuongHieu.Focus();
            }
            if (Gia.Equals("")|Gia.Equals("0"))
            {
                flag = false;
                strError += "Giá sản phẩm phải lớn hơn 0.\n";
            }


            if (flag == false)
                MessageBox.Show(strError);

            return flag;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addNew = false;
            txtIdSanPham.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtThuongHieu.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            txtTenSP.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            nGiaSP.Value = decimal.Parse(dgvSanPham.CurrentRow.Cells[3].Value.ToString());
            txtNote.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnExitt_Click(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();
            // Show
            this.Visible = false;
            frm.ShowDialog();
        }
    }
}
