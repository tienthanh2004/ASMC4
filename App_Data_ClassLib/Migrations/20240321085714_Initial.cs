using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App_Data_ClassLib.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    MaSale = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSale = table.Column<string>(type: "Nvarchar(max)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayketThuc = table.Column<DateTime>(type: "DateTime", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaTri = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.MaSale);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    IDSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "Nvarchar(max)", nullable: false),
                    GiaSP = table.Column<double>(type: "float", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.IDSP);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNguoiDung = table.Column<string>(type: "Nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "Nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    DiaChi = table.Column<string>(type: "Nvarchar(max)", nullable: false),
                    ChucVu = table.Column<string>(type: "Nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Vouncher",
                columns: table => new
                {
                    IDVouncher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenVouncher = table.Column<string>(type: "Nvarchar(max)", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    GiaTri = table.Column<double>(type: "float", nullable: false),
                    DieuKien = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouncher", x => x.IDVouncher);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamChiTiet",
                columns: table => new
                {
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSPCT = table.Column<string>(type: "Nvarchar(max)", nullable: false),
                    GiaSP = table.Column<double>(type: "float", nullable: false),
                    LoaiSP = table.Column<string>(type: "Nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MaSale = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamChiTiet", x => x.IDSPCT);
                    table.ForeignKey(
                        name: "FK_Sales_Users",
                        column: x => x.MaSale,
                        principalTable: "Sale",
                        principalColumn: "MaSale",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_SanPhamChiTiet",
                        column: x => x.IDSP,
                        principalTable: "SanPham",
                        principalColumn: "IDSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuongSP = table.Column<int>(type: "int", nullable: false),
                    GiaSanPham = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_GioHang_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    IDHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiaChi = table.Column<string>(type: "Nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false),
                    ThoiGianThanhToan = table.Column<DateTime>(type: "DateTime", nullable: false),
                    IDVouncher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IDPTTT = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.IDHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vouncher_HDs",
                        column: x => x.IDVouncher,
                        principalTable: "Vouncher",
                        principalColumn: "IDVouncher",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiet",
                columns: table => new
                {
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiet", x => x.IDUser);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_GioHang_IDUser",
                        column: x => x.IDUser,
                        principalTable: "GioHang",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_GioHangChiTiet",
                        column: x => x.IDSPCT,
                        principalTable: "SanPhamChiTiet",
                        principalColumn: "IDSPCT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    IDHDCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiaSP = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    IDHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSPCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.IDHDCT);
                    table.ForeignKey(
                        name: "FK_HoaDons_HDCTS",
                        column: x => x.IDHD,
                        principalTable: "HoaDon",
                        principalColumn: "IDHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_HDCT",
                        column: x => x.IDSPCT,
                        principalTable: "SanPhamChiTiet",
                        principalColumn: "IDSPCT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    IDPTTT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenPhuongThuc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongThucThanhToan", x => x.IDPTTT);
                    table.ForeignKey(
                        name: "FK_PTTT_HoaDons",
                        column: x => x.IDPTTT,
                        principalTable: "HoaDon",
                        principalColumn: "IDHD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IDSPCT",
                table: "GioHangChiTiet",
                column: "IDSPCT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDVouncher",
                table: "HoaDon",
                column: "IDVouncher");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_UserID",
                table: "HoaDon",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IDHD",
                table: "HoaDonChiTiet",
                column: "IDHD");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IDSPCT",
                table: "HoaDonChiTiet",
                column: "IDSPCT");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IDSP",
                table: "SanPhamChiTiet",
                column: "IDSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_MaSale",
                table: "SanPhamChiTiet",
                column: "MaSale");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "SanPhamChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Vouncher");
        }
    }
}
