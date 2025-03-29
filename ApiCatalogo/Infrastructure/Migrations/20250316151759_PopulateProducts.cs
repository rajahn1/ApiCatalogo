using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulateProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Products(Name, Description, Price, Stock, ImageUrl, CreatedOn, CategoryId) Values('Vodka', 'Good vodka', 25.90, 25, 'vodka.jpg', now(), 1)");
            mb.Sql("Insert into Products(Name, Description, Price, Stock, ImageUrl, CreatedOn, CategoryId) Values('Coke', 'Coke 2l', 10.90, 100, 'coke.jpg', now(), 1)");
            mb.Sql("Insert into Products(Name, Description, Price, Stock, ImageUrl, CreatedOn, CategoryId) Values('Nuggets', 'Searar nuggets', 13.45, 30, 'nuggets.jpg', now(), 2)");
            mb.Sql("Insert into Products(Name, Description, Price, Stock, ImageUrl, CreatedOn, CategoryId) Values('Chocolate', 'Nestle 40% cacau', 9.90, 100, 'nestle.jpg', now(), 3)");
            mb.Sql("Insert into Products(Name, Description, Price, Stock, ImageUrl, CreatedOn, CategoryId) Values('Nike Air', 'Nike air lebron james', 450.99, 150, 'nike.jpg', now(), 4)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Products");

        }
    }
}
