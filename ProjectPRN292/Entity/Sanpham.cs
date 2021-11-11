using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPRN292.Entity
{
    class Sanpham
    {
        private int sanPhamID;
        private string tenSanPham;
        private string thuongHieu;
        private int gia;
        private string note;

        public Sanpham()
        {
        }

        public Sanpham(int sanPhamID, string tenSanPham, string thuongHieu, int gia, string note)
        {
            this.SanPhamID = sanPhamID;
            this.TenSanPham = tenSanPham;
            this.ThuongHieu = thuongHieu;
            this.Gia = gia;
            this.Note = note;
        }

        public int SanPhamID { get => sanPhamID; set => sanPhamID = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string ThuongHieu { get => thuongHieu; set => thuongHieu = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Note { get => note; set => note = value; }
    }
}
