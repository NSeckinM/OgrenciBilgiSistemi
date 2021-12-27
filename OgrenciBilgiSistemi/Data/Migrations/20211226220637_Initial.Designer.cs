﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OgrenciBilgiSistemi.Data;

namespace OgrenciBilgiSistemi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211226220637_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Ders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DersAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersKodu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("Kredi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dersler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DersAdi = "Türk Demokrasi Tarihi",
                            DersKodu = "HUM101",
                            Durum = true,
                            Kredi = 5
                        },
                        new
                        {
                            Id = 2,
                            DersAdi = "Calculus 2",
                            DersKodu = "MATH102",
                            Durum = false,
                            Kredi = 6
                        },
                        new
                        {
                            Id = 3,
                            DersAdi = "Metaruljiye Giriş",
                            DersKodu = "MATE103",
                            Durum = false,
                            Kredi = 6
                        },
                        new
                        {
                            Id = 4,
                            DersAdi = "Grafik dizayn",
                            DersKodu = "GRA105",
                            Durum = true,
                            Kredi = 5
                        },
                        new
                        {
                            Id = 5,
                            DersAdi = "Bilgisayar Teknolojileri",
                            DersKodu = "CMPE201",
                            Durum = true,
                            Kredi = 4
                        },
                        new
                        {
                            Id = 6,
                            DersAdi = "İngilizce 2",
                            DersKodu = "ENG102",
                            Durum = true,
                            Kredi = 4
                        },
                        new
                        {
                            Id = 7,
                            DersAdi = "İleri Calculus",
                            DersKodu = "MATH201",
                            Durum = true,
                            Kredi = 6
                        });
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.DersKayit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DersId")
                        .HasColumnType("int");

                    b.Property<int?>("OgrenciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DersId");

                    b.HasIndex("OgrenciId");

                    b.ToTable("DersKayitlari");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DersId = 3,
                            OgrenciId = 3
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DersId = 6,
                            OgrenciId = 4
                        });
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Iletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gsm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Il")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Iletisimler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adres = "CUMHURİYET MAH. BİRİNCİ SOK. İKİNCİ APT. NO:11/6",
                            Email = "abc@hotmail.com",
                            Gsm = "5332342342",
                            Il = "ANKARA",
                            Ilce = "YENİMAHALLE"
                        },
                        new
                        {
                            Id = 2,
                            Adres = "KUŞADASI SOK NO:123 KARAAĞAÇ",
                            Email = "def@gmail.com",
                            Gsm = "5437657567",
                            Il = "ANKARA",
                            Ilce = "ÇANKAYA"
                        },
                        new
                        {
                            Id = 3,
                            Adres = "TURAN GÜNEŞ BULVARI TAMTAM SİTESİ 13. CAD. NO:51",
                            Email = "ghi@abc.com",
                            Gsm = "5305464646",
                            Il = "ANKARA",
                            Ilce = "KEÇİÖREN"
                        },
                        new
                        {
                            Id = 4,
                            Adres = "DEMİRCİKARA MAH. B.ONAT CAD. HEDE SİT. B BLOK NO:1",
                            Email = "mno@xyz.com",
                            Gsm = "5555424245",
                            Il = "ANKARA",
                            Ilce = "PURSAKLAR"
                        },
                        new
                        {
                            Id = 5,
                            Adres = "AHMET HAMDİ SOK. NO:19/15",
                            Email = "prs@hotmail.com",
                            Gsm = "5302908432",
                            Il = "ANKARA",
                            Ilce = "SİNCAN"
                        },
                        new
                        {
                            Id = 6,
                            Adres = "SİTELER MAHALLESİ 6223 SOKAK DURU APT. NO:11 KAT:3",
                            Email = "klm@outlook.com",
                            Gsm = "5408932042",
                            Il = "ANKARA",
                            Ilce = "POLATLI"
                        });
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Kimlik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DogumTarihi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DogumYeri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IletisimId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IletisimId")
                        .IsUnique()
                        .HasFilter("[IletisimId] IS NOT NULL");

                    b.ToTable("Kimlikler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Hasan",
                            DogumTarihi = "11.10.1983",
                            DogumYeri = "Kayseri",
                            IletisimId = 4,
                            Soyad = "Ersoy",
                            TcNo = "45456747611"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Mehmet",
                            DogumTarihi = "12.03.2000",
                            DogumYeri = "Adana",
                            IletisimId = 1,
                            Soyad = "Yılmaz",
                            TcNo = "67967856634"
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Ahmet",
                            DogumTarihi = "14.06.2001",
                            DogumYeri = "Ankara",
                            IletisimId = 6,
                            Soyad = "Ünal",
                            TcNo = "72347322958"
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Mustafa",
                            DogumTarihi = "21.12.2000",
                            DogumYeri = "Sivas",
                            IletisimId = 3,
                            Soyad = "Işık",
                            TcNo = "97850348520"
                        },
                        new
                        {
                            Id = 5,
                            Ad = "Ayşe",
                            DogumTarihi = "04.03.2001",
                            DogumYeri = "Uşak",
                            IletisimId = 5,
                            Soyad = "Erdoğan",
                            TcNo = "32756874239"
                        },
                        new
                        {
                            Id = 6,
                            Ad = "Fatma",
                            DogumTarihi = "01.01.2001",
                            DogumYeri = "Kütahya",
                            IletisimId = 2,
                            Soyad = "Korkmaz",
                            TcNo = "98423479320"
                        });
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Kullanici", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("KimlikId")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Tur")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("KimlikId")
                        .IsUnique()
                        .HasFilter("[KimlikId] IS NOT NULL");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Mufredat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MufredatAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mufredatlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MufredatAdi = "BilgMuh_Mufredat"
                        },
                        new
                        {
                            Id = 2,
                            MufredatAdi = "GrafikMuh_Mufredat"
                        },
                        new
                        {
                            Id = 3,
                            MufredatAdi = "IngDilEdebiyat_Muf"
                        });
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.MufredatDers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DersId")
                        .HasColumnType("int");

                    b.Property<int?>("MufredatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DersId");

                    b.HasIndex("MufredatId");

                    b.ToTable("MufredatDersler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DersId = 2,
                            MufredatId = 1
                        },
                        new
                        {
                            Id = 2,
                            DersId = 5,
                            MufredatId = 1
                        },
                        new
                        {
                            Id = 3,
                            DersId = 6,
                            MufredatId = 1
                        },
                        new
                        {
                            Id = 4,
                            DersId = 7,
                            MufredatId = 1
                        },
                        new
                        {
                            Id = 5,
                            DersId = 1,
                            MufredatId = 2
                        },
                        new
                        {
                            Id = 6,
                            DersId = 2,
                            MufredatId = 2
                        },
                        new
                        {
                            Id = 7,
                            DersId = 3,
                            MufredatId = 2
                        },
                        new
                        {
                            Id = 8,
                            DersId = 4,
                            MufredatId = 2
                        },
                        new
                        {
                            Id = 9,
                            DersId = 6,
                            MufredatId = 2
                        },
                        new
                        {
                            Id = 10,
                            DersId = 7,
                            MufredatId = 2
                        },
                        new
                        {
                            Id = 11,
                            DersId = 1,
                            MufredatId = 3
                        },
                        new
                        {
                            Id = 12,
                            DersId = 4,
                            MufredatId = 3
                        },
                        new
                        {
                            Id = 13,
                            DersId = 5,
                            MufredatId = 3
                        },
                        new
                        {
                            Id = 14,
                            DersId = 6,
                            MufredatId = 3
                        });
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KimlikId")
                        .HasColumnType("int");

                    b.Property<int?>("MufredatId")
                        .HasColumnType("int");

                    b.Property<string>("OgrenciNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KimlikId")
                        .IsUnique()
                        .HasFilter("[KimlikId] IS NOT NULL");

                    b.HasIndex("MufredatId");

                    b.ToTable("Ogrenciler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KimlikId = 3,
                            MufredatId = 1,
                            OgrenciNo = "27482379"
                        },
                        new
                        {
                            Id = 2,
                            KimlikId = 5,
                            MufredatId = 1,
                            OgrenciNo = "23462368"
                        },
                        new
                        {
                            Id = 3,
                            KimlikId = 6,
                            MufredatId = 2,
                            OgrenciNo = "34565479"
                        },
                        new
                        {
                            Id = 4,
                            KimlikId = 2,
                            MufredatId = 2,
                            OgrenciNo = "53456346"
                        },
                        new
                        {
                            Id = 5,
                            KimlikId = 4,
                            MufredatId = 3,
                            OgrenciNo = "34674575"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Kullanici", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.DersKayit", b =>
                {
                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Ders", "Ders")
                        .WithMany("DersKayitlari")
                        .HasForeignKey("DersId");

                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Ogrenci", "Ogrenci")
                        .WithMany("DersKayitlari")
                        .HasForeignKey("OgrenciId");

                    b.Navigation("Ders");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Kimlik", b =>
                {
                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Iletisim", "Iletisim")
                        .WithOne("Kimlik")
                        .HasForeignKey("OgrenciBilgiSistemi.Data.Entities.Kimlik", "IletisimId");

                    b.Navigation("Iletisim");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Kullanici", b =>
                {
                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Kimlik", "Kimlik")
                        .WithOne("Kullanici")
                        .HasForeignKey("OgrenciBilgiSistemi.Data.Entities.Kullanici", "KimlikId");

                    b.Navigation("Kimlik");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.MufredatDers", b =>
                {
                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Ders", "Ders")
                        .WithMany("MufredatDersler")
                        .HasForeignKey("DersId");

                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Mufredat", "Mufredat")
                        .WithMany("MufredatDersler")
                        .HasForeignKey("MufredatId");

                    b.Navigation("Ders");

                    b.Navigation("Mufredat");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Ogrenci", b =>
                {
                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Kimlik", "Kimlik")
                        .WithOne("Ogrenci")
                        .HasForeignKey("OgrenciBilgiSistemi.Data.Entities.Ogrenci", "KimlikId");

                    b.HasOne("OgrenciBilgiSistemi.Data.Entities.Mufredat", "Mufredat")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("MufredatId");

                    b.Navigation("Kimlik");

                    b.Navigation("Mufredat");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Ders", b =>
                {
                    b.Navigation("DersKayitlari");

                    b.Navigation("MufredatDersler");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Iletisim", b =>
                {
                    b.Navigation("Kimlik");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Kimlik", b =>
                {
                    b.Navigation("Kullanici");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Mufredat", b =>
                {
                    b.Navigation("MufredatDersler");

                    b.Navigation("Ogrenciler");
                });

            modelBuilder.Entity("OgrenciBilgiSistemi.Data.Entities.Ogrenci", b =>
                {
                    b.Navigation("DersKayitlari");
                });
#pragma warning restore 612, 618
        }
    }
}