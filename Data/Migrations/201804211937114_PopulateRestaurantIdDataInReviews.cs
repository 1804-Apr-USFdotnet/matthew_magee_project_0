namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRestaurantIdDataInReviews : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Reviews SET RestaurantId_Id = 3 WHERE Id = 1");
            Sql("UPDATE Reviews SET RestaurantId_Id = 2 WHERE Id = 2");
            Sql("UPDATE Reviews SET RestaurantId_Id = 5 WHERE Id = 3");
            Sql("UPDATE Reviews SET RestaurantId_Id = 5 WHERE Id = 4");
            Sql("UPDATE Reviews SET ReataurantId_Id = 8 WHERE Id = 5");
            Sql("UPDATE Reviews SET RestaurantId_Id = 10 WHERE Id = 6");
            Sql("UPDATE Reviews SET RestaurantId_Id = 1 WHERE Id = 7");
            Sql("UPDATE Reviews SET RestaurantId_Id = 18 WHERE Id = 8");
            Sql("UPDATE Reviews SET ReataurantId_Id = 12 WHERE Id = 9");
            Sql("UPDATE Reviews SET RestaurantId_Id = 1 WHERE Id = 10");
            Sql("UPDATE Reviews SET RestaurantId_Id = 4 WHERE Id = 11");
            Sql("UPDATE Reviews SET RestaurantId_Id = 5 WHERE Id = 12");
            Sql("UPDATE Reviews SET RestaurantId_Id = 17 WHERE Id = 13");
            Sql("UPDATE Reviews SET RestaurantId_Id = 2 WHERE Id = 14");
            Sql("UPDATE Reviews SET RestaurantId_Id = 20 WHERE Id = 15");
            Sql("UPDATE Reviews SET RestaurantId_Id = 20 WHERE Id = 16");
            Sql("UPDATE Reviews SET RestaurantId_Id = 2 WHERE Id = 17");
            Sql("UPDATE Reviews SET RestaurantId_Id = 7 WHERE Id = 18");
            Sql("UPDATE Reviews SET RestaurantId_Id = 6 WHERE Id = 19");
            Sql("UPDATE Reviews SET RestaurantId_Id = 19 WHERE Id = 20");
            Sql("UPDATE Reviews SET RestaurantId = 20 WHERE Id = 16");
            Sql("UPDATE Reviews SET RestaurantId = 2 WHERE Id = 17");
            Sql("UPDATE Reviews SET RestaurantId = 7 WHERE Id = 18");
            Sql("UPDATE Reviews SET RestaurantId = 6 WHERE Id = 19");
            Sql("UPDATE Reviews SET RestaurantId = 19 WHERE Id = 20");
        }
        
        public override void Down()
        {
        }
    }
}
