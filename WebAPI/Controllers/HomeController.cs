using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Terms()
        {
            ViewBag.Title = "Terms of Service";

            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Title = "Privacy Policy";

            return View();
        }
    }
}
