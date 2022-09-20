using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class qlbh2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KHACHHANG_KhachHangId",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_KHOHANGSANPHAM_KHOHANG_KhoHangId",
                table: "KHOHANGSANPHAM");

            migrationBuilder.DropForeignKey(
                name: "FK_KHOHANGSANPHAM_SANPHAM_SanPhamId",
                table: "KHOHANGSANPHAM");

            migrationBuilder.DropForeignKey(
                name: "FK_SANPHAMHOADON_HoaDon_HoaDonId",
                table: "SANPHAMHOADON");

            migrationBuilder.DropForeignKey(
                name: "FK_SANPHAMHOADON_SANPHAM_SanPhamId",
                table: "SANPHAMHOADON");

            migrationBuilder.DropIndex(
                name: "IX_SANPHAMHOADON_HoaDonId",
                table: "SANPHAMHOADON");

            migrationBuilder.DropIndex(
                name: "IX_SANPHAMHOADON_SanPhamId",
                table: "SANPHAMHOADON");

            migrationBuilder.DropIndex(
                name: "IX_KHOHANGSANPHAM_KhoHangId",
                table: "KHOHANGSANPHAM");

            migrationBuilder.DropIndex(
                name: "IX_KHOHANGSANPHAM_SanPhamId",
                table: "KHOHANGSANPHAM");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_KhachHangId",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "HoaDonId",
                table: "SANPHAMHOADON");

            migrationBuilder.DropColumn(
                name: "SanPhamId",
                table: "SANPHAMHOADON");

            migrationBuilder.DropColumn(
                name: "KhoHangId",
                table: "KHOHANGSANPHAM");

            migrationBuilder.DropColumn(
                name: "SanPhamId",
                table: "KHOHANGSANPHAM");

            migrationBuilder.DropColumn(
                name: "KhachHangId",
                table: "HoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMHOADON_IdHoaDon",
                table: "SANPHAMHOADON",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_KHOHANGSANPHAM_IdSanPham",
                table: "KHOHANGSANPHAM",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KHACHHANG_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang",
                principalTable: "KHACHHANG",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KHOHANGSANPHAM_KHOHANG_IdKhoHang",
                table: "KHOHANGSANPHAM",
                column: "IdKhoHang",
                principalTable: "KHOHANG",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KHOHANGSANPHAM_SANPHAM_IdSanPham",
                table: "KHOHANGSANPHAM",
                column: "IdSanPham",
                principalTable: "SANPHAM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SANPHAMHOADON_HoaDon_IdHoaDon",
                table: "SANPHAMHOADON",
                column: "IdHoaDon",
                principalTable: "HoaDon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SANPHAMHOADON_SANPHAM_IdSanPham",
                table: "SANPHAMHOADON",
                column: "IdSanPham",
                principalTable: "SANPHAM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KHACHHANG_IdKhachHang",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_KHOHANGSANPHAM_KHOHANG_IdKhoHang",
                table: "KHOHANGSANPHAM");

            migrationBuilder.DropForeignKey(
                name: "FK_KHOHANGSANPHAM_SANPHAM_IdSanPham",
                table: "KHOHANGSANPHAM");

            migrationBuilder.DropForeignKey(
                name: "FK_SANPHAMHOADON_HoaDon_IdHoaDon",
                table: "SANPHAMHOADON");

            migrationBuilder.DropForeignKey(
                name: "FK_SANPHAMHOADON_SANPHAM_IdSanPham",
                table: "SANPHAMHOADON");

            migrationBuilder.DropIndex(
                name: "IX_SANPHAMHOADON_IdHoaDon",
                table: "SANPHAMHOADON");

            migrationBuilder.DropIndex(
                name: "IX_KHOHANGSANPHAM_IdSanPham",
                table: "KHOHANGSANPHAM");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon");

            migrationBuilder.AddColumn<Guid>(
                name: "HoaDonId",
                table: "SANPHAMHOADON",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SanPhamId",
                table: "SANPHAMHOADON",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "KhoHangId",
                table: "KHOHANGSANPHAM",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SanPhamId",
                table: "KHOHANGSANPHAM",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "KhachHangId",
                table: "HoaDon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMHOADON_HoaDonId",
                table: "SANPHAMHOADON",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMHOADON_SanPhamId",
                table: "SANPHAMHOADON",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_KHOHANGSANPHAM_KhoHangId",
                table: "KHOHANGSANPHAM",
                column: "KhoHangId");

            migrationBuilder.CreateIndex(
                name: "IX_KHOHANGSANPHAM_SanPhamId",
                table: "KHOHANGSANPHAM",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangId",
                table: "HoaDon",
                column: "KhachHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KHACHHANG_KhachHangId",
                table: "HoaDon",
                column: "KhachHangId",
                principalTable: "KHACHHANG",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KHOHANGSANPHAM_KHOHANG_KhoHangId",
                table: "KHOHANGSANPHAM",
                column: "KhoHangId",
                principalTable: "KHOHANG",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KHOHANGSANPHAM_SANPHAM_SanPhamId",
                table: "KHOHANGSANPHAM",
                column: "SanPhamId",
                principalTable: "SANPHAM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SANPHAMHOADON_HoaDon_HoaDonId",
                table: "SANPHAMHOADON",
                column: "HoaDonId",
                principalTable: "HoaDon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SANPHAMHOADON_SANPHAM_SanPhamId",
                table: "SANPHAMHOADON",
                column: "SanPhamId",
                principalTable: "SANPHAM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
