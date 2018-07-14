using System.Collections.Generic;
using Airport.DAL.Entities;

namespace Airport.DAL.Repositories
{
    public class FlightRepository : GenericRepository<Flight>
    {
        public FlightRepository(AirportContext contex) : base(contex) { }
    }
}
