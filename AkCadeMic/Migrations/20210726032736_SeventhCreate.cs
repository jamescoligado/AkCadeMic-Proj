using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class SeventhCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepliesH",
                columns: table => new
                {
                    IdH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThreadIdH = table.Column<int>(type: "int", nullable: false),
                    UserHId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ThreadHPostIdH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepliesH", x => x.IdH);
                    table.ForeignKey(
                        name: "FK_RepliesH_AspNetUsers_UserHId",
                        column: x => x.UserHId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RepliesH_ThreadsH_ThreadHPostIdH",
                        column: x => x.ThreadHPostIdH,
                        principalTable: "ThreadsH",
                        principalColumn: "PostIdH",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RepliesH_ThreadsS_ThreadIdH",
                        column: x => x.ThreadIdH,
                        principalTable: "ThreadsS",
                        principalColumn: "PostIdS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepliesH_ThreadHPostIdH",
                table: "RepliesH",
                column: "ThreadHPostIdH");

            migrationBuilder.CreateIndex(
                name: "IX_RepliesH_ThreadIdH",
                table: "RepliesH",
                column: "ThreadIdH");

            migrationBuilder.CreateIndex(
                name: "IX_RepliesH_UserHId",
                table: "RepliesH",
                column: "UserHId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepliesH");
        }
    }
}
