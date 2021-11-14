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
    public partial class frmKhoHang : Form
    {
        public static int id;
        public static DateTime date;
        public static string tenKH;
        public static string tenSP;
        public static string tenTH;
        public static int GiaThue;
        public static int GiaSP;
        public static int soluong;
        public static string Note;


        WareHouseDAL listWareHouse = new WareHouseDAL();
        KhachHangDAL listkhachhang = new KhachHangDAL();



        public frmKhoHang()
        {
            InitializeComponent();
            LoadKhachHang();
            LoadSanPham();
            addBinding();
        }

        public void LoadKhachHang()
        {
            cbKhachHang.DataSource = listkhachhang.GetKhachHang();
            cbKhachHang.DisplayMember = "TenKhachHang";
        }

        public void LoadSanPham()
        {
            SanPhamDAL sp = new SanPhamDAL();
            cbSanPham.DataSource = null;
            cbSanPham.DataSource = sp.GetSanPham();
            cbSanPham.DisplayMember = "TenSanPham";
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void addBinding()
        {
            txtThuongHieu.DataBindings.Add(new Binding("Text", cbSanPham.DataSource, "ThuongHieu"));
            txtGiaSP.DataBindings.Add(new Binding("Text", cbSanPham.DataSource, "Gia"));
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            lbKho.Text = "Kho Hàng " + id.ToString();
            //set value cho nhay nhap kho
            string a = date.ToString("dd/MM/yyyy");
            string[] result = a.Split('/');
            dtpNgayNhap.Value = new DateTime(int.Parse(result[2]), int.Parse(result[1]), int.Parse(result[0]));
            cbKhachHang.SelectedIndex = cbKhachHang.FindStringExact(tenKH);
            cbSanPham.SelectedIndex = cbSanPham.FindStringExact(tenSP);
            txtGiaThue.Text = GiaThue.ToString();
            txtNote.Text = Note;
            nSoLuong.Value = soluong;
            //txtGiaSP.Text = GiaSP.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddSanPham frm = new frmAddSanPham();
            // Show
            this.Visible = false;
            frm.ShowDialog();
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int khID = listWareHouse.getIDKhachHang(cbKhachHang.GetItemText(cbKhachHang.SelectedItem));
                int spID = listWareHouse.getIDSanPham(cbSanPham.GetItemText(cbSanPham.SelectedItem));
                WareHouse khoHang = new WareHouse()              
                {
                NhapHangID = id,
                TenKhachHang = cbKhachHang.GetItemText(cbKhachHang.SelectedItem),
                TenThuongHieu = txtThuongHieu.Text,
                TenSanPham = cbSanPham.GetItemText(cbSanPham.SelectedItem),
                NgayNhapKho = Convert.ToDateTime(dtpNgayNhap.Value.ToString("dd/MM/yyyy")),
                GiaSP = int.Parse(txtGiaSP.Text),
                Soluong = int.Parse(nSoLuong.Text),
                Giathue = int.Parse(txtGiaThue.Text),
                Note = txtNote.Text
                };
                if (listWareHouse.UpdateWareHouse(khoHang,khID,spID) > 0)
                {
                    MessageBox.Show("Chỉnh sửa thành công.");
                    frmTrangChu f = new frmTrangChu();
                    f.ShowDialog();
                    Visible = false;
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
}} 
        
    

