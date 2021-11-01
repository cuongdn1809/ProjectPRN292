using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPRN292.Entity
{
    public class DonNhap
    {
        private int nhapHangId1;
        private DateTime ngayNhapHang1;
        private int khachHangID;
        private int soLuong1;
        private string note1;
        private int sanPhamID;
        private int quanLyID;

        public int nhapHangId { get => nhapHangId1; set => nhapHangId1 = value; }
        public DateTime ngayNhapHang { get => ngayNhapHang1; set => ngayNhapHang1 = value; }
        public int KhachHangID { get => khachHangID; set => khachHangID = value; }
        public int soLuong { get => soLuong1; set => soLuong1 = value; }
        public string note { get => note1; set => note1 = value; }
        public int SanPhamID { get => sanPhamID; set => sanPhamID = value; }
        public int QuanLyID { get => quanLyID; set => quanLyID = value; }

        public DonNhap() { }

        public DonNhap(DateTime ngayNhapHang, int khachHangID, int soLuong, string note, int sanPhamID, int quanLyID)
        {
            this.ngayNhapHang = ngayNhapHang;
            KhachHangID = khachHangID;
            this.soLuong = soLuong;
            this.note = note;
            SanPhamID = sanPhamID;
            QuanLyID = quanLyID;
        }

        public DonNhap(int nhapHangId, DateTime ngayNhapHang, int khachHangID, int soLuong, string note, int sanPhamID, int quanLyID)
        {
            this.nhapHangId = nhapHangId;
            this.ngayNhapHang = ngayNhapHang;
            KhachHangID = khachHangID;
            this.soLuong = soLuong;
            this.note = note;
            SanPhamID = sanPhamID;
            QuanLyID = quanLyID;
        }
    }
}
