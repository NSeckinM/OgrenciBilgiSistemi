using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Identity
{
    public class ApplicationIdentityDbSeed
    {

        public static async Task SeedIdentityAsync(RoleManager<IdentityRole> roleManager, UserManager<Kullanici> userManager)
        {
            //Admin rolu henüz yoksa oluşturur.
            if (!await roleManager.RoleExistsAsync("admin"))
            {
                await roleManager.CreateAsync(new IdentityRole() { Name = "admin" });
            }

            if (!await roleManager.RoleExistsAsync("ogr"))
            {
                await roleManager.CreateAsync(new IdentityRole() { Name = "ogr" });
            }

            //mno@xyz.com kullanıcısı yok ise oluştur ve sonra admin rolune ata
            if (!await userManager.Users.AnyAsync(x => x.Email == "mno@xyz.com"))
            {
                Kullanici adminUser = new Kullanici()
                {
                    KimlikNo = 1,
                    KullaniciAdi = "hasan.ersoy",
                    Tur = false,
                    UserName = "mno@xyz.com",
                    Email = "mno@xyz.com",
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(adminUser, "Haser1.");
                await userManager.AddToRoleAsync(adminUser, "admin");

            }

            var u1 = new Kullanici() { KimlikNo = 2, KullaniciAdi = "mehmet.yilmaz", Tur = true, UserName = "abc@hotmail.com", Email = "abc@hotmail.com", EmailConfirmed = true };
            var u2 = new Kullanici() { KimlikNo = 3, KullaniciAdi = "ahmet.unal", Tur = true, UserName = "klm@outlook.com", Email = "klm@outlook.com", EmailConfirmed = true };
            var u3 = new Kullanici() { KimlikNo = 4, KullaniciAdi = "mustafa.isik", Tur = true, UserName = "ghi@abc.com", Email = "ghi@abc.com", EmailConfirmed = true };
            var u4 = new Kullanici() { KimlikNo = 5, KullaniciAdi = "ayse.erdogan", Tur = true, UserName = "prs@hotmail.com", Email = "prs@hotmail.com", EmailConfirmed = true };
            var u5 = new Kullanici() { KimlikNo = 6, KullaniciAdi = "fatma.korkmaz", Tur = true, UserName = "def@gmail.com", Email = "def@gmail.com", EmailConfirmed = true };

            await userManager.CreateAsync(u1, "Mehyil6!");
            await userManager.AddToRoleAsync(u1, "ogr");

            await userManager.CreateAsync(u2, "Ahun23+");
            await userManager.AddToRoleAsync(u2, "ogr");

            await userManager.CreateAsync(u3, "Musi64%");
            await userManager.AddToRoleAsync(u3, "ogr");

            await userManager.CreateAsync(u4, "Ayer33.");
            await userManager.AddToRoleAsync(u4, "ogr");

            await userManager.CreateAsync(u5, "Fatkor12%");
            await userManager.AddToRoleAsync(u5, "ogr");

        }
    }
}
