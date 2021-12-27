using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OgrenciBilgiSistemi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciBilgiSistemi.Data
{
    public class ApplicationDbContext : IdentityDbContext<Kullanici>
    {

        public DbSet<Ders> Dersler { get; set; }

        public DbSet<DersKayit> DersKayitlari { get; set; }

        public DbSet<Iletisim> Iletisimler { get; set; }

        public DbSet<Kimlik> Kimlikler { get; set; }

        public DbSet<Mufredat> Mufredatlar { get; set; }

        public DbSet<MufredatDers> MufredatDersler { get; set; }

        public DbSet<Ogrenci> Ogrenciler { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Iletisim>().HasData(
            new Iletisim() { Id = 1, Adres = "CUMHURİYET MAH. BİRİNCİ SOK. İKİNCİ APT. NO:11/6", Il = "ANKARA", Ilce = "YENİMAHALLE", Email = "abc@hotmail.com", Gsm = "5332342342" },
            new Iletisim() { Id = 2, Adres = "KUŞADASI SOK NO:123 KARAAĞAÇ", Il = "ANKARA", Ilce = "ÇANKAYA", Email = "def@gmail.com", Gsm = "5437657567" },
            new Iletisim() { Id = 3, Adres = "TURAN GÜNEŞ BULVARI TAMTAM SİTESİ 13. CAD. NO:51", Il = "ANKARA", Ilce = "KEÇİÖREN", Email = "ghi@abc.com", Gsm = "5305464646" },
            new Iletisim() { Id = 4, Adres = "DEMİRCİKARA MAH. B.ONAT CAD. HEDE SİT. B BLOK NO:1", Il = "ANKARA", Ilce = "PURSAKLAR", Email = "mno@xyz.com", Gsm = "5555424245" },
            new Iletisim() { Id = 5, Adres = "AHMET HAMDİ SOK. NO:19/15", Il = "ANKARA", Ilce = "SİNCAN", Email = "prs@hotmail.com", Gsm = "5302908432" },
            new Iletisim() { Id = 6, Adres = "SİTELER MAHALLESİ 6223 SOKAK DURU APT. NO:11 KAT:3", Il = "ANKARA", Ilce = "POLATLI", Email = "klm@outlook.com", Gsm = "5408932042" }
                );

             builder.Entity<Kimlik>().HasData(
             new Kimlik() { Id = 1, TcNo = "45456747611", Ad = "Hasan", Soyad = "Ersoy", DogumYeri = "Kayseri", DogumTarihi = "11.10.1983", IletisimId = 4 },
             new Kimlik() { Id = 2, TcNo = "67967856634", Ad = "Mehmet", Soyad = "Yılmaz", DogumYeri = "Adana", DogumTarihi = "12.03.2000", IletisimId = 1 },
             new Kimlik() { Id = 3, TcNo = "72347322958", Ad = "Ahmet", Soyad = "Ünal", DogumYeri = "Ankara", DogumTarihi = "14.06.2001", IletisimId = 6 },
             new Kimlik() { Id = 4, TcNo = "97850348520", Ad = "Mustafa", Soyad = "Işık", DogumYeri = "Sivas", DogumTarihi = "21.12.2000", IletisimId = 3 },
             new Kimlik() { Id = 5, TcNo = "32756874239", Ad = "Ayşe", Soyad = "Erdoğan", DogumYeri = "Uşak", DogumTarihi = "04.03.2001", IletisimId = 5 },
             new Kimlik() { Id = 6, TcNo = "98423479320", Ad = "Fatma", Soyad = "Korkmaz", DogumYeri = "Kütahya", DogumTarihi = "01.01.2001", IletisimId = 2 }
                );

            builder.Entity<Ders>().HasData(
            new Ders() { Id = 1, DersKodu = "HUM101", DersAdi = "Türk Demokrasi Tarihi", Durum = true, Kredi = 5 },
            new Ders() { Id = 2, DersKodu = "MATH102", DersAdi = "Calculus 2", Durum = false, Kredi = 6 },
            new Ders() { Id = 3, DersKodu = "MATE103", DersAdi = "Metaruljiye Giriş", Durum = false, Kredi = 6 },
            new Ders() { Id = 4, DersKodu = "GRA105", DersAdi = "Grafik dizayn", Durum = true, Kredi = 5 },
            new Ders() { Id = 5, DersKodu = "CMPE201", DersAdi = "Bilgisayar Teknolojileri", Durum = true, Kredi = 4 },
            new Ders() { Id = 6, DersKodu = "ENG102", DersAdi = "İngilizce 2", Durum = true, Kredi = 4 },
            new Ders() { Id = 7, DersKodu = "MATH201", DersAdi = "İleri Calculus", Durum = true, Kredi = 6 }

                );
            builder.Entity<Mufredat>().HasData(
            new Mufredat() { Id = 1, MufredatAdi = "BilgMuh_Mufredat" },
            new Mufredat() { Id = 2, MufredatAdi = "GrafikMuh_Mufredat" },
            new Mufredat() { Id = 3, MufredatAdi = "IngDilEdebiyat_Muf" }
                );

            builder.Entity<Ogrenci>().HasData(
            new Ogrenci() { Id = 1, OgrenciNo = "27482379", MufredatId = 1, KimlikId = 3 },
            new Ogrenci() { Id = 2, OgrenciNo = "23462368", MufredatId = 1, KimlikId = 5 },
            new Ogrenci() { Id = 3, OgrenciNo = "34565479", MufredatId = 2, KimlikId = 6 },
            new Ogrenci() { Id = 4, OgrenciNo = "53456346", MufredatId = 2, KimlikId = 2 },
            new Ogrenci() { Id = 5, OgrenciNo = "34674575", MufredatId = 3, KimlikId = 4 }
               );

            builder.Entity<MufredatDers>().HasData(
            new MufredatDers() { Id = 1, MufredatId = 1, DersId = 2 },
            new MufredatDers() { Id = 2, MufredatId = 1, DersId = 5 },
            new MufredatDers() { Id = 3, MufredatId = 1, DersId = 6 },
            new MufredatDers() { Id = 4, MufredatId = 1, DersId = 7 },
            new MufredatDers() { Id = 5, MufredatId = 2, DersId = 1 },
            new MufredatDers() { Id = 6, MufredatId = 2, DersId = 2 },
            new MufredatDers() { Id = 7, MufredatId = 2, DersId = 3 },
            new MufredatDers() { Id = 8, MufredatId = 2, DersId = 4 },
            new MufredatDers() { Id = 9, MufredatId = 2, DersId = 6 },
            new MufredatDers() { Id = 10, MufredatId = 2, DersId = 7 },
            new MufredatDers() { Id = 11, MufredatId = 3, DersId = 1 },
            new MufredatDers() { Id = 12, MufredatId = 3, DersId = 4 },
            new MufredatDers() { Id = 13, MufredatId = 3, DersId = 5 },
            new MufredatDers() { Id = 14, MufredatId = 3, DersId = 6 }
                );

            builder.Entity<DersKayit>().HasData(
            new DersKayit() {Id = 1, OgrenciId = 3, DersId = 3, CreatedDate = new DateTime(2021, 11, 04) },
            new DersKayit() {Id = 2, OgrenciId = 4, DersId = 6, CreatedDate = new DateTime(2021, 11, 04) }
                );

        }


    }
}
