using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SharpAddress.Data.Migrations
{
    public partial class _002birthdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Contact",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Contact",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "CategoryImage",
                table: "Category",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Category",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "CategoryImage",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Category");
        }
    }
}
