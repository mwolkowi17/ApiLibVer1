using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLibVer1.Migrations
{
    public partial class LibraryClassAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Librarys",
                columns: table => new
                {
                    LibraryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librarys", x => x.LibraryID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Librarys");
        }
    }
}
