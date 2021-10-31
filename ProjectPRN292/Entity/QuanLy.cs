using ProjectPRN292.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectPRN292.Entity
{
    class QuanLy
    {
        private string tenquanly;
        private string matkhau;

        public QuanLy()
        {
        }

        public QuanLy(string tenquanly, string matkhau)
        {
            Tenquanly = tenquanly;
            Matkhau = matkhau;
        }

        public string Tenquanly { get => tenquanly; set => tenquanly = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }

    }
}
