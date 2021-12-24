using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OgrenciBilgiSistemi.Identity
{
    public class Kullanici: IdentityUser
    {
        public int KimlikNo { get; set; }

        [Required]
        public string KullaniciAdi { get; set; }

        public bool Tur { get; set; }



    }
}
