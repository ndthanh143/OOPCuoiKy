using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class HopDongNgheSi
    {
        public int maHopDong { get; set; }
        public string ngayBatDau { get; set; }
        public string ngayKetThuc { get; set; }
        public int giaTriHopDong { get; set; }
        public HopDongNgheSi() { }
        public HopDongNgheSi(int maHopDong, string ngayBatDau, string ngayKetThuc, int giaTriHopDong, NgheSi ns)
        {
            this.maHopDong = maHopDong;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.giaTriHopDong = giaTriHopDong;
            this.ns = ns;
        }

        public HopDongNgheSi(HopDongNgheSi hdns)
        {
            maHopDong = hdns.maHopDong;
            ngayBatDau = hdns.ngayBatDau;
            ngayKetThuc = hdns.ngayKetThuc;
            giaTriHopDong = hdns.giaTriHopDong;
            ns = ns;
        }
        public NgheSi ns { get; set; }
    }
}
