﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Win32.SafeHandles;

#nullable disable

namespace IdentityAndUserManagement.Data.Migrations
{
    public partial class seedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                new object[] {Guid.NewGuid().ToString(), "User" , "User".ToUpper(),Guid.NewGuid().ToString() },
                schema:"security"
                );
            migrationBuilder.InsertData(
    table: "Roles",
    columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
    new object[] { Guid.NewGuid().ToString(), "Admin", "Admin".ToUpper(), Guid.NewGuid().ToString() },
    schema: "security"
    );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Roles]");
        }
    }
}
