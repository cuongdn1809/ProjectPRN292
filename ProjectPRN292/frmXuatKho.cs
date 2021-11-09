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
        public static  int id;
        public static DateTime date;
        public static string tenKH;
        public static string tenSP;
        public static int GiaThue;

        HoaDonDAL listBill = new HoaDonDAL();
        
        public frmXuatKho()
        { 
            InitializeComponent();          
            this.txtKho.Text = id.ToString();
            this.txtKhachHang.Text = tenKH;
            dtpNgayXuatHang.Value = DateTime.Now;
            //dtpNgayNhapHang.Value =date;
            this.txtGiatheoNgay.Text = GiaThue.ToString();
        }

        private void frmXuatKho_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var bill = new HoaDon();
            {
                DateTime aDateTime = DateTime.Now;
                bill.NgayNhapHang = date;
                bill.NgayXuatHang = aDateTime;
                TimeSpan interval = aDateTime.Subtract(date);
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

       
    }
}
