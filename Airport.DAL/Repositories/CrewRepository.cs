using System.Collections.Generic;
using Airport.DAL.Models;

namespace Airport.DAL.Repositories
{
    public class CrewRepository : GenericRepository<Crew>
    {
        public CrewRepository(AirportContext contex) : base(contex) { }
    }
}
