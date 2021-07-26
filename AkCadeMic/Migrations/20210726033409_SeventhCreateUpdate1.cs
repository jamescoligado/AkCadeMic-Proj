using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class SeventhCreateUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepliesH_ThreadsH_ThreadHPostIdH",
                table: "RepliesH");

            migrationBuilder.DropForeignKey(
                name: "FK_RepliesH_ThreadsS_ThreadIdH",
                table: "RepliesH");

            migrationBuilder.DropIndex(
                name: "IX_RepliesH_ThreadHPostIdH",
                table: "RepliesH");

            migrationBuilder.DropColumn(
                name: "ThreadHPostIdH",
                table: "RepliesH");

            migrationBuilder.AddForeignKey(
                name: "FK_RepliesH_ThreadsH_ThreadIdH",
                table: "RepliesH",
                column: "ThreadIdH",
                principalTable: "ThreadsH",
                principalColumn: "PostIdH",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepliesH_ThreadsH_ThreadIdH",
                table: "RepliesH");

            migrationBuilder.AddColumn<int>(
                name: "ThreadHPostIdH",
                table: "RepliesH",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepliesH_ThreadHPostIdH",
                table: "RepliesH",
                column: "ThreadHPostIdH");

            migrationBuilder.AddForeignKey(
                name: "FK_RepliesH_ThreadsH_ThreadHPostIdH",
                table: "RepliesH",
                column: "ThreadHPostIdH",
                principalTable: "ThreadsH",
                principalColumn: "PostIdH",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepliesH_ThreadsS_ThreadIdH",
                table: "RepliesH",
                column: "ThreadIdH",
                principalTable: "ThreadsS",
                principalColumn: "PostIdS",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
