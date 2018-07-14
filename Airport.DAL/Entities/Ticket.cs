using System;

namespace Airport.DAL.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public decimal Price { get; set; }

        public Flight Flight { get; set; }
    }
}
