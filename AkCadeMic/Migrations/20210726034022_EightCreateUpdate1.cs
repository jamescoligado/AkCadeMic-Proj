using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class EightCreateUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepliesO_ThreadsO_ThreadOPostIdO",
                table: "RepliesO");

            migrationBuilder.DropForeignKey(
                name: "FK_RepliesO_ThreadsS_ThreadIdO",
                table: "RepliesO");

            migrationBuilder.DropIndex(
                name: "IX_RepliesO_ThreadOPostIdO",
                table: "RepliesO");

            migrationBuilder.DropColumn(
                name: "ThreadOPostIdO",
                table: "RepliesO");

            migrationBuilder.AddForeignKey(
                name: "FK_RepliesO_ThreadsO_ThreadIdO",
                table: "RepliesO",
                column: "ThreadIdO",
                principalTable: "ThreadsO",
                principalColumn: "PostIdO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepliesO_ThreadsO_ThreadIdO",
                table: "RepliesO");

            migrationBuilder.AddColumn<int>(
                name: "ThreadOPostIdO",
                table: "RepliesO",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepliesO_ThreadOPostIdO",
                table: "RepliesO",
                column: "ThreadOPostIdO");

            migrationBuilder.AddForeignKey(
                name: "FK_RepliesO_ThreadsO_ThreadOPostIdO",
                table: "RepliesO",
                column: "ThreadOPostIdO",
                principalTable: "ThreadsO",
                principalColumn: "PostIdO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepliesO_ThreadsS_ThreadIdO",
                table: "RepliesO",
                column: "ThreadIdO",
                principalTable: "ThreadsS",
                principalColumn: "PostIdS",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
