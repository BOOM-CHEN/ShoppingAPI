using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.ShoppingEntity.Migrations
{
    /// <inheritdoc />
    public partial class V101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Carousel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Carousel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRecieveAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAvatar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTotalPrice = table.Column<float>(type: "real", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShoppingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Order_T_User_UserId",
                        column: x => x.UserId,
                        principalTable: "T_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ShoppingCart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ShoppingCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_ShoppingCart_T_User_UserId",
                        column: x => x.UserId,
                        principalTable: "T_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_UserPassword",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_UserPassword", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_UserPassword_T_User_UserId",
                        column: x => x.UserId,
                        principalTable: "T_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDiscount = table.Column<double>(type: "float", nullable: false, defaultValue: 1.0),
                    ProductInventory = table.Column<int>(type: "int", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShoppingCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Product_T_ShoppingCart_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "T_ShoppingCart",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "T_ProductCategory",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ProductCategory", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_T_ProductCategory_T_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "T_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_ProductCategory_T_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "T_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "T_Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("01ce3fb9-409e-46db-ba97-98cc90be57bc"), "学习用具" },
                    { new Guid("0d9197bc-5ac4-4218-97c6-df550a4333ac"), "教育书籍" },
                    { new Guid("45ff3e52-c412-455e-aeda-08acba51cdf9"), "彩妆" },
                    { new Guid("4f50ad19-55a3-4ffe-be8a-af2ff3a2a7d2"), "装饰品" },
                    { new Guid("5242e593-a5c1-4f02-a808-28b5f1b94039"), "零食" },
                    { new Guid("542fc497-a67f-47ae-9bd6-b2ac83ac2de8"), "玩具" },
                    { new Guid("61bedeb6-227e-4077-9b59-8fd24b0d7f5e"), "运动装备" },
                    { new Guid("6440189b-8982-4a55-89f0-2145dd49fad5"), "杂志" },
                    { new Guid("679ca632-a1e2-4caf-8f2b-c64dd040093d"), "护肤品" },
                    { new Guid("756b06ac-c9e5-4a75-8aff-4fdf76b3aad4"), "家用电器" },
                    { new Guid("79e115a6-87f4-4091-8abb-3820ce027fa2"), "调味品" },
                    { new Guid("7ed2485b-63b0-452c-8195-ceeb04b4fe68"), "婴儿用品" },
                    { new Guid("95dbb072-971d-41a8-97f0-e931d4974c78"), "家具" },
                    { new Guid("99751b4c-e64c-4fb0-a162-c3fecc5da638"), "小说" },
                    { new Guid("9a9c04a9-cc7d-4c36-a984-16380ef911ed"), "女装" },
                    { new Guid("a222a78f-7338-4cc0-b6c2-908e61e09ad0"), "童装" },
                    { new Guid("a2cb0536-9ef1-4121-b02b-64e8188da46f"), "饮料" },
                    { new Guid("a53fd49e-252c-41ba-9469-b1b8c9900db8"), "手机" },
                    { new Guid("b9b87c47-73ff-4a73-b943-ce6aea1fc748"), "厨房用具" },
                    { new Guid("d1cdf256-299b-4b52-a249-963196ede7cb"), "生鲜食品" },
                    { new Guid("e056ce9c-942c-4837-88ff-7983e9fa6387"), "男装" },
                    { new Guid("e6b7d413-d504-49cc-8cb8-18e1fa2ccf39"), "电脑" },
                    { new Guid("ec9db1dd-01a2-4f3e-a7e9-529a298676e2"), "香水" },
                    { new Guid("fe396e62-0a7b-4c68-ab2e-add695e5c7fa"), "相机" }
                });

            migrationBuilder.InsertData(
                table: "T_Product",
                columns: new[] { "Id", "ProductCategory", "ProductDate", "ProductDescription", "ProductImage", "ProductInventory", "ProductName", "ProductPrice", "ShoppingCartId" },
                values: new object[,]
                {
                    { new Guid("43b9e9f4-6c05-4efd-b2cf-dd1b68a83d46"), "手机", "2023-11-09 17:28:48", "小米手机", null, 925, "小米1", 250.0, null },
                    { new Guid("5796e7c5-8519-4d1e-bb9d-2b4372d1127a"), "电脑", "2023-11-09 17:28:48", "联想系列", null, 255, "联想y7000p", 8555.0, null },
                    { new Guid("8b0a37ee-8350-403b-a180-9006f3e672bb"), "电脑", "2023-11-09 17:28:48", "联想系列", null, 300, "联想7000p", 9555.0, null },
                    { new Guid("91f9b102-b399-4103-aa8e-e58a081a923d"), "小说", "2023-11-09 17:28:48", "江南小说", null, 925, "龙族1", 99.0, null },
                    { new Guid("afdcd286-300a-4ab2-a556-796e4f19d318"), "小说", "2023-11-09 17:28:48", "江南小说", null, 854, "龙族2", 109.0, null },
                    { new Guid("bf5b7b85-5c97-4752-8f03-300c6fb56eac"), "手机", "2023-11-09 17:28:48", "小米手机", null, 655, "小米2", 165.0, null },
                    { new Guid("c20c7b1f-7936-4ab2-a55d-3da7b1bd5bc6"), "小说", "2023-11-09 17:28:48", "江南小说", null, 658, "龙族3", 125.0, null },
                    { new Guid("c59cef60-36ca-40a6-905a-781450f7e0aa"), "小说", "2023-11-09 17:28:48", "江南小说", null, 356, "龙族4", 169.0, null },
                    { new Guid("ec7d613b-b4d2-4e87-bbd3-c5b340c3dac4"), "小说", "2023-11-09 17:28:48", "江南小说", null, 500, "龙族5", 135.0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Order_UserId",
                table: "T_Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Product_ShoppingCartId",
                table: "T_Product",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ProductCategory_CategoryId",
                table: "T_ProductCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ShoppingCart_UserId",
                table: "T_ShoppingCart",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_UserPassword_UserId",
                table: "T_UserPassword",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Carousel");

            migrationBuilder.DropTable(
                name: "T_Order");

            migrationBuilder.DropTable(
                name: "T_ProductCategory");

            migrationBuilder.DropTable(
                name: "T_UserPassword");

            migrationBuilder.DropTable(
                name: "T_Category");

            migrationBuilder.DropTable(
                name: "T_Product");

            migrationBuilder.DropTable(
                name: "T_ShoppingCart");

            migrationBuilder.DropTable(
                name: "T_User");
        }
    }
}
