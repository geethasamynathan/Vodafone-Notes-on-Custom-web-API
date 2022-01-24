using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstConfigDemo.Migrations
{
    public partial class DAappliedreversed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tlStudent",
                table: "tlStudent");

            migrationBuilder.RenameTable(
                name: "tlStudent",
                newName: "Student");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Student",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "stdid",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "stdid",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "tlStudent");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tlStudent",
                newName: "StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tlStudent",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tlStudent",
                table: "tlStudent",
                column: "StudentId");
        }
    }
}
