using Microsoft.EntityFrameworkCore.Migrations;

namespace SilliconSushi.Migrations
{
    public partial class testSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 4, "", "https://i.ibb.co/QcZMNxm/makisushi.jpg", true, "This is the dragon sushi made of all veggies ingredients", "Dragon Sushi Super", 4m, "Super Yummy Sushi", true });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 5, "", "https://i.ibb.co/f4H3PH6/rolls.jpg", true, "This is the dragon sushi made of all veggies ingredients", "Miki Sushi", 2m, "Second Yummy Sushi", true });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 6, "", "https://i.ibb.co/xKTvpLz/avocado-sushi.jpg", true, "Made with organic avocadoes, this healthy sushi is amazingly yummy!", "Avocado Sushi", 3m, "Delicious Avocado Sushi", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "SushiId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "SushiId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "SushiId",
                keyValue: 6);
        }
    }
}
