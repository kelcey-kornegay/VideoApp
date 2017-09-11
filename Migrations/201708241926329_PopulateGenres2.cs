namespace VideoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Genres (Name)values('Family')");
            Sql("INSERT into Genres (Name)values('Comedy')");
            Sql("INSERT into Genres (Name)values('Action')");
            Sql("INSERT into Genres (Name)values('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
