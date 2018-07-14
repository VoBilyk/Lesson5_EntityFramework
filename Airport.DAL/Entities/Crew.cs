using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Airport.DAL.Entities
{
    public class Crew
    {
        public Guid Id { get; set; }

        [Required]
        public Pilot Pilot { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Crew can`t have less than 1 stewardess")]
        public ICollection<Stewardess> Stewardesses { get; set; }
    }
}
