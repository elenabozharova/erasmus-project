using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Erasmus.Repository.Migrations
{
    public partial class AddedCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("4016591e-cea0-4383-badf-b25b5a9987d5"), "Language Learning" },
                    { new Guid("64ba8248-6319-49b7-809d-8760a26129f0"), "Computer Science Learning" },
                    { new Guid("b2563001-c42d-402e-90d6-25aac82aec46"), "Business and Marketing" },
                    { new Guid("6bdc7210-1db3-44e2-b1bb-4667173d57e1"), "Politics" }
                });
        }
    }
}
