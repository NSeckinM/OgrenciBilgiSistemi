using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OgrenciBilgiSistemi.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    IletisimId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kimlikler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kimlikler_Iletisimler_IletisimId",
                        column: x => x.IletisimId,
                        principalTable: "Iletisimler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MufredatDersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersId = table.Column<int>(type: "int", nullable: true),
                    MufredatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MufredatDersler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MufredatDersler_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MufredatDersler_Mufredatlar_MufredatId",
                        column: x => x.MufredatId,
                        principalTable: "Mufredatlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tur = table.Column<bool>(type: "bit", nullable: false),
                    KimlikId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Kimlikler_KimlikId",
                        column: x => x.KimlikId,
                        principalTable: "Kimlikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MufredatId = table.Column<int>(type: "int", nullable: true),
                    KimlikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Kimlikler_KimlikId",
                        column: x => x.KimlikId,
                        principalTable: "Kimlikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Mufredatlar_MufredatId",
                        column: x => x.MufredatId,
                        principalTable: "Mufredatlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DersKayitlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: true),
                    DersId = table.Column<int>(type: "int", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DersKayitlari_Ogrenciler_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "Id", "DersAdi", "DersKodu", "Durum", "Kredi" },
                values: new object[,]
                {
                    { 1, "Türk Demokrasi Tarihi", "HUM101", true, 5 },
                    { 2, "Calculus 2", "MATH102", false, 6 },
                    { 3, "Metaruljiye Giriş", "MATE103", false, 6 },
                    { 4, "Grafik dizayn", "GRA105", true, 5 },
                    { 5, "Bilgisayar Teknolojileri", "CMPE201", true, 4 },
                    { 6, "İngilizce 2", "ENG102", true, 4 },
                    { 7, "İleri Calculus", "MATH201", true, 6 }
                });

            migrationBuilder.InsertData(
                table: "Iletisimler",
                columns: new[] { "Id", "Adres", "Email", "Gsm", "Il", "Ilce" },
                values: new object[,]
                {
                    { 1, "CUMHURİYET MAH. BİRİNCİ SOK. İKİNCİ APT. NO:11/6", "abc@hotmail.com", "5332342342", "ANKARA", "YENİMAHALLE" },
                    { 2, "KUŞADASI SOK NO:123 KARAAĞAÇ", "def@gmail.com", "5437657567", "ANKARA", "ÇANKAYA" },
                    { 3, "TURAN GÜNEŞ BULVARI TAMTAM SİTESİ 13. CAD. NO:51", "ghi@abc.com", "5305464646", "ANKARA", "KEÇİÖREN" },
                    { 4, "DEMİRCİKARA MAH. B.ONAT CAD. HEDE SİT. B BLOK NO:1", "mno@xyz.com", "5555424245", "ANKARA", "PURSAKLAR" },
                    { 5, "AHMET HAMDİ SOK. NO:19/15", "prs@hotmail.com", "5302908432", "ANKARA", "SİNCAN" },
                    { 6, "SİTELER MAHALLESİ 6223 SOKAK DURU APT. NO:11 KAT:3", "klm@outlook.com", "5408932042", "ANKARA", "POLATLI" }
                });

            migrationBuilder.InsertData(
                table: "Mufredatlar",
                columns: new[] { "Id", "MufredatAdi" },
                values: new object[,]
                {
                    { 1, "BilgMuh_Mufredat" },
                    { 2, "GrafikMuh_Mufredat" },
                    { 3, "IngDilEdebiyat_Muf" }
                });

            migrationBuilder.InsertData(
                table: "Kimlikler",
                columns: new[] { "Id", "Ad", "DogumTarihi", "DogumYeri", "IletisimId", "Soyad", "TcNo" },
                values: new object[,]
                {
                    { 2, "Mehmet", "12.03.2000", "Adana", 1, "Yılmaz", "67967856634" },
                    { 6, "Fatma", "01.01.2001", "Kütahya", 2, "Korkmaz", "98423479320" },
                    { 4, "Mustafa", "21.12.2000", "Sivas", 3, "Işık", "97850348520" },
                    { 1, "Hasan", "11.10.1983", "Kayseri", 4, "Ersoy", "45456747611" },
                    { 5, "Ayşe", "04.03.2001", "Uşak", 5, "Erdoğan", "32756874239" },
                    { 3, "Ahmet", "14.06.2001", "Ankara", 6, "Ünal", "72347322958" }
                });

            migrationBuilder.InsertData(
                table: "MufredatDersler",
                columns: new[] { "Id", "DersId", "MufredatId" },
                values: new object[,]
                {
                    { 12, 4, 3 },
                    { 11, 1, 3 },
                    { 10, 7, 2 },
                    { 9, 6, 2 },
                    { 8, 4, 2 },
                    { 7, 3, 2 },
                    { 4, 7, 1 },
                    { 5, 1, 2 },
                    { 13, 5, 3 },
                    { 3, 6, 1 },
                    { 2, 5, 1 },
                    { 1, 2, 1 },
                    { 6, 2, 2 },
                    { 14, 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ogrenciler",
                columns: new[] { "Id", "KimlikId", "MufredatId", "OgrenciNo" },
                values: new object[,]
                {
                    { 4, 2, 2, "53456346" },
                    { 3, 6, 2, "34565479" },
                    { 5, 4, 3, "34674575" },
                    { 2, 5, 1, "23462368" },
                    { 1, 3, 1, "27482379" }
                });

            migrationBuilder.InsertData(
                table: "DersKayitlari",
                columns: new[] { "Id", "CreatedDate", "DersId", "OgrenciId" },
                values: new object[] { 2, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 });

            migrationBuilder.InsertData(
                table: "DersKayitlari",
                columns: new[] { "Id", "CreatedDate", "DersId", "OgrenciId" },
                values: new object[] { 1, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_KimlikId",
                table: "AspNetUsers",
                column: "KimlikId",
                unique: true,
                filter: "[KimlikId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                unique: true,
                filter: "[IletisimId] IS NOT NULL");

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
                unique: true,
                filter: "[KimlikId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_MufredatId",
                table: "Ogrenciler",
                column: "MufredatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DersKayitlari");

            migrationBuilder.DropTable(
                name: "MufredatDersler");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
