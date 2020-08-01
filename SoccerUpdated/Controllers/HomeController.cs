using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerUpdated.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "One place for all.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Let's Connect";

            return View();
        }
    }
}