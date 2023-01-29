using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityAndUserManagement.Data.Migrations
{
    public partial class AssignAdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles] (UserId,RoleId) SELECT 'cca55dc5-4eea-4649-90a2-c94437a48d2e' , Id FROM [security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId = 'cca55dc5-4eea-4649-90a2-c94437a48d2e' ");
        }
    }
}
