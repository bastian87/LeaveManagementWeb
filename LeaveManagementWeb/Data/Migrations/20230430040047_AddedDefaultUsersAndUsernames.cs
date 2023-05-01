using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "30754028-f4f9-43e9-8b0c-6b7daac04d47", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHcl05sLLYWfe85UXe8h06advlib2wQfT5MA+HMA24AcqL6wxqJZ6axQBEp8lWQ7aw==", "58c56843-f0af-4ee7-bad7-15b0d56a38cb", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "927a6a01-a341-4266-a1cf-dbbab6c69a88", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKaXhFpe7v90JGqin0Jvz+zzWGzGmmYVU9n/K9CWmkV+VzHtMgCcBDxLv20zFyeCOA==", "ac6ec0bb-5844-4219-8008-b985d838829d", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "184edd88-a1ee-4e77-afec-d220a19efb8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac47a7f-f1ac-1248-bacf-2bdd431ccbbf",
                column: "ConcurrencyStamp",
                value: "e6729f64-0fec-47d8-9476-aa1c913cef0b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f66dd3ac-e192-4cb0-ae81-dda92161f869", false, null, "AQAAAAEAACcQAAAAEBPgHr1I+BbQ+lCrtcvbegsVdAFLPaqadFx/aViRCGyleOmSJTOlk5R5bShsgbS0zg==", "06f6ee38-9336-4d94-abea-315248f171a2", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d3e49fb8-a600-418b-a87f-233ef8a1de67", false, null, "AQAAAAEAACcQAAAAEBSWloB/cWBBi3TEOZAVeCMUTlv3J2ClttGpqZSGnYwBQ3Tw/SWKRlL2oTuVefVdbg==", "051f07ec-c7e6-4022-8807-54aa6c01c705", null });
        }
    }
}
