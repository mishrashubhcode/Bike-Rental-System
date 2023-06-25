namespace Bike_Rental_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rentals : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                {
                    RentalID = c.Int(nullable: false, identity: true),
                    CustomerID = c.Int(nullable: false),
                    BikeID = c.Int(nullable: false),
                    RentalDate = c.DateTime(nullable: false),
                    ReturnDate = c.DateTime(nullable: true),
                    TotalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.RentalID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Bikes", t => t.BikeID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.BikeID);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "BikeID", "dbo.Bikes");
            DropForeignKey("dbo.Rentals", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "BikeID" });
            DropIndex("dbo.Rentals", new[] { "CustomerID" });
            DropTable("dbo.Rentals");
            
        }
    }
}
