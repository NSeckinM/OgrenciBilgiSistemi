using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class DersKayit
    {
        public int Id { get; set; }


        [ForeignKey("Ogrenci")]
        public int? OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }


        [ForeignKey("Ders")]
        public int? DersId { get; set; }
        public Ders Ders { get; set; }


        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
