using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTermProject
{
    public class QLNgheSi
    {
        public QLNgheSi() { }
        public QLNgheSi(NgheSi ns, NhanVien nvql)
        {
            this.ns = ns;
            this.nvql = nvql;
        }
        public QLNgheSi(QLNgheSi qlns)
        {
            ns = qlns.ns;
            nvql = qlns.nvql;
        }
        public NhanVien nvql { get; set; }
        public NgheSi ns { get; set; }
    }
}
