using System.Collections.Generic;
using Airport.DAL.Entities;

namespace Airport.DAL.Repositories
{
    public class TicketRepository : GenericRepository<Ticket>
    {
        public TicketRepository(AirportContext contex) : base(contex) { }
    }
}
