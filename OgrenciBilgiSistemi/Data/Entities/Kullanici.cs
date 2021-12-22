using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        public bool Tur { get; set; }

        public Kimlik Kimlik { get; set; }


    }
}
