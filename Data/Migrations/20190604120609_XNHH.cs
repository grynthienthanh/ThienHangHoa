using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XNHH.Data.Migrations
{
    public partial class XNHH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HD_NHAP",
                columns: table => new
                {
                    MaHDN = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaNCC = table.Column<int>(nullable: false),
                    SoHDNhap = table.Column<int>(nullable: true),
                    Ngay = table.Column<DateTime>(nullable: true),
                    TongTienNhap = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HD_NHAP", x => x.MaHDN);
                });

            migrationBuilder.CreateTable(
                name: "KHACH_HANG",
                columns: table => new
                {
                    MaKH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenKH = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(maxLength: 20, nullable: true),
                    DiaChi = table.Column<string>(maxLength: 100, nullable: true),
                    TienNo = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACH_HANG", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "MAT_HANG",
                columns: table => new
                {
                    MaMH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenMH = table.Column<string>(maxLength: 70, nullable: true),
                    SoLuongTon = table.Column<int>(nullable: true),
                    DonGiaXuat = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MAT_HANG", x => x.MaMH);
                });

            migrationBuilder.CreateTable(
                name: "NHA_CUNG_CAP",
                columns: table => new
                {
                    MaNCC = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenNCC = table.Column<string>(maxLength: 200, nullable: true),
                    DiaChi = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHA_CUNG_CAP", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "BAO_CAO_CONG_NO",
                columns: table => new
                {
                    MaBCN = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Thang = table.Column<DateTime>(nullable: false),
                    MaKH = table.Column<int>(nullable: false),
                    NoDau = table.Column<int>(nullable: true),
                    NoCuoi = table.Column<int>(nullable: true),
                    PhatSinh = table.Column<int>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAO_CAO_CONG_NO", x => x.MaBCN);
                    table.ForeignKey(
                        name: "FK_BAO_CAO_CONG_NO_KHACH_HANG_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KHACH_HANG",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HD_XUAT",
                columns: table => new
                {
                    MaHDX = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaKH = table.Column<int>(nullable: false),
                    SoHDX = table.Column<int>(nullable: false),
                    Ngay = table.Column<DateTime>(nullable: false),
                    TongTien = table.Column<int>(nullable: true),
                    PhiVanCHuyen = table.Column<int>(nullable: true),
                    TongCong = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HD_XUAT", x => x.MaHDX);
                    table.ForeignKey(
                        name: "FK_HD_XUAT_KHACH_HANG_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KHACH_HANG",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PHIEU_THU_TIEN",
                columns: table => new
                {
                    MaPTT = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaKH = table.Column<int>(nullable: false),
                    SoTienThu = table.Column<int>(nullable: false),
                    NgayThuTien = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHIEU_THU_TIEN", x => x.MaPTT);
                    table.ForeignKey(
                        name: "FK_PHIEU_THU_TIEN_KHACH_HANG_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KHACH_HANG",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CT_DH_NHAP",
                columns: table => new
                {
                    MaCTHDN = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaHDN = table.Column<int>(nullable: false),
                    MaMH = table.Column<int>(nullable: false),
                    SoLuongNhap = table.Column<int>(nullable: true),
                    ThanhTien = table.Column<int>(nullable: true),
                    MaHD = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_DH_NHAP", x => x.MaCTHDN);
                    table.ForeignKey(
                        name: "FK_CT_DH_NHAP_HD_NHAP_MaHD",
                        column: x => x.MaHD,
                        principalTable: "HD_NHAP",
                        principalColumn: "MaHDN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CT_DH_NHAP_MAT_HANG_MaMH",
                        column: x => x.MaMH,
                        principalTable: "MAT_HANG",
                        principalColumn: "MaMH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BAO_CAO_TON",
                columns: table => new
                {
                    MaBCTon = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Thang = table.Column<DateTime>(nullable: false),
                    MaMH = table.Column<int>(nullable: false),
                    MANCC = table.Column<int>(nullable: false),
                    TonDau = table.Column<int>(nullable: true),
                    TonCuoi = table.Column<int>(nullable: true),
                    PhatSinh = table.Column<int>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAO_CAO_TON", x => x.MaBCTon);
                    table.ForeignKey(
                        name: "FK_BAO_CAO_TON_NHA_CUNG_CAP_MANCC",
                        column: x => x.MANCC,
                        principalTable: "NHA_CUNG_CAP",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BAO_CAO_TON_MAT_HANG_MaMH",
                        column: x => x.MaMH,
                        principalTable: "MAT_HANG",
                        principalColumn: "MaMH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NCC_HANG_NHAP",
                columns: table => new
                {
                    MaNCCHangNhap = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaMH = table.Column<int>(nullable: false),
                    MaNCC = table.Column<int>(maxLength: 5, nullable: false),
                    SoLuongTon = table.Column<int>(nullable: true),
                    DonGiaNhap = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCC_HANG_NHAP", x => x.MaNCCHangNhap);
                    table.ForeignKey(
                        name: "FK_NCC_HANG_NHAP_MAT_HANG_MaMH",
                        column: x => x.MaMH,
                        principalTable: "MAT_HANG",
                        principalColumn: "MaMH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NCC_HANG_NHAP_NHA_CUNG_CAP_MaNCC",
                        column: x => x.MaNCC,
                        principalTable: "NHA_CUNG_CAP",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CT_HD_XUAT",
                columns: table => new
                {
                    MaCTHDX = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaHDX = table.Column<int>(nullable: false),
                    MaMH = table.Column<int>(nullable: false),
                    SoLuongXuat = table.Column<int>(nullable: true),
                    ThanhTien = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_HD_XUAT", x => x.MaCTHDX);
                    table.ForeignKey(
                        name: "FK_CT_HD_XUAT_HD_XUAT_MaHDX",
                        column: x => x.MaHDX,
                        principalTable: "HD_XUAT",
                        principalColumn: "MaHDX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CT_HD_XUAT_MAT_HANG_MaMH",
                        column: x => x.MaMH,
                        principalTable: "MAT_HANG",
                        principalColumn: "MaMH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BAO_CAO_CONG_NO_MaKH",
                table: "BAO_CAO_CONG_NO",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_BAO_CAO_TON_MANCC",
                table: "BAO_CAO_TON",
                column: "MANCC");

            migrationBuilder.CreateIndex(
                name: "IX_BAO_CAO_TON_MaMH",
                table: "BAO_CAO_TON",
                column: "MaMH");

            migrationBuilder.CreateIndex(
                name: "IX_CT_DH_NHAP_MaHD",
                table: "CT_DH_NHAP",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_CT_DH_NHAP_MaMH",
                table: "CT_DH_NHAP",
                column: "MaMH");

            migrationBuilder.CreateIndex(
                name: "IX_CT_HD_XUAT_MaHDX",
                table: "CT_HD_XUAT",
                column: "MaHDX");

            migrationBuilder.CreateIndex(
                name: "IX_CT_HD_XUAT_MaMH",
                table: "CT_HD_XUAT",
                column: "MaMH");

            migrationBuilder.CreateIndex(
                name: "IX_HD_XUAT_MaKH",
                table: "HD_XUAT",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_NCC_HANG_NHAP_MaMH",
                table: "NCC_HANG_NHAP",
                column: "MaMH");

            migrationBuilder.CreateIndex(
                name: "IX_NCC_HANG_NHAP_MaNCC",
                table: "NCC_HANG_NHAP",
                column: "MaNCC");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEU_THU_TIEN_MaKH",
                table: "PHIEU_THU_TIEN",
                column: "MaKH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BAO_CAO_CONG_NO");

            migrationBuilder.DropTable(
                name: "BAO_CAO_TON");

            migrationBuilder.DropTable(
                name: "CT_DH_NHAP");

            migrationBuilder.DropTable(
                name: "CT_HD_XUAT");

            migrationBuilder.DropTable(
                name: "NCC_HANG_NHAP");

            migrationBuilder.DropTable(
                name: "PHIEU_THU_TIEN");

            migrationBuilder.DropTable(
                name: "HD_NHAP");

            migrationBuilder.DropTable(
                name: "HD_XUAT");

            migrationBuilder.DropTable(
                name: "MAT_HANG");

            migrationBuilder.DropTable(
                name: "NHA_CUNG_CAP");

            migrationBuilder.DropTable(
                name: "KHACH_HANG");
        }
    }
}
