using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class EightCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepliesO",
                columns: table => new
                {
                    IdO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThreadIdO = table.Column<int>(type: "int", nullable: false),
                    UserOId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ThreadOPostIdO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepliesO", x => x.IdO);
                    table.ForeignKey(
                        name: "FK_RepliesO_AspNetUsers_UserOId",
                        column: x => x.UserOId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RepliesO_ThreadsO_ThreadOPostIdO",
                        column: x => x.ThreadOPostIdO,
                        principalTable: "ThreadsO",
                        principalColumn: "PostIdO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RepliesO_ThreadsS_ThreadIdO",
                        column: x => x.ThreadIdO,
                        principalTable: "ThreadsS",
                        principalColumn: "PostIdS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepliesO_ThreadIdO",
                table: "RepliesO",
                column: "ThreadIdO");

            migrationBuilder.CreateIndex(
                name: "IX_RepliesO_ThreadOPostIdO",
                table: "RepliesO",
                column: "ThreadOPostIdO");

            migrationBuilder.CreateIndex(
                name: "IX_RepliesO_UserOId",
                table: "RepliesO",
                column: "UserOId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepliesO");
        }
    }
}
