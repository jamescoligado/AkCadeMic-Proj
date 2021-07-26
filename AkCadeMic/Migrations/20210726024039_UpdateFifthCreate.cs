using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class UpdateFifthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Replies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Replies_UserId",
                table: "Replies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_AspNetUsers_UserId",
                table: "Replies",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_AspNetUsers_UserId",
                table: "Replies");

            migrationBuilder.DropIndex(
                name: "IX_Replies_UserId",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Replies");
        }
    }
}
