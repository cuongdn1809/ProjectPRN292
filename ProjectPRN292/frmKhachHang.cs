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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        KhachHangDAL listkhachhang = new KhachHangDAL();
        void loadKhachHang()
        {
            List<KhachHang> kh = listkhachhang.GetKhachHang();
            txtIdKhach.DataBindings.Clear();
            txtTenKhach.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            mtxtSdt.DataBindings.Clear();

            txtIdKhach.DataBindings.Add("Text", kh, "KhachHangID");
            txtTenKhach.DataBindings.Add("Text", kh, "TenKhachHang");
            txtDiaChi.DataBindings.Add("Text", kh, "DiaChi");
            mtxtSdt.DataBindings.Add("Text", kh, "Sdt");
          
            dgvKhachHang.DataSource = kh;
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Số điện thoại";
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                loadKhachHang();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chương trình lỗi");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = new KhachHang()
                {
                    Tenkhachhang = txtTenKhach.Text,
                    Diachi = txtDiaChi.Text,
                    Sdt = mtxtSdt.Text,

                };
                if (listkhachhang.InsertKhachHang(kh) > 0)
                {
                    MessageBox.Show("Thêm thành công.");
                    loadKhachHang();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chương trình lỗi");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = new KhachHang()
                {
                    Tenkhachhang = txtTenKhach.Text,
                    Diachi = txtDiaChi.Text,
                    Sdt = mtxtSdt.Text,
                    Khachhangid = int.Parse(txtIdKhach.Text)
                };
                if (listkhachhang.UpdateKhachHang(kh) > 0)
                {
                    MessageBox.Show("Chỉnh sửa thành công.");
                    loadKhachHang();
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



        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi tác vụ này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                frmTrangChu h = new frmTrangChu();
                Visible = false;
                h.ShowDialog();
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                if (listkhachhang.SearchKhachHangByName(txtSearch.Text.Trim()).Count > 0)
                {
                    dgvKhachHang.DataSource = null;
                    dgvKhachHang.DataSource = listkhachhang.SearchKhachHangByName(txtSearch.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng!");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập tên khách hàng!");
                txtSearch.Focus();
            }
        }


    }
}
