using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Erasmus.Repository.Migrations
{
    public partial class ProjectTypeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5c7b4cf-0386-4a3a-acff-ed31f0ba02f5");

            migrationBuilder.DropColumn(
                name: "ProjectType",
                table: "NonGovProject");

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectTypeId",
                table: "NonGovProject",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12739aa2-fc68-45db-82e8-2d0602e94eb6",
                column: "ConcurrencyStamp",
                value: "b51ab947-3ed7-4c2a-b678-e1653c0a4b74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb6f781-cba6-4873-ac70-7539916f1a17",
                column: "ConcurrencyStamp",
                value: "1414de76-ea05-4d49-b445-a06661a993c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a5b35b-ef16-434d-b99c-6ecf3c88b40a",
                column: "ConcurrencyStamp",
                value: "e108f19e-c3da-44a2-bdb1-249138272a56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c76aee55-4ff7-463d-a2ba-ce2c8a06e13b",
                column: "ConcurrencyStamp",
                value: "5351e13c-59c8-4332-bf5c-5b6d567bc18e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7",
                column: "ConcurrencyStamp",
                value: "8b5ee835-e6e8-4f38-9631-e1b81f8a25ef");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12c4851c-da44-4fa4-bf22-3c92b823582b", "3d217d2d-2829-4166-82d0-00a8158fcd62", "Organizer", "ORGANIZER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0a7a140-6f22-43b6-af0b-125b071cfc96", "AQAAAAEAACcQAAAAEPKTIbYmibKLMwISGQalpOp7S9QjWbspfnLGhZFrwpx52xmuhLdmToN1/3NWSX8PIw==", "7e529e7b-c007-4199-b2d5-1cd28f8d84a9" });

            migrationBuilder.CreateIndex(
                name: "IX_NonGovProject_ProjectTypeId",
                table: "NonGovProject",
                column: "ProjectTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_NonGovProject_ProjectType_ProjectTypeId",
                table: "NonGovProject",
                column: "ProjectTypeId",
                principalTable: "ProjectType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NonGovProject_ProjectType_ProjectTypeId",
                table: "NonGovProject");

            migrationBuilder.DropTable(
                name: "ProjectType");

            migrationBuilder.DropIndex(
                name: "IX_NonGovProject_ProjectTypeId",
                table: "NonGovProject");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12c4851c-da44-4fa4-bf22-3c92b823582b");

            migrationBuilder.DropColumn(
                name: "ProjectTypeId",
                table: "NonGovProject");

            migrationBuilder.AddColumn<string>(
                name: "ProjectType",
                table: "NonGovProject",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12739aa2-fc68-45db-82e8-2d0602e94eb6",
                column: "ConcurrencyStamp",
                value: "9b98ebae-6ade-4f05-9e56-d31dd9b688df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb6f781-cba6-4873-ac70-7539916f1a17",
                column: "ConcurrencyStamp",
                value: "8abc57cb-362f-4690-880b-cbdbab892650");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a5b35b-ef16-434d-b99c-6ecf3c88b40a",
                column: "ConcurrencyStamp",
                value: "19155cc7-d8e8-4533-9b52-4a0a6ab9a16b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c76aee55-4ff7-463d-a2ba-ce2c8a06e13b",
                column: "ConcurrencyStamp",
                value: "538cd46c-24ce-4d83-a145-8c6179332d8c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7",
                column: "ConcurrencyStamp",
                value: "6c2f9e9a-64c9-4305-b54a-b9ba006e9aed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5c7b4cf-0386-4a3a-acff-ed31f0ba02f5", "374f4160-82d9-4564-afa6-07bc915c16b2", "Organizer", "ORGANIZER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39d5fa31-a2f2-4a15-92d1-85270e35ac83", "AQAAAAEAACcQAAAAEEJ23bV+IlPBlhClVnlguL8Du0xoUpbWVfGrM3ior5geCsrXvtgO+WmUCkmnkmGlCg==", "99228c2d-8b32-4b0d-b234-9173d8fc7c42" });
        }
    }
}
