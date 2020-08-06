using SoccerUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SoccerUpdated.Controllers.API
{
    public class ClubController : ApiController
    {
        private ApplicationDbContext _context;
        public ClubController()
        {
            _context = new ApplicationDbContext();
        }

        //Get api/players
        public IHttpActionResult GetClubs()
        {
            var clubs = _context.Clubs.ToList();
            return Ok(clubs);
        }

        //Get api/players/1
        public IHttpActionResult GetPlayers(int id)
        {
            var club = _context.Clubs.Single(m => m.Id == id);

            if (club == null)
                return NotFound();

            return Ok(club);
        }
    }
}
