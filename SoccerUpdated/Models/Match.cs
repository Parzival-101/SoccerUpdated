using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoccerUpdated.Models
{
    public class Match
    {
        public int Id { get; set; }

        [Display(Name ="Match Day")]
        public DateTime? MatchDay { get; set; }

        [Required]
        public League League { get; set; }

        [Required]
        public Club Club { get; set; }

    }
}