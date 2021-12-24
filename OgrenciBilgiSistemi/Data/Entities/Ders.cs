using System.Collections.Generic;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class Ders
    {
        public int Id { get; set; }
        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public bool Durum { get; set; }
        public int Kredi { get; set; }

        public List<DersKayit> DersKayitlari { get; set; }
        public List<MufredatDers> MufredatDersler { get; set; }

    }
}
