using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class Kullanici : IdentityUser
    {

        [Required]
        public string KullaniciAdi { get; set; }
        public bool Tur { get; set; }


        [ForeignKey("Kimlik")]
        public int? KimlikId { get; set; }
        public Kimlik Kimlik { get; set; }

    }
}
