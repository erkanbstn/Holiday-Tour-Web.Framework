﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context(); 
        public ActionResult AnaAbout()
        {
            var x = c.Hakkimizdas.ToList();
            return View(x);
        }
    }
}