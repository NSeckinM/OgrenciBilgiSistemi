using OgrenciBilgiSistemi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Models.AdminVM
{
    public class DersofMufViewModel
    {
        public int Id { get; set; }
        public List<MufredatDers> MufredatinDerslerivm { get; set; }

        public Mufredat Mufredatvm { get; set; }

    }
}
