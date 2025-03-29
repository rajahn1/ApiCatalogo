using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Drinks', 'drinks.jpg')");
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Food', 'food.jpg')");
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Candy', 'candy.jpg')");
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Clothes', 'clothes.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categories");
        }
    }
}
