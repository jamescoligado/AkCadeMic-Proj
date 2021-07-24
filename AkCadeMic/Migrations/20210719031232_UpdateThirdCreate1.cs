using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class UpdateThirdCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "ThreadsH",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserHId",
                table: "ThreadsH",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThreadsH_UserHId",
                table: "ThreadsH",
                column: "UserHId");

            migrationBuilder.AddForeignKey(
                name: "FK_ThreadsH_AspNetUsers_UserHId",
                table: "ThreadsH",
                column: "UserHId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThreadsH_AspNetUsers_UserHId",
                table: "ThreadsH");

            migrationBuilder.DropIndex(
                name: "IX_ThreadsH_UserHId",
                table: "ThreadsH");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "ThreadsH");

            migrationBuilder.DropColumn(
                name: "UserHId",
                table: "ThreadsH");
        }
    }
}
