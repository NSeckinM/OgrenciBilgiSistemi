using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class Ogrenci
    {
        public int Id { get; set; }

        public string OgrenciNo { get; set; }


        //Nav prop

        public List<DersKayit> DersKayitlari { get; set; }

        public Kimlik Kimlik { get; set; }


        [ForeignKey("Mufredat")]
        public int MufredatId { get; set; }
        public Mufredat Mufredat { get; set; }

    }
}
