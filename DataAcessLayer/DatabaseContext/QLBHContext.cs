using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer.NewFolder
{
    public class QLBHContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=TUNGHACK\\SQLEXPRESS;Initial Catalog=Lab1_3" +
                    ";Integrated Security=True");
                //"Data Source= Ten server;Initial Catalog= ten-database;câu hình kết nối"
            }
        }
        public DbSet<KhoHang> KhoHangs { get; set; }
        public DbSet<KhoHangSanPham> KhoHangSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<SanPhamHoaDon> SanPhamHoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            //kết nối để ở cuối
            builder.Entity<KhoHang>().
                HasMany<KhoHangSanPham>(b => b.KhoHangSanPhams).WithOne(c => c.KhoHang).HasForeignKey(s => s.IdKhoHang);
            builder.Entity<SanPham>().
                HasMany<KhoHangSanPham>(b => b.KhoHangSanPhams).WithOne(c => c.SanPham).HasForeignKey(s => s.IdSanPham); 
            builder.Entity<SanPham>().
                HasMany<SanPhamHoaDon>(b => b.SanPhamHoaDons).WithOne(c=>c.SanPham).HasForeignKey(s => s.IdSanPham);
            builder.Entity<HoaDon>().
                HasMany<SanPhamHoaDon>(b => b.SanPhamHoaDons).WithOne(c=>c.HoaDon).HasForeignKey(s => s.IdHoaDon);
            builder.Entity<HoaDon>().
                HasOne<KhachHang>(c => c.KhachHang).WithMany(c=>c.HoaDons).HasForeignKey(s => s.IdKhachHang);
            //
            //
            // theo đúng thứ tự
            builder.Entity<KhachHang>().
                ToTable("KHACHHANG")
                .HasKey(b => b.Id);
            //
            builder.Entity<KhoHang>().
                ToTable("KHOHANG")
                .HasKey(b => b.Id);
            //
            builder.Entity<SanPham>().
                ToTable("SANPHAM")
                .HasKey(b => b.Id);
            //
            builder.Entity<HoaDon>().
                ToTable("HoaDon")//sai t
                .HasKey(b => b.Id);

            builder.Entity<KhoHangSanPham>().
                ToTable("KHOHANGSANPHAM")
                .HasKey(b => new { b.IdKhoHang, b.IdSanPham });
            //
            builder.Entity<SanPhamHoaDon>().
                ToTable("SANPHAMHOADON")
                .HasKey(b => new { b.IdSanPham, b.IdHoaDon });

        }
    }
}
