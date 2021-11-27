using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class DiaDiemBieuDien
    {
        public string maDiaDiem { get; set; }
        public string diaChi { get; set; }
        public string tenDiaDiem { get; set; }
        public int sucChua { get; set; }

        //constructors
        public DiaDiemBieuDien() { }
        public DiaDiemBieuDien(string MaDiaDiem, string DiaChi,
            string TenDiaDiem, int SucChua, ICollection<Booking> dsbk_bk)
        {
            this.maDiaDiem = MaDiaDiem;
            this.diaChi = DiaChi;
            this.tenDiaDiem = TenDiaDiem;
            this.sucChua = SucChua;
            this.dsbk_bk = dsbk_bk;
        }
        public DiaDiemBieuDien(DiaDiemBieuDien ddbd)
        {
            maDiaDiem = ddbd.maDiaDiem;
            diaChi = ddbd.diaChi;
            tenDiaDiem = ddbd.tenDiaDiem;
            sucChua = ddbd.sucChua;
            dsbk_bk = ddbd.dsbk_bk;
        }
        public ICollection<Booking> dsbk_bk { get; set; }
    }
}
