using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hochi_food.Models;

public partial class foodContext : DbContext
{
    public foodContext(DbContextOptions<foodContext> options)
        : base(options)
    {
    }

    public virtual DbSet<c_cooking_method> c_cooking_method { get; set; }

    public virtual DbSet<c_cooking_method_old> c_cooking_method_old { get; set; }

    public virtual DbSet<c_dishes> c_dishes { get; set; }

    public virtual DbSet<c_dishes_type> c_dishes_type { get; set; }

    public virtual DbSet<c_food_nutrition> c_food_nutrition { get; set; }

    public virtual DbSet<c_fruits> c_fruits { get; set; }

    public virtual DbSet<c_ingredients_unit> c_ingredients_unit { get; set; }

    public virtual DbSet<c_meal_type> c_meal_type { get; set; }

    public virtual DbSet<c_seasoning> c_seasoning { get; set; }

    public virtual DbSet<category> category { get; set; }

    public virtual DbSet<chef> chef { get; set; }

    public virtual DbSet<h_activity_records> h_activity_records { get; set; }

    public virtual DbSet<ingredient> ingredient { get; set; }

    public virtual DbSet<main_ingredient> main_ingredient { get; set; }

    public virtual DbSet<recipe> recipe { get; set; }

    public virtual DbSet<recipe_steps> recipe_steps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<c_cooking_method>(entity =>
        {
            entity.HasKey(e => e.cooking_method_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("烹飪方式"));

            entity.Property(e => e.cooking_method_id)
                .HasMaxLength(10)
                .HasComment("烹飪方式ID");
            entity.Property(e => e.cooking_method)
                .HasMaxLength(45)
                .HasComment("烹飪方式");
            entity.Property(e => e.method_description)
                .HasMaxLength(45)
                .HasComment("烹飪說明");
        });

        modelBuilder.Entity<c_cooking_method_old>(entity =>
        {
            entity.HasKey(e => e.cooking_method_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("烹飪方法對照表"));

            entity.Property(e => e.cooking_method_id)
                .HasMaxLength(10)
                .HasComment("烹飪方式編碼");
            entity.Property(e => e.cooking_explain)
                .HasMaxLength(100)
                .HasComment("烹飪方式解釋");
            entity.Property(e => e.cooking_method)
                .HasMaxLength(45)
                .HasComment("烹飪方式");
        });

        modelBuilder.Entity<c_dishes>(entity =>
        {
            entity.HasKey(e => e.dishes_id).HasName("PRIMARY");

            entity.Property(e => e.dishes_id)
                .HasMaxLength(15)
                .HasComment("菜品編號");
            entity.Property(e => e.commentary)
                .HasMaxLength(150)
                .HasComment("介紹菜品");
            entity.Property(e => e.cooking_method)
                .HasMaxLength(10)
                .HasComment("烹飪方式 分類");
            entity.Property(e => e.cooking_step)
                .HasMaxLength(500)
                .HasComment("烹飪步驟 說明限制500字以內");
            entity.Property(e => e.cooking_time).HasComment("烹飪時間 單位:分鐘");
            entity.Property(e => e.dishes_image)
                .HasMaxLength(150)
                .HasComment("菜品照片Urls");
            entity.Property(e => e.dishes_name)
                .HasMaxLength(45)
                .HasComment("菜品名稱");
            entity.Property(e => e.dishes_type)
                .HasMaxLength(15)
                .HasComment("菜品類型");
            entity.Property(e => e.material_id_items)
                .HasMaxLength(150)
                .HasComment("食材名稱 代號");
            entity.Property(e => e.material_id_names)
                .HasMaxLength(150)
                .HasComment("食材名稱 中文");
            entity.Property(e => e.seasoning)
                .HasMaxLength(100)
                .HasComment("調味品");
        });

        modelBuilder.Entity<c_dishes_type>(entity =>
        {
            entity.HasKey(e => e.dishes_type_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("餐點類型資訊"));

            entity.Property(e => e.dishes_type_id)
                .HasMaxLength(10)
                .HasComment("餐點類型ID");
            entity.Property(e => e.dishes_type_name)
                .HasMaxLength(45)
                .HasComment("餐點類型名稱");
        });

