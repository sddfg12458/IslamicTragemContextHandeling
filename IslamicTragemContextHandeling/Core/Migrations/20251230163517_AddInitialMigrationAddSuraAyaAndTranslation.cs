using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IslamicTragemContextHandeling.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialMigrationAddSuraAyaAndTranslation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ayas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextNoSigned = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageNo = table.Column<int>(type: "int", nullable: true),
                    PartNo = table.Column<int>(type: "int", nullable: true),
                    HezbNo = table.Column<int>(type: "int", nullable: false),
                    RobaNo = table.Column<int>(type: "int", nullable: false),
                    AyaNo = table.Column<int>(type: "int", nullable: true),
                    AyaNoAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuraId = table.Column<int>(type: "int", nullable: true),
                    WordCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ayas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ayas_Suras_SuraId",
                        column: x => x.SuraId,
                        principalTable: "Suras",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuranTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AyaId = table.Column<int>(type: "int", nullable: false),
                    LanguageName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranslatorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuranTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuranTranslations_Ayas_AyaId",
                        column: x => x.AyaId,
                        principalTable: "Ayas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ayas_SuraId",
                table: "Ayas",
                column: "SuraId");

            migrationBuilder.CreateIndex(
                name: "IX_QuranTranslations_AyaId",
                table: "QuranTranslations",
                column: "AyaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuranTranslations");

            migrationBuilder.DropTable(
                name: "Ayas");

            migrationBuilder.DropTable(
                name: "Suras");
        }
    }
}
