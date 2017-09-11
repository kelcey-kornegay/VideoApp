namespace VideoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieNumberInStockAndDateAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}
