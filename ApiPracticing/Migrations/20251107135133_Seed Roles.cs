using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace ApiPracticing.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // User
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new [] { "Id", "Name" , "NormalizedName" , "ConcurrencyStamp" },
                values : new object[] { Guid.NewGuid().ToString() , "User" , "User".ToUpper() , Guid.NewGuid().ToString() }
              );


            // Admin
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), "Admin", "Admin".ToUpper(), Guid.NewGuid().ToString() }
              );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetRoles]");

        }
    }
}
