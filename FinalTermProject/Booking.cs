using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class Booking
    {
        public string MaBook { get; set; }
        public string TenSuKien { get; set; }
        public string NgayBieuDien { get; set; }
        public Booking() { }
        public Booking(Booking bk)
        {
            MaBook = bk.MaBook;
            TenSuKien = bk.TenSuKien;
            NgayBieuDien = bk.NgayBieuDien;
            ns = bk.ns;
            ddbd = bk.ddbd;
            kh = bk.kh;
        }
        public Booking(string MaBook, string TenSuKien, string NgayBieuDien, NgheSi ns,
             DiaDiemBieuDien ddbd, KhachHang kh)
        {
            this.MaBook = MaBook;
            this.TenSuKien = TenSuKien;
            this.NgayBieuDien = NgayBieuDien;
            this.ns = ns;
            this.ddbd = ddbd;
            this.kh = kh;
        }
        public DiaDiemBieuDien ddbd { get; set; }
        public KhachHang kh { get; set; }
        public NgheSi ns { get; set; }
    }
}
