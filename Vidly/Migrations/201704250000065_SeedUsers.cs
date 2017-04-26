namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'50d8e71d-e5b2-425e-9681-ab944ec94eb6', N'admin@vidly.com', 0, N'APtSnM+dO5Ygw67V4GwiCPJYYBgNKBewlZI0aJyKRT/Z7pGDOO5Jcsa9+ixVBey69w==', N'8eba858f-e853-4005-966c-2a0195778def', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ae4755ce-ebc8-40bb-870a-f763d59a44a6', N'guest@vidly.com', 0, N'AJ9XmBrzrSxOXThW1dEWY1gGLyEhCH04no44gzm0rQhVY3kq9lDUa9i7wSVYtSRuRw==', N'e955e9d3-7736-4170-a86f-68566c86334a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a87503b7-8033-43ef-bb6f-77658235217a', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'50d8e71d-e5b2-425e-9681-ab944ec94eb6', N'a87503b7-8033-43ef-bb6f-77658235217a')



            ");
        }
        
        public override void Down()
        {
        }
    }
}
