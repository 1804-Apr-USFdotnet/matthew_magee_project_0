namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedReviewModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "RestaurantId_Id", "dbo.Restaurants");
            DropIndex("dbo.Reviews", new[] { "RestaurantId_Id" });
            AddColumn("dbo.Reviews", "RestaurantId", c => c.Int(nullable: false));
            DropColumn("dbo.Reviews", "RestaurantId_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "RestaurantId_Id", c => c.Int());
            DropColumn("dbo.Reviews", "RestaurantId");
            CreateIndex("dbo.Reviews", "RestaurantId_Id");
            AddForeignKey("dbo.Reviews", "RestaurantId_Id", "dbo.Restaurants", "Id");
        }
    }
}
