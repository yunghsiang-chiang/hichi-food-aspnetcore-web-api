using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace hochi_food.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRecipeNavigationFromIngredientsAndSeasonings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "c_cooking_method",
                columns: table => new
                {
                    cooking_method_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, comment: "烹飪方式ID"),
                    cooking_method = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "烹飪方式"),
                    method_description = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, comment: "烹飪說明")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.cooking_method_id);
                },
                comment: "烹飪方式")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "c_cooking_method_old",
                columns: table => new
                {
                    cooking_method_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, comment: "烹飪方式編碼"),
                    cooking_method = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "烹飪方式"),
                    cooking_explain = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "烹飪方式解釋")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.cooking_method_id);
                },
                comment: "烹飪方法對照表")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "c_dishes",
                columns: table => new
                {
                    dishes_id = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, comment: "菜品編號"),
                    dishes_name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "菜品名稱"),
                    dishes_type = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, comment: "菜品類型"),
                    cooking_method = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, comment: "烹飪方式 分類"),
                    material_id_items = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false, comment: "食材名稱 代號"),
                    material_id_names = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false, comment: "食材名稱 中文"),
                    cooking_step = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false, comment: "烹飪步驟 說明限制500字以內"),
                    cooking_time = table.Column<int>(type: "int", nullable: false, comment: "烹飪時間 單位:分鐘"),
                    dishes_image = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false, comment: "菜品照片Urls"),
                    commentary = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false, comment: "介紹菜品"),
                    seasoning = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "調味品")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.dishes_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "c_dishes_type",
                columns: table => new
                {
                    dishes_type_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, comment: "餐點類型ID"),
                    dishes_type_name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, comment: "餐點類型名稱")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.dishes_type_id);
                },
                comment: "餐點類型資訊")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "c_food_nutrition",
                columns: table => new
                {
                    樣品編號 = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    食品分類 = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    樣品名稱 = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    俗名 = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true),
                    內容物描述 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    廢棄率 = table.Column<int>(name: "廢棄率(%)", type: "int", nullable: false),
                    熱量kcal = table.Column<int>(name: "熱量(kcal)", type: "int", nullable: false),
                    修正熱量kcal = table.Column<int>(name: "修正熱量(kcal)", type: "int", nullable: false),
                    水分g = table.Column<double>(name: "水分(g)", type: "double", nullable: false),
                    粗蛋白g = table.Column<double>(name: "粗蛋白(g)", type: "double", nullable: false),
                    粗脂肪g = table.Column<double>(name: "粗脂肪(g)", type: "double", nullable: false),
                    飽和脂肪g = table.Column<double>(name: "飽和脂肪(g)", type: "double", nullable: false),
                    灰分g = table.Column<double>(name: "灰分(g)", type: "double", nullable: false),
                    總碳水化合物g = table.Column<double>(name: "總碳水化合物(g)", type: "double", nullable: false),
                    膳食纖維g = table.Column<double>(name: "膳食纖維(g)", type: "double", nullable: false),
                    糖質總量g = table.Column<double>(name: "糖質總量(g)", type: "double", nullable: false),
                    葡萄糖g = table.Column<int>(name: "葡萄糖(g)", type: "int", nullable: false),
                    果糖g = table.Column<int>(name: "果糖(g)", type: "int", nullable: false),
                    半乳糖g = table.Column<int>(name: "半乳糖(g)", type: "int", nullable: false),
                    麥芽糖g = table.Column<int>(name: "麥芽糖(g)", type: "int", nullable: false),
                    蔗糖g = table.Column<double>(name: "蔗糖(g)", type: "double", nullable: false),
                    乳糖g = table.Column<int>(name: "乳糖(g)", type: "int", nullable: false),
                    鈉mg = table.Column<int>(name: "鈉(mg)", type: "int", nullable: false),
                    鉀mg = table.Column<int>(name: "鉀(mg)", type: "int", nullable: false),
                    鈣mg = table.Column<int>(name: "鈣(mg)", type: "int", nullable: false),
                    鎂mg = table.Column<int>(name: "鎂(mg)", type: "int", nullable: false),
                    鐵mg = table.Column<double>(name: "鐵(mg)", type: "double", nullable: false),
                    鋅mg = table.Column<double>(name: "鋅(mg)", type: "double", nullable: false),
                    磷mg = table.Column<int>(name: "磷(mg)", type: "int", nullable: false),
                    銅mg = table.Column<int>(name: "銅(mg)", type: "int", nullable: false),
                    錳mg = table.Column<int>(name: "錳(mg)", type: "int", nullable: false),
                    維生素A總量IU = table.Column<int>(name: "維生素A總量(IU)", type: "int", nullable: false),
                    視網醇當量REug = table.Column<int>(name: "視網醇當量(RE)(ug)", type: "int", nullable: false),
                    視網醇ug = table.Column<int>(name: "視網醇(ug)", type: "int", nullable: false),
                    α胡蘿蔔素ug = table.Column<int>(name: "α-胡蘿蔔素(ug)", type: "int", nullable: false),
                    β胡蘿蔔素ug = table.Column<int>(name: "β-胡蘿蔔素(ug)", type: "int", nullable: false),
                    維生素D總量IU = table.Column<int>(name: "維生素D總量(IU)", type: "int", nullable: false),
                    維生素D總量ug = table.Column<int>(name: "維生素D總量(ug)", type: "int", nullable: false),
                    維生素D2ug = table.Column<int>(name: "維生素D2(ug)", type: "int", nullable: false),
                    維生素D3ug = table.Column<int>(name: "維生素D3(ug)", type: "int", nullable: false),
                    維生素E總量mg = table.Column<double>(name: "維生素E總量(mg)", type: "double", nullable: false),
                    α維生素E當量αTEmg = table.Column<double>(name: "α-維生素E當量(α-TE)(mg)", type: "double", nullable: false),
                    α生育酚mg = table.Column<double>(name: "α-生育酚(mg)", type: "double", nullable: false),
                    β生育酚mg = table.Column<double>(name: "β-生育酚(mg)", type: "double", nullable: false),
                    γ生育酚mg = table.Column<double>(name: "γ-生育酚(mg)", type: "double", nullable: false),
                    δ生育酚mg = table.Column<double>(name: "δ-生育酚(mg)", type: "double", nullable: false),
                    維生素K1ug = table.Column<int>(name: "維生素K1(ug)", type: "int", nullable: false),
                    維生素K2MK4ug = table.Column<int>(name: "維生素K2 (MK-4)(ug)", type: "int", nullable: false),
                    維生素K2MK7ug = table.Column<int>(name: "維生素K2 (MK-7)(ug)", type: "int", nullable: false),
                    維生素B1mg = table.Column<double>(name: "維生素B1(mg)", type: "double", nullable: false),
                    維生素B2mg = table.Column<double>(name: "維生素B2(mg)", type: "double", nullable: false),
                    菸鹼素mg = table.Column<double>(name: "菸鹼素(mg)", type: "double", nullable: false),
                    維生素B6mg = table.Column<double>(name: "維生素B6(mg)", type: "double", nullable: false),
                    維生素B12ug = table.Column<int>(name: "維生素B12(ug)", type: "int", nullable: false),
                    葉酸ug = table.Column<double>(name: "葉酸(ug)", type: "double", nullable: false),
                    維生素Cmg = table.Column<double>(name: "維生素C(mg)", type: "double", nullable: false),
                    脂肪酸S總量mg = table.Column<int>(name: "脂肪酸S總量(mg)", type: "int", nullable: false),
                    酪酸40mg = table.Column<int>(name: "酪酸(4:0)(mg)", type: "int", nullable: false),
                    己酸60mg = table.Column<int>(name: "己酸(6:0)(mg)", type: "int", nullable: false),
                    辛酸80mg = table.Column<int>(name: "辛酸(8:0)(mg)", type: "int", nullable: false),
                    癸酸100mg = table.Column<int>(name: "癸酸(10:0)(mg)", type: "int", nullable: false),
                    月桂酸120mg = table.Column<int>(name: "月桂酸(12:0)(mg)", type: "int", nullable: false),
                    十三酸130mg = table.Column<int>(name: "十三酸(13:0)(mg)", type: "int", nullable: false),
                    肉豆蔻酸140mg = table.Column<int>(name: "肉豆蔻酸(14:0)(mg)", type: "int", nullable: false),
                    十五酸150mg = table.Column<int>(name: "十五酸(15:0)(mg)", type: "int", nullable: false),
                    棕櫚酸160mg = table.Column<int>(name: "棕櫚酸(16:0)(mg)", type: "int", nullable: false),
                    十七酸170mg = table.Column<int>(name: "十七酸(17:0)(mg)", type: "int", nullable: false),
                    硬脂酸180mg = table.Column<int>(name: "硬脂酸(18:0)(mg)", type: "int", nullable: false),
                    十九酸190mg = table.Column<int>(name: "十九酸(19:0)(mg)", type: "int", nullable: false),
                    花生酸200mg = table.Column<int>(name: "花生酸(20:0)(mg)", type: "int", nullable: false),
                    山酸220mg = table.Column<int>(name: "山酸(22:0)(mg)", type: "int", nullable: false),
                    廿四酸240mg = table.Column<int>(name: "廿四酸(24:0)(mg)", type: "int", nullable: false),
                    脂肪酸M總量mg = table.Column<int>(name: "脂肪酸M總量(mg)", type: "int", nullable: false),
                    肉豆蔻烯酸141mg = table.Column<int>(name: "肉豆蔻烯酸(14:1)(mg)", type: "int", nullable: false),
                    棕櫚烯酸161mg = table.Column<int>(name: "棕櫚烯酸(16:1)(mg)", type: "int", nullable: false),
                    油酸181mg = table.Column<int>(name: "油酸(18:1)(mg)", type: "int", nullable: false),
                    鱈烯酸201mg = table.Column<int>(name: "鱈烯酸(20:1)(mg)", type: "int", nullable: false),
                    芥子酸221mg = table.Column<int>(name: "芥子酸(22:1)(mg)", type: "int", nullable: false),
                    脂肪酸P總量mg = table.Column<int>(name: "脂肪酸P總量(mg)", type: "int", nullable: false),
                    亞麻油酸182mg = table.Column<int>(name: "亞麻油酸(18:2)(mg)", type: "int", nullable: false),
                    次亞麻油酸183mg = table.Column<int>(name: "次亞麻油酸(18:3)(mg)", type: "int", nullable: false),
                    十八碳四烯酸184mg = table.Column<int>(name: "十八碳四烯酸(18:4)(mg)", type: "int", nullable: false),
                    花生油酸204mg = table.Column<int>(name: "花生油酸(20:4)(mg)", type: "int", nullable: false),
                    廿碳五烯酸205mg = table.Column<int>(name: "廿碳五烯酸(20:5)(mg)", type: "int", nullable: false),
                    廿二碳五烯酸225mg = table.Column<int>(name: "廿二碳五烯酸(22:5)(mg)", type: "int", nullable: false),
                    廿二碳六烯酸226mg = table.Column<int>(name: "廿二碳六烯酸(22:6)(mg)", type: "int", nullable: false),
                    其他脂肪酸mg = table.Column<int>(name: "其他脂肪酸(mg)", type: "int", nullable: false),
                    PMS = table.Column<string>(name: "P/M/S", type: "text", nullable: false),
                    反式脂肪mg = table.Column<int>(name: "反式脂肪(mg)", type: "int", nullable: false),
                    水解胺基酸總量mg = table.Column<int>(name: "水解胺基酸總量(mg)", type: "int", nullable: false),
                    天門冬胺酸Aspmg = table.Column<int>(name: "天門冬胺酸(Asp)(mg)", type: "int", nullable: false),
                    酥胺酸Thrmg = table.Column<int>(name: "酥胺酸(Thr)(mg)", type: "int", nullable: false),
                    絲胺酸Sermg = table.Column<int>(name: "絲胺酸(Ser)(mg)", type: "int", nullable: false),
                    麩胺酸Glumg = table.Column<int>(name: "麩胺酸(Glu)(mg)", type: "int", nullable: false),
                    脯胺酸Promg = table.Column<int>(name: "脯胺酸(Pro)(mg)", type: "int", nullable: false),
                    甘胺酸Glymg = table.Column<int>(name: "甘胺酸(Gly)(mg)", type: "int", nullable: false),
                    丙胺酸Alamg = table.Column<int>(name: "丙胺酸(Ala)(mg)", type: "int", nullable: false),
                    胱胺酸Cysmg = table.Column<int>(name: "胱胺酸(Cys)(mg)", type: "int", nullable: false),
                    纈胺酸Valmg = table.Column<int>(name: "纈胺酸(Val)(mg)", type: "int", nullable: false),
                    甲硫胺酸Metmg = table.Column<int>(name: "甲硫胺酸(Met)(mg)", type: "int", nullable: false),
                    異白胺酸Ilemg = table.Column<int>(name: "異白胺酸(Ile)(mg)", type: "int", nullable: false),
                    白胺酸Leumg = table.Column<int>(name: "白胺酸(Leu)(mg)", type: "int", nullable: false),
                    酪胺酸Tyrmg = table.Column<int>(name: "酪胺酸(Tyr)(mg)", type: "int", nullable: false),
                    苯丙胺酸Phemg = table.Column<int>(name: "苯丙胺酸(Phe)(mg)", type: "int", nullable: false),
                    離胺酸Lysmg = table.Column<int>(name: "離胺酸(Lys)(mg)", type: "int", nullable: false),
                    組胺酸Hismg = table.Column<int>(name: "組胺酸(His)(mg)", type: "int", nullable: false),
                    精胺酸Argmg = table.Column<int>(name: "精胺酸(Arg)(mg)", type: "int", nullable: false),
                    色胺酸Trpmg = table.Column<int>(name: "色胺酸(Trp)(mg)", type: "int", nullable: false),
                    膽固醇mg = table.Column<int>(name: "膽固醇(mg)", type: "int", nullable: false),
                    酒精含量g = table.Column<int>(name: "酒精含量(g)", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.樣品編號);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "c_fruits",
                columns: table => new
                {
                    fruits_chinese = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    fruits_english = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.fruits_chinese);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "c_ingredients_unit",
                columns: table => new
                {
                    unit_chinese = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, comment: "單位中文稱呼"),
                    unit_english = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, comment: "單位英文稱呼"),
                    unit_type = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "單位類型"),
                    unit_description = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "單位說明")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.unit_chinese, x.unit_english });
                },
                comment: "食材單位表")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "c_meal_type",
                columns: table => new
                {
                    meal_type = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, comment: "餐別")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.meal_type);
                },
                comment: "餐別")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "c_seasoning",
                columns: table => new
                {
                    seasoning_id = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, comment: "調味料ID"),
                    seasoning_name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "調味料名稱"),
                    seasoning_description = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.seasoning_id);
                },
                comment: "調味料")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each recipe category")
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    category_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "Name of the category (e.g., 主菜, 紅燒, 咖哩)"),
                    description = table.Column<string>(type: "text", nullable: true, comment: "Optional description or notes about the category"),
                    icon = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, comment: "category icon")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.category_id);
                },
                comment: "Table to store different categories for recipes")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "chef",
                columns: table => new
                {
                    chef_id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each chef")
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "Name of the chef (e.g., 王金對)"),
                    region = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, comment: "Region or location associated with the chef (optional)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.chef_id);
                },
                comment: "Table to store information about each chef")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "h_activity_records",
                columns: table => new
                {
                    activity_name = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, comment: "活動名稱"),
                    activity_date = table.Column<DateTime>(type: "date", nullable: false, comment: "活動日期"),
                    meal_type = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "餐別"),
                    activity_days = table.Column<int>(type: "int", nullable: false, defaultValueSql: "'1'", comment: "活動天數"),
                    during_the_activity = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "活動期間"),
                    lm_user = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, comment: "最後編輯者"),
                    dishes_id_str = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "菜色清單")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.activity_name, x.activity_date, x.meal_type });
                },
                comment: "歷史活動紀錄")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ingredient",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each ingredient")
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ingredient_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "Name of the ingredient (e.g., 天貝, 豆包)"),
                    description = table.Column<string>(type: "text", nullable: true, comment: "Optional description or notes about the ingredient"),
                    unit = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "Unit of measurement for the ingredient (e.g., grams, ml)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ingredient_id);
                },
                comment: "Table to store detailed information about ingredients used in recipes")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "main_ingredient",
                columns: table => new
                {
                    main_ingredient_id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each main ingredient")
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    main_ingredient_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "Name of the main ingredient (e.g., 豆包, 天貝)"),
                    description = table.Column<string>(type: "text", nullable: true, comment: "Optional description or notes about the ingredient"),
                    category = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, comment: "Category of the ingredient (e.g., 豆製品 for tofu products)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.main_ingredient_id);
                },
                comment: "Table to store detailed information about each main ingredient used in recipes")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "recipe",
                columns: table => new
                {
                    recipe_id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each recipe")
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    recipe_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "Name of the recipe (e.g., 糖醋豆包)"),
                    main_ingredient_id = table.Column<int>(type: "int", nullable: true, comment: "References the ID of the main ingredient from the Main_Ingredient table"),
                    category = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, comment: "Category of the recipe (e.g., 主菜 - 紅燒, 咖哩)"),
                    chef_id = table.Column<int>(type: "int", nullable: true, comment: "References the ID of the chef from the Chef table"),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, comment: "Link or identifier for further recipe details")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.recipe_id);
                    table.ForeignKey(
                        name: "recipe_ibfk_1",
                        column: x => x.main_ingredient_id,
                        principalTable: "main_ingredient",
                        principalColumn: "main_ingredient_id");
                    table.ForeignKey(
                        name: "recipe_ibfk_2",
                        column: x => x.chef_id,
                        principalTable: "chef",
                        principalColumn: "chef_id");
                },
                comment: "Table to store information about each recipe, including name, main ingredient, category, and chef reference")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ingredients",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    recipe_id = table.Column<int>(type: "int", nullable: false),
                    ingredient_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    amount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, nullable: false),
                    unit = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    recipe_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ingredient_id);
                    table.ForeignKey(
                        name: "FK_ingredients_recipe_recipe_id1",
                        column: x => x.recipe_id1,
                        principalTable: "recipe",
                        principalColumn: "recipe_id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "recipe_steps",
                columns: table => new
                {
                    step_id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier for each recipe step")
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    recipe_id = table.Column<int>(type: "int", nullable: true, comment: "References the ID of the recipe from the Recipe table"),
                    step_number = table.Column<int>(type: "int", nullable: false, comment: "The order of the step in the recipe"),
                    description = table.Column<string>(type: "text", nullable: false, comment: "Detailed description of the step"),
                    image_url = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, comment: "URL for an image illustrating the step (if available)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.step_id);
                    table.ForeignKey(
                        name: "recipe_steps_ibfk_1",
                        column: x => x.recipe_id,
                        principalTable: "recipe",
                        principalColumn: "recipe_id");
                },
                comment: "Table to store step-by-step instructions for each recipe")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "seasonings",
                columns: table => new
                {
                    seasoning_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    recipe_id = table.Column<int>(type: "int", nullable: false),
                    seasoning_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    amount = table.Column<decimal>(type: "decimal(10,2)", precision: 10, nullable: false),
                    unit = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    recipe_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.seasoning_id);
                    table.ForeignKey(
                        name: "FK_seasonings_recipe_recipe_id1",
                        column: x => x.recipe_id1,
                        principalTable: "recipe",
                        principalColumn: "recipe_id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ingredients_recipe_id1",
                table: "ingredients",
                column: "recipe_id1");

            migrationBuilder.CreateIndex(
                name: "recipe_id",
                table: "ingredients",
                column: "recipe_id");

            migrationBuilder.CreateIndex(
                name: "chef_id",
                table: "recipe",
                column: "chef_id");

            migrationBuilder.CreateIndex(
                name: "main_ingredient_id",
                table: "recipe",
                column: "main_ingredient_id");

            migrationBuilder.CreateIndex(
                name: "recipe_id1",
                table: "recipe_steps",
                column: "recipe_id");

            migrationBuilder.CreateIndex(
                name: "IX_seasonings_recipe_id1",
                table: "seasonings",
                column: "recipe_id1");

            migrationBuilder.CreateIndex(
                name: "recipe_id2",
                table: "seasonings",
                column: "recipe_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "c_cooking_method");

            migrationBuilder.DropTable(
                name: "c_cooking_method_old");

            migrationBuilder.DropTable(
                name: "c_dishes");

            migrationBuilder.DropTable(
                name: "c_dishes_type");

            migrationBuilder.DropTable(
                name: "c_food_nutrition");

            migrationBuilder.DropTable(
                name: "c_fruits");

            migrationBuilder.DropTable(
                name: "c_ingredients_unit");

            migrationBuilder.DropTable(
                name: "c_meal_type");

            migrationBuilder.DropTable(
                name: "c_seasoning");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "h_activity_records");

            migrationBuilder.DropTable(
                name: "ingredient");

            migrationBuilder.DropTable(
                name: "ingredients");

            migrationBuilder.DropTable(
                name: "recipe_steps");

            migrationBuilder.DropTable(
                name: "seasonings");

            migrationBuilder.DropTable(
                name: "recipe");

            migrationBuilder.DropTable(
                name: "main_ingredient");

            migrationBuilder.DropTable(
                name: "chef");
        }
    }
}
