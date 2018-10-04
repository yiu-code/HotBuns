﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hotbuns.Controllers;

namespace Hotbuns.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Brood()
        {
            ViewBag.Message = "Product category Brood";

            return View();
        }

        //// KLANTENSERVICE BELOW

        public ActionResult VeelgesteldeVragen()
        {
            ViewBag.Message = "Veelgesteld";

            return View();
        }

    }
}