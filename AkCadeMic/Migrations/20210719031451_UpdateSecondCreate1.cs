using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class UpdateSecondCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "ThreadsS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserSId",
                table: "ThreadsS",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThreadsS_UserSId",
                table: "ThreadsS",
                column: "UserSId");

            migrationBuilder.AddForeignKey(
                name: "FK_ThreadsS_AspNetUsers_UserSId",
                table: "ThreadsS",
                column: "UserSId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThreadsS_AspNetUsers_UserSId",
                table: "ThreadsS");

            migrationBuilder.DropIndex(
                name: "IX_ThreadsS_UserSId",
                table: "ThreadsS");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "ThreadsS");

            migrationBuilder.DropColumn(
                name: "UserSId",
                table: "ThreadsS");
        }
    }
}
