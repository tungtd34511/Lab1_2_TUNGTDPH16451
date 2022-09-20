using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab12_New.Migrations
{
    public partial class lab11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACHHANG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KHOHANG",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHOHANG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANPHAM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KHACHHANG_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KHACHHANG",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KHOHANGSANPHAM",
                columns: table => new
                {
                    IdKhoHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHOHANGSANPHAM", x => new { x.IdKhoHang, x.IdSanPham });
                    table.ForeignKey(
                        name: "FK_KHOHANGSANPHAM_KHOHANG_IdKhoHang",
                        column: x => x.IdKhoHang,
                        principalTable: "KHOHANG",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KHOHANGSANPHAM_SANPHAM_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SANPHAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SANPHAMHOADON",
                columns: table => new
                {
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANPHAMHOADON", x => new { x.IdSanPham, x.IdHoaDon });
                    table.ForeignKey(
                        name: "FK_SANPHAMHOADON_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SANPHAMHOADON_SANPHAM_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SANPHAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_KHOHANGSANPHAM_IdSanPham",
                table: "KHOHANGSANPHAM",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMHOADON_IdHoaDon",
                table: "SANPHAMHOADON",
                column: "IdHoaDon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KHOHANGSANPHAM");

            migrationBuilder.DropTable(
                name: "SANPHAMHOADON");

            migrationBuilder.DropTable(
                name: "KHOHANG");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "KHACHHANG");
        }
    }
}
