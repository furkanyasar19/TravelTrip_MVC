using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            //Ana sayfadaki ilk üç bloğun ilk ikisini getiriyor. Tasarımdan Dolayı böyle parça parça getirmek zorunda kaldık
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            //Ana sayfadaki ilk üç bloğun sondakini getiriyor. Tasarımdan Dolayı böyle parça parça getirmek zorunda kaldık
            var deger = c.Blogs.Where(x => x.ID == 5).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            //TOP 10 Kategorileri getiriyor
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            //En Beğenilen Yerleri Getiriyor (İlk 3 tane)
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            //En Beğenilen Yerleri Getiriyor (İlk 3 tane)
            var deger = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return PartialView(deger);
        }
    }
}