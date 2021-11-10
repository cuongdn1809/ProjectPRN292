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
    public partial class frmKhoHang : Form
    {
        public frmKhoHang()
        {
            InitializeComponent();
          
        }

        public void LoadKhachHang()
        {
            string sql = "select * from KhachHang";
            DataTable dt = Database.GetDataBySQL(sql);
            cbKhachHang.DisplayMember = "TenKhachHang";
            cbKhachHang.DataSource = dt;
        }
        public void LoadSanPham()
        {
            string sql = "select * from SanPham";
            DataTable dt = Database.GetDataBySQL(sql);
            cbSanPham.DisplayMember = "TenSanPham";
            cbSanPham.DataSource = dt;
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadSanPham();
        }
    }
}
