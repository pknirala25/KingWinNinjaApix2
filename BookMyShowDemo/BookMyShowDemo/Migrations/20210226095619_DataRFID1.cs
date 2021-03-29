using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMyShowDemo.Migrations
{
    public partial class DataRFID1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "locationModels",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locationModels", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "movieModels",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(nullable: false),
                    Language = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieModels", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "theatreModels",
                columns: table => new
                {
                    TheatreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Theatre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theatreModels", x => x.TheatreId);
                });

            migrationBuilder.CreateTable(
                name: "ratingModels",
                columns: table => new
                {
                    RatingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RatingNumber = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    RatingComment = table.Column<string>(nullable: false),
                    movieModelsMovieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratingModels", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_ratingModels_movieModels_movieModelsMovieId",
                        column: x => x.movieModelsMovieId,
                        principalTable: "movieModels",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ratingModels_movieModelsMovieId",
                table: "ratingModels",
                column: "movieModelsMovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "locationModels");

            migrationBuilder.DropTable(
                name: "ratingModels");

            migrationBuilder.DropTable(
                name: "theatreModels");

            migrationBuilder.DropTable(
                name: "movieModels");
        }
    }
}
