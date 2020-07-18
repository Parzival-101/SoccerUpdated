using SoccerUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerUpdated.Controllers
{
    public class ClubController : Controller
    {
        // GET: Club
        public ActionResult Random()
        {
            var club = new Club() { Name = "Bourisia Dortmund" };
            return View(club);
        }
    }
}