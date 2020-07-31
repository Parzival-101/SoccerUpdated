using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoccerUpdated.Dto
{
    public class PlayerDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public DateTime? BirthDate { get; set; }

        public ClubDto Club { get; set; }

        public int ClubId { get; set; }

        public string Position { get; set; }

        public string Country { get; set; }
    }
}