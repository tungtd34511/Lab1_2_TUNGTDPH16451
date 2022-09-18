using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.DomainClass
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayNhan { get; set; }
        public DateTime? NgayShip { get; set; }
        public decimal TongTien { get; set; }
        public Guid IdKhachHang { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual List<SanPhamHoaDon> SanPhamHoaDons { get; set; }
    }
}
