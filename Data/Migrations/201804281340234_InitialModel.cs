namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        ZipCode = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReviewMessage = c.String(),
                        Rating = c.Single(nullable: false),
                        Restaurants_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.Restaurants_Id)
                .Index(t => t.Restaurants_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Restaurants_Id", "dbo.Restaurants");
            DropIndex("dbo.Reviews", new[] { "Restaurants_Id" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Restaurants");
        }
    }
}
