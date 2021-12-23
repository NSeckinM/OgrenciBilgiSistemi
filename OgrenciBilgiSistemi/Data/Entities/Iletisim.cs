using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$")]
        public string Email { get; set; }

        [RegularExpression("^(05)([0-9]{2})\\s?([0-9]{3})\\s?([0-9]{2})\\s?([0-9]{2})$")]
        public string Gsm { get; set; }

        

        [ForeignKey("Kimlik")]
        public int KimlikId { get; set; }
        public Kimlik Kimlik { get; set; }

    }
}
