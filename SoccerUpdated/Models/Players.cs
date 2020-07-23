using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoccerUpdated.Models
{
    public class Players
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public Club Club { get; set; }
        public string Position { get; set; }
        public string Country { get; set; }

    }
}