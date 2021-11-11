﻿using ProjectPRN292.DAL;
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
        public static int GiaThue;
        public static int soluong;
        public static string Note;


        WareHouseDAL khohang = new WareHouseDAL();
        KhachHangDAL listkhachhang = new KhachHangDAL();


        //public int getIndex(string tenKH)
        //{
            
        //    int index = -2;
        //    for (int i = 0; i < cbKhachHang.Items.Count; i++)
        //    {
        //        if (int a = cbKhachHang.Items.IndexOf(tenKH))                
        //           //.Equals(tenKH))
        //        {
        //            index = i;
        //            break;
        //        }
        //    }
        //    return index;

        //}

        public frmKhoHang()
        {
            InitializeComponent();
            LoadKhachHang();
            LoadSanPham();
        }
       
        public void LoadKhachHang()
        {
            cbKhachHang.DataSource = listkhachhang.GetKhachHang();
            cbKhachHang.DisplayMember = "TenKhachHang";        
            //cbKhachHang.ValueMember = "KhachHangID";   
        }

        public void LoadSanPham()
        {
            string sql = "select * from SanPham";
            DataTable dt = Database.GetDataBySQL(sql);
            cbSanPham.DisplayMember = "TenSanPham";
            cbSanPham.ValueMember = "TenSanPham";
            cbSanPham.DataSource = dt;
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //addBinding();
        }

        public void addBinding()
        {
            txtThuongHieu.DataBindings.Add(new Binding("text", cbSanPham, "ThuongHieu"));
        }
        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            
            lbKho.Text = id.ToString();
            //set value cho nhay nhap kho
            string a = date.ToString("dd/MM/yyyy");
            string[] result = a.Split('/');
            dtpNgayNhap.Value = new DateTime(int.Parse(result[2]), int.Parse(result[1]), int.Parse(result[0]));
            cbKhachHang.SelectedIndex = cbKhachHang.FindStringExact(tenKH);
            txtGiaThue.Text = GiaThue.ToString();
            txtNote.Text = Note;            
            nSoLuong.Value = soluong;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddSanPham frm = new frmAddSanPham();
            // Show
            this.Visible = false;
            frm.ShowDialog();
        }
    }
}
