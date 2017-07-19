﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MotorCycleDB.Data
{
    public class MotorCycleDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

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
