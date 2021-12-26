using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Models.AdminVM
{
    public class DuzenleDersViewModel
    {
        public int Id { get; set; }
        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public bool Durum { get; set; }
        public int Kredi { get; set; }

    }
}
