using SoccerUpdated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerUpdated.Dto
{
    public class NewMatchDto
    {
        public int LeagueId { get; set; }
        public List<int> ClubIds { get; set; }
    }
}