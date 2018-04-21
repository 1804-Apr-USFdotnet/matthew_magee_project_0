namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRestaruantData : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Fadeo', '1627 Jenifer Point', 60020, '268-264-0521')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Babbleset', '3 Karstens Street', 59641, '912-126-2741')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Blogtag', '22 Reinke Alley', 93087, '855-135-8319')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Trilia', '72 Buhler Point', 62418, '569-384-4325')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Jabbersphere', '829 Russell Crossing', 70206, '388-827-9250')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Snaptags', '04128 Thompson Place', 69451, '443-117-2865')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Brainsphere', '400 Burrows Court', 15190, '865-715-7303')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Lazz', '1263 Fairfield Center', 21954, '447-641-3637')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Kwimbee', '44 Riverside Circle', 57404, '381-536-0732')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Shufflester', '31603 Ridgeview Avenue', 58267, '688-345-9561')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Photolist', '8 Porter Hill', 68512, '144-482-2938')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Yoveo', '03229 Lindbergh Place', 32032, '954-653-4243')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Oyope', '6 Hazelcrest Road', 26938, '781-392-6674')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Blogpad', '41 Marcy Trail', 25949, '314-468-0843')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Zoomdog', '35 Longview Junction', 48421, '194-165-5765')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Gabspot', '7030 Ohio Hill', 76095, '266-369-5293')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Livetube', '04017 Anderson Park', 15179, '436-387-0381')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Jaxworks', '819 Reindahl Point', 77827, '302-135-5579')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Yamia', '61438 Bonner Circle', 36869, '259-497-3947')");
            Sql("insert into Restaurants (Name, Address, ZipCode, PhoneNumber) values ('Tagcat', '76 Roxbury Way', 26420, '556-201-0016')");

        }

        public override void Down()
        {
        }
    }
}
