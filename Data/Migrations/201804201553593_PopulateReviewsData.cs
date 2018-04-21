namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateReviewsData : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam.', 6.2, 11, 19)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.', 2.1, 7, 15)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Duis mattis egestas metus. Aenean fermentum.', 4.0, 18, 18)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum.', 2.7, 8, 14)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet. Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.', 8.5, 16, 12)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem.', 9.7, 3, 5)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Suspendisse potenti. Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.', 9.7, 18, 15)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.', 6.9, 6, 20)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat. Nulla nisl.', 2.6, 16, 3)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.', 8.5, 18, 2)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor. Duis mattis egestas metus. Aenean fermentum.', 5.1, 15, 19)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.', 7.7, 1, 4)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat.', 9.4, 20, 16)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem. Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio.', 2.9, 17, 17)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio.', 6.6, 19, 16)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Donec ut dolor.', 7.7, 20, 9)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla.', 2.3, 1, 7)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi. Cras non velit nec nisi vulputate nonummy.', 6.6, 16, 17)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.', 9.6, 3, 12)");
            Sql("insert into Reviews (ReviewMessage, Rating, Restaurants_Id, Users_Id) values ('Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.', 3.2, 20, 17)");

        }

        public override void Down()
        {
        }
    }
}
