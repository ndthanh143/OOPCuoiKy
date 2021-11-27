using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class NhanVien
    {
        public int maNhanVien { get; set; }
        public string tenNhanVien { get; set; }
        public int tuoi { get; set; }
        public string diaChi { get; set; }
        public string phai { get; set; }
        public int luong { get; set; }
        public NhanVien() { }
        public NhanVien(int maNhanVien, string tenNhanVien, int tuoi, string diaChi,string phai, int luong, 
            BoPhanCongTy boPhan, QLNgheSi qlns)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.tuoi = tuoi;
            this.diaChi = diaChi;
            this.phai = phai;
            this.luong = luong;
            this.boPhan = boPhan;
            this.qlns = qlns;
        }

        public NhanVien(NhanVien nv)
        {
            maNhanVien = nv.maNhanVien;
            tenNhanVien = nv.tenNhanVien;
            tuoi = nv.tuoi;
            diaChi = nv.diaChi;
            phai = nv.phai;
            luong = nv.luong;
            boPhan = nv.boPhan;
            qlns = nv.qlns;
        }
        public BoPhanCongTy boPhan { get; set; }
        public QLNgheSi qlns { get; set; }
    }
}
