using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.DomainClass
{
    public class SanPhamHoaDon
    {
        public Guid IdSanPham { get; set; }
        public virtual SanPham SanPham { get; set; }
        public Guid IdHoaDon { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
