using frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
            for (int i = 0; i < 10; i++)
            {

                SiparisViewModel siparis = new SiparisViewModel();
                siparis.AliciAdi = "nizameddin neşem";
                siparis.SiparisResmi = "/img/resim1.jpg";
                siparis.SiparisTarihi = DateTime.Now;
                siparis.SiparisTutari = 7.99m;
                siparis.SiparisDetayı = "Teslim Edildi";
                siparislerim.Add(siparis);


                SiparisViewModel nesem = new SiparisViewModel();
                nesem.AliciAdi = "nizameddin";
                nesem.SiparisTutari = 290.99m;
                nesem.SiparisTarihi = DateTime.Now;
                nesem.SiparisResmi = "/img/resim1.jpg";
                nesem.SiparisDetayı = "Kargolanıyor";
                siparislerim.Add(nesem);





            }

            return View(siparislerim);
        }

        public IActionResult SifreGuncelle()

        {
            return View();


        }


        public IActionResult KategoriUrunleri()
        {
            return View();
        }


        public IActionResult KategoriUrunDetay()
        {
            return View();
        }


        public IActionResult AdresBilgileri()
        {
            AdresBilgileriViewModel model = new AdresBilgileriViewModel();
            for (int i = 0; i < 6; i++)
            {
                AdresBilgileriViewModel adresbil = new AdresBilgileriViewModel();
                adresbil.AdresSehri = "ankara";
                adresbil.AdresBasligi = "evim";
                adresbil.Ad = "neşem";
                adresbil.SoyAd = "nizameddin";
                adresbil.Adres = " açık adres";
                adresbil.CepTelefonu = "997585473";
                model.Adresler.Add(adresbil);

            }
            return View(model);
        }


        public IActionResult SiparisDetay()
        {
            List<SiparisViewModel> siparislerim = new List<SiparisViewModel>();
            for (int i = 0; i < 3; i++)
            {

                SiparisViewModel siparis = new SiparisViewModel();
                siparis.AliciAdi = "didem neşem";
                siparis.SiparisResmi = "/img/resim1.jpg";
                siparis.SiparisTarihi = DateTime.Now;
                siparis.SiparisTutari = 7.99m;
                siparis.SiparisDetayı = "Kargoya verildi";
                siparislerim.Add(siparis);


             



            }

            return View(siparislerim);
        }
        public IActionResult KargoTakip()
        {
            return View();
        }

        public IActionResult OdemeBilgisi()
        {
            return View();
        }
        public IActionResult KvkAydınlatmaMetni
            ()
        {
            return View();
        }
        public IActionResult KvkBasvuru
            ()
        {
            return View();
        }
        public IActionResult SartlarveKosullar
            ()
        {
            return View();
        }
        public IActionResult GizlilikPolitikasi

            ()
        {
            return View();
        }
        public IActionResult IslemRehberi
            ()
        {
            return View();
        }
        public IActionResult Iletisim

            ()
        {
            return View();
        }
        public IActionResult Yardim()
        {
            return View();
        }
        public IActionResult KargoveTeslimat

            ()
        {
            return View();
        }
        public IActionResult GuvenlikYardim

            ()
        {
            return View();
        }
        public IActionResult İletisimYardim

            ()
        {
            return View();
        }
        public IActionResult İslemRehberiYardim

            ()
        {
            return View();
        }
        public IActionResult HesabimYardim

            ()
        {
            return View();
        }
        public IActionResult HakkindaYardim

            ()
        {
            return View();
        }
        public IActionResult BayilikYardim

            ()
        {
            return View();
        }
        public IActionResult PopulerSorular

            ()
        {
            return View();
        }
      public IActionResult SiparislerYardim

            ()
        {
            return View();
        }
       
   
    }
}
