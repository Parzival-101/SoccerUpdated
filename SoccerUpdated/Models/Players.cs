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

        [Display(Name ="Date of Birth")]
        public DateTime? BirthDate { get; set; }

        public Club Club { get; set; }

        [Display(Name ="Club")]
        public int ClubId { get; set; }

        public string Position { get; set; }

        public string Country { get; set; }

    }
}