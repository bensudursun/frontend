using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace frontend.Controllers
{
    public class UyeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hesabim()
        {
            return View();
        }
        public IActionResult Kategoriler
           ()
        {

            List<UrunViewModel> modellerim = new List<UrunViewModel>();

            for (int i = 0; i < 10; i++)
            {
                UrunViewModel model1 = new UrunViewModel();
                model1.UrunResmi = "/img/resim1.jpg";
                model1.UrunFiyat = 20.99m;
                model1.UrunAd = "Pos Terminali";
                modellerim.Add(model1);

            }
            return View(modellerim);
        }
        public IActionResult Siparislerim()
        {
            List<SiparisViewModel> siparislerim = new List<SiparisViewModel>();
            for( int i=0; i<10; i++) { 

            SiparisViewModel siparis = new SiparisViewModel();
            siparis.AliciAdi = "nizameddin neşem";
            siparis.SiparisResmi= "/img/resim1.jpg";
            siparis.SiparisTarihi = DateTime.Now;
            siparis.SiparisTutari = 7.99m;
                siparis.SiparisDetayı = "Teslim Edildi.";
            siparislerim.Add(siparis);


            SiparisViewModel nesem = new SiparisViewModel();
            nesem.AliciAdi = "nizameddin";
            nesem.SiparisTutari = 290.99m;
            nesem.SiparisTarihi = DateTime.Now;
            nesem.SiparisResmi= "/img/resim1.jpg";
                nesem.SiparisDetayı = "Kargolanıyor";
            siparislerim.Add(nesem);
             

        


}

            return View(siparislerim);
        }
        public IActionResult KategoriUrunleri()
        {
            return View();
        }
        public IActionResult KategoriUrunDetay()
        {
            return View();
        }
    }
}
