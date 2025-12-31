using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IslamicTragemContextHandeling.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddThirdMigrationdependentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HadithCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CatNameTakhreej = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Writer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullWriterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WriterDeath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutBook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    ChapterRows = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    StartId = table.Column<int>(type: "int", nullable: false),
                    EndId = table.Column<int>(type: "int", nullable: false),
                    DeathYear = table.Column<int>(type: "int", nullable: false),
                    IndexBook = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SearchOrder = table.Column<int>(type: "int", nullable: false),
                    Sound = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HadithCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Translator = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SourceLang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TargetLang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownloadLink = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OutSource = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ViewCount = table.Column<int>(type: "int", nullable: true),
                    DownloadCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryBooks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Papers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PaperLanguageId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResearcherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PagesNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Results = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewCount = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Papers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Papers_PaperLanguages_PaperLanguageId",
                        column: x => x.PaperLanguageId,
                        principalTable: "PaperLanguages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    MeaningLanguage = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    MeaningTerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    VoiceSpell = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    English = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    French = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true),
                    Spanish = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EnglishSynonyms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FrenchSynonyms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SpanishSynonyms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ViewCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Terms_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HadithChapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HadithCategoryId = table.Column<int>(type: "int", nullable: false),
                    ChapterNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HadithChapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HadithChapters_HadithCategories_HadithCategoryId",
                        column: x => x.HadithCategoryId,
                        principalTable: "HadithCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HadithChapters_HadithCategoryId",
                table: "HadithChapters",
                column: "HadithCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryBooks_CategoryId",
                table: "LibraryBooks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Papers_PaperLanguageId",
                table: "Papers",
                column: "PaperLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_CategoryId",
                table: "Terms",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HadithChapters");

            migrationBuilder.DropTable(
                name: "LibraryBooks");

            migrationBuilder.DropTable(
                name: "Papers");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "HadithCategories");
        }
    }
}
