using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstTest.Migrations
{
    public partial class NewCreated_Book_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BorrowEndDate",
                table: "AppBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BorrowStartDate",
                table: "AppBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Borrowpay",
                table: "AppBooks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBorrowed",
                table: "AppBooks",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorrowEndDate",
                table: "AppBooks");

            migrationBuilder.DropColumn(
                name: "BorrowStartDate",
                table: "AppBooks");

            migrationBuilder.DropColumn(
                name: "Borrowpay",
                table: "AppBooks");

            migrationBuilder.DropColumn(
                name: "IsBorrowed",
                table: "AppBooks");
        }
    }
}
