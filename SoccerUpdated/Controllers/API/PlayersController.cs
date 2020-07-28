using SoccerUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SoccerUpdated.Controllers.API
{
    public class PlayersController : ApiController
    {
        private ApplicationDbContext _context;
        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }

        //Get api/players
        public IEnumerable<Players> GetPlayers()
        {
            return _context.Players.ToList() ;
        }

        //Get api/players/1
        public Players GetPlayers(int id)
        {
            var player = _context.Players.SingleOrDefault(m => m.Id == id);

            if (player == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            return player;
        }

        //Post api/players
        [HttpPost]
        public Players CreatePlayer(Players players)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Players.Add(players);
            _context.SaveChanges();

            return players;
        }

        //Put api/players/1
        [HttpPut]
        public void UpdatePlayer(int id, Players players)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var playerInDb = _context.Players.SingleOrDefault(m => m.Id == id);

            if (playerInDb == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            playerInDb.Name = players.Name;
            playerInDb.Position = players.Position;
            playerInDb.ClubId = players.ClubId;
            playerInDb.Country = players.Country;
            playerInDb.BirthDate = players.BirthDate;

            _context.SaveChanges();

        }

        //Delete api/players/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var playerInDb = _context.Players.SingleOrDefault(m => m.Id == id);

            if (playerInDb == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Players.Remove(playerInDb);
            _context.SaveChanges();
        }
    }
}
