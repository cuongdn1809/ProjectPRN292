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
        private string tenThuongHieu;
        private String tenSanPham;
        private DateTime ngayNhapKho;
        private int giaSP;
        private int soluong;
        private int giathue;
        private String note;
     

        public WareHouse()
        {
        }

        public WareHouse(int nhapHangID, string tenKhachHang, string tenThuongHieu, string tenSanPham, DateTime ngayNhapKho, int giaSP, int soluong, int giathue, string note)
        {
            this.nhapHangID = nhapHangID;
            this.tenKhachHang = tenKhachHang;
            this.tenThuongHieu = tenThuongHieu;
            this.tenSanPham = tenSanPham;
            this.ngayNhapKho = ngayNhapKho;
            this.giaSP = giaSP;
            this.soluong = soluong;
            this.giathue = giathue;
            this.note = note;
           
        }
        public int NhapHangID { get => nhapHangID; set => nhapHangID = value; }
        public String TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public String TenThuongHieu { get => tenThuongHieu; set => tenThuongHieu = value; }
        public String TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public DateTime NgayNhapKho { get => ngayNhapKho; set => ngayNhapKho = value; }
        public int GiaSP { get => giaSP; set => giaSP = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Giathue { get => giathue; set => giathue = value; }
        public String Note { get => note; set => note = value; }
       

    }
}
