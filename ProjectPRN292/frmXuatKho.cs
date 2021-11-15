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
            //set value cho nhay nhap kho
            //string a = date.ToString("dd/MM/yyyy");
            //string[] result = a.Split('/');
            // dtpNgayNhapKho.Value = new DateTime(int.Parse(result[2]), int.Parse(result[1]), int.Parse(result[0]));
            txtNhapHang.Text = date.ToString("dd/MM/yyyy");
            this.txtKho.Text = id.ToString();
            this.txtKhachHang.Text = tenKH;         
            txtXuatHang.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.txtGiatheoNgay.Text = GiaThue.ToString();
            this.txtTongGia.Text = tonggiathue(GiaThue).ToString();
        }
        private void frmXuatKho_Load(object sender, EventArgs e)
        {
           
        }
        public int tonggiathue( int Giathue)
        {
            TimeSpan interval = (DateTime.Now).Subtract(date);
            int tonggiathue = Giathue * interval.Days;
            return tonggiathue;
        }
    

        private void btnConfirm_Click(object sender, EventArgs e)
        {           
            try { 

                var bill = new HoaDon();            
                DateTime aDateTime = DateTime.Now;
                bill.NgayNhapHang = date;
                bill.NgayXuatHang = aDateTime;
                bill.GiaThue = GiaThue;
                bill.TongTien = tonggiathue(GiaThue);
                WareHouseDAL a = new WareHouseDAL();
                int idkh = a.getIDKhachHang(tenKH);
                bill.KhachHangId = idkh;
                int idsp = a.getIDSanPham(tenSP);
                bill.SanPhamId = idsp;
                listBill.InsertBill(bill);
                a.DelateWareHouse(id);
            MessageBox.Show("Xuất kho thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chương trình lỗi");
            }
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            frmTrangChu f = new frmTrangChu();            
            f.ShowDialog();
            Visible = false;
        }
    }
}
