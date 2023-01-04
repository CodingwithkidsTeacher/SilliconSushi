using Microsoft.EntityFrameworkCore.Migrations;

namespace SilliconSushi.Migrations
{
    public partial class newSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 6, "", null, "https://i.ibb.co/xKTvpLz/avocado-sushi.jpg", true, "Made with organic avocadoes, this healthy sushi is amazingly yummy!", "Avocado Sushi", 3m, "Delicious Avocado Sushi", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "SushiId",
                keyValue: 6);
        }
    }
}
