using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackingWebApp.Data.Migrations
{
    public partial class addedUserIdtoProjectModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50cab7ed-2add-4482-bbf9-9e4237df811e");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Projects",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c4fb00c-15f7-46ce-b6cc-98133d97d551", "d7e9818b-5823-4275-bdb3-47e449c8ef38", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c4fb00c-15f7-46ce-b6cc-98133d97d551");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Projects");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50cab7ed-2add-4482-bbf9-9e4237df811e", "687829d8-77e7-4fdd-b9a1-cf541afdc3ca", "User", "USER" });
        }
    }
}
