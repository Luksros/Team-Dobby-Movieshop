using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team_Dobby_Movieshop.Migrations
{
    public partial class testmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movies",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9fa474d4-0246-47db-834e-5b44c2d3ae19", "31451941-4521-4aae-869f-fb4468d30054", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d49bc437-f9e7-41c4-be19-c17ad1691612", "74657c24-ef90-41bd-b8f9-6984108c72ea", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fa474d4-0246-47db-834e-5b44c2d3ae19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d49bc437-f9e7-41c4-be19-c17ad1691612");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Movies",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");
        }
    }
}
