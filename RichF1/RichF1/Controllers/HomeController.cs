using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RichF1.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Rich's AIT Formula 1 project!.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us on the details below!";

            return View();
        }
    }
}