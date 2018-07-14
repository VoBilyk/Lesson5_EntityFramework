using System;

namespace Airport.DAL.Entities
{
    public class AeroplaneType
    {
        public Guid Id { get; set; }

        public string Model { get; set; }

        public int Places { get; set; }

        public int Carrying { get; set; }
    }
}
