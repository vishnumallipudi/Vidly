namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdayToCoustomers : DbMigration
    {
        public override void Up()
        {
            //Sql("UPDATE Customers SET Birthday='1/7/1994' WHERE Id=1");
            Sql("UPDATE Customers SET Birthday = CAST('1980-01-01' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
