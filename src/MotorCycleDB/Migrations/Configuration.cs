namespace MotorCycleDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MotorCycleDB.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MotorCycleDB.Data.MotorCycleDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        // Seed method to populate database with some records.
        protected override void Seed(MotorCycleDB.Data.MotorCycleDBContext context)
        {
            context.Motorcycles.AddOrUpdate(
                m => m.Id,
                new Motorcycle()
                {
                    Id = 1,
                    Mfg = "Honda",
                    ModelId = "VFR800",
                    ModelYear = 2003,
                    Engine = "800",
                    Horsepower = 110,
                    Torque = 60,
                    Weight = 525,
                    Style = "Sport-Touring",
                    Description = "The Honda VFR800 Interceptor is a sport touring motorcycye featuring a 90 degree V4 engine, a VTEC valve train and a single sided swingarm."
                });

            context.Motorcycles.AddOrUpdate(
                m => m.Id,
                new Motorcycle()
                {
                    Id = 2,
                    Mfg = "Harley-Davidson",
                    ModelId = "Sportster Iron 883",
                    ModelYear = 2010,
                    Engine = "883",
                    Horsepower = 40,
                    Torque = 60,
                    Weight = 550,
                    Style = "Cruiser",
                    Description = "The Harley Sportster is an iconic cruiser motorcycle.  The Iron 883 variant has a throwback style."
                });

            context.Motorcycles.AddOrUpdate(
                m => m.Id,
                new Motorcycle()
                {
                    Id = 3,
                    Mfg = "Kawasaki",
                    ModelId = "Vulcan",
                    ModelYear = 2012,
                    Engine = "900",
                    Horsepower = 50,
                    Torque = 64,
                    Weight = 550,
                    Style = "Cruiser",
                    Description = "The Kawasaki Vulcan is a cruiser style motorcycle.  It features a low seat height and a relaxed riding position."
                });
        }
    }
}
