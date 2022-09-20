using Lab12_New.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_New.DatabaseContext
{
    public class Lab12Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=TUNGHACK\\SQLEXPRESS;Initial Catalog=Lab1_22" +
                    ";Integrated Security=True");
            }
        }
        public DbSet<KhoHang> KhoHangs { get; set; }
        public DbSet<KhoHangSanPham> KhoHangSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonSanPham> hoaDonSanPhams { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
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
                ToTable("HoaDon")
                .HasKey(b => b.Id);

            builder.Entity<KhoHangSanPham>().
                ToTable("KHOHANGSANPHAM")
                .HasKey(b => new { b.IdKhoHang, b.IdSanPham });
            //
            builder.Entity<HoaDonSanPham>().
                ToTable("SANPHAMHOADON")
                .HasKey(b => new { b.IdSanPham, b.IdHoaDon });
            //
            builder.Entity<KhoHangSanPham>().HasOne<KhoHang>(b=>b.KhoHang)
            .WithMany(b=>b.KhoHangSanPhams)
            .HasForeignKey(b=>b.IdKhoHang).IsRequired();
            builder.Entity<KhoHangSanPham>().HasOne<SanPham>(b => b.SanPham)
            .WithMany(b => b.KhoHangSanPhams)
            .HasForeignKey(b => b.IdSanPham).IsRequired();
            builder.Entity<HoaDonSanPham>().HasOne<SanPham>(b => b.SanPham)
            .WithMany(b => b.HoaDonSanPhams)
            .HasForeignKey(b => b.IdSanPham).IsRequired();
            builder.Entity<HoaDonSanPham>().HasOne<HoaDon>(b => b.HoaDon)
            .WithMany(b => b.HoaDonSanPhams)
            .HasForeignKey(b => b.IdHoaDon).IsRequired();
            builder.Entity<HoaDon>().HasOne<KhachHang>(b => b.KhachHang)
            .WithMany(b => b.HoaDons)
            .HasForeignKey(b => b.IdKhachHang).IsRequired();
        }
    }
}
