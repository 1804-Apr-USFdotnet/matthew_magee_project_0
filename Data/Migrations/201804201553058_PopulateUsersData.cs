namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUsersData : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Users (Username) values ('ddrillot0')");
            Sql("insert into Users (Username) values ('zmaymond1')");
            Sql("insert into Users (Username) values ('jcliburn2')");
            Sql("insert into Users (Username) values ('kculter3')");
            Sql("insert into Users (Username) values ('rorman4')");
            Sql("insert into Users (Username) values ('ilagadu5')");
            Sql("insert into Users (Username) values ('cskivington6')");
            Sql("insert into Users (Username) values ('caindrais7')");
            Sql("insert into Users (Username) values ('iwhale8')");
            Sql("insert into Users (Username) values ('nveldstra9')");
            Sql("insert into Users (Username) values ('bhoylea')");
            Sql("insert into Users (Username) values ('ckulvearb')");
            Sql("insert into Users (Username) values ('fmowlamc')");
            Sql("insert into Users (Username) values ('thaggatad')");
            Sql("insert into Users (Username) values ('klille')");
            Sql("insert into Users (Username) values ('mhynamf')");
            Sql("insert into Users (Username) values ('maffleckg')");
            Sql("insert into Users (Username) values ( 'hhurtadoh')");
            Sql("insert into Users (Username) values ( 'gstockini')");
            Sql("insert into Users (Username) values ('asaffellj')");

        }

        public override void Down()
        {
        }
    }
}
