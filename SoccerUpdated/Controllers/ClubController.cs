using SoccerUpdated.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerUpdated.Controllers
{
    public class ClubController : Controller
    {
        private ApplicationDbContext _context;

        public ClubController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }
        // GET: Club
        public ActionResult Index()
        {
            var clubs = _context.Clubs.Include(c=> c.League).ToList();
            return View(clubs);
        }
    }
}