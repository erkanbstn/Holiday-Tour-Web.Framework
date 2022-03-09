using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        public ActionResult AnaBlog()
        {
            var x = c.Blogs.ToList();
            return View(x);
        }
        Listele l = new Listele();
        [HttpGet]
        public ActionResult BlogDetail(int id)
        {
            l.BlogDeger = c.Blogs.Where(b => b.ID == id).ToList();
            l.YorumDeger = c.Yorums.Where(b => b.BlogID== id).ToList();
            ViewBag.dg = id;
            return View(l);
        }
        [HttpPost]
        public ActionResult BlogDetail(Yorum y)
        {
            c.Yorums.Add(y);
            c.SaveChanges();
            return RedirectToAction("AnaBlog");
        }

    }
}