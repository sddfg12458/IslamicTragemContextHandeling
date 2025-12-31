using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IslamicTragemContextHandeling.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddFourthHdithTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HadithBabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    ChapterNo = table.Column<int>(type: "int", nullable: false),
                    BabNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HadithBabs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HadithBabs_HadithChapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "HadithChapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HadithLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HadithLanguages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HadithBabs_ChapterId",
                table: "HadithBabs",
                column: "ChapterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HadithBabs");

            migrationBuilder.DropTable(
                name: "HadithLanguages");
        }
    }
}
