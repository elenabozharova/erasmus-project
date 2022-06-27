using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Erasmus.Repository.Migrations
{
    public partial class addedCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("6345465d-a6a3-4b40-93c8-2847fa0b674e"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("87594b2c-62a5-482f-91d2-e27053775054"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("9bf302dd-0422-4d5c-a49d-8fc9dc4ea936"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: new Guid("a8b6fa6e-2bc5-4062-bf86-7de52a9b371d"));

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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { new Guid("3eb96050-5828-4b14-9c64-ad1cfa2738ef"), new Guid("3eb96050-5828-4b14-9c64-ad1cfa2738ef"), "Kastamonu" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9c3f0035-42be-496f-9848-6f8dbfe21a8b"), "Turkey" },
                    { new Guid("e55179e7-b895-41be-b713-4f65f6d7c724"), "Latvia" },
                    { new Guid("f2a6d1ae-3a1b-422d-8322-6c65fbd67e8a"), "Croatia" },
                    { new Guid("a34904ad-50fc-4acc-9779-aa1e2f9d7d49"), "Portugal" }
                });

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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { new Guid("26bc664b-88c4-4d80-b0f3-200b31d03673"), new Guid("e55179e7-b895-41be-b713-4f65f6d7c724"), "Bernāti" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { new Guid("1efa10f3-37e9-42b8-b7a6-c8d773c71f47"), new Guid("f2a6d1ae-3a1b-422d-8322-6c65fbd67e8a"), "Zagreb" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { new Guid("5139f7c4-0010-4df3-a6be-570ba90cd8b1"), new Guid("a34904ad-50fc-4acc-9779-aa1e2f9d7d49"), "Lisbon" });
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
                keyValue: new Guid("5139f7c4-0010-4df3-a6be-570ba90cd8b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c3f0035-42be-496f-9848-6f8dbfe21a8b"));

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

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a34904ad-50fc-4acc-9779-aa1e2f9d7d49"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e55179e7-b895-41be-b713-4f65f6d7c724"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2a6d1ae-3a1b-422d-8322-6c65fbd67e8a"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eb6f781-cba6-4873-ac70-7539916f1a17",
                column: "ConcurrencyStamp",
                value: "64a8140b-a9a6-4aed-a854-d8563aa61b0e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a5b35b-ef16-434d-b99c-6ecf3c88b40a",
                column: "ConcurrencyStamp",
                value: "186d0130-b15e-4106-82cc-059918f4a4ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a06137ff-e363-4441-a340-569663a0cc0e",
                column: "ConcurrencyStamp",
                value: "0c71a736-e920-4aea-9bb7-dca68fc5b007");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7",
                column: "ConcurrencyStamp",
                value: "2d74c9a1-a724-44de-8081-15378dd248a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "943c6fb0-34db-4ddc-b080-957a9c119964", "AQAAAAEAACcQAAAAEDws57p0n9p3XYHlmLeRJDCw8pJq0ZMFRb6OCt7cnr23IXZtZEbnTz51Z1zdtgzzUQ==", "d85b6a27-42f4-44ea-9533-d36a89d203a4" });

            migrationBuilder.InsertData(
                table: "ProjectType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("6345465d-a6a3-4b40-93c8-2847fa0b674e"), "Language Learning" },
                    { new Guid("9bf302dd-0422-4d5c-a49d-8fc9dc4ea936"), "Computer Science Learning" },
                    { new Guid("a8b6fa6e-2bc5-4062-bf86-7de52a9b371d"), "Business and Marketing" },
                    { new Guid("87594b2c-62a5-482f-91d2-e27053775054"), "Politics" }
                });
        }
    }
}
