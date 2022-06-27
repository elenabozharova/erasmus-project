using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Erasmus.Repository.Migrations
{
    public partial class AddedCityNamesTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("56a484dc-6980-44b6-abb7-04b9e11dbd6f"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("7a4ebd46-b0b3-4d19-a3d4-d22a992cb972"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("b525ff4a-28e3-47e8-9755-3a10a6ba51f1"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("ba275cb3-290d-4b08-85bb-484b9e044a9c"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb6f781-cba6-4873-ac70-7539916f1a17",
                column: "ConcurrencyStamp",
                value: "dbad127f-ce65-4113-9084-6526b6c6ca96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a5b35b-ef16-434d-b99c-6ecf3c88b40a",
                column: "ConcurrencyStamp",
                value: "b635e0e4-f5d6-4a76-bbce-b6f720bc6182");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a06137ff-e363-4441-a340-569663a0cc0e",
                column: "ConcurrencyStamp",
                value: "ef865ccf-a0af-44b6-82bf-61a5299e5ff1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7",
                column: "ConcurrencyStamp",
                value: "d6767b4f-828d-4f7d-b0ff-3e7dd02db7a4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd7ed156-875f-41e2-983f-732d03c3081d", "AQAAAAEAACcQAAAAEI0fjAfRSuzfniEs3+3+opIbd6VSjZSbidFLYOZNzhTEpH/V0X2dr6LMCJsoaewdQw==", "d9bdb999-fd6e-4b71-8df3-f0a8f18138af" });

            migrationBuilder.InsertData(
                table: "ProjectType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("4016591e-cea0-4383-badf-b25b5a9987d5"), "Language Learning" },
                    { new Guid("64ba8248-6319-49b7-809d-8760a26129f0"), "Computer Science Learning" },
                    { new Guid("b2563001-c42d-402e-90d6-25aac82aec46"), "Business and Marketing" },
                    { new Guid("6bdc7210-1db3-44e2-b1bb-4667173d57e1"), "Politics" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("4016591e-cea0-4383-badf-b25b5a9987d5"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("64ba8248-6319-49b7-809d-8760a26129f0"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("6bdc7210-1db3-44e2-b1bb-4667173d57e1"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("b2563001-c42d-402e-90d6-25aac82aec46"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb6f781-cba6-4873-ac70-7539916f1a17",
                column: "ConcurrencyStamp",
                value: "4bb5e4b1-d01a-494c-8c9d-b4f7a06a8332");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a5b35b-ef16-434d-b99c-6ecf3c88b40a",
                column: "ConcurrencyStamp",
                value: "c4621f5a-d72f-472f-af66-dbe61666794a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a06137ff-e363-4441-a340-569663a0cc0e",
                column: "ConcurrencyStamp",
                value: "f8d3ccc6-b9ff-40c2-aa85-056052380b0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7",
                column: "ConcurrencyStamp",
                value: "cd141612-0774-4117-b9d9-bfd5ed9a439f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a18565a-1aa9-4c91-a935-bdb2a1666852", "AQAAAAEAACcQAAAAEORxcnPK6QSk8TQ3UBTjn4ixfX78GnpAoqiPryVqIH5fVIYKC/Hw/V/ZVin07ty5rw==", "121a953e-d978-4e6d-9707-87dc7d6d0ac4" });

            migrationBuilder.InsertData(
                table: "ProjectType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("7a4ebd46-b0b3-4d19-a3d4-d22a992cb972"), "Language Learning" },
                    { new Guid("ba275cb3-290d-4b08-85bb-484b9e044a9c"), "Computer Science Learning" },
                    { new Guid("b525ff4a-28e3-47e8-9755-3a10a6ba51f1"), "Business and Marketing" },
                    { new Guid("56a484dc-6980-44b6-abb7-04b9e11dbd6f"), "Politics" }
                });
        }
    }
}
