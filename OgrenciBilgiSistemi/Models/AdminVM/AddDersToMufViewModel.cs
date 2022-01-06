using OgrenciBilgiSistemi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Models.AdminVM
{
    public class AddDersToMufViewModel
    {
        public int Id { get; set; }
        public List<Ders> Derslervm { get; set; }

    }
}
