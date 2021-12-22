using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class Kimlik
    {

        public int Id { get; set; }

        public string TcNo { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumYeri { get; set; }

        public DateTime DogumTarihi { get; set; }


        //nav

        [ForeignKey("Ogrenci")]
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }


        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        public Iletisim Iletisim { get; set; }

    }
}
