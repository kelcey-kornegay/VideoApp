namespace VideoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeData : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name ='Pay as You Go' where id = 1");
            Sql("Update MembershipTypes Set Name ='Monthly' where id = 2");
            Sql("Update MembershipTypes Set Name ='Quarterly' where id = 3");
            Sql("Update MembershipTypes Set Name ='Annual' where id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
