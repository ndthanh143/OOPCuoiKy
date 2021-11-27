using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class NgheSi
    {
        public string maNgheSi { get; set; }
        public string tenNgheSi { get; set; }
        public string nghedanh { get; set; }
        public int tuoi { get; set; }
        public string queQuan { get; set; }
        public string ngayRaMat { get; set; }

        public NgheSi() { }
        public NgheSi(
            string maNgheSi, string tenNgheSi, string ngheDanh, int tuoi, string queQuan, string ngayRaMat,
            ICollection<BaiNhac> dsbn_bn, ICollection<Booking> dsbk_bk, ICollection<HopDongNgheSi> dshd_hdns, QLNgheSi qlns)
        {
            this.maNgheSi = maNgheSi;
            this.tenNgheSi = tenNgheSi;
            this.nghedanh = nghedanh;
            this.tuoi = tuoi;
            this.queQuan = queQuan;
            this.ngayRaMat = ngayRaMat;
            this.dsbn_bn = dsbn_bn;
            this.dsbk_bk = dsbk_bk;
            this.dshd_hdns = dshd_hdns;
            this.qlns = qlns;
        }
        public NgheSi(NgheSi NS)
        {
            maNgheSi = NS.maNgheSi;
            tenNgheSi = NS.tenNgheSi;
            nghedanh = NS.nghedanh;
            tuoi = NS.tuoi;
            queQuan = NS.queQuan;
            ngayRaMat = NS.ngayRaMat;
            dsbn_bn = NS.dsbn_bn;
            dsbk_bk = NS.dsbk_bk;
            dshd_hdns = NS.dshd_hdns;
            qlns = NS.qlns;
        }

        public ICollection<BaiNhac> dsbn_bn { get; set; }
        public ICollection<Booking> dsbk_bk { get; set; }
        public ICollection<HopDongNgheSi> dshd_hdns { get; set; }
        public QLNgheSi qlns { get; set; }


    }
}
