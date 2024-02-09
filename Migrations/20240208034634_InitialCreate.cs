using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace teamgunghocodersbackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieTitle = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "MovieReview",
                columns: table => new
                {
                    MovieReviewId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TextBody = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    MovieRating = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReview", x => x.MovieReviewId);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 1, "Die Hard" },
                    { 2, "The Proposal" }
                });

            migrationBuilder.InsertData(
                table: "MovieReview",
                columns: new[] { "MovieReviewId", "MovieRating", "TextBody" },
                values: new object[,]
                {
                    { 1, 5, "I loved this movie so very much! It was really, really amazing!" },
                    { 2, 1, "This movie was not very good. Total snooze fest." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "MovieReview");
        }
    }
}
