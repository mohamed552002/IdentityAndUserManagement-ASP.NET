using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityAndUserManagement.Data.Migrations
{
    public partial class AddAdminToUserWithMigrationBuilder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePic]) VALUES (N'cca55dc5-4eea-4649-90a2-c94437a48d2e', N'admin@test.com', N'ADMIN@TEST.COM', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAEAACcQAAAAEEX90QWe7MGV6psk/+793zEJAJJFVUJCQbcX/Pk4f1sWl4Veh8H6nHoPXSmCD4uXJA==', N'D3XESDNWXU53SIYOM5U5IJUOY2BIXDUI', N'fce99f5c-73aa-4fbb-8464-805ed287aef7', NULL, 0, 0, NULL, 1, 0, N'admin', N'test', NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = 'cca55dc5-4eea-4649-90a2-c94437a48d2e' ");
        }
    }
}
