using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Models.OgrenciVM
{
    public class EditIletisimBilgileriViewModel
    {
        public int Id { get; set; }
        public string Adres { get; set; }

        public string Il { get; set; }

        public string Ilce { get; set; }

        public string Email { get; set; }

        public string Gsm { get; set; }
    }
}
