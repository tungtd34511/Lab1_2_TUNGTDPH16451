using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.DomainClass
{
     public class SanPham
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string LoaiHang { get; set; }
        public string GhiChu { get; set; }
        public virtual List<KhoHangSanPham> KhoHangSanPhams { get; set; }
        public virtual List<SanPhamHoaDon> SanPhamHoaDons { get; set; }
    }
}
