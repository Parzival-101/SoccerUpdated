using SoccerUpdated.Dto;
using SoccerUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SoccerUpdated.Controllers.API
{
    public class MatchController : ApiController
    {
        private ApplicationDbContext _context;
        public MatchController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewMatch(NewMatchDto newMatch)
        {
            var league = _context.Leagues.Single(c => c.Id == newMatch.LeagueId);
            var clubs = _context.Clubs.Where(
                c => newMatch.ClubIds.Contains(c.Id));

            foreach (var club in clubs)
            {
                var match = new Match
                {
                    League = league,
                    Club = club,
                    MatchDay = DateTime.Now
                };

                _context.Matches.Add(match);
            }
            _context.SaveChanges();

            return Ok();
        }
    }
}
