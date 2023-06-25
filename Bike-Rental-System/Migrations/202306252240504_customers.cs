namespace Bike_Rental_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customers : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
            
        }
    }
}
