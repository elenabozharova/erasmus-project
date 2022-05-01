using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Erasmus.Repository.Migrations
{
    public partial class seededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12c4851c-da44-4fa4-bf22-3c92b823582b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12739aa2-fc68-45db-82e8-2d0602e94eb6",
                column: "ConcurrencyStamp",
                value: "3189f7fc-1077-4223-beb9-5abcae04bcd4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb6f781-cba6-4873-ac70-7539916f1a17",
                column: "ConcurrencyStamp",
                value: "35868977-50f0-47fc-9229-1eb3f3a8c6f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a5b35b-ef16-434d-b99c-6ecf3c88b40a",
                column: "ConcurrencyStamp",
                value: "dfcb69d0-36ab-4ce6-9a43-159f23c6a515");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c76aee55-4ff7-463d-a2ba-ce2c8a06e13b",
                column: "ConcurrencyStamp",
                value: "77da1fb5-62e5-434c-b45e-d1722a718757");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7",
                column: "ConcurrencyStamp",
                value: "f23516ab-92d9-4373-8b51-af9a47089f88");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "807d92d8-5eca-4587-88c8-03fbfd0cbc8a", "a57648c3-b979-48b0-a9ad-74fb74257c6c", "Organizer", "ORGANIZER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e41d931e-5d38-4a7b-9508-e16067748d4b", "AQAAAAEAACcQAAAAEP6+HRQ9ryLpyH+bYKOauVDJQ+PfrTz/PIV6Ejej9r5zjwUROVPm8t13uBMWar+Rgw==", "c32e9e65-f755-4a1e-95a6-56c7fdc55add" });

            migrationBuilder.InsertData(
                table: "ProjectType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("4d267702-ea7f-4ac6-a34d-70a61c472184"), "Language Learning" },
                    { new Guid("0824444a-963b-4318-aa93-0a328916aa36"), "Computer Science Learning" },
                    { new Guid("ca7651ab-925a-41c1-942a-d095504d060f"), "Business and Marketing" },
                    { new Guid("afa89454-4d54-4070-a19b-9869fe00a995"), "Politics" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "807d92d8-5eca-4587-88c8-03fbfd0cbc8a");

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("0824444a-963b-4318-aa93-0a328916aa36"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("4d267702-ea7f-4ac6-a34d-70a61c472184"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("afa89454-4d54-4070-a19b-9869fe00a995"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("ca7651ab-925a-41c1-942a-d095504d060f"));

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
        }
    }
}
