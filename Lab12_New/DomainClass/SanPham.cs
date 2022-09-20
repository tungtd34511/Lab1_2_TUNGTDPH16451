using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_New.DomainClass
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public virtual List<KhoHangSanPham> KhoHangSanPhams { get; set; }
        public virtual List<HoaDonSanPham> HoaDonSanPhams { get; set; }
    }
}
