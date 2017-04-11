namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES(Name,GenreId,DataAdded,ReleasaeDate,NumberInStock) VALUES('Hangover',5,'2/6/2017','6/15/2014',8)");
            Sql("INSERT INTO MOVIES(Name,GenreId,DataAdded,ReleasaeDate,NumberInStock) VALUES('DieHard',1,'2/6/2017','3/12/2013',3)");
            Sql("INSERT INTO MOVIES(Name,GenreId,DataAdded,ReleasaeDate,NumberInStock) VALUES('StepUp 2',2,'2/6/2017','5/6/2011',5)");
            Sql("INSERT INTO MOVIES(Name,GenreId,DataAdded,ReleasaeDate,NumberInStock) VALUES('Transformers-3',1,'2/6/2017','9/23/2012',6)");
            Sql("INSERT INTO MOVIES(Name,GenreId,DataAdded,ReleasaeDate,NumberInStock) VALUES('Battleship ',1,'2/6/2017','1/15/2014',2)");
            Sql("INSERT INTO MOVIES(Name,GenreId,DataAdded,ReleasaeDate,NumberInStock) VALUES('Getout',4,'2/6/2017','7/15/2015',4)");
        }
        
        public override void Down()
        {
        }
    }
}
