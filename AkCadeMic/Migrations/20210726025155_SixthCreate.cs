using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class SixthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepliesS",
                columns: table => new
                {
                    IdS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThreadIdS = table.Column<int>(type: "int", nullable: false),
                    UserSId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepliesS", x => x.IdS);
                    table.ForeignKey(
                        name: "FK_RepliesS_AspNetUsers_UserSId",
                        column: x => x.UserSId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RepliesS_ThreadsS_ThreadIdS",
                        column: x => x.ThreadIdS,
                        principalTable: "ThreadsS",
                        principalColumn: "PostIdS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepliesS_ThreadIdS",
                table: "RepliesS",
                column: "ThreadIdS");

            migrationBuilder.CreateIndex(
                name: "IX_RepliesS_UserSId",
                table: "RepliesS",
                column: "UserSId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepliesS");
        }
    }
}
