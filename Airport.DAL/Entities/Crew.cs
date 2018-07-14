using System;
using System.Collections.Generic;

namespace Airport.DAL.Entities
{
    public class Crew
    {
        public Guid Id { get; set; }

        public Pilot Pilot { get; set; }

        public ICollection<Stewardess> Stewardesses { get; set; }
    }
}
