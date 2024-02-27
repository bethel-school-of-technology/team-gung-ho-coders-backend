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
                    MovieTitle = table.Column<string>(type: "TEXT", nullable: false),
                    ImgUrl = table.Column<string>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieId", "ImgUrl", "MovieTitle" },
                values: new object[,]
                {
                    { 1, "https://musicart.xboxlive.com/7/2ea05000-0000-0000-0000-000000000002/504/image.jpg?w=1920&h=1080", "Die Hard" },
                    { 2, "data:image/jpeg;base64,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", "The Proposal" }
                });

            migrationBuilder.InsertData(
                table: "MovieReview",
                columns: new[] { "MovieReviewId", "MovieRating", "TextBody" },
                values: new object[,]
                {
                    { 1, 5, "I loved this movie so very much! It was really, really amazing!" },
                    { 2, 1, "This movie was not very good. Total snooze fest." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "G0dl0v3sth3l1ttl3ch1ldr3n", "waymaker6557" },
                    { 2, "Ch0s3nbl3ss3dl0v3d", "blessedboy327" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "MovieReview");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