        modelBuilder.Entity<c_food_nutrition>(entity =>
        {
            entity.HasKey(e => e.樣品編號).HasName("PRIMARY");

            entity.Property(e => e.樣品編號).HasMaxLength(20);
            entity.Property(e => e.P_M_S)
                .HasColumnType("text")
                .HasColumnName("P/M/S");
            entity.Property(e => e.α_生育酚_mg_).HasColumnName("α-生育酚(mg)");
            entity.Property(e => e.α_維生素E當量_α_TE__mg_).HasColumnName("α-維生素E當量(α-TE)(mg)");
            entity.Property(e => e.α_胡蘿蔔素_ug_).HasColumnName("α-胡蘿蔔素(ug)");
            entity.Property(e => e.β_生育酚_mg_).HasColumnName("β-生育酚(mg)");
            entity.Property(e => e.β_胡蘿蔔素_ug_).HasColumnName("β-胡蘿蔔素(ug)");
            entity.Property(e => e.γ_生育酚_mg_).HasColumnName("γ-生育酚(mg)");
            entity.Property(e => e.δ_生育酚_mg_).HasColumnName("δ-生育酚(mg)");
            entity.Property(e => e.丙胺酸_Ala__mg_).HasColumnName("丙胺酸(Ala)(mg)");
            entity.Property(e => e.乳糖_g_).HasColumnName("乳糖(g)");
            entity.Property(e => e.亞麻油酸_18_2__mg_).HasColumnName("亞麻油酸(18:2)(mg)");
            entity.Property(e => e.俗名).HasMaxLength(70);
            entity.Property(e => e.修正熱量_kcal_).HasColumnName("修正熱量(kcal)");
            entity.Property(e => e.內容物描述).HasMaxLength(100);
            entity.Property(e => e.其他脂肪酸_mg_).HasColumnName("其他脂肪酸(mg)");
            entity.Property(e => e.十七酸_17_0__mg_).HasColumnName("十七酸(17:0)(mg)");
            entity.Property(e => e.十三酸_13_0__mg_).HasColumnName("十三酸(13:0)(mg)");
            entity.Property(e => e.十九酸_19_0__mg_).HasColumnName("十九酸(19:0)(mg)");
            entity.Property(e => e.十五酸_15_0__mg_).HasColumnName("十五酸(15:0)(mg)");
            entity.Property(e => e.十八碳四烯酸_18_4__mg_).HasColumnName("十八碳四烯酸(18:4)(mg)");
            entity.Property(e => e.半乳糖_g_).HasColumnName("半乳糖(g)");
            entity.Property(e => e.反式脂肪_mg_).HasColumnName("反式脂肪(mg)");
            entity.Property(e => e.天門冬胺酸_Asp__mg_).HasColumnName("天門冬胺酸(Asp)(mg)");
            entity.Property(e => e.山酸_22_0__mg_).HasColumnName("山酸(22:0)(mg)");
            entity.Property(e => e.己酸_6_0__mg_).HasColumnName("己酸(6:0)(mg)");
            entity.Property(e => e.廢棄率___).HasColumnName("廢棄率(%)");
            entity.Property(e => e.廿二碳五烯酸_22_5__mg_).HasColumnName("廿二碳五烯酸(22:5)(mg)");
            entity.Property(e => e.廿二碳六烯酸_22_6__mg_).HasColumnName("廿二碳六烯酸(22:6)(mg)");
            entity.Property(e => e.廿四酸_24_0__mg_).HasColumnName("廿四酸(24:0)(mg)");
            entity.Property(e => e.廿碳五烯酸_20_5__mg_).HasColumnName("廿碳五烯酸(20:5)(mg)");
            entity.Property(e => e.月桂酸_12_0__mg_).HasColumnName("月桂酸(12:0)(mg)");
            entity.Property(e => e.果糖_g_).HasColumnName("果糖(g)");
            entity.Property(e => e.棕櫚烯酸_16_1__mg_).HasColumnName("棕櫚烯酸(16:1)(mg)");
            entity.Property(e => e.棕櫚酸_16_0__mg_).HasColumnName("棕櫚酸(16:0)(mg)");
            entity.Property(e => e.樣品名稱).HasMaxLength(20);
            entity.Property(e => e.次亞麻油酸_18_3__mg_).HasColumnName("次亞麻油酸(18:3)(mg)");
            entity.Property(e => e.水分_g_).HasColumnName("水分(g)");
            entity.Property(e => e.水解胺基酸總量_mg_).HasColumnName("水解胺基酸總量(mg)");
            entity.Property(e => e.油酸_18_1__mg_).HasColumnName("油酸(18:1)(mg)");
            entity.Property(e => e.灰分_g_).HasColumnName("灰分(g)");
            entity.Property(e => e.熱量_kcal_).HasColumnName("熱量(kcal)");
            entity.Property(e => e.甘胺酸_Gly__mg_).HasColumnName("甘胺酸(Gly)(mg)");
            entity.Property(e => e.甲硫胺酸_Met__mg_).HasColumnName("甲硫胺酸(Met)(mg)");
            entity.Property(e => e.異白胺酸_Ile__mg_).HasColumnName("異白胺酸(Ile)(mg)");
            entity.Property(e => e.癸酸_10_0__mg_).HasColumnName("癸酸(10:0)(mg)");
            entity.Property(e => e.白胺酸_Leu__mg_).HasColumnName("白胺酸(Leu)(mg)");
            entity.Property(e => e.硬脂酸_18_0__mg_).HasColumnName("硬脂酸(18:0)(mg)");
            entity.Property(e => e.磷_mg_).HasColumnName("磷(mg)");
            entity.Property(e => e.粗脂肪_g_).HasColumnName("粗脂肪(g)");
            entity.Property(e => e.粗蛋白_g_).HasColumnName("粗蛋白(g)");
            entity.Property(e => e.精胺酸_Arg__mg_).HasColumnName("精胺酸(Arg)(mg)");
            entity.Property(e => e.糖質總量_g_).HasColumnName("糖質總量(g)");
            entity.Property(e => e.組胺酸_His__mg_).HasColumnName("組胺酸(His)(mg)");
            entity.Property(e => e.絲胺酸_Ser__mg_).HasColumnName("絲胺酸(Ser)(mg)");
            entity.Property(e => e.維生素A總量_IU_).HasColumnName("維生素A總量(IU)");
            entity.Property(e => e.維生素B12_ug_).HasColumnName("維生素B12(ug)");
            entity.Property(e => e.維生素B1_mg_).HasColumnName("維生素B1(mg)");
            entity.Property(e => e.維生素B2_mg_).HasColumnName("維生素B2(mg)");
            entity.Property(e => e.維生素B6_mg_).HasColumnName("維生素B6(mg)");
            entity.Property(e => e.維生素C_mg_).HasColumnName("維生素C(mg)");
            entity.Property(e => e.維生素D2_ug_).HasColumnName("維生素D2(ug)");
            entity.Property(e => e.維生素D3_ug_).HasColumnName("維生素D3(ug)");
            entity.Property(e => e.維生素D總量_IU_).HasColumnName("維生素D總量(IU)");
            entity.Property(e => e.維生素D總量_ug_).HasColumnName("維生素D總量(ug)");
            entity.Property(e => e.維生素E總量_mg_).HasColumnName("維生素E總量(mg)");
            entity.Property(e => e.維生素K1_ug_).HasColumnName("維生素K1(ug)");
            entity.Property(e => e.維生素K2__MK_4__ug_).HasColumnName("維生素K2 (MK-4)(ug)");
            entity.Property(e => e.維生素K2__MK_7__ug_).HasColumnName("維生素K2 (MK-7)(ug)");
            entity.Property(e => e.總碳水化合物_g_).HasColumnName("總碳水化合物(g)");
            entity.Property(e => e.纈胺酸_Val__mg_).HasColumnName("纈胺酸(Val)(mg)");
            entity.Property(e => e.肉豆蔻烯酸_14_1__mg_).HasColumnName("肉豆蔻烯酸(14:1)(mg)");
            entity.Property(e => e.肉豆蔻酸_14_0__mg_).HasColumnName("肉豆蔻酸(14:0)(mg)");
            entity.Property(e => e.胱胺酸_Cys__mg_).HasColumnName("胱胺酸(Cys)(mg)");
            entity.Property(e => e.脂肪酸M總量_mg_).HasColumnName("脂肪酸M總量(mg)");
            entity.Property(e => e.脂肪酸P總量_mg_).HasColumnName("脂肪酸P總量(mg)");
            entity.Property(e => e.脂肪酸S總量_mg_).HasColumnName("脂肪酸S總量(mg)");
            entity.Property(e => e.脯胺酸_Pro__mg_).HasColumnName("脯胺酸(Pro)(mg)");
            entity.Property(e => e.膳食纖維_g_).HasColumnName("膳食纖維(g)");
            entity.Property(e => e.膽固醇_mg_).HasColumnName("膽固醇(mg)");
            entity.Property(e => e.色胺酸_Trp__mg_).HasColumnName("色胺酸(Trp)(mg)");
            entity.Property(e => e.芥子酸_22_1__mg_).HasColumnName("芥子酸(22:1)(mg)");
            entity.Property(e => e.花生油酸_20_4__mg_).HasColumnName("花生油酸(20:4)(mg)");
            entity.Property(e => e.花生酸_20_0__mg_).HasColumnName("花生酸(20:0)(mg)");
            entity.Property(e => e.苯丙胺酸_Phe__mg_).HasColumnName("苯丙胺酸(Phe)(mg)");
            entity.Property(e => e.菸鹼素_mg_).HasColumnName("菸鹼素(mg)");
            entity.Property(e => e.葉酸_ug_).HasColumnName("葉酸(ug)");
            entity.Property(e => e.葡萄糖_g_).HasColumnName("葡萄糖(g)");
            entity.Property(e => e.蔗糖_g_).HasColumnName("蔗糖(g)");
            entity.Property(e => e.視網醇_ug_).HasColumnName("視網醇(ug)");
            entity.Property(e => e.視網醇當量_RE__ug_).HasColumnName("視網醇當量(RE)(ug)");
            entity.Property(e => e.辛酸_8_0__mg_).HasColumnName("辛酸(8:0)(mg)");
            entity.Property(e => e.酒精含量_g_).HasColumnName("酒精含量(g)");
            entity.Property(e => e.酥胺酸_Thr__mg_).HasColumnName("酥胺酸(Thr)(mg)");
            entity.Property(e => e.酪胺酸_Tyr__mg_).HasColumnName("酪胺酸(Tyr)(mg)");
            entity.Property(e => e.酪酸_4_0__mg_).HasColumnName("酪酸(4:0)(mg)");
            entity.Property(e => e.鈉_mg_).HasColumnName("鈉(mg)");
            entity.Property(e => e.鈣_mg_).HasColumnName("鈣(mg)");
            entity.Property(e => e.鉀_mg_).HasColumnName("鉀(mg)");
            entity.Property(e => e.銅_mg_).HasColumnName("銅(mg)");
            entity.Property(e => e.鋅_mg_).HasColumnName("鋅(mg)");
            entity.Property(e => e.錳_mg_).HasColumnName("錳(mg)");
            entity.Property(e => e.鎂_mg_).HasColumnName("鎂(mg)");
            entity.Property(e => e.鐵_mg_).HasColumnName("鐵(mg)");
            entity.Property(e => e.離胺酸_Lys__mg_).HasColumnName("離胺酸(Lys)(mg)");
            entity.Property(e => e.食品分類).HasMaxLength(20);
            entity.Property(e => e.飽和脂肪_g_).HasColumnName("飽和脂肪(g)");
            entity.Property(e => e.鱈烯酸_20_1__mg_).HasColumnName("鱈烯酸(20:1)(mg)");
            entity.Property(e => e.麥芽糖_g_).HasColumnName("麥芽糖(g)");
            entity.Property(e => e.麩胺酸_Glu__mg_).HasColumnName("麩胺酸(Glu)(mg)");
        });

