using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MotorCycleDB.Models
{
    public class Motorcycle
    {
        // Set up properties for Motorcycles
        public int Id { get; set; }
        public string Mfg { get; set; }
        public string ModelId { get; set; }
        public int ModelYear { get; set; }
        public string Engine { get; set; }
        public int Horsepower { get; set; }
        public int Torque { get; set; }
        public int? Weight { get; set; }
        public string Style { get; set; }
        public string Description { get; set; }

        //public string GetDisplayBike()
        //{
        //    return ModelYear + " " + ModelId;
        //}

            // Add DB context class for communication with database
        public class MotorcycleDBContext : DbContext
        {
            public DbSet<Motorcycle> Motorcycles { get; set; }
        }

        //public string BikeImage
        //{
        //    get
        //    {
        //        return SeriesTitle.Replace
        //    }
        //}

        //public Engine Engine { get; set; }
        //public Chassis Chassis { get; set; }
        //public Mfg Mfg { get; set; }

    }
}