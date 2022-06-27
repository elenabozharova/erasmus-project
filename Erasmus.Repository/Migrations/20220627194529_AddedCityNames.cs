using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Erasmus.Repository.Migrations
{
    public partial class AddedCityNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("217176b3-0c63-4efd-9acd-6fa11191ca59"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("bb6aa271-1925-4094-8c96-34021546c9c2"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("db6dd5ff-6e51-4043-8099-787ff376658c"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("e1b0c56b-cf99-4e1a-901c-53ec2030625f"));

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

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3eb96050-5828-4b14-9c64-ad1cfa2738ef"),
                column: "CountryId",
                value: new Guid("9c3f0035-42be-496f-9848-6f8dbfe21a8b"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "720570a9-591a-48ad-8423-ef22159ee2cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a5b35b-ef16-434d-b99c-6ecf3c88b40a",
                column: "ConcurrencyStamp",
                value: "499d4335-2c52-43b1-ab15-526c641e2442");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a06137ff-e363-4441-a340-569663a0cc0e",
                column: "ConcurrencyStamp",
                value: "6bd7661e-7224-4d6d-9058-92bd98e99a7f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7",
                column: "ConcurrencyStamp",
                value: "76dfb005-cbaa-476e-8e69-7ec11af2e004");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fd0e0ad-222d-4d9b-80c7-c83207cd1d4a", "AQAAAAEAACcQAAAAEFh91X41GzHf3GgnLdNgV7xlbLW6n5L1C1Pua9vwRNbDs2+D5hgsE+l8QGkizA5XJQ==", "dc4c110d-f149-4628-9615-eed8feea2d28" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3eb96050-5828-4b14-9c64-ad1cfa2738ef"),
                column: "CountryId",
                value: new Guid("3eb96050-5828-4b14-9c64-ad1cfa2738ef"));

            migrationBuilder.InsertData(
                table: "ProjectType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("bb6aa271-1925-4094-8c96-34021546c9c2"), "Language Learning" },
                    { new Guid("217176b3-0c63-4efd-9acd-6fa11191ca59"), "Computer Science Learning" },
                    { new Guid("e1b0c56b-cf99-4e1a-901c-53ec2030625f"), "Business and Marketing" },
                    { new Guid("db6dd5ff-6e51-4043-8099-787ff376658c"), "Politics" }
                });
        }
    }
}
