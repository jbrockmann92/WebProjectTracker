using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackingWebApp.Data.Migrations
{
    public partial class addedProjectToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9985c27f-f151-4149-a799-8dfe6450b391");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50cab7ed-2add-4482-bbf9-9e4237df811e", "687829d8-77e7-4fdd-b9a1-cf541afdc3ca", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Budget", "BudgetUsed", "Mileage", "Title" },
                values: new object[] { 1, 1000f, 500f, 50f, "Roof" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50cab7ed-2add-4482-bbf9-9e4237df811e");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9985c27f-f151-4149-a799-8dfe6450b391", "a57193d6-e7d7-4283-9b68-22b7e5fe42f7", "User", "USER" });
        }
    }
}
