using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.ShoppingEntity.Migrations
{
    /// <inheritdoc />
    public partial class V106 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductCategory",
                table: "T_Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCategory",
                table: "T_Product");
        }
    }
}
