namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedInitialModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Users_Id", "dbo.Users");
            DropIndex("dbo.Reviews", new[] { "Users_Id" });
            RenameColumn(table: "dbo.Reviews", name: "Restaurants_Id", newName: "RestaurantId_Id");
            RenameIndex(table: "dbo.Reviews", name: "IX_Restaurants_Id", newName: "IX_RestaurantId_Id");
            AddColumn("dbo.Reviews", "Username", c => c.String());
            DropColumn("dbo.Reviews", "Users_Id");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Reviews", "Users_Id", c => c.Int());
            DropColumn("dbo.Reviews", "Username");
            RenameIndex(table: "dbo.Reviews", name: "IX_RestaurantId_Id", newName: "IX_Restaurants_Id");
            RenameColumn(table: "dbo.Reviews", name: "RestaurantId_Id", newName: "Restaurants_Id");
            CreateIndex("dbo.Reviews", "Users_Id");
            AddForeignKey("dbo.Reviews", "Users_Id", "dbo.Users", "Id");
        }
    }
}
