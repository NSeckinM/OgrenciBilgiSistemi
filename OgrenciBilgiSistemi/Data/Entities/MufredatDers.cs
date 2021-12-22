using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class MufredatDers
    {

        public int Id { get; set; }

        [ForeignKey("Ders")]
        public int DersId { get; set; }
        public Ders Ders { get; set; }


        [ForeignKey("Mufredat")]
        public int MufredatId { get; set; }
        public Mufredat Mufredat { get; set; }


    }
}
