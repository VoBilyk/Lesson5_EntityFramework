using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Airport.DAL.Entities
{
    public class Flight
    {
        [Key]
        public string Name { get; set; }

        [Required]
        public string DeparturePoint { get; set; }

        [Required]
        public string Destinition { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public ICollection<Ticket> Tickets { get; set; }
    }
}
