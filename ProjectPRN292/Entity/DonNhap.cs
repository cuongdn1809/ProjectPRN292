using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPRN292.Entity
{
    public class DonNhap
    {
        private int nhapHangId;
        private string ngayNhapHang;
        private int khachHangID;
        private int soLuong;
        private string note;
        private int sanPhamID;
        private int quanLyID;

        public DonNhap()
        {
        }

        public DonNhap(int nhapHangId, string ngayNhapHang, int khachHangID, int soLuong, string note, int sanPhamID, int quanLyID)
        {
            this.nhapHangId = nhapHangId;
            this.ngayNhapHang = ngayNhapHang;
            this.khachHangID = khachHangID;
            this.soLuong = soLuong;
            this.note = note;
            this.sanPhamID = sanPhamID;
            this.quanLyID = quanLyID;
        }

        public DonNhap(string ngayNhapHang, int khachHangID, int soLuong, string note, int sanPhamID, int quanLyID)
        {
            this.ngayNhapHang = ngayNhapHang;
            this.khachHangID = khachHangID;
            this.soLuong = soLuong;
            this.note = note;
            this.sanPhamID = sanPhamID;
            this.quanLyID = quanLyID;
        }

        public int NhapHangId { get => nhapHangId; set => nhapHangId = value; }
        public string NgayNhapHang { get => ngayNhapHang; set => ngayNhapHang = value; }
        public int KhachHangID { get => khachHangID; set => khachHangID = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string Note { get => note; set => note = value; }
        public int SanPhamID { get => sanPhamID; set => sanPhamID = value; }
        public int QuanLyID { get => quanLyID; set => quanLyID = value; }
    }
}
