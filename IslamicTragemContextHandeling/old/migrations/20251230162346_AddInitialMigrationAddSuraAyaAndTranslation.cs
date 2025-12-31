using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IslamicTragemContextHandeling.old.migrations
{
    /// <inheritdoc />
    public partial class AddInitialMigrationAddSuraAyaAndTranslation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "forumisl_quran2");

            migrationBuilder.CreateTable(
                name: "aya",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aya_id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    aya = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aya_no_tashkil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    page_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    part_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    hezb_no = table.Column<int>(type: "int", nullable: false),
                    rob3_no = table.Column<int>(type: "int", nullable: false),
                    aya_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    aya_no_ar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sura_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    sura_name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    wordCount = table.Column<int>(type: "int", nullable: false),
                    view_count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aya_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "bab",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name_new = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    bab_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    sub_id = table.Column<int>(type: "int", nullable: false),
                    cron = table.Column<int>(type: "int", nullable: false),
                    sound = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    video = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bab_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "bab_bokhary",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name_new = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    bab_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    sub_id = table.Column<int>(type: "int", nullable: false),
                    cron = table.Column<int>(type: "int", nullable: false),
                    sound = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    video = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bab_bokhary_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "bab_muslim",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name_new = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    bab_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    sub_id = table.Column<int>(type: "int", nullable: false),
                    cron = table.Column<int>(type: "int", nullable: false),
                    sound = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    video = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bab_muslim_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "book",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(NULL)"),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    author = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(NULL)"),
                    translator = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(NULL)"),
                    source_lang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(NULL)"),
                    target_lang = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(NULL)"),
                    publisher = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(NULL)"),
                    image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(NULL)"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    download_link = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(NULL)"),
                    out_source = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "(NULL)"),
                    url = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(NULL)"),
                    inside_book_link = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "(NULL)"),
                    page_html = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    view_count = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    download_count = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    book_id = table.Column<int>(type: "int", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    cover_image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    sort_menu = table.Column<int>(type: "int", nullable: false),
                    definition = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cat",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title_en = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(NULL)"),
                    title_ar = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(NULL)"),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cats",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    full_name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    cat_name_takhreej = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    writer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    full_writer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    writer_death = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    about_book = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slug = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    definition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rank = table.Column<int>(type: "int", nullable: false),
                    chapter_rows = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cover_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<int>(type: "int", nullable: false),
                    lang = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ver = table.Column<int>(type: "int", nullable: false),
                    start_id = table.Column<int>(type: "int", nullable: false),
                    end_id = table.Column<int>(type: "int", nullable: false),
                    death_year = table.Column<int>(type: "int", nullable: false),
                    index_book = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    type_view = table.Column<int>(type: "int", nullable: false),
                    priority = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    search_order = table.Column<int>(type: "int", nullable: false),
                    sound = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    multi = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cats_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "chapters",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    tags = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    my_sort = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    cron = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chapters_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "chapters_bokhary",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    tags = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    my_sort = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    cron = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chapters_bokhary_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "chapters_muslim",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    tags = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    my_sort = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    cron = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chapters_muslim_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "chapters_ttf",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    tags = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    my_sort = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    cron = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chapters_ttf_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fixed_pages",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_en = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fixed_pages_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hadith_bokhary",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    bab_id = table.Column<int>(type: "int", nullable: false),
                    m_hadtih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    h_id = table.Column<int>(type: "int", nullable: false),
                    selid = table.Column<int>(type: "int", nullable: false),
                    uid = table.Column<int>(type: "int", nullable: false),
                    search_txt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rank = table.Column<int>(type: "int", nullable: false),
                    hokm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shaker = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    sub_id = table.Column<int>(type: "int", nullable: false),
                    tab_id = table.Column<int>(type: "int", nullable: false),
                    nass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ver = table.Column<int>(type: "int", nullable: false),
                    rawy_id = table.Column<int>(type: "int", nullable: false),
                    hid_old = table.Column<int>(type: "int", nullable: false),
                    search_order = table.Column<int>(type: "int", nullable: false, defaultValue: 1100),
                    word_menaing = table.Column<int>(type: "int", nullable: false),
                    tarf = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    make_edit = table.Column<int>(type: "int", nullable: false),
                    yusuf_taraf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    yusuf_matn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hmp3 = table.Column<int>(type: "int", nullable: false),
                    sharh_mp3 = table.Column<short>(type: "smallint", nullable: false),
                    view_count = table.Column<int>(type: "int", nullable: false),
                    last_views = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    wordCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hadith_bokhary_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hadith_english",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hid = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rawy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    rank = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    hokm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sound = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    sunnah_id = table.Column<int>(type: "int", nullable: false),
                    selid = table.Column<int>(type: "int", nullable: false),
                    cat_id_old = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    lang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hadith_english_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hadith_french",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hid = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    sunnah_id = table.Column<int>(type: "int", nullable: false),
                    selid = table.Column<int>(type: "int", nullable: false),
                    cat_id_old = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hadith_french_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hadith_indo",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hid = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    book_id = table.Column<int>(type: "int", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    sunnah_id = table.Column<int>(type: "int", nullable: false),
                    selid = table.Column<int>(type: "int", nullable: false),
                    cat_id_old = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hadith_indo_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hadith_muslim",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    bab_id = table.Column<int>(type: "int", nullable: false),
                    m_hadtih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lang_id = table.Column<int>(type: "int", nullable: false),
                    matn_english = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    h_id = table.Column<int>(type: "int", nullable: false),
                    selid = table.Column<int>(type: "int", nullable: false),
                    uid = table.Column<int>(type: "int", nullable: false),
                    search_txt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rank = table.Column<int>(type: "int", nullable: false),
                    hokm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shaker = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    sub_id = table.Column<int>(type: "int", nullable: false),
                    tab_id = table.Column<int>(type: "int", nullable: false),
                    nass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ver = table.Column<int>(type: "int", nullable: false),
                    rawy_id = table.Column<int>(type: "int", nullable: false),
                    hid_old = table.Column<int>(type: "int", nullable: false),
                    search_order = table.Column<int>(type: "int", nullable: false, defaultValue: 1100),
                    word_menaing = table.Column<int>(type: "int", nullable: false),
                    tarf = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    make_edit = table.Column<int>(type: "int", nullable: false),
                    yusuf_taraf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    yusuf_matn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hmp3 = table.Column<int>(type: "int", nullable: false),
                    sharh_mp3 = table.Column<short>(type: "smallint", nullable: false),
                    view_count = table.Column<int>(type: "int", nullable: false),
                    last_views = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    wordCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hadith_muslim_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hadith_new",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    bab_id = table.Column<int>(type: "int", nullable: false),
                    m_hadtih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    h_id = table.Column<int>(type: "int", nullable: false),
                    selid = table.Column<int>(type: "int", nullable: false),
                    uid = table.Column<int>(type: "int", nullable: false),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    search_txt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rank = table.Column<int>(type: "int", nullable: false),
                    hokm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shaker = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    sub_id = table.Column<int>(type: "int", nullable: false),
                    tab_id = table.Column<int>(type: "int", nullable: false),
                    nass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ver = table.Column<int>(type: "int", nullable: false),
                    rawy_id = table.Column<int>(type: "int", nullable: false),
                    hid_old = table.Column<int>(type: "int", nullable: false),
                    search_order = table.Column<int>(type: "int", nullable: false, defaultValue: 1100),
                    word_menaing = table.Column<int>(type: "int", nullable: false),
                    tarf = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    make_edit = table.Column<int>(type: "int", nullable: false),
                    yusuf_taraf = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)"),
                    yusuf_matn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hmp3 = table.Column<int>(type: "int", nullable: false),
                    sharh_mp3 = table.Column<short>(type: "smallint", nullable: false),
                    view = table.Column<int>(type: "int", nullable: false),
                    last_views = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    wordCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hadith_new_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hadith_translation",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    book_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    volume_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    chapter_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    hadeeth_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    hadeeth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    hadeeth1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hadith_translation_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hadith_translation_manage",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hadeeth_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    translation_type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    hadeeth_translation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hadith_translation_manage_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hadith_translation_manage1",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hadeeth_id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    translation_type = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true, defaultValueSql: "(NULL)"),
                    hadeeth_translation = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hadith_translation_manage1_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hr_vacation",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    end_date = table.Column<DateOnly>(type: "date", nullable: false),
                    days_number = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    description_admin = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    admin_approve = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    user_add = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hr_vacation_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lang",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    status_mobile = table.Column<int>(type: "int", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    date_creat = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    logo_lang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    user_add = table.Column<int>(type: "int", nullable: false),
                    master_lang = table.Column<int>(type: "int", nullable: false),
                    filename = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    direction = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lang_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lang_hadith",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lang_hadith_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lang_word",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    word = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    lang = table.Column<int>(type: "int", nullable: false),
                    similar_word = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    date_creat = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    user_add = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lang_word_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "marakez",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    markaz_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    markaz_location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    english_manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(112)", maxLength: 112, nullable: true, defaultValueSql: "(NULL)"),
                    email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, defaultValueSql: "(NULL)"),
                    website = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true, defaultValueSql: "(NULL)"),
                    masarat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    view_count = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true, defaultValueSql: "(NULL)"),
                    download_count = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true, defaultValueSql: "(NULL)"),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marakez_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "meaning_name",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    word_notashkeel = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    meaning = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    h_id = table.Column<int>(type: "int", nullable: false),
                    selid = table.Column<int>(type: "int", nullable: false),
                    word_tashkeel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    cat_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    bab_name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    chapter_name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    bab_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meaning_name_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "news",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "(NULL)"),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NewsTest",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "(NULL)"),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "papers",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lang_id = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    paper_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paper_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paper_researcher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paper_admin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paper_date = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, defaultValueSql: "(NULL)"),
                    paper_location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pages_no = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, defaultValueSql: "(NULL)"),
                    paper_summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paper_results = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(NULL)"),
                    image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(NULL)"),
                    view_count = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true, defaultValueSql: "(NULL)"),
                    download_count = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true, defaultValueSql: "(NULL)"),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_papers_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "papers_cat",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paper_lang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    paper_lang_en = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_papers_cat_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "quran_translation",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aya_id = table.Column<int>(type: "int", nullable: false),
                    sura_no = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true, defaultValueSql: "(NULL)"),
                    aya_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    translation_lang = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "(NULL)"),
                    translation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    translator_name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true, defaultValueSql: "(NULL)"),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quran_translation_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "report_hadith",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    selid = table.Column<int>(type: "int", nullable: false),
                    solved = table.Column<short>(type: "smallint", nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false),
                    date_send = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_report_hadith_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sharh",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hid = table.Column<int>(type: "int", nullable: false),
                    uid = table.Column<int>(type: "int", nullable: false),
                    sharh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    book_id = table.Column<int>(type: "int", nullable: false),
                    search_txt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sunnah_id = table.Column<int>(type: "int", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    selid = table.Column<int>(type: "int", nullable: false),
                    hadith_yes = table.Column<int>(type: "int", nullable: false),
                    name_book = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    chapter_id = table.Column<int>(type: "int", nullable: false),
                    bab_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sharh_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sidbar_menu",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    date_creat = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    user_add = table.Column<int>(type: "int", nullable: false),
                    status_mobile = table.Column<int>(type: "int", nullable: false),
                    link = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    link_target = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    icon = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    sub_menu = table.Column<int>(type: "int", nullable: false),
                    permission = table.Column<int>(type: "int", nullable: false),
                    sort_menu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sidbar_menu_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "single_page",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comment = table.Column<short>(type: "smallint", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    user_add = table.Column<int>(type: "int", nullable: false),
                    lang = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false),
                    larg_page = table.Column<short>(type: "smallint", nullable: false),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_single_page_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "styles",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    path_files = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    path_image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_styles_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sura",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sura_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    name = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sura_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "taragem2",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    nickname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    rotabah = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    koniaa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    lakab = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    tabkaa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    full_cv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gorha_weadllah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shoikh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    student = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kamal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ikhamah = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ikrabaa = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    nasaab = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    mawaley = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    dead_where = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ikhtalet = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    age_rawey = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    born_date = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    dead_date = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taragem2_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "term",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true, defaultValueSql: "(NULL)"),
                    meaning_lang = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true, defaultValueSql: "(NULL)"),
                    meaning_term = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cat_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    voice_spell = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true, defaultValueSql: "(NULL)"),
                    en = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "(NULL)"),
                    fr = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true, defaultValueSql: "(NULL)"),
                    es = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "(NULL)"),
                    en_synonyms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "(NULL)"),
                    fr_synonyms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "(NULL)"),
                    es_synonyms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "(NULL)"),
                    url = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true, defaultValueSql: "(NULL)"),
                    page_html = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    view_count = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    cat_title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_term_id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tragem",
                schema: "forumisl_quran2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuranID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    aya = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    GVerse = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    English = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    english2 = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Ahmed_Ali = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Yusuf_Ali = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Qarai = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Ahmed_Raza_Khan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Arberry = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Asad = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Daryabadi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Hilali_And_Khan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_ClearQuran_God = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_ClearQuran_Allah = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Community_God = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Community_Allah = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Khattab = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Maududi = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Mubarakpuri = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Pickthall = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Sarwar = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Eng_Qaribullah_And_Darwish = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Germany = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    page_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    part_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    aya_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    sura_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sura_no = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(NULL)"),
                    japanese = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    chinese = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    italy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fr2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    indo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sa7ly = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rusha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hendi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    malawy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    polg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    polsh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    posna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fares = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    torki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    azer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    braz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    english_shaker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    german2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fh = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tragem_id", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "hadith_bab_id_idx",
                schema: "forumisl_quran2",
                table: "chapters",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "hadith_bab_id_idx",
                schema: "forumisl_quran2",
                table: "chapters_bokhary",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "hadith_bab_id_idx",
                schema: "forumisl_quran2",
                table: "chapters_muslim",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "hadith_bab_id_idx",
                schema: "forumisl_quran2",
                table: "chapters_ttf",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "cat_id",
                schema: "forumisl_quran2",
                table: "hadith_bokhary",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "hadith_bokhary$yusuf_rawys",
                schema: "forumisl_quran2",
                table: "hadith_bokhary",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "selid",
                schema: "forumisl_quran2",
                table: "hadith_bokhary",
                column: "selid");

            migrationBuilder.CreateIndex(
                name: "cat_id",
                schema: "forumisl_quran2",
                table: "hadith_muslim",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "hadith_muslim$yusuf_rawys",
                schema: "forumisl_quran2",
                table: "hadith_muslim",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "selid",
                schema: "forumisl_quran2",
                table: "hadith_muslim",
                column: "selid");

            migrationBuilder.CreateIndex(
                name: "cat_id",
                schema: "forumisl_quran2",
                table: "hadith_new",
                column: "cat_id");

            migrationBuilder.CreateIndex(
                name: "hadith_new$yusuf_rawys",
                schema: "forumisl_quran2",
                table: "hadith_new",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "selid",
                schema: "forumisl_quran2",
                table: "hadith_new",
                column: "selid");

            migrationBuilder.CreateIndex(
                name: "hid",
                schema: "forumisl_quran2",
                table: "sharh",
                column: "hid");

            migrationBuilder.CreateIndex(
                name: "sura$id",
                schema: "forumisl_quran2",
                table: "sura",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id",
                schema: "forumisl_quran2",
                table: "taragem2",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "QuranID",
                schema: "forumisl_quran2",
                table: "tragem",
                column: "QuranID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aya",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "bab",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "bab_bokhary",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "bab_muslim",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "book",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "books",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "cat",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "cats",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "chapters",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "chapters_bokhary",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "chapters_muslim",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "chapters_ttf",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "fixed_pages",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "hadith_bokhary",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "hadith_english",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "hadith_french",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "hadith_indo",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "hadith_muslim",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "hadith_new",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "hadith_translation",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "hadith_translation_manage",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "hadith_translation_manage1",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "hr_vacation",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "lang",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "lang_hadith",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "lang_word",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "marakez",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "meaning_name",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "news",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "NewsTest",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "papers",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "papers_cat",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "quran_translation",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "report_hadith",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "sharh",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "sidbar_menu",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "single_page",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "styles",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "sura",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "taragem2",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "term",
                schema: "forumisl_quran2");

            migrationBuilder.DropTable(
                name: "tragem",
                schema: "forumisl_quran2");
        }
    }
}
