using ProjectPRN292.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            lbMa.Text = currentData["HoaDonID"].ToString();
            lbKhach.Text = currentData["TenKhachHang"].ToString();
            lbSanPham.Text = currentData["TenSanPham"].ToString();
            lbTong.Text = currentData["TongTien"].ToString();
            lbThuong.Text = currentData["ThuongHieu"].ToString();
            lbNhap.Text = currentData["NgayNhapHang"].ToString();
            lbXuat.Text = currentData["NgayXuatHang"].ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
