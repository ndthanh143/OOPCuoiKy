using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class TheLoaiNhac
    {
        public string maTheLoai { get; set; }
        public string tenTheLoai { get; set; }
        public TheLoaiNhac() { }
        public TheLoaiNhac(string maTheLoai, string tenTheLoai, ICollection<BaiNhac> dsbn_bn)
        {
            this.maTheLoai = maTheLoai;
            this.tenTheLoai = tenTheLoai;
            this.dsbn_bn = dsbn_bn;
        }
        public TheLoaiNhac(TheLoaiNhac TLNhac)
        {
            maTheLoai = TLNhac.maTheLoai;
            tenTheLoai = TLNhac.tenTheLoai;
            dsbn_bn = TLNhac.dsbn_bn;
        }

        public ICollection<BaiNhac> dsbn_bn { get; set; }
    }
}
