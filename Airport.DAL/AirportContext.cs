using Microsoft.EntityFrameworkCore;
using Airport.DAL.Models;


namespace Airport.DAL
{
    public class AirportContext : DbContext
    {
        public DbSet<Aeroplane> Aeroplanes { get; set; }

        public DbSet<AeroplaneType> AeroplaneTypes { get; set; }

        public DbSet<Crew> Crews { get; set; }

        public DbSet<Departure> Departures { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<Pilot> Pilots { get; set; }

        public DbSet<Stewardess> Stewardesses { get; set; }

        public DbSet<Ticket> Tickets { get; set; }


        public AirportContext()
        {
            Database.EnsureCreated();
        }

    }
}
