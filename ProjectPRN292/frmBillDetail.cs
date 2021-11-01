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
    public partial class frmBillDetail : Form
    {
        DataRowView currentData;
        public frmBillDetail()
        {
            InitializeComponent();
        }

        public frmBillDetail(DataRowView data)
        {
            InitializeComponent();
            currentData = data;
            LoadData();
        }

        private void LoadData()
        {
            txtMaHoaDon.Text = currentData["HoaDonID"].ToString();
            txtKhachHang.Text = currentData["TenKhachHang"].ToString();
            txtSanPham.Text = currentData["TenSanPham"].ToString();
            txtTongGia.Text = currentData["TongTien"].ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you really want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                frmHome h = new frmHome();
                Visible = false;
                h.ShowDialog();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
