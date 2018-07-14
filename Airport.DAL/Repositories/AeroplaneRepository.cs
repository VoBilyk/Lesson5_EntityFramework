using System.Collections.Generic;
using Airport.DAL.Entities;

namespace Airport.DAL.Repositories
{
    public class AeroplaneRepository : GenericRepository<Aeroplane>
    {
        public AeroplaneRepository(AirportContext contex) : base(contex) { }
    }
}
