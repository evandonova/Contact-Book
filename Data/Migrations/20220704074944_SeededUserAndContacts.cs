using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact_Book.Data.Migrations
{
    public partial class SeededUserAndContacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
               name: "Comments",
               table: "Contacts",
               type: "nvarchar(200)",
               nullable: true,
               oldClrType: typeof(string),
               oldType: "nvarchar(80)",
               oldMaxLength: 80);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "guest856-c198-4129-b3f3-b893d8395082", 0, "302bd798-a046-4997-94ea-6b5f0126e192", "guest@mail.com", false, "Guest", "User", false, null, "GUEST@MAIL.COM", "GUEST@MAIL.COM", "AQAAAAEAACcQAAAAEEVZApI6Cmg4z8A+Dgb+KZAM/0cul15SxsiVXQCSdES231lLyH7ngepPx32+1ZrT0w==", "+359000000000", false, "1a2b057a-ea97-471b-a07f-d112e08371b8", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Comments", "DateCreated", "Email", "FirstName", "LastName", "OwnerId", "PhoneNumber" },
                values: new object[] { 1, "Steven Jobs was an American business magnate, industrial designer, investor, and media proprietor.", new DateTime(2021, 8, 18, 10, 49, 44, 523, DateTimeKind.Local).AddTicks(9794), "steve@apple.com", "Steve", "Jobs", "guest856-c198-4129-b3f3-b893d8395082", "+180023456789" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Comments", "DateCreated", "Email", "FirstName", "LastName", "OwnerId", "PhoneNumber" },
                values: new object[] { 2, "Michael Joseph Jackson was an American singer, songwriter, and dancer.", new DateTime(2021, 2, 19, 10, 49, 44, 523, DateTimeKind.Local).AddTicks(9827), "michael@jackson.com", "Michael", "Jackson", "guest856-c198-4129-b3f3-b893d8395082", "+190088877744" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Comments", "DateCreated", "Email", "FirstName", "LastName", "OwnerId", "PhoneNumber" },
                values: new object[] { 3, "Albert Einstein was a German-born theoretical physicist, universally acknowledged to be one of the two greatest physicists of all time, the other being Isaac Newton.", new DateTime(2019, 10, 8, 10, 49, 44, 523, DateTimeKind.Local).AddTicks(9829), "albert.e@uzh.ch", "Albert", "Einstein", "guest856-c198-4129-b3f3-b893d8395082", "+41446344901" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
               name: "Comments",
               table: "Contacts",
               type: "nvarchar(80)",
               nullable: true,
               oldClrType: typeof(string),
               oldType: "nvarchar(200)",
               oldMaxLength: 200);
        }
    }
}
