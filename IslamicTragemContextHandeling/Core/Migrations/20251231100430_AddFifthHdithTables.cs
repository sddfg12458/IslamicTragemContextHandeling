using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IslamicTragemContextHandeling.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddFifthHdithTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hadiths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BabId = table.Column<int>(type: "int", nullable: true),
                    Matn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HadithWithSign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HadithWithNoSign = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hadiths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hadiths_HadithBabs_BabId",
                        column: x => x.BabId,
                        principalTable: "HadithBabs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HadithTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    HadithId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HadithTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HadithTranslations_HadithLanguages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "HadithLanguages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HadithTranslations_Hadiths_HadithId",
                        column: x => x.HadithId,
                        principalTable: "Hadiths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hadiths_BabId",
                table: "Hadiths",
                column: "BabId");

            migrationBuilder.CreateIndex(
                name: "IX_HadithTranslations_HadithId",
                table: "HadithTranslations",
                column: "HadithId");

            migrationBuilder.CreateIndex(
                name: "IX_HadithTranslations_LanguageId",
                table: "HadithTranslations",
                column: "LanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HadithTranslations");

            migrationBuilder.DropTable(
                name: "Hadiths");
        }
    }
}
