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

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }


    }
}
