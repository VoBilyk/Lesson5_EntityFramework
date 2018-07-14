﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Airport.DAL.Entities
{
    public class Pilot
    {
        public Guid Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "FirstName can`t be less than 3 symbols")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "SecondName can`t be less than 3 symbols")]
        public string SecondName { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
    }
}
