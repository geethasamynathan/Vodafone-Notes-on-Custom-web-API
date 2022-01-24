using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDemo.Migrations
{
    public partial class CodeFirstDemoModelsEmployeeContextseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "Phonenumber" },
                values: new object[] { 1, new DateTime(1987, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "geetha@gmail.com", "Geetha", "Samynathan", "950003433" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "Phonenumber" },
                values: new object[] { 2, new DateTime(1986, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "tinaa@gmail.com", "tina", "Sam", "999-444-6666" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);
        }
    }
}
