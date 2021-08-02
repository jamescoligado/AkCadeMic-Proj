using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class ReplySHO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailS",
                table: "RepliesS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailH",
                table: "RepliesO",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailH",
                table: "RepliesH",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailS",
                table: "RepliesS");

            migrationBuilder.DropColumn(
                name: "EmailH",
                table: "RepliesO");

            migrationBuilder.DropColumn(
                name: "EmailH",
                table: "RepliesH");
        }
    }
}