        modelBuilder.Entity<c_fruits>(entity =>
        {
            entity.HasKey(e => e.fruits_chinese).HasName("PRIMARY");

            entity.Property(e => e.fruits_chinese).HasMaxLength(5);
            entity.Property(e => e.fruits_english).HasMaxLength(20);
        });

        modelBuilder.Entity<c_ingredients_unit>(entity =>
        {
            entity.HasKey(e => new { e.unit_chinese, e.unit_english }).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("食材單位表"));

            entity.Property(e => e.unit_chinese)
                .HasMaxLength(10)
                .HasComment("單位中文稱呼");
            entity.Property(e => e.unit_english)
                .HasMaxLength(10)
                .HasComment("單位英文稱呼");
            entity.Property(e => e.unit_description)
                .HasMaxLength(45)
                .HasComment("單位說明");
            entity.Property(e => e.unit_type)
                .HasMaxLength(45)
                .HasComment("單位類型");
        });

        modelBuilder.Entity<c_meal_type>(entity =>
        {
            entity.HasKey(e => e.meal_type).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("餐別"));

            entity.Property(e => e.meal_type)
                .HasMaxLength(10)
                .HasComment("餐別");
        });

        modelBuilder.Entity<c_seasoning>(entity =>
        {
            entity.HasKey(e => e.seasoning_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("調味料"));

            entity.Property(e => e.seasoning_id)
                .HasMaxLength(2)
                .HasComment("調味料ID");
            entity.Property(e => e.seasoning_description).HasMaxLength(45);
            entity.Property(e => e.seasoning_name)
                .HasMaxLength(45)
                .HasComment("調味料名稱");
        });

        modelBuilder.Entity<category>(entity =>
        {
            entity.HasKey(e => e.category_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Table to store different categories for recipes"));

            entity.Property(e => e.category_id).HasComment("Unique identifier for each recipe category");
            entity.Property(e => e.category_name)
                .HasMaxLength(255)
                .HasComment("Name of the category (e.g., 主菜, 紅燒, 咖哩)");
            entity.Property(e => e.description)
                .HasComment("Optional description or notes about the category")
                .HasColumnType("text");
            entity.Property(e => e.icon)
                .HasMaxLength(255)
                .HasComment("category icon");
        });

        modelBuilder.Entity<chef>(entity =>
        {
            entity.HasKey(e => e.chef_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Table to store information about each chef"));

            entity.Property(e => e.chef_id).HasComment("Unique identifier for each chef");
            entity.Property(e => e.name)
                .HasMaxLength(255)
                .HasComment("Name of the chef (e.g., 王金對)");
            entity.Property(e => e.region)
                .HasMaxLength(255)
                .HasComment("Region or location associated with the chef (optional)");
        });

        modelBuilder.Entity<h_activity_records>(entity =>
        {
            entity.HasKey(e => new { e.activity_name, e.activity_date, e.meal_type }).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("歷史活動紀錄"));

            entity.Property(e => e.activity_name)
                .HasMaxLength(15)
                .HasComment("活動名稱");
            entity.Property(e => e.activity_date)
                .HasComment("活動日期")
                .HasColumnType("date");
            entity.Property(e => e.meal_type)
                .HasMaxLength(45)
                .HasComment("餐別");
            entity.Property(e => e.activity_days)
                .HasDefaultValueSql("'1'")
                .HasComment("活動天數");
            entity.Property(e => e.dishes_id_str)
                .HasMaxLength(100)
                .HasComment("菜色清單");
            entity.Property(e => e.during_the_activity)
                .HasMaxLength(45)
                .HasComment("活動期間");
            entity.Property(e => e.lm_user)
                .HasMaxLength(15)
                .HasComment("最後編輯者");
        });

        modelBuilder.Entity<ingredient>(entity =>
        {
            entity.HasKey(e => e.ingredient_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Table to store detailed information about ingredients used in recipes"));

            entity.Property(e => e.ingredient_id).HasComment("Unique identifier for each ingredient");
            entity.Property(e => e.description)
                .HasComment("Optional description or notes about the ingredient")
                .HasColumnType("text");
            entity.Property(e => e.ingredient_name)
                .HasMaxLength(255)
                .HasComment("Name of the ingredient (e.g., 天貝, 豆包)");
            entity.Property(e => e.unit)
                .HasMaxLength(50)
                .HasComment("Unit of measurement for the ingredient (e.g., grams, ml)");
        });

        modelBuilder.Entity<main_ingredient>(entity =>
        {
            entity.HasKey(e => e.main_ingredient_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Table to store detailed information about each main ingredient used in recipes"));

            entity.Property(e => e.main_ingredient_id).HasComment("Unique identifier for each main ingredient");
            entity.Property(e => e.category)
                .HasMaxLength(255)
                .HasComment("Category of the ingredient (e.g., 豆製品 for tofu products)");
            entity.Property(e => e.description)
                .HasComment("Optional description or notes about the ingredient")
                .HasColumnType("text");
            entity.Property(e => e.main_ingredient_name)
                .HasMaxLength(255)
                .HasComment("Name of the main ingredient (e.g., 豆包, 天貝)");
        });

        modelBuilder.Entity<recipe>(entity =>
        {
            entity.HasKey(e => e.recipe_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Table to store information about each recipe, including name, main ingredient, category, and chef reference"));

            entity.HasIndex(e => e.chef_id, "chef_id");

            entity.HasIndex(e => e.main_ingredient_id, "main_ingredient_id");

            entity.Property(e => e.recipe_id).HasComment("Unique identifier for each recipe");
            entity.Property(e => e.category)
                .HasMaxLength(255)
                .HasComment("Category of the recipe (e.g., 主菜 - 紅燒, 咖哩)");
            entity.Property(e => e.chef_id).HasComment("References the ID of the chef from the Chef table");
            entity.Property(e => e.description)
                .HasMaxLength(255)
                .HasComment("Link or identifier for further recipe details");
            entity.Property(e => e.main_ingredient_id).HasComment("References the ID of the main ingredient from the Main_Ingredient table");
            entity.Property(e => e.recipe_name)
                .HasMaxLength(255)
                .HasComment("Name of the recipe (e.g., 糖醋豆包)");

            entity.HasOne(d => d.chef).WithMany(p => p.recipe)
                .HasForeignKey(d => d.chef_id)
                .HasConstraintName("recipe_ibfk_2");

            entity.HasOne(d => d.main_ingredient).WithMany(p => p.recipe)
                .HasForeignKey(d => d.main_ingredient_id)
                .HasConstraintName("recipe_ibfk_1");
        });

        modelBuilder.Entity<recipe_steps>(entity =>
        {
            entity.HasKey(e => e.step_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Table to store step-by-step instructions for each recipe"));

            entity.HasIndex(e => e.recipe_id, "recipe_id");

            entity.Property(e => e.step_id).HasComment("Unique identifier for each recipe step");
            entity.Property(e => e.description)
                .HasComment("Detailed description of the step")
                .HasColumnType("text");
            entity.Property(e => e.image_url)
                .HasMaxLength(255)
                .HasComment("URL for an image illustrating the step (if available)");
            entity.Property(e => e.recipe_id).HasComment("References the ID of the recipe from the Recipe table");
            entity.Property(e => e.step_number).HasComment("The order of the step in the recipe");

            entity.HasOne(d => d.recipe).WithMany(p => p.recipe_steps)
                .HasForeignKey(d => d.recipe_id)
                .HasConstraintName("recipe_steps_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
