using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Airport.DAL.Models;


namespace Airport.DAL
{
    public class AirportContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }


        public AirportContext() : base()
        {

        }
    }
}
