using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class Kimlik
    {

        public int Id { get; set; }
        [Required]
        [RegularExpression("^[1-9]{1}[0-9]{9}[02468]{1}$",ErrorMessage ="Lütfen 11 haneli Tc kimlik numarası giriniz.")]
        public string TcNo { get; set; }

        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string DogumYeri { get; set; }

        [Required]
        [RegularExpression("^([1-9]|[12][0-9]|3[01])(|\\/|\\.|\\-|\\s)?(0[1-9]|1[12])\\2(19[0-9]{2}|200[0-9]|201[0-8])$")]
        public string DogumTarihi { get; set; }

        //nav
        public Ogrenci Ogrenci { get; set; }

        public Kullanici Kullanici { get; set; }

        [ForeignKey("Iletisim")]
        public int? IletisimId { get; set; }
        public Iletisim Iletisim { get; set; }

    }
}
