using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.DomainClass
{
    public class KhoHangSanPham
    {
        public Guid IdKhoHang { get; set; }
        public virtual KhoHang KhoHang { get; set; }
        public Guid IdSanPham { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
