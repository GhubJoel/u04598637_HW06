using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u04598637_HW06.Models;

namespace u04598637_HW06.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BikeStoresEntities db = new BikeStoresEntities();
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
    }
}