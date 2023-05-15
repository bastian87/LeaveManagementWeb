using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "leaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "leaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b06ccc64-5309-40e9-8bd2-317d6ef42fb6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac47a7f-f1ac-1248-bacf-2bdd431ccbbf",
                column: "ConcurrencyStamp",
                value: "bfa3d938-29ec-4be9-8e50-1cf52658a529");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10811ec2-29d9-452b-8ce3-2fdddc4220bb", "AQAAAAEAACcQAAAAEJ+w/Jy9JtOBbaZciDrMTlCmxBCNUOCNr4SjZ9jbqwYYs1Qr1Qir//+RFX4T06LvQQ==", "9effc977-da06-46ef-8e9a-cd010821a38d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e06e580e-43c5-47b2-b620-0598359217f4", "AQAAAAEAACcQAAAAEL5urfrMHHIgiAkE9082imAJNxjabZbZkR6c+Yshjbxaw4vqVMUyKtPppvtlpqCYjw==", "9a90fa04-5de3-461b-a8ff-94bd652ed2ad" });
        }
    }
}
