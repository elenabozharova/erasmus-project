using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Erasmus.Repository.Migrations
{
    public partial class AddedCountries1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("23ad1aff-30f8-4b38-85f8-2d75d488f0ba"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("8bc0a1b1-3179-4707-95b4-7af52e5959a2"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("c3960c15-3459-45a3-bb27-b923e9088110"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("d076958b-92a3-4b8f-aa46-5a4af069a6ed"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb6f781-cba6-4873-ac70-7539916f1a17",
                column: "ConcurrencyStamp",
                value: "4f71ca80-95a2-471c-95a7-da5ed2477880");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a5b35b-ef16-434d-b99c-6ecf3c88b40a",
                column: "ConcurrencyStamp",
                value: "4dc93787-44b2-4bdb-9ed1-4a8fa7d7de81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a06137ff-e363-4441-a340-569663a0cc0e",
                column: "ConcurrencyStamp",
                value: "9f73b42c-a288-4996-8461-95be477812a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7",
                column: "ConcurrencyStamp",
                value: "fbe341b2-c3eb-4bc6-b576-cd2768765375");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb3d0e77-155e-4064-8a6c-c30ee8b668d4", "AQAAAAEAACcQAAAAEFYZqtuCVjwbsH+EOZWS59amDphqE8rke5JGrH/y/1D2qqR3abdTJIhbxiTbyy/gcA==", "d52b6a72-66f3-4ad0-a707-997f8116027b" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { new Guid("415c3843-4bf9-4a21-8696-6781a66204e2"), new Guid("57242f19-0405-494c-b4bc-bdb52a725442"), "Skopje" },
                    { new Guid("6c3175f9-55e1-423c-a721-ee2ce7af688c"), new Guid("cbec8be4-6325-4b2f-b08e-22d709c27688"), "London" },
                    { new Guid("3eb96050-5828-4b14-9c64-ad1cfa2738ef"), new Guid("9c3f0035-42be-496f-9848-6f8dbfe21a8b"), "Kastamonu" },
                    { new Guid("26bc664b-88c4-4d80-b0f3-200b31d03673"), new Guid("e55179e7-b895-41be-b713-4f65f6d7c724"), "Bernāti" },
                    { new Guid("1efa10f3-37e9-42b8-b7a6-c8d773c71f47"), new Guid("f2a6d1ae-3a1b-422d-8322-6c65fbd67e8a"), "Zagreb" },
                    { new Guid("5139f7c4-0010-4df3-a6be-570ba90cd8b1"), new Guid("a34904ad-50fc-4acc-9779-aa1e2f9d7d49"), "Lisbon" }
                });

            migrationBuilder.InsertData(
                table: "ProjectType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("a7700417-0c78-42a4-96ae-8bde0ab9a581"), "Language Learning" },
                    { new Guid("05c90c14-30d9-4c57-a894-76560939d791"), "Computer Science Learning" },
                    { new Guid("f58de588-0f89-426e-acbb-5449e89d29bb"), "Business and Marketing" },
                    { new Guid("3f5a6b15-b28c-47a5-92b6-8fb896075dae"), "Politics" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("1efa10f3-37e9-42b8-b7a6-c8d773c71f47"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("26bc664b-88c4-4d80-b0f3-200b31d03673"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("3eb96050-5828-4b14-9c64-ad1cfa2738ef"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("415c3843-4bf9-4a21-8696-6781a66204e2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("5139f7c4-0010-4df3-a6be-570ba90cd8b1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("6c3175f9-55e1-423c-a721-ee2ce7af688c"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("05c90c14-30d9-4c57-a894-76560939d791"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("3f5a6b15-b28c-47a5-92b6-8fb896075dae"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("a7700417-0c78-42a4-96ae-8bde0ab9a581"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("f58de588-0f89-426e-acbb-5449e89d29bb"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb6f781-cba6-4873-ac70-7539916f1a17",
                column: "ConcurrencyStamp",
                value: "1dd3ea89-691d-493a-9345-601267cf0d77");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a5b35b-ef16-434d-b99c-6ecf3c88b40a",
                column: "ConcurrencyStamp",
                value: "0a0f2421-af7c-4608-9137-50aea1e83839");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a06137ff-e363-4441-a340-569663a0cc0e",
                column: "ConcurrencyStamp",
                value: "b0937c9d-37ac-477c-aa95-27b6c7d309cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7",
                column: "ConcurrencyStamp",
                value: "62d50248-6ed4-49d0-8460-afad58745d0c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b529193-9d92-40c5-93c2-0feff5ee82ed", "AQAAAAEAACcQAAAAEMDUto51qEnEjZa4KJiaRjCMkEyZRlZqJPEWyCjUQrSRP5wN4dNMc9fW+HN86S9aGg==", "a5869616-78cf-4ca5-acdd-e4d0ed579a7e" });

            migrationBuilder.InsertData(
                table: "ProjectType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("c3960c15-3459-45a3-bb27-b923e9088110"), "Language Learning" },
                    { new Guid("23ad1aff-30f8-4b38-85f8-2d75d488f0ba"), "Computer Science Learning" },
                    { new Guid("d076958b-92a3-4b8f-aa46-5a4af069a6ed"), "Business and Marketing" },
                    { new Guid("8bc0a1b1-3179-4707-95b4-7af52e5959a2"), "Politics" }
                });
        }
    }
}
