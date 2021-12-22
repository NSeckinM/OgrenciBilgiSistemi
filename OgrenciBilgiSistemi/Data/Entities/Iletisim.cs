using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Data.Entities
{
    public class Iletisim
    {
        public int Id { get; set; }

        public string Adres { get; set; }

        public string Il { get; set; }

        public string Ilce { get; set; }

        public string Email { get; set; }

        public string Gsm { get; set; }



        [ForeignKey("Kimlik")]
        public int KimlikId { get; set; }
        public Kimlik Kimlik { get; set; }

    }
}
