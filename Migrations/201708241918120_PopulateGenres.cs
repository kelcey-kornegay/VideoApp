namespace VideoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Genres (Name)values('Thriller')");
            


        }
        
        public override void Down()
        {
        }
    }
}
