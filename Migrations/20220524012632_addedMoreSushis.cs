using Microsoft.EntityFrameworkCore.Migrations;

namespace SilliconSushi.Migrations
{
    public partial class addedMoreSushis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "SushiId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sushis",
                keyColumn: "SushiId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 4, "", null, "https://i.ibb.co/QcZMNxm/makisushi.jpg", true, "This is the dragon sushi made of all veggies ingredients", "Dragon Sushi Super", 4m, "Super Yummy Sushi", true });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 5, "", null, "https://i.ibb.co/f4H3PH6/rolls.jpg", true, "This is the dragon sushi made of all veggies ingredients", "Miki Sushi", 2m, "Second Yummy Sushi", true });
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "Vegetarian" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Vegan" });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 1, "", null, "https://i.ibb.co/QcZMNxm/makisushi.jpg", true, "This is the dragon sushi made of all veggies ingredients", "Dragon Sushi", 4m, "First Yummy Sushi", false });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 2, "", null, "https://i.ibb.co/f4H3PH6/rolls.jpg", true, "This is the dragon sushi made of all veggies ingredients", "Miki Sushi", 2m, "Second Yummy Sushi", false });
        }
    }
}
