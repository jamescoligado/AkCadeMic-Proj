using Microsoft.EntityFrameworkCore.Migrations;

namespace AkCadeMic.Migrations
{
    public partial class ThreadsJ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThreadsJ",
                columns: table => new
                {
                    PostIdJ = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailJ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreadsJ", x => x.PostIdJ);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThreadsJ");
        }
    }
}
