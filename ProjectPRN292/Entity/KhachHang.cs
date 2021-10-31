using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPRN292.Entity
{
    class KhachHang
    {
        private int khachhangid;
        private string tenkhachhang;
        private string diachi;
        private string sdt;

        public KhachHang()
        {
        }

        public KhachHang(int khachhangid, string tenkhachhang, string diachi, string sdt)
        {
            Khachhangid = khachhangid;
            Tenkhachhang = tenkhachhang;
            Diachi = diachi;
            Sdt = sdt;
        }

        public int Khachhangid { get => khachhangid; set => khachhangid = value; }
        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
