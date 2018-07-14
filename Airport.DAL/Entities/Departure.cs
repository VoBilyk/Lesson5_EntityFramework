using Airport.DAL.Interfaces;
using System;

namespace Airport.DAL.Entities
{
    public class Departure
    {
        public Guid Id { get; set; }

        public DateTime Time { get; set; }

        public Crew Crew { get; set; }

        public Aeroplane Airplane { get; set; }
    }
}
