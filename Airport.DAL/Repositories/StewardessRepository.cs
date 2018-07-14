using System.Collections.Generic;
using Airport.DAL.Models;

namespace Airport.DAL.Repositories
{
    public class StewardessRepository : GenericRepository<Stewardess>
    {
        public StewardessRepository(AirportContext contex) : base(contex) { }
    }
}
