using ProjectPRN292.DAL;
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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjectPRN292
{
    public partial class frmNhapHang : Form
    {
        DonNhapDAL dal = new DonNhapDAL();
        KhachHangDAL listKhach = new KhachHangDAL();
        SanPhamDAL listSanPham = new SanPhamDAL();
        LoginDAL login = new LoginDAL();
        public frmNhapHang()
        {
            InitializeComponent();
            LoadForm();
            LoadKhachHang();
            LoadSanPham();
            addBinding();
        }

        public void LoadForm()
        {
            dtpNgayNhap.Value = DateTime.Now;
            txtGiaThue.Text = "";
            txtNote.Text = "";
            nSoLuong.Value = 0;
        }
        public void LoadKhachHang()
        {
            cbKhachHang.DataSource = null;
            cbKhachHang.DataSource = listKhach.GetKhachHang();
            cbKhachHang.DisplayMember = "TenKhachHang";
        }
        public void LoadSanPham()
        {
            cbSanPham.DataSource = null;
            cbSanPham.DataSource = listSanPham.GetSanPham();
            cbSanPham.DisplayMember = "TenSanPham";
        }
        public void addBinding()
        {
            txtThuongHieu.DataBindings.Add(new Binding("Text", cbSanPham.DataSource, "ThuongHieu"));
            txtGiaSP.DataBindings.Add(new Binding("Text", cbSanPham.DataSource, "Gia"));
        }


        private bool isValid()
        {
            bool Boo = true;          
            string strError = "";
            Regex regexInt = new Regex(@"^[0-9]+$");

            string gia = nSoLuong.Text;
            string giaThue = txtGiaThue.Text;

            if (!regexInt.IsMatch(gia))
            {
                Boo = false;
                strError += "Giá tiền phải là số và lớn hơn 0!.\n";
            }
            if (!regexInt.IsMatch(giaThue))
            {
                Boo = false;
                strError += "Giá tiền phải là số và lớn hơn 0!.\n";
            }
            if (Boo == false)
                MessageBox.Show(strError);
            return Boo;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DateTime time = dtpNgayNhap.Value;
            string pattern = "yyyy-MM-dd";
            try
            {
                var donNhap = new DonNhap()
                {
                    NgayNhapHang = time.ToString(pattern),
                    KhachHangID = dal.getIDKhachHang(cbKhachHang.Text.Trim()),
                    SoLuong = Int32.Parse(nSoLuong.Value.ToString()),
                    GiaThue = Int32.Parse(txtGiaThue.Text),
                    Note = txtNote.Text,
                    SanPhamID = dal.getIDSanPham(cbSanPham.Text.Trim()),
                    QuanLyID = login.getIDQuanLy()
                };
                if (isValid())
                {
                    if (dal.InsertDonNhap(donNhap) > 0)
                    {
                        DialogResult result = MessageBox.Show("Thêm thành công!\nBạn có muốn tiếp tục không?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.Cancel)
                        {
                            frmTrangChu h = new frmTrangChu();
                            Visible = false;
                            h.ShowDialog();
                        }
                        else if (result == DialogResult.OK)
                        {
                            LoadForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
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
