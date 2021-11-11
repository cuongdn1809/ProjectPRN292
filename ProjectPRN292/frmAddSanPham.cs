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
    public partial class frmAddSanPham : Form
    {
        public frmAddSanPham()
        {
            InitializeComponent();
        }
        SanPhamDAL sanpham = new SanPhamDAL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = new Sanpham()
                {
                    TenSanPham = txtTebSanPham.Text,
                    ThuongHieu = txtThuongHieu.Text,
                    Gia = int.Parse(numGia.Value.ToString()),
                    Note = txtNote.Text,

                };
                if (sanpham.InsertSanPam(sp) > 0)
                {
                    MessageBox.Show("Thêm thành công.");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmTrangChu tc = new frmTrangChu();
            Visible = false;
            tc.ShowDialog();
        }
    }
}
