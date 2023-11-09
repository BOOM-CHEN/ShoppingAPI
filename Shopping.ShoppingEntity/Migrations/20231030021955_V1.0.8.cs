using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.ShoppingEntity.Migrations
{
    /// <inheritdoc />
    public partial class V108 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductImage",
                table: "T_Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "T_Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("00100bb7-7d2a-4547-b8b0-d5e0d673e833"), "饮料" },
                    { new Guid("0152e738-329f-43ab-80f0-0f93fbc47f27"), "童装" },
                    { new Guid("06850552-050c-48d5-9f25-b2e7aa744c14"), "教育书籍" },
                    { new Guid("0e1dcdf1-6694-445f-a791-33fbf1146a4b"), "男装" },
                    { new Guid("262adbb3-52fa-43c5-afb5-e8602adb6005"), "女装" },
                    { new Guid("350a2fbc-a11f-4fbc-aa22-6ee27506cb05"), "装饰品" },
                    { new Guid("3d89c66b-5a83-44a6-b14e-9db336434054"), "香水" },
                    { new Guid("3db17da6-7acf-42b1-b376-da508f4d4985"), "运动装备" },
                    { new Guid("481a1edd-0491-428c-a5b9-b625a56dc254"), "玩具" },
                    { new Guid("4f6059b9-2d00-439e-adeb-98c02c3274c7"), "家具" },
                    { new Guid("5243b771-9bce-4378-8004-ec2ae130d692"), "彩妆" },
                    { new Guid("5deb2416-fa7e-48e1-be63-79112797dc94"), "生鲜食品" },
                    { new Guid("5eb7fd94-738c-430d-9d1c-be7d894b9a26"), "零食" },
                    { new Guid("8690dd29-d1cc-410d-9e78-d097c5d7b582"), "手机" },
                    { new Guid("8fcf9f63-9247-47a0-8b5e-42f622c58636"), "小说" },
                    { new Guid("94de0303-9db0-4724-89c4-ccee632aaf24"), "杂志" },
                    { new Guid("a81dafce-4634-4696-99bf-807602230449"), "厨房用具" },
                    { new Guid("b298bc07-02ad-4e72-8aae-3014dcee66f2"), "相机" },
                    { new Guid("b5349404-de97-4185-8aa6-07734bb0f891"), "调味品" },
                    { new Guid("c0334388-a7c0-4c40-8039-ad5b273311c2"), "电脑" },
                    { new Guid("c966899a-a2f1-4cba-96fd-0aa2be4f9743"), "家用电器" },
                    { new Guid("d87a6609-4516-40fc-b0e2-4d1985f2a6c6"), "学习用具" },
                    { new Guid("f53f4b0e-9bf1-4bf5-ae9b-c5d2f25eadc5"), "婴儿用品" },
                    { new Guid("f5b569c2-5f18-44a7-872f-aa15bc960b5a"), "护肤品" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("00100bb7-7d2a-4547-b8b0-d5e0d673e833"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("0152e738-329f-43ab-80f0-0f93fbc47f27"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("06850552-050c-48d5-9f25-b2e7aa744c14"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("0e1dcdf1-6694-445f-a791-33fbf1146a4b"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("262adbb3-52fa-43c5-afb5-e8602adb6005"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("350a2fbc-a11f-4fbc-aa22-6ee27506cb05"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("3d89c66b-5a83-44a6-b14e-9db336434054"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("3db17da6-7acf-42b1-b376-da508f4d4985"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("481a1edd-0491-428c-a5b9-b625a56dc254"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("4f6059b9-2d00-439e-adeb-98c02c3274c7"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("5243b771-9bce-4378-8004-ec2ae130d692"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("5deb2416-fa7e-48e1-be63-79112797dc94"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("5eb7fd94-738c-430d-9d1c-be7d894b9a26"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("8690dd29-d1cc-410d-9e78-d097c5d7b582"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("8fcf9f63-9247-47a0-8b5e-42f622c58636"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("94de0303-9db0-4724-89c4-ccee632aaf24"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("a81dafce-4634-4696-99bf-807602230449"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("b298bc07-02ad-4e72-8aae-3014dcee66f2"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("b5349404-de97-4185-8aa6-07734bb0f891"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("c0334388-a7c0-4c40-8039-ad5b273311c2"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("c966899a-a2f1-4cba-96fd-0aa2be4f9743"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("d87a6609-4516-40fc-b0e2-4d1985f2a6c6"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("f53f4b0e-9bf1-4bf5-ae9b-c5d2f25eadc5"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("f5b569c2-5f18-44a7-872f-aa15bc960b5a"));

            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "T_Product");
        }
    }
}
