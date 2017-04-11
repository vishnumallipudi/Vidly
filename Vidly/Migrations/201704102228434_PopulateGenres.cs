namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id,Name) VALUES(1,'Action')");
            Sql("INSERT INTO GENRES (Id,Name) VALUES(2,'Thrillers')");
            Sql("INSERT INTO GENRES (Id,Name) VALUES(3,'Family')");
            Sql("INSERT INTO GENRES (Id,Name) VALUES(4,'Romance')");
            Sql("INSERT INTO GENRES (Id,Name) VALUES(5,'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
