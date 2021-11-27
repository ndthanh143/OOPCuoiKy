using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class BaiNhac
    {
        public string maBaiNhac { get; set; }
        public string tenBaiNhac { get; set; }
        public BaiNhac() { }
        public BaiNhac(string maBaiNhac, string tenBaiNhac, TheLoaiNhac TLN, NgheSi ngsi)
        {
            this.maBaiNhac = maBaiNhac;
            this.tenBaiNhac = tenBaiNhac;
            this.TLN = TLN;
            this.ngsi = ngsi;
        }
        public BaiNhac(BaiNhac bn)
        {
            maBaiNhac = bn.maBaiNhac;
            tenBaiNhac = bn.tenBaiNhac;
            TLN = bn.TLN;
            ngsi = bn.ngsi;
        }
        public NgheSi ngsi { get; set; }
        public TheLoaiNhac TLN { get; set; }
    }
}
