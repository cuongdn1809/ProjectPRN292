using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPRN292.Entity
{
    class Sanpham
    {
        private int sanPhamID;
        private string thuongHieu;
        private string tenSanPham;
        private int gia;
        private string note;

        public Sanpham()
        {
        }

        public Sanpham(int sanPhamID, string thuongHieu, string tenSanPham, int gia, string note)
        {
            this.SanPhamID = sanPhamID;
            this.ThuongHieu = thuongHieu;
            this.TenSanPham = tenSanPham;
            this.Gia = gia;
            this.Note = note;
        }

        public int SanPhamID { get => sanPhamID; set => sanPhamID = value; }     
        public string ThuongHieu { get => thuongHieu; set => thuongHieu = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Note { get => note; set => note = value; }
    }
}
