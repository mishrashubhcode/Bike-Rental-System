namespace Bike_Rental_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bikes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                {
                    BikeID = c.Int(nullable: false, identity: true),
                    Brand = c.String(nullable: false, maxLength: 100),
                    Model = c.String(nullable: false, maxLength: 100),
                    Type = c.String(nullable: false),
                    Available = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.BikeID);
        }
        
        public override void Down()
        {
            DropTable("dbo.Bikes");
        }
    }
}
