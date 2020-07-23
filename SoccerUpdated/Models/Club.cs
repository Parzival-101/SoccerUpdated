using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoccerUpdated.Models
{
    public class Club
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public League League { get; set; }
        public string Stadium { get; set; }
        public string City { get; set; }
    }
}