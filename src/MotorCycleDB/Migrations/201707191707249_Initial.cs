namespace MotorCycleDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Motorcycles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mfg = c.String(),
                        ModelId = c.String(),
                        ModelYear = c.Int(nullable: false),
                        Engine = c.String(),
                        Horsepower = c.Int(nullable: false),
                        Torque = c.Int(nullable: false),
                        Weight = c.Int(),
                        Style = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Motorcycles");
        }
    }
}
