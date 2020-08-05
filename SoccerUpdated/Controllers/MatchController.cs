using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerUpdated.Controllers
{
    public class MatchController : Controller
    {
        public ActionResult New()
        {
            return View();
        }
    }
}