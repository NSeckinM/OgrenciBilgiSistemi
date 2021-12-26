using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Models.AdminVM
{
    public class DuzenleOgrViewModel
    {

        public int Id { get; set; }

        [Required]
        [RegularExpression("^[1-9]{1}[0-9]{9}[02468]{1}$", ErrorMessage = "Lütfen 11 haneli Tc kimlik numarası giriniz.")]
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

        public string Adres { get; set; }

        public string Il { get; set; }

        public string Ilce { get; set; }

        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$")]
        public string Email { get; set; }

        [RegularExpression("^(05)([0-9]{2})\\s?([0-9]{3})\\s?([0-9]{2})\\s?([0-9]{2})$")]
        public string Gsm { get; set; }

    }
}
