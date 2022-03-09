using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AnaController : Controller
    {
        Context c = new Context();
        Listele l = new Listele();
        public ActionResult AnaSayfa()
        {
            l.AnaDeger = c.AnaSayfas.ToList();
            l.BlogDeger = c.Blogs.ToList();
            l.BlogDeger2 = c.Blogs.Take(3).ToList();
            return View(l);
        }
    }
}