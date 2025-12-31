using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IslamicTragemContextHandeling.Core.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnNamesAndAddColumnsToFixedPages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "FixedPages",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "DataEn",
                table: "FixedPages",
                newName: "TitleAr");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "FixedPages",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "ContentAr",
                table: "FixedPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentEn",
                table: "FixedPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentAr",
                table: "FixedPages");

            migrationBuilder.DropColumn(
                name: "ContentEn",
                table: "FixedPages");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "FixedPages",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleAr",
                table: "FixedPages",
                newName: "DataEn");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FixedPages",
                newName: "Data");
        }
    }
}
