using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace frontend.Models
{
    public class AdresBilgileriViewModel
    {
        public string AdresBasligi { get; set;}
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string AdresSehri { get; set;}
        public string CepTelefonu { get; set;}
        public string Adres { get; set; }
        public List<AdresBilgileriViewModel> Adresler { get; set; } = new List<AdresBilgileriViewModel>();

        public string TamAd { get =>
            $"{Ad } {SoyAd}";
             }
     }
}
