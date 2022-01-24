using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDemo.Migrations
{
    public partial class insert4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "Phonenumber" },
                values: new object[] { 12, new DateTime(1987, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "yash@gmail.com", "yash", "sam", "950003433" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 12);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "Phonenumber" },
                values: new object[] { 1, new DateTime(1987, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "geetha@gmail.com", "fransy", "Samynathan", "950003433" });
        }
    }
}
