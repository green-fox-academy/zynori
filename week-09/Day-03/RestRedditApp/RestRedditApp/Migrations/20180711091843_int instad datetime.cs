using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestRedditApp.Migrations
{
    public partial class intinstaddatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TimeStamp",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeStamp",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
