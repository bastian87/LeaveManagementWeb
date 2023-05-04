using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "leaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "372f2d59-46e2-41ca-9bff-aca0e992200c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac47a7f-f1ac-1248-bacf-2bdd431ccbbf",
                column: "ConcurrencyStamp",
                value: "7baf3a79-9fb3-4387-b427-42dc91d88756");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57343bfe-ac1a-4a35-8dc3-edc01108a1d4", "AQAAAAEAACcQAAAAEHfubVPF+hhrEA/Pj0YtNZFEsbiWHvITDzL1iv+oakeaTr3hTeQICLp+oY/VYfKz9g==", "416e299f-4213-42d6-8a6e-5e08e63311be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e568d05-1bfe-429e-a3a5-7fc62ac7ae75", "AQAAAAEAACcQAAAAEGtPH/zpdYLfVgILXd3iceYiEnWgyIWdNPrIAV62F80nuvQAwd/THD9ZUZGBtEMAiw==", "8bf45beb-4800-46cc-b920-ffc5e91df76e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "leaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a30d4ee1-bf2c-4cb9-94e9-f4714af0e1f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac47a7f-f1ac-1248-bacf-2bdd431ccbbf",
                column: "ConcurrencyStamp",
                value: "c9ebb96e-a7ce-4546-aa36-fffde7404ab3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30754028-f4f9-43e9-8b0c-6b7daac04d47", "AQAAAAEAACcQAAAAEHcl05sLLYWfe85UXe8h06advlib2wQfT5MA+HMA24AcqL6wxqJZ6axQBEp8lWQ7aw==", "58c56843-f0af-4ee7-bad7-15b0d56a38cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "927a6a01-a341-4266-a1cf-dbbab6c69a88", "AQAAAAEAACcQAAAAEKaXhFpe7v90JGqin0Jvz+zzWGzGmmYVU9n/K9CWmkV+VzHtMgCcBDxLv20zFyeCOA==", "ac6ec0bb-5844-4219-8008-b985d838829d" });
        }
    }
}
