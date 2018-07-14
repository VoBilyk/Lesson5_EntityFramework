using Airport.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Airport.DAL.Entities
{
    public class Departure
    {
        public Guid Id { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public Crew Crew { get; set; }

        [Required]
        public Aeroplane Airplane { get; set; }
    }
}
