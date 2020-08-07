namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'70b92f23-a5de-4649-9955-10c8a64a4b49', N'admin@vidly.com', 0, N'ANnAqu/9pP7DRl7BGIB3rvAGT3869Y9jdHQ+utvbhSgGm4WgrSIHskWTzFdDGWwnrg==', N'04bacba8-d25a-4fae-a21d-00d0fbcd3f2e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a697344b-69f4-43bb-871e-e62d2f35ec03', N'guest@vidly.com', 0, N'AFfxYVo/YfzEX9LvDP63OwS+FlGDc9e96bkzh4bPga7M+M7KX4Gj55eZ24mtWC07Zw==', N'2091e3ac-04a7-463e-adad-ccf64b96e8ea', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2517b517-4ebb-4ced-b697-6c86e651f258', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'70b92f23-a5de-4649-9955-10c8a64a4b49', N'2517b517-4ebb-4ced-b697-6c86e651f258')

");
        }
        
        public override void Down()
        {
        }
    }
}
