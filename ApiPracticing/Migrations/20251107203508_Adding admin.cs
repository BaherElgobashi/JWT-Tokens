using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPracticing.Migrations
{
    /// <inheritdoc />
    public partial class Addingadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Admin
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), "Manga", "Manga".ToUpper(), Guid.NewGuid().ToString() }
              );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetRoles]");
        }
    }
}
