namespace VideoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Isubscribed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribrdToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribrdToNewsletter");
        }
    }
}
