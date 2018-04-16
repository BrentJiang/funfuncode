using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace QRCodeMain.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LanguageCode = table.Column<string>(nullable: true),
                    LanguageName = table.Column<string>(nullable: true),
                    LanguageType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "QrCodes",
                columns: table => new
                {
                    QrCodeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QrCodeRelativePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QrCodes", x => x.QrCodeId);
                });

            migrationBuilder.CreateTable(
                name: "WordStatisticses",
                columns: table => new
                {
                    WordStatisticsId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaxOccur = table.Column<int>(nullable: false),
                    MaxRatio = table.Column<double>(nullable: false),
                    MaxWords = table.Column<int>(nullable: false),
                    TotalBook = table.Column<int>(nullable: false),
                    TotalOccur = table.Column<int>(nullable: false),
                    TotalWords = table.Column<int>(nullable: false),
                    WordDescription = table.Column<string>(nullable: true),
                    WordUnicode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordStatisticses", x => x.WordStatisticsId);
                });

            migrationBuilder.CreateTable(
                name: "MyVocabularyStatisticses",
                columns: table => new
                {
                    MyVocabularyStatisticsId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CurrentScore = table.Column<double>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    TotalTestCount = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyVocabularyStatisticses", x => x.MyVocabularyStatisticsId);
                    table.ForeignKey(
                        name: "FK_MyVocabularyStatisticses_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyVocabularyTests",
                columns: table => new
                {
                    MyVocabularyTestId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CorrectWordCount = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Score = table.Column<double>(nullable: false),
                    TestTime = table.Column<DateTime>(nullable: false),
                    TestWordCount = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyVocabularyTests", x => x.MyVocabularyTestId);
                    table.ForeignKey(
                        name: "FK_MyVocabularyTests_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserVocabularies",
                columns: table => new
                {
                    UserVocabularyId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CriticalTimes = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    TestTimes = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    WordUnicode = table.Column<string>(nullable: true),
                    WrongTimes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVocabularies", x => x.UserVocabularyId);
                    table.ForeignKey(
                        name: "FK_UserVocabularies_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(nullable: true),
                    QrCodeId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_Articles_QrCodes_QrCodeId",
                        column: x => x.QrCodeId,
                        principalTable: "QrCodes",
                        principalColumn: "QrCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VocabularyTestDetails",
                columns: table => new
                {
                    VocabularyTestDetailId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnswerContentA = table.Column<string>(nullable: true),
                    AnswerContentB = table.Column<string>(nullable: true),
                    AnswerContentC = table.Column<string>(nullable: true),
                    AnswerContentD = table.Column<string>(nullable: true),
                    CorrectAnswer = table.Column<char>(nullable: false),
                    FinalAnswer = table.Column<char>(nullable: false),
                    LanguageCode = table.Column<string>(nullable: true),
                    VocabularyTestId = table.Column<int>(nullable: false),
                    WordUnicode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocabularyTestDetails", x => x.VocabularyTestDetailId);
                    table.ForeignKey(
                        name: "FK_VocabularyTestDetails_MyVocabularyTests_VocabularyTestId",
                        column: x => x.VocabularyTestId,
                        principalTable: "MyVocabularyTests",
                        principalColumn: "MyVocabularyTestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticleId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticleId = table.Column<int>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTags",
                columns: table => new
                {
                    UserTagId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticleId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTags", x => x.UserTagId);
                    table.ForeignKey(
                        name: "FK_UserTags_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_QrCodeId",
                table: "Articles",
                column: "QrCodeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ArticleId",
                table: "Categories",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_LanguageCode",
                table: "Languages",
                column: "LanguageCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyVocabularyStatisticses_LanguageId",
                table: "MyVocabularyStatisticses",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_MyVocabularyStatisticses_UserName",
                table: "MyVocabularyStatisticses",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyVocabularyTests_LanguageId",
                table: "MyVocabularyTests",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTags_ArticleId",
                table: "UserTags",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVocabularies_LanguageId",
                table: "UserVocabularies",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_VocabularyTestDetails_VocabularyTestId",
                table: "VocabularyTestDetails",
                column: "VocabularyTestId");

            migrationBuilder.CreateIndex(
                name: "IX_WordStatisticses_WordUnicode",
                table: "WordStatisticses",
                column: "WordUnicode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "MyVocabularyStatisticses");

            migrationBuilder.DropTable(
                name: "UserTags");

            migrationBuilder.DropTable(
                name: "UserVocabularies");

            migrationBuilder.DropTable(
                name: "VocabularyTestDetails");

            migrationBuilder.DropTable(
                name: "WordStatisticses");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "MyVocabularyTests");

            migrationBuilder.DropTable(
                name: "QrCodes");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
