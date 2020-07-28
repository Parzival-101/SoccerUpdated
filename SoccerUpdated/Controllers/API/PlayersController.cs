using AutoMapper;
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
    public class PlayersController : ApiController
    {
        private ApplicationDbContext _context;
        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }

        //Get api/players
        public IHttpActionResult GetPlayers()
        {
            return Ok(_context.Players.ToList().Select(Mapper.Map <Players,PlayerDto>)) ;
        }

        //Get api/players/1
        public IHttpActionResult GetPlayers(int id)
        {
            var player = _context.Players.SingleOrDefault(m => m.Id == id);

            if (player == null)
                return NotFound();

            return Ok(Mapper.Map<Players, PlayerDto>(player));
        }

        //Post api/players
        [HttpPost]
        public IHttpActionResult CreatePlayer(PlayerDto playerdto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var players = Mapper.Map<PlayerDto, Players>(playerdto);
            _context.Players.Add(players);
            _context.SaveChanges();

            playerdto.Id = players.Id;
            return Created(new Uri(Request.RequestUri + "/" + players.Id),playerdto);
        }

        //Put api/players/1
        [HttpPut]
        public void UpdatePlayer(int id, PlayerDto playerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var playerInDb = _context.Players.SingleOrDefault(m => m.Id == id);

            if (playerInDb == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            Mapper.Map(playerDto, playerInDb);


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
