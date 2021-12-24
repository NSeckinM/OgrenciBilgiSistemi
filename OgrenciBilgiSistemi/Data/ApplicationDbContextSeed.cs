using Microsoft.EntityFrameworkCore;
using OgrenciBilgiSistemi.Data.Entities;
using System;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Data
{
    public static class ApplicationDbContextSeed
    {

        public static async Task SeedAsync(ApplicationDbContext dbContext)
        {

            if (await dbContext.Ogrenciler.AnyAsync() || await dbContext.Dersler.AnyAsync() || await dbContext.Iletisimler.AnyAsync() || await dbContext.Kimlikler.AnyAsync() || await dbContext.Mufredatlar.AnyAsync() || await dbContext.MufredatDersler.AnyAsync() || await dbContext.DersKayitlari.AnyAsync()) return;

            var ogr1 = new Ogrenci() { OgrenciNo = "27482379", MufredatId = 1, KimlikId = 3 };
            var ogr2 = new Ogrenci() { OgrenciNo = "23462368", MufredatId = 1, KimlikId = 5 };
            var ogr3 = new Ogrenci() { OgrenciNo = "34565479", MufredatId = 2, KimlikId = 6 };
            var ogr4 = new Ogrenci() { OgrenciNo = "53456346", MufredatId = 2, KimlikId = 2 };
            var ogr5 = new Ogrenci() { OgrenciNo = "34674575", MufredatId = 3, KimlikId = 4 };
            dbContext.AddRange(ogr1, ogr2, ogr3, ogr4, ogr5);

            var iletsm1 = new Iletisim() { Adres = "CUMHURİYET MAH. BİRİNCİ SOK. İKİNCİ APT. NO:11/6", Il = "ANKARA", Ilce = "YENİMAHALLE", Email = "abc@hotmail.com", Gsm = "5332342342" };
            var iletsm2 = new Iletisim() { Adres = "KUŞADASI SOK NO:123 KARAAĞAÇ", Il = "ANKARA", Ilce = "ÇANKAYA", Email = "def@gmail.com", Gsm = "5437657567" };
            var iletsm3 = new Iletisim() { Adres = "TURAN GÜNEŞ BULVARI TAMTAM SİTESİ 13. CAD. NO:51", Il = "ANKARA", Ilce = "KEÇİÖREN", Email = "ghi@abc.com", Gsm = "5305464646" };
            var iletsm4 = new Iletisim() { Adres = "DEMİRCİKARA MAH. B.ONAT CAD. HEDE SİT. B BLOK NO:1", Il = "ANKARA", Ilce = "PURSAKLAR", Email = "mno@xyz.com", Gsm = "5555424245" };
            var iletsm5 = new Iletisim() { Adres = "AHMET HAMDİ SOK. NO:19/15", Il = "ANKARA", Ilce = "SİNCAN", Email = "prs@hotmail.com", Gsm = "5302908432" };
            var iletsm6 = new Iletisim() { Adres = "SİTELER MAHALLESİ 6223 SOKAK DURU APT. NO:11 KAT:3", Il = "ANKARA", Ilce = "POLATLI", Email = "klm@outlook.com", Gsm = "5408932042" };
            dbContext.AddRange(iletsm1, iletsm2, iletsm3, iletsm4, iletsm5, iletsm6);

            var kimlik1 = new Kimlik() { TcNo = "45456747611", Ad = "Hasan", Soyad = "Ersoy", DogumYeri = "Kayseri", DogumTarihi = "11.10.1983", IletisimId = 4 };
            var kimlik2 = new Kimlik() { TcNo = "67967856634", Ad = "Mehmet", Soyad = "Yılmaz", DogumYeri = "Adana", DogumTarihi = "12.03.2000", IletisimId = 1 };
            var kimlik3 = new Kimlik() { TcNo = "72347322958", Ad = "Ahmet", Soyad = "Ünal", DogumYeri = "Ankara", DogumTarihi = "14.06.2001", IletisimId = 6 };
            var kimlik4 = new Kimlik() { TcNo = "97850348520", Ad = "Mustafa", Soyad = "Işık", DogumYeri = "Sivas", DogumTarihi = "21.12.2000", IletisimId = 3 };
            var kimlik5 = new Kimlik() { TcNo = "32756874239", Ad = "Ayşe", Soyad = "Erdoğan", DogumYeri = "Uşak", DogumTarihi = "04.03.2001", IletisimId = 5 };
            var kimlik6 = new Kimlik() { TcNo = "98423479320", Ad = "Fatma", Soyad = "Korkmaz", DogumYeri = "Kütahya", DogumTarihi = "01.01.2001", IletisimId = 2 };
            dbContext.AddRange(kimlik1, kimlik2, kimlik3, kimlik4, kimlik5, kimlik6);


            var ders1 = new Ders() { DersKodu = "HUM101", DersAdi = "Türk Demokrasi Tarihi", Durum = true, Kredi = 5 };
            var ders2 = new Ders() { DersKodu = "MATH102", DersAdi = "Calculus 2", Durum = false, Kredi = 6 };
            var ders3 = new Ders() { DersKodu = "MATE103", DersAdi = "Metaruljiye Giriş", Durum = false, Kredi = 6 };
            var ders4 = new Ders() { DersKodu = "GRA105", DersAdi = "Grafik dizayn", Durum = true, Kredi = 5 };
            var ders5 = new Ders() { DersKodu = "CMPE201", DersAdi = "Bilgisayar Teknolojileri", Durum = true, Kredi = 4 };
            var ders6 = new Ders() { DersKodu = "ENG102", DersAdi = "İngilizce 2", Durum = true, Kredi = 4 };
            var ders7 = new Ders() { DersKodu = "MATH201", DersAdi = "İleri Calculus", Durum = true, Kredi = 6 };
            dbContext.AddRange(ders1, ders2, ders3, ders4, ders5, ders6, ders7);

            var muf1 = new Mufredat() { MufredatAdi = "BilgMuh_Mufredat" };
            var muf2 = new Mufredat() { MufredatAdi = "GrafikMuh_Mufredat" };
            var muf3 = new Mufredat() { MufredatAdi = "IngDilEdebiyat_Muf" };
            dbContext.AddRange(muf1, muf2, muf3);

            var mufDers1 = new MufredatDers() { MufredatId = 1, DersId = 2 };
            var mufDers2 = new MufredatDers() { MufredatId = 1, DersId = 5 };
            var mufDers3 = new MufredatDers() { MufredatId = 1, DersId = 6 };
            var mufDers4 = new MufredatDers() { MufredatId = 1, DersId = 7 };
            var mufDers5 = new MufredatDers() { MufredatId = 2, DersId = 1 };
            var mufDers6 = new MufredatDers() { MufredatId = 2, DersId = 2 };
            var mufDers7 = new MufredatDers() { MufredatId = 2, DersId = 3 };
            var mufDers8 = new MufredatDers() { MufredatId = 2, DersId = 4 };
            var mufDers9 = new MufredatDers() { MufredatId = 2, DersId = 6 };
            var mufDers10 = new MufredatDers() { MufredatId = 2, DersId = 7 };
            var mufDers11 = new MufredatDers() { MufredatId = 3, DersId = 1 };
            var mufDers12 = new MufredatDers() { MufredatId = 3, DersId = 4 };
            var mufDers13 = new MufredatDers() { MufredatId = 3, DersId = 5 };
            var mufDers14 = new MufredatDers() { MufredatId = 3, DersId = 6 };
            dbContext.AddRange(mufDers1, mufDers2, mufDers3, mufDers4, mufDers5, mufDers6, mufDers7, mufDers8, mufDers9, mufDers10, mufDers11, mufDers12, mufDers13, mufDers14);

            var derskayt1 = new DersKayit() {  OgrenciId = 3, DersId = 3, CreatedDate = new DateTime(2021, 11, 04) };
            var derskayt2 = new DersKayit() {  OgrenciId = 4, DersId = 6, CreatedDate = new DateTime(2021, 11, 04) };
            dbContext.AddRange(derskayt1, derskayt2);

            await dbContext.SaveChangesAsync();

        }



    }
}
