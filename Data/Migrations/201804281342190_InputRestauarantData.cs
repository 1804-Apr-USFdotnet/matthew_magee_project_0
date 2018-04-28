namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InputRestauarantData : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Gibson Group', '390 Mariners Cove Point', 18289, '336-239-5329')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Homenick, Schimmel and Hoppe', '7914 Ramsey Park', 14637, '304-332-3562')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Konopelski LLC', '472 Riverside Way', 42481, '831-897-9365')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Hegmann, Thompson and Cassin', '4195 Rusk Pass', 94213, '995-164-4152')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Greenfelder-Muller', '00826 Bluestem Street', 53629, '918-642-9289')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Runolfsdottir-Renner', '0 Mariners Cove Crossing', 13153, '316-855-6447')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Muller LLC', '0898 Kropf Court', 96071, '505-927-2523')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Bogisich, Yundt and Cassin', '7223 Mallory Center', 50195, '269-884-7355')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Dibbert, Langworth and Koelpin', '5 Basil Junction', 29848, '504-911-9097')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Kozey, Murphy and Hand', '525 Crescent Oaks Junction', 27239, '474-497-4830')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Haag and Sons', '890 Hanson Hill', 87398, '209-684-7398')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Kilback Group', '6 Alpine Hill', 62691, '493-709-7234')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Kovacek-Schneider', '409 Lindbergh Lane', 35910, '783-100-9891')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Lowe-Bernier', '588 Crest Line Lane', 59334, '329-832-4170')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Borer-Goldner', '0 Debra Circle', 65862, '947-502-4749')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Denesik, Keebler and Blanda', '6 Fairfield Court', 69765, '562-646-5817')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Rowe, Rempel and Rolfson', '1948 Walton Court', 65762, '840-807-3069')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Mosciski, Ankunding and Smitham', '26838 Sundown Parkway', 74963, '265-112-3400')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Glover-Gaylord', '0 Stuart Parkway', 73944, '817-856-0527')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Padberg, Wunsch and Schowalter', '2 Merry Drive', 21169, '840-854-9275')");

        }

        public override void Down()
        {
        }
    }
}
