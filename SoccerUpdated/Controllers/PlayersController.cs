using SoccerUpdated.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerUpdated.Controllers
{
    public class PlayersController : Controller
    {
        private ApplicationDbContext _context;
        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Players
        public ActionResult Index()
        {
            var players = _context.Players.Include(c=>c.Club).ToList();
            return View(players);
        }

        public ActionResult Info(int id)
        {
            var player = _context.Players.Include(c => c.Club).SingleOrDefault(c => c.Id == id);
            if (player == null)
                throw new System.ArgumentException("Parameter cannot be null");
            return View(player);
        }
    }
}