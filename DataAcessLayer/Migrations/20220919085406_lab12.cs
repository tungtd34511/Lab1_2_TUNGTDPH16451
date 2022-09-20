using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class lab12 : Migration
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

            migrationBuilder.AlterColumn<Guid>(
                name: "SanPhamId",
                table: "SANPHAMHOADON",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "HoaDonId",
                table: "SANPHAMHOADON",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SanPhamId",
                table: "KHOHANGSANPHAM",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "KhoHangId",
                table: "KHOHANGSANPHAM",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "KhachHangId",
                table: "HoaDon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "SanPhamId",
                table: "SANPHAMHOADON",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "HoaDonId",
                table: "SANPHAMHOADON",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SanPhamId",
                table: "KHOHANGSANPHAM",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "KhoHangId",
                table: "KHOHANGSANPHAM",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "KhachHangId",
                table: "HoaDon",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KHACHHANG_KhachHangId",
                table: "HoaDon",
                column: "KhachHangId",
                principalTable: "KHACHHANG",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KHOHANGSANPHAM_KHOHANG_KhoHangId",
                table: "KHOHANGSANPHAM",
                column: "KhoHangId",
                principalTable: "KHOHANG",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KHOHANGSANPHAM_SANPHAM_SanPhamId",
                table: "KHOHANGSANPHAM",
                column: "SanPhamId",
                principalTable: "SANPHAM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SANPHAMHOADON_HoaDon_HoaDonId",
                table: "SANPHAMHOADON",
                column: "HoaDonId",
                principalTable: "HoaDon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SANPHAMHOADON_SANPHAM_SanPhamId",
                table: "SANPHAMHOADON",
                column: "SanPhamId",
                principalTable: "SANPHAM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
