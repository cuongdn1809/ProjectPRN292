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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        SanPhamDAL listsp = new SanPhamDAL();
        void loadSP()
        {
            List<Sanpham> kh = listsp.GetSanPham();
            txtIdSanPham.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            txtThuongHieu.DataBindings.Clear();
            txtGiaSP.DataBindings.Clear();
            txtNote.DataBindings.Clear();

            txtIdSanPham.DataBindings.Add("Text", kh, "SanPhamID");
            txtTenSP.DataBindings.Add("Text", kh, "TenSanPham");
            txtThuongHieu.DataBindings.Add("Text", kh, "ThuongHieu");
            txtGiaSP.DataBindings.Add("Text", kh, "Gia");
            txtNote.DataBindings.Add("Text", kh, "Note");

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
                case 0:

                    if (txtTim.Text.Length != 0)
                    {
                       
                            LoadWarehouseBySanPham(txtTim.Text.Trim());
                       
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập tên sản phẩm!");
                        loadSP();
                        txtTim.Focus();
                    }
                    break;
                case 1:
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
                            loadSP();
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
    }
}
