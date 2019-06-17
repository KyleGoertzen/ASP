namespace VideoStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'03ca02b0-e1b0-4d63-a6d7-97696c5726fe', N'admin@videostore.com', 0, N'AG6kTTF/jV+njECkOwC3HDq8LF8jqA/cmUAemXN2op7011AdjrpTtdIPEQ38kRB2qw==', N'3edcbcc9-5ad9-4bf1-9a79-c1e26109dacd', NULL, 0, 0, NULL, 1, 0, N'admin@videostore.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0b822e6a-4034-4848-b47f-fb4510a18e6e', N'guest@videostore.com', 0, N'AHXWhVnCZ7cWNoReUh3F99EeP0qdQ9MihMOhaJeyCGYYX6s06tvH/BFGAowGp9VDYQ==', N'e6c76d16-24d9-430b-a2b2-28e4ed1b46d3', NULL, 0, 0, NULL, 1, 0, N'guest@videostore.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd9943533-84dd-4a1e-b8dd-d28b9daa7138', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'03ca02b0-e1b0-4d63-a6d7-97696c5726fe', N'd9943533-84dd-4a1e-b8dd-d28b9daa7138')

");
        }
        
        public override void Down()
        {
        }
    }
}
