﻿using System.Collections.Generic;
using Airport.DAL.Models;

namespace Airport.DAL.Repositories
{
    class AeroplaneTypeRepository : GenericRepository<AeroplaneType>
    {
        public AeroplaneTypeRepository(AirportContext context) : base(context) { }
    }
}
