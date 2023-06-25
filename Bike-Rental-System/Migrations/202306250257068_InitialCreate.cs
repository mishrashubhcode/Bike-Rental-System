namespace Bike_Rental_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "CustomerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "CustomerName", c => c.String());
        }
    }
}
