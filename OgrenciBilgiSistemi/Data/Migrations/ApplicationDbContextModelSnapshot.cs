﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OgrenciBilgiSistemi.Data;

namespace OgrenciBilgiSistemi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
