namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReviewsData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Reviews SET Username = 'ddrillot0' WHERE Id = 1");
            Sql("UPDATE Reviews SET Username = 'zmaymond1' WHERE Id = 2");
            Sql("UPDATE Reviews SET Username = 'jcliburn2' WHERE Id = 3");
            Sql("UPDATE Reviews SET Username = 'kculter3' WHERE Id = 4");
            Sql("UPDATE Reviews SET Username = 'rorman4' WHERE Id = 5");
            Sql("UPDATE Reviews SET Username = 'ilagadu5' WHERE Id = 6");
            Sql("UPDATE Reviews SET Username = 'cskivington6' WHERE Id = 7");
            Sql("UPDATE Reviews SET Username = 'caindrais7' WHERE Id = 8");
            Sql("UPDATE Reviews SET Username = 'iwhale8' WHERE Id = 9");
            Sql("UPDATE Reviews SET Username = 'nveldstra9' WHERE Id = 10");
            Sql("UPDATE Reviews SET Username = 'bhoylea' WHERE Id = 11");
            Sql("UPDATE Reviews SET Username = 'ckulvearb' WHERE Id = 12");
            Sql("UPDATE Reviews SET Username = 'fmowlamc' WHERE Id = 13");
            Sql("UPDATE Reviews SET Username = 'thaggatad' WHERE Id = 14");
            Sql("UPDATE Reviews SET Username = 'klille' WHERE Id = 15");
            Sql("UPDATE Reviews SET Username = 'mhynamf' WHERE Id = 16");
            Sql("UPDATE Reviews SET Username = 'maffleckg' WHERE Id = 17");
            Sql("UPDATE Reviews SET Username = 'hhurtadoh' WHERE Id = 18");
            Sql("UPDATE Reviews SET Username = 'gstockini' WHERE Id = 19");
            Sql("UPDATE Reviews SET Username = 'asaffellj' WHERE Id = 20");
        }
        
        public override void Down()
        {
        }
    }
}
