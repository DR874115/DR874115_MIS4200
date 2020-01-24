using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DR874115_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Devin Ruff";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Devin Ruff";

            return View();
        }
    }
}