using OgrenciBilgiSistemi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Models.AdminVM
{
    public class OgrDersGoruntuleViewModel
    {

        public string OgrenciNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string MufredatAdi { get; set; }

        public List<DersKayit> Dersler { get; set; }

    }
}
