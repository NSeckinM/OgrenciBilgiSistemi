using System.Collections.Generic;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class Mufredat
    {

        public int Id { get; set; }

        public string MufredatAdi { get; set; }


        public List<Ogrenci> Ogrenciler { get; set; }

        public List<MufredatDers> MufredatDersler { get; set; }

    }
}
