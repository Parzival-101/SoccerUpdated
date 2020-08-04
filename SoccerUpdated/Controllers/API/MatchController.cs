using SoccerUpdated.Dto;
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
        [HttpPost]
        public IHttpActionResult CreateNewMatch(NewMatchDto newMatch)
        {
            throw new NotImplementedException();
        }
    }
}
