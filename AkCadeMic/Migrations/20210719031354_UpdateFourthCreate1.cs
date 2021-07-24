using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class UpdateFourthCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "ThreadsO",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserOId",
                table: "ThreadsO",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThreadsO_UserOId",
                table: "ThreadsO",
                column: "UserOId");

            migrationBuilder.AddForeignKey(
                name: "FK_ThreadsO_AspNetUsers_UserOId",
                table: "ThreadsO",
                column: "UserOId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThreadsO_AspNetUsers_UserOId",
                table: "ThreadsO");

            migrationBuilder.DropIndex(
                name: "IX_ThreadsO_UserOId",
                table: "ThreadsO");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "ThreadsO");

            migrationBuilder.DropColumn(
                name: "UserOId",
                table: "ThreadsO");
        }
    }
}
