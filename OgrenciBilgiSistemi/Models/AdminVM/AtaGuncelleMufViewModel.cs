using OgrenciBilgiSistemi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Models.AdminVM
{
    public class AtaGuncelleMufViewModel
    {
        public int Id { get; set; }
        public List<Mufredat> mufredatlar { get; set; }

        public string muf { get; set; }

    }
}
