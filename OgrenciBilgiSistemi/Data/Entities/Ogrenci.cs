using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class Ogrenci
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression("^[1-9]{1}[0-9]{7}$",ErrorMessage ="Sadece 8 haneli sayı girebilirsiniz")]
        public string OgrenciNo { get; set; }  


        //Nav prop

        [ForeignKey("Kimlik")]
        public int KimlikId { get; set; }
        public Kimlik Kimlik { get; set; }


        [ForeignKey("Mufredat")]
        public int MufredatId { get; set; }
        public Mufredat Mufredat { get; set; }

        public List<DersKayit> DersKayitlari { get; set; }
    }
}
