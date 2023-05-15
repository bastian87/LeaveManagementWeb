using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class addedNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "cc3ac694-03c3-4316-9f21-cbeec8fa7b80");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac47a7f-f1ac-1248-bacf-2bdd431ccbbf",
                column: "ConcurrencyStamp",
                value: "d3d999c9-4526-4111-aee9-58b66bed94d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e531ed81-98f7-4a37-bf93-1306ba16d8d1", "AQAAAAEAACcQAAAAEIageNwCeLLyDmLDBBjRKxwo8L+UBvE1DdhcZ3OdH4ggwDX5ZzKY1X+45tYHLjq8Bg==", "7e4b9521-331f-4253-a4a1-37548ba836bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa693996-ae67-4ce8-9ea0-b87a899f51d2", "AQAAAAEAACcQAAAAEF8kCfrr3g2wbmW2Ni89TpXq/swpr0KXdGinggoyJdVuxx6kIY3gRypIxbUjyOFeaw==", "4f04e55b-ddc0-4039-b5c9-bd4e5f6a4188" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "94456b85-5308-48d0-be8d-d7d246c8baa7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac47a7f-f1ac-1248-bacf-2bdd431ccbbf",
                column: "ConcurrencyStamp",
                value: "99f8d123-3878-4073-a8d4-61158a29c574");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b15ca20-debf-4fa0-9713-1776e513ff24", "AQAAAAEAACcQAAAAECY6FHlTpg/RDJiFX5PBHDuIWpuiSn5t3C2AEtZxcci/E9mljP36Dlyt/jiuzx29aw==", "6110a353-8d64-427d-be38-313e257eaf27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f422bd8-d0f8-421e-8c90-cad43d91dcb5", "AQAAAAEAACcQAAAAEC46PpZL0THQW6ANX4f0J4zPzXnTAI3JEl1kJarNJ4ekWlE+BWTVLlQKlCQYoWY2gA==", "6f4a0201-44b1-49b8-9532-29932f590ce0" });
        }
    }
}
