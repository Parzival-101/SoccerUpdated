using SoccerUpdated.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoccerUpdated.ViewModel;

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

        //Player form
        public ActionResult New()
        {
            var clubs = _context.Clubs.ToList();
            var viewModel = new PlayerFormViewModel
            {
                Players = new Players(),
                Clubs = clubs
            };
            return View("PlayerForm",viewModel);
        }

        //Create New Player
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Players Players)
        {
            if (!ModelState.IsValid)
            {
               var viewModel = new PlayerFormViewModel
                {
                    Players = Players,
                    Clubs = _context.Clubs.ToList()
                };
                return View("PlayerForm",viewModel);
            }
            if (Players.Id == 0)
              _context.Players.Add(Players);
            else
            {
                var playerInDb = _context.Players.Single(m => m.Id == Players.Id);

                playerInDb.Name = Players.Name;
                playerInDb.Position = Players.Position;
                playerInDb.Country = Players.Country;
                playerInDb.ClubId = Players.ClubId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Players");
        }
        public ActionResult Info(int id)
        {
            var player = _context.Players.Include(c => c.Club).SingleOrDefault(c => c.Id == id);
            if (player == null)
                throw new System.ArgumentException("Parameter cannot be null");
            return View(player);
        }

        //Edit Player
        public ActionResult Edit(int id)
        {
            var player = _context.Players.SingleOrDefault(m => m.Id == id);
            var viewModel = new PlayerFormViewModel
            {
                Players = player,
                Clubs = _context.Clubs.ToList()
            };
            return View("PlayerForm",viewModel);
        }
    }
}