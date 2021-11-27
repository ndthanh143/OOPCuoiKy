using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class BoPhanCongTy
    {
        public int maBoPhan { get; set; }
        public string tenBoPhan { get; set; }
        public BoPhanCongTy() { }
        public BoPhanCongTy(int maBoPhan, string tenBoPhan,ICollection<NhanVien> dsnv_nv)
        {
            this.maBoPhan = maBoPhan;
            this.tenBoPhan = tenBoPhan;
            this.dsnv_nv = dsnv_nv;
        }

        public BoPhanCongTy(BoPhanCongTy bpct)
        {
            maBoPhan = bpct.maBoPhan;
            tenBoPhan = bpct.tenBoPhan;
            dsnv_nv = bpct.dsnv_nv;
        }
        public ICollection<NhanVien> dsnv_nv { get; set; }

    }
}
