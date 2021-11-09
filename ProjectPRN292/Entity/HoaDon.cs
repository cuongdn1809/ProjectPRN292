using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPRN292.Entity
{
    class HoaDon
    {
        private DateTime ngayNhapHang;
        private DateTime ngayXuatHang;
        private int giaThue;
        private int tongTien;
        private int khachHangId;
        private int sanPhamId;

        public HoaDon()
        {
        }

        public HoaDon(DateTime ngayNhapHang, DateTime ngayXuatHang, int giaThue, int tongTien, int khachHangId, int sanPhamId)
        {
            this.ngayNhapHang = ngayNhapHang;
            this.ngayXuatHang = ngayXuatHang;
            this.giaThue = giaThue;
            this.tongTien = tongTien;
            this.khachHangId = khachHangId;
            this.sanPhamId = sanPhamId;
        }

        public DateTime NgayNhapHang { get => ngayNhapHang; set => ngayNhapHang = value; }
        public DateTime NgayXuatHang { get => ngayXuatHang; set => ngayXuatHang = value; }
        public int GiaThue { get => giaThue; set => giaThue = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int KhachHangId { get => khachHangId; set => khachHangId = value; }
        public int SanPhamId { get => sanPhamId; set => sanPhamId = value; }

    }
}
