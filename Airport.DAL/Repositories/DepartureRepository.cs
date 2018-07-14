﻿using System.Collections.Generic;
using Airport.DAL.Models;

namespace Airport.DAL.Repositories
{
    public class DepartureRepository : GenericRepository<Departure>
    {
        public DepartureRepository(AirportContext contex) : base(contex) { }
    }
}
