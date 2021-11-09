using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPRN292.Entity
{
    class WareHouse
    {
        private int nhapHangID;
        private String tenKhachHang;
        private String tenSanPham;
        private int soluong;
        private int giathue;
        private String note;
        private DateTime ngayNhapKho;

        public WareHouse()
        {
        }

        public WareHouse(int nhapHangID, string tenKhachHang, string tenSanPham, int soluong, int giathue, string note, DateTime ngayNhapKho)
        {
            this.nhapHangID = nhapHangID;
            this.tenKhachHang = tenKhachHang;
            this.tenSanPham = tenSanPham;
            this.soluong = soluong;
            this.giathue = giathue;
            this.note = note;
            this.ngayNhapKho = ngayNhapKho;
        }
        public int NhapHangID { get => nhapHangID; set => nhapHangID = value; }
        public String TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public String TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Giathue { get => giathue; set => giathue = value; }
        public String Note { get => note; set => note = value; }
        public DateTime NgayNhapKho { get => ngayNhapKho; set => ngayNhapKho = value; }

    }
}
