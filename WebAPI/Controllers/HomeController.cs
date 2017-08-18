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
            ViewBag.Title = "Survey Punch - Home";

            return View();
        }

        public ActionResult Terms()
        {
            ViewBag.Title = "Survey Punch - Terms of Service";

            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Title = "Survey Punch - Privacy Policy and Consents";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Survey Punch - Contact";

            return View();
        }
    }
}
