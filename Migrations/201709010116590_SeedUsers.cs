namespace VideoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[AspNetUsers]
        ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'e986d642-ae25-4013-b58c-45d492fe80dc', N'fake@gmail.com', 0, N'ANfSxPZcRon2PKOOPTHizgrnTRKjwHS7KIjsBAo2uqda/arxXrH0VBlv6uax4S+VAA==', N'15ac40ed-fccd-458d-a74b-b9d90587a42a', NULL, 0, 0, NULL, 1, 0, N'fake@gmail.com')
INSERT INTO[dbo].[AspNetUsers]
        ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'f4eb21ce-528f-4d5b-8941-c83adfce9e21', N'admin@kelecy.com', 0, N'AEVaFVBJlRq6hnm5bKwtHR78rjlspsPcJkR9bbUlTEYt5uqj1G1UNWATxxT1SNhjdg==', N'e9356536-c40b-4726-ba8c-daf3132cdb6d', NULL, 0, 0, NULL, 1, 0, N'admin@kelecy.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'13fcc209-726a-4271-89c0-0ae46d2314e7', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f4eb21ce-528f-4d5b-8941-c83adfce9e21', N'13fcc209-726a-4271-89c0-0ae46d2314e7')
");
        }

    public override void Down()
        {
        }
    }
}
