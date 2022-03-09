using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class GirisYapController : Controller
    {
        public ActionResult AnaGiris()
        {
            return View();
        }
        Context c = new Context();
        [HttpPost]
        public ActionResult AnaGiris(Admin a)
        {
            var x = c.Admins.FirstOrDefault(b => b.Kullanici == a.Kullanici && b.Sifre == a.Sifre);
            if (x != null)
            {
                FormsAuthentication.SetAuthCookie(x.Kullanici, false);
                Session["Kullanici"] = x.Kullanici.ToString();
                return RedirectToAction("AnaSayfa", "Ana");
            }
            else
            {
                return View();
            }
        }
    }
}