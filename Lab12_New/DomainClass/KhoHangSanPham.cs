using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_New.DomainClass
{
    public class KhoHangSanPham
    {
        public Guid IdKhoHang { get; set; }
        public KhoHang KhoHang { get; set; }
        public Guid IdSanPham { get; set; }
        public SanPham SanPham { get; set; }
    }
}
