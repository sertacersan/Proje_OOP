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
            MesajListesi("Parametre ismi");
            Kullanıcı("murat123");
            return View();
        }

        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            ViewBag.c = Cevre();
            Kullanıcı("murat000");
            return View();
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }

        int Cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int sonuc = 2 * (kisa + uzun);
            return sonuc;
        }

        string cumle()
        {
            string c = "Merhaba C#";
            return c;
        }

        public IActionResult Musteriler()
        {
            ViewBag.d = cumle();
            Kullanıcı("admin123");
            return View();
        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }

        void Kullanıcı(string kullaniciadi)
        {
            ViewBag.v = kullaniciadi;
        }
    }
}
