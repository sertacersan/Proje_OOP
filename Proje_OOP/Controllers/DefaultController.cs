using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        void islemler()
        {
            Class1 c = new Class1();
            c.Topla();
        }

        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Proje çok iyi duruyor";
            ViewBag.m3 = "Selamlar hi ";
        }

        public IActionResult Index()
        {
            mesajlar();
            return View();
        }

        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            return View();
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }
    }
}
