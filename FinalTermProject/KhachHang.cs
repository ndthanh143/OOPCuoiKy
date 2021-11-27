using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class KhachHang
    {
        public string maKH { get; set; }
        public string hoTenKH { get; set; }
        public string mail { get; set; }
        public string soDT { get; set; }
        public KhachHang() { }
        public KhachHang(string MaKH, string HoTenKH, string mail, string SoDT, ICollection<Booking> dsbk_bk)
        {
            this.maKH = MaKH;
            this.hoTenKH = HoTenKH;
            this.mail = mail;
            this.soDT = SoDT;
            this.dsbk_bk = dsbk_bk;
        }
        public KhachHang(KhachHang kh)
        {
            maKH = kh.maKH;
            hoTenKH = kh.hoTenKH;
            mail = kh.mail;
            soDT = kh.soDT;
            dsbk_bk = kh.dsbk_bk;
        }
  
        public ICollection<Booking> dsbk_bk { get; set; }
    }
}
