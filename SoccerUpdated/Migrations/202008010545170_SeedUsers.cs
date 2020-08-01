namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
             INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7bd92d93-cc2d-42ff-95ae-4796897da962', N'User1@gmail.com', 0, N'AOpHou3/6IXjZK/zxwzeQbMkC+lMgd0dQVBSAklvCBMQGYImjPLg6CMFa8dscZgLWA==', N'fbbede5c-3269-453d-8993-5029e7500501', NULL, 0, 0, NULL, 1, 0, N'User1@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cf299028-8b43-42bc-aef8-3fe9d992b8b7', N'Admin101@gmail.com', 0, N'ANQBYMAuoadjiRFSjwePK3NfBwmN00ZRnft6sg6zJ05gB/r9C8qKXjjewG9gHxlq+Q==', N'e0c6e499-a4c4-4ee1-9f51-3c98b3788787', NULL, 0, 0, NULL, 1, 0, N'Admin101@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b27b0f03-217b-423b-83f7-882e88ae5914', N'CanManagePlayer')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cf299028-8b43-42bc-aef8-3fe9d992b8b7', N'b27b0f03-217b-423b-83f7-882e88ae5914')

           ");
        }
        
        public override void Down()
        {
        }
    }
}
