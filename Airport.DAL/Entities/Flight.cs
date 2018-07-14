using System;
using System.Collections.Generic;

namespace Airport.DAL.Entities
{
    public class Flight
    {
        public Guid Id { get; set; }

        public string DeparturePoint { get; set; }

        public string Destinition { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureTime { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
