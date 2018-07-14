using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Airport.DAL.Entities
{
    public class Aeroplane
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public AeroplaneType AeroplaneType { get; set; }

        public long LifeTimeHourses { get; set; }

        [NotMapped]
        public TimeSpan LifetimeFullForm {
            get
            {
                return LifetimeFullForm;
            }

            set
            {
                value = TimeSpan.FromHours(LifeTimeHourses);
            }
        }
    }
}
