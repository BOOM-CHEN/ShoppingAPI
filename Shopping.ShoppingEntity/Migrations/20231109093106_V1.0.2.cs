using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.ShoppingEntity.Migrations
{
    /// <inheritdoc />
    public partial class V102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("01ce3fb9-409e-46db-ba97-98cc90be57bc"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("0d9197bc-5ac4-4218-97c6-df550a4333ac"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("45ff3e52-c412-455e-aeda-08acba51cdf9"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("4f50ad19-55a3-4ffe-be8a-af2ff3a2a7d2"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("5242e593-a5c1-4f02-a808-28b5f1b94039"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("542fc497-a67f-47ae-9bd6-b2ac83ac2de8"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("61bedeb6-227e-4077-9b59-8fd24b0d7f5e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("6440189b-8982-4a55-89f0-2145dd49fad5"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("679ca632-a1e2-4caf-8f2b-c64dd040093d"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("756b06ac-c9e5-4a75-8aff-4fdf76b3aad4"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("79e115a6-87f4-4091-8abb-3820ce027fa2"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("7ed2485b-63b0-452c-8195-ceeb04b4fe68"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("95dbb072-971d-41a8-97f0-e931d4974c78"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("99751b4c-e64c-4fb0-a162-c3fecc5da638"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("9a9c04a9-cc7d-4c36-a984-16380ef911ed"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("a222a78f-7338-4cc0-b6c2-908e61e09ad0"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("a2cb0536-9ef1-4121-b02b-64e8188da46f"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("a53fd49e-252c-41ba-9469-b1b8c9900db8"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("b9b87c47-73ff-4a73-b943-ce6aea1fc748"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("d1cdf256-299b-4b52-a249-963196ede7cb"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("e056ce9c-942c-4837-88ff-7983e9fa6387"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("e6b7d413-d504-49cc-8cb8-18e1fa2ccf39"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("ec9db1dd-01a2-4f3e-a7e9-529a298676e2"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("fe396e62-0a7b-4c68-ab2e-add695e5c7fa"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("43b9e9f4-6c05-4efd-b2cf-dd1b68a83d46"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("5796e7c5-8519-4d1e-bb9d-2b4372d1127a"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("8b0a37ee-8350-403b-a180-9006f3e672bb"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("91f9b102-b399-4103-aa8e-e58a081a923d"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("afdcd286-300a-4ab2-a556-796e4f19d318"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("bf5b7b85-5c97-4752-8f03-300c6fb56eac"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("c20c7b1f-7936-4ab2-a55d-3da7b1bd5bc6"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("c59cef60-36ca-40a6-905a-781450f7e0aa"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("ec7d613b-b4d2-4e87-bbd3-c5b340c3dac4"));

            migrationBuilder.InsertData(
                table: "T_Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("05bb47f3-7cac-4d6a-ab90-c770d936d968"), "家用电器" },
                    { new Guid("0c6f184a-97d9-4061-a51e-9d9d3325cc8a"), "护肤品" },
                    { new Guid("0fd17238-9fad-4b4b-bb96-7b5619643e3d"), "香水" },
                    { new Guid("218445db-d01d-4884-99dd-6ceff726ff44"), "童装" },
                    { new Guid("22560735-5af0-4437-aa63-072dbb35e82b"), "男装" },
                    { new Guid("28697baa-6573-4a54-a8a1-e8901155faed"), "装饰品" },
                    { new Guid("2f845cff-9a3b-421c-ac8d-c9bf3a058035"), "电脑" },
                    { new Guid("32f0e944-aac3-4d0b-b6dc-fff5a2c930c1"), "小说" },
                    { new Guid("3662d026-b8fc-4468-afa5-b4b64be1698e"), "饮料" },
                    { new Guid("4248824d-879c-4464-a495-f8b0591ba882"), "零食" },
                    { new Guid("6ec6fe5e-9034-46f2-a284-e6d936633f14"), "相机" },
                    { new Guid("7895dec2-f012-4f90-8a87-b0b784c8c14b"), "手机" },
                    { new Guid("9058eed1-7690-4f37-af6e-6c8e190ee245"), "彩妆" },
                    { new Guid("908a47a1-b2f6-492f-b604-a42e12ecc7fd"), "厨房用具" },
                    { new Guid("a6cb0c79-8240-440d-aeb6-452d431a1531"), "调味品" },
                    { new Guid("b88d2598-9e0a-4098-9f89-e975e56bed38"), "玩具" },
                    { new Guid("bcfbb528-c357-428a-98f8-9db5e77bb8a5"), "生鲜食品" },
                    { new Guid("c000b9b3-899e-4b0f-8649-8d6681d0a15a"), "学习用具" },
                    { new Guid("c037325d-dc47-4fdb-8f07-956b728da65e"), "女装" },
                    { new Guid("cd6e6797-ee25-42c5-84d4-df65c0d2fba1"), "杂志" },
                    { new Guid("e98cde80-a11c-4e9a-b03f-06aec08bada4"), "运动装备" },
                    { new Guid("f4c838ea-67fb-4e13-a2a0-044cb15daa6c"), "家具" },
                    { new Guid("f81a6e7e-b485-427f-bd76-6169c3405b7c"), "教育书籍" },
                    { new Guid("fb9d180e-86d9-49b3-b805-10855a7973fb"), "婴儿用品" }
                });

            migrationBuilder.InsertData(
                table: "T_Product",
                columns: new[] { "Id", "ProductCategory", "ProductDate", "ProductDescription", "ProductImage", "ProductInventory", "ProductName", "ProductPrice", "ShoppingCartId" },
                values: new object[,]
                {
                    { new Guid("72591916-1c6c-4c64-b953-b1f9026f32e5"), "手机", "2023-11-09 17:31:06", "小米手机", null, 925, "小米1", 250.0, null },
                    { new Guid("80d17f1a-1594-453a-abbb-8c6c42977af2"), "小说", "2023-11-09 17:31:06", "江南小说", null, 925, "龙族1", 99.0, null },
                    { new Guid("847773cd-f632-4502-897e-c66b68b9856e"), "电脑", "2023-11-09 17:31:06", "联想系列", null, 255, "联想y7000p", 8555.0, null },
                    { new Guid("907438b2-401d-4ffc-93ee-c2da0533d83a"), "手机", "2023-11-09 17:31:06", "小米手机", null, 655, "小米2", 165.0, null },
                    { new Guid("96b96da8-a6a6-4c5d-a7f1-3ae2c56b8238"), "小说", "2023-11-09 17:31:06", "江南小说", null, 356, "龙族4", 169.0, null },
                    { new Guid("a69629cd-9aa9-4347-9681-2eb6e74f1a48"), "电脑", "2023-11-09 17:31:06", "联想系列", null, 300, "联想7000p", 9555.0, null },
                    { new Guid("b4bd90cb-8c8d-4113-abe1-25bb075b24b1"), "小说", "2023-11-09 17:31:06", "江南小说", null, 854, "龙族2", 109.0, null },
                    { new Guid("b4efc0bb-de87-4dae-8810-5a29c4cd48b8"), "小说", "2023-11-09 17:31:06", "江南小说", null, 500, "龙族5", 135.0, null },
                    { new Guid("b829d62e-0e2d-49a9-9c64-7533fa965459"), "小说", "2023-11-09 17:31:06", "江南小说", null, 658, "龙族3", 125.0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("05bb47f3-7cac-4d6a-ab90-c770d936d968"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("0c6f184a-97d9-4061-a51e-9d9d3325cc8a"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("0fd17238-9fad-4b4b-bb96-7b5619643e3d"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("218445db-d01d-4884-99dd-6ceff726ff44"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("22560735-5af0-4437-aa63-072dbb35e82b"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("28697baa-6573-4a54-a8a1-e8901155faed"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("2f845cff-9a3b-421c-ac8d-c9bf3a058035"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("32f0e944-aac3-4d0b-b6dc-fff5a2c930c1"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("3662d026-b8fc-4468-afa5-b4b64be1698e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("4248824d-879c-4464-a495-f8b0591ba882"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("6ec6fe5e-9034-46f2-a284-e6d936633f14"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("7895dec2-f012-4f90-8a87-b0b784c8c14b"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("9058eed1-7690-4f37-af6e-6c8e190ee245"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("908a47a1-b2f6-492f-b604-a42e12ecc7fd"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("a6cb0c79-8240-440d-aeb6-452d431a1531"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("b88d2598-9e0a-4098-9f89-e975e56bed38"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("bcfbb528-c357-428a-98f8-9db5e77bb8a5"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("c000b9b3-899e-4b0f-8649-8d6681d0a15a"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("c037325d-dc47-4fdb-8f07-956b728da65e"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("cd6e6797-ee25-42c5-84d4-df65c0d2fba1"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("e98cde80-a11c-4e9a-b03f-06aec08bada4"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("f4c838ea-67fb-4e13-a2a0-044cb15daa6c"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("f81a6e7e-b485-427f-bd76-6169c3405b7c"));

            migrationBuilder.DeleteData(
                table: "T_Category",
                keyColumn: "Id",
                keyValue: new Guid("fb9d180e-86d9-49b3-b805-10855a7973fb"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("72591916-1c6c-4c64-b953-b1f9026f32e5"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("80d17f1a-1594-453a-abbb-8c6c42977af2"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("847773cd-f632-4502-897e-c66b68b9856e"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("907438b2-401d-4ffc-93ee-c2da0533d83a"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("96b96da8-a6a6-4c5d-a7f1-3ae2c56b8238"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("a69629cd-9aa9-4347-9681-2eb6e74f1a48"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("b4bd90cb-8c8d-4113-abe1-25bb075b24b1"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("b4efc0bb-de87-4dae-8810-5a29c4cd48b8"));

            migrationBuilder.DeleteData(
                table: "T_Product",
                keyColumn: "Id",
                keyValue: new Guid("b829d62e-0e2d-49a9-9c64-7533fa965459"));

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
        }
    }
}
