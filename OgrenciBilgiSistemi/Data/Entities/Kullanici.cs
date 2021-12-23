using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class Kullanici : IdentityUser
    {

        public int KullaniciId { get; set; }

        [Required]
        public string KullaniciAdi { get; set; }
        [Required]
        public string Sifre { get; set; }

        public bool Tur { get; set; }

        public Kimlik Kimlik { get; set; }


    }
}
