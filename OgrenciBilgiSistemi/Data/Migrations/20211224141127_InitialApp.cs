using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OgrenciBilgiSistemi.Data.Migrations
{
    public partial class InitialApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Kredi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iletisimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mufredatlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MufredatAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mufredatlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kimlikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumYeri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kimlikler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kimlikler_Iletisimler_IletisimId",
                        column: x => x.IletisimId,
                        principalTable: "Iletisimler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MufredatDersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    MufredatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MufredatDersler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MufredatDersler_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MufredatDersler_Mufredatlar_MufredatId",
                        column: x => x.MufredatId,
                        principalTable: "Mufredatlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KimlikId = table.Column<int>(type: "int", nullable: false),
                    MufredatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Kimlikler_KimlikId",
                        column: x => x.KimlikId,
                        principalTable: "Kimlikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Mufredatlar_MufredatId",
                        column: x => x.MufredatId,
                        principalTable: "Mufredatlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DersKayitlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersKayitlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DersKayitlari_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersKayitlari_Ogrenciler_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DersKayitlari_DersId",
                table: "DersKayitlari",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_DersKayitlari_OgrenciId",
                table: "DersKayitlari",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kimlikler_IletisimId",
                table: "Kimlikler",
                column: "IletisimId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MufredatDersler_DersId",
                table: "MufredatDersler",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_MufredatDersler_MufredatId",
                table: "MufredatDersler",
                column: "MufredatId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_KimlikId",
                table: "Ogrenciler",
                column: "KimlikId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_MufredatId",
                table: "Ogrenciler",
                column: "MufredatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersKayitlari");

            migrationBuilder.DropTable(
                name: "MufredatDersler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Kimlikler");

            migrationBuilder.DropTable(
                name: "Mufredatlar");

            migrationBuilder.DropTable(
                name: "Iletisimler");
        }
    }
}
