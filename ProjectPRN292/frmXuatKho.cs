using ProjectPRN292.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectPRN292.DAL;
namespace ProjectPRN292
{
    public partial class frmXuatKho : Form
    {
        private int id;
        private string date;
        private string tenKH;
        private string tenSP;
        private int GiaThue;

        HoaDonDAL listBill = new HoaDonDAL();

        public frmXuatKho(string date1, int id1, string tenKH1, string tenSP1, int GiaThue1)
        {
            InitializeComponent();
            date = date1;
            id = id1;
            tenKH = tenKH1;
            tenSP = tenSP1;
            GiaThue = GiaThue1;
        }


    public void loadForm()
        {
            txtKho.Text = id.ToString();
            txtKhachHang.Text = tenKH;
            //dtpNgayXuatHang.Value = DateTime.Now;
            //dtpNgayNhapHang.Value = DateTime.Parse(date);
            txtGiatheoNgay.Text = GiaThue.ToString();
        }

        private void frmXuatKho_Load(object sender, EventArgs e)
        {

            loadForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var bill = new HoaDon();
            {
                DateTime aDateTime = DateTime.Now;
                bill.NgayNhapHang = DateTime.Parse(date);
                bill.NgayXuatHang = aDateTime;
                TimeSpan interval = aDateTime.Subtract(DateTime.Parse(date));
                bill.TongTien = interval.Days * GiaThue;
                WareHouseDAL a = new WareHouseDAL();
                int idkh = a.getIDKhachHang(tenKH);
                bill.KhachHangId = idkh;
                int idsp = a.getIDSanPham(tenSP);
                bill.SanPhamId = idsp;
                listBill.InsertBill(bill);
            }
            MessageBox.Show("Xuat kho Thanh cong");

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

           
            Visible = true;
        }
    }
}
