using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace frontend.Controllers
{
    public class UyeController : Controller
    {
        public IActionResult Hesabim()
        {
            return View();
        }   public IActionResult GirisYap()
        {
            return View();
        }  public IActionResult SifremiUnuttum()
        {
            return View();
        }public IActionResult SifreLinkiGonderildi ()
        {
            return View();
        }public IActionResult Urunler ()
        {
            return View();
        }public IActionResult EpostaSifreDegistir ()
        {
            return View();
        }
    }
}
