using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.DomainClass
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Sdt{ get; set; }
        public string DiaChi { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
