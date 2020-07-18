using SoccerUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerUpdated.Controllers
{
    public class LeagueController : Controller
    {
        // GET: League
        public ActionResult Index()
        {
            var league = new League() { Name = "Bundasliga" };
            return View(league);
        }
    }
}