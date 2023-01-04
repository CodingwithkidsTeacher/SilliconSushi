using Microsoft.EntityFrameworkCore.Migrations;

namespace SilliconSushi.Migrations
{
    public partial class categoryIDtoSushiModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sushis_Categories_CategoryId",
                table: "Sushis");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

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

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Sushis",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sushis_Categories_CategoryId",
                table: "Sushis",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sushis_Categories_CategoryId",
                table: "Sushis");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Sushis",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "Meat Sushi" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Veggie Sushi" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "Vegetarian Sushi" });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 4, "", null, "https://i.ibb.co/QcZMNxm/makisushi.jpg", true, "This is the dragon sushi made of all veggies ingredients", "Dragon Sushi Super", 4m, "Super Yummy Sushi", true });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 5, "", null, "https://i.ibb.co/f4H3PH6/rolls.jpg", true, "This is the dragon sushi made of all veggies ingredients", "Miki Sushi", 2m, "Second Yummy Sushi", true });

            migrationBuilder.InsertData(
                table: "Sushis",
                columns: new[] { "SushiId", "Allergy", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription", "SushiOfTheDay" },
                values: new object[] { 6, "", null, "https://i.ibb.co/xKTvpLz/avocado-sushi.jpg", true, "Made with organic avocadoes, this healthy sushi is amazingly yummy!", "Avocado Sushi", 3m, "Delicious Avocado Sushi", false });

            migrationBuilder.AddForeignKey(
                name: "FK_Sushis_Categories_CategoryId",
                table: "Sushis",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
