using SoccerUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerUpdated.Controllers
{
    public class PlayersController : Controller
    {
        // GET: Players
        public ActionResult Random()
        {
            var player = new Players() { Name = "Jaden Sancho"};
            return View(player);
        }
    }
}