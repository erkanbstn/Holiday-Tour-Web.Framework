using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class IletisimController : Controller
    {
        Context c = new Context();
        public ActionResult AnaIletisim()
        {
            var x = c.AdresBlogs.ToList();
            return View(x);
        }
        public PartialViewResult IletisimForm()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult SendMessage(Iletisim a)
        {
            c.Iletisims.Add(a);
            c.SaveChanges();
            return RedirectToAction("AnaIletisim");
        }
    }
}