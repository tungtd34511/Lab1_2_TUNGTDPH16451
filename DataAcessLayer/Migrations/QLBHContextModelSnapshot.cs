// <auto-generated />
using System;
using DataAcessLayer.NewFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAcessLayer.Migrations
{
    [DbContext(typeof(QLBHContext))]
    partial class QLBHContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAcessLayer.DomainClass.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayNhan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayShip")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KHACHHANG");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.KhoHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiQuanLy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KHOHANG");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.KhoHangSanPham", b =>
                {
                    b.Property<Guid>("IdKhoHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdKhoHang", "IdSanPham");

                    b.HasIndex("IdSanPham");

                    b.ToTable("KHOHANGSANPHAM");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SANPHAM");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.SanPhamHoaDon", b =>
                {
                    b.Property<Guid>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdSanPham", "IdHoaDon");

                    b.HasIndex("IdHoaDon");

                    b.ToTable("SANPHAMHOADON");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.HoaDon", b =>
                {
                    b.HasOne("DataAcessLayer.DomainClass.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.KhoHangSanPham", b =>
                {
                    b.HasOne("DataAcessLayer.DomainClass.KhoHang", "KhoHang")
                        .WithMany("KhoHangSanPhams")
                        .HasForeignKey("IdKhoHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAcessLayer.DomainClass.SanPham", "SanPham")
                        .WithMany("KhoHangSanPhams")
                        .HasForeignKey("IdSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhoHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.SanPhamHoaDon", b =>
                {
                    b.HasOne("DataAcessLayer.DomainClass.HoaDon", "HoaDon")
                        .WithMany("SanPhamHoaDons")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAcessLayer.DomainClass.SanPham", "SanPham")
                        .WithMany("SanPhamHoaDons")
                        .HasForeignKey("IdSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.HoaDon", b =>
                {
                    b.Navigation("SanPhamHoaDons");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.KhoHang", b =>
                {
                    b.Navigation("KhoHangSanPhams");
                });

            modelBuilder.Entity("DataAcessLayer.DomainClass.SanPham", b =>
                {
                    b.Navigation("KhoHangSanPhams");

                    b.Navigation("SanPhamHoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
