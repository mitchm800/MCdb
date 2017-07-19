using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

// Motorcycle DB Context class connects to the database for all of the controller functions.
namespace MotorCycleDB.Data
{
    public class MotorCycleDBContext : DbContext
    {

        //public MotorCycleDBContext()
        //{
        //    Database.SetInitializer(new DropCreateDatabaseAlways<MotorCycleDBContext>());
        //    Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MotorCycleDBContext>());
        //}

        public MotorCycleDBContext() : base("name=MotorCycleDBContext")
        {
            
        }

        public System.Data.Entity.DbSet<MotorCycleDB.Models.Motorcycle> Motorcycles { get; set; }
    }


}
