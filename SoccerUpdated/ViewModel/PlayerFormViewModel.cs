using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoccerUpdated.Models;

namespace SoccerUpdated.ViewModel
{
    public class PlayerFormViewModel
    {
        public IEnumerable<Club> Clubs { get; set; }
        public Players Players { get; set; }
    }
}