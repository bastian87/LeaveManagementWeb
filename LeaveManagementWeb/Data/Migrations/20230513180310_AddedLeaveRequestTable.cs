using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "leaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_leaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_leaveRequests_LeaveTypeId",
                table: "leaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leaveRequests");

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
    }
}
