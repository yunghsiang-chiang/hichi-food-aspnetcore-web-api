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

    public virtual DbSet<__efmigrationshistory> __efmigrationshistory { get; set; }

    public virtual DbSet<activity_meal_recipes> activity_meal_recipes { get; set; }

    public virtual DbSet<activity_meals> activity_meals { get; set; }

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

    public virtual DbSet<food_nutrition> food_nutrition { get; set; }

    public virtual DbSet<h_activity_records> h_activity_records { get; set; }

    public virtual DbSet<ingredient> ingredient { get; set; }

    public virtual DbSet<ingredients> ingredients { get; set; }

    public virtual DbSet<main_ingredient> main_ingredient { get; set; }

    public virtual DbSet<recipe> recipe { get; set; }

    public virtual DbSet<recipe_steps> recipe_steps { get; set; }

    public virtual DbSet<seasonings> seasonings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<__efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<activity_meal_recipes>(entity =>
        {
            entity.HasKey(e => e.activity_meal_recipe_id).HasName("PRIMARY");

            entity.Property(e => e.recipe_category).HasMaxLength(50);
        });

        modelBuilder.Entity<activity_meals>(entity =>
        {
            entity.HasKey(e => e.activity_meal_id).HasName("PRIMARY");

            entity.Property(e => e.activity_meal_id).HasComment("每場活動的餐點紀錄");
            entity.Property(e => e.activity_date)
                .HasComment("班會日期")
                .HasColumnType("date");
            entity.Property(e => e.activity_name)
                .HasMaxLength(100)
                .HasComment("活動名稱");
            entity.Property(e => e.end_date)
                .HasComment("班會結束日")
                .HasColumnType("date");
            entity.Property(e => e.meal_type)
                .HasComment("餐別")
                .HasColumnType("enum('早餐','午餐','晚餐')");
            entity.Property(e => e.start_date)
                .HasComment("班會起始日")
                .HasColumnType("date");
        });

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
            entity.Property(e => e.俗名).HasMaxLength(70);
            entity.Property(e => e.內容物描述).HasMaxLength(100);
            entity.Property(e => e.樣品名稱).HasMaxLength(20);
            entity.Property(e => e.食品分類).HasMaxLength(20);
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
            entity.Property(e => e.icon).HasMaxLength(255);
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

        modelBuilder.Entity<food_nutrition>(entity =>
        {
            entity.HasKey(e => e.ingredient_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("食材"));

            entity.Property(e => e.ingredient_id).HasComment("食材ID");
            entity.Property(e => e.common_name)
                .HasMaxLength(200)
                .HasComment("俗名");
            entity.Property(e => e.ingredient_name)
                .HasMaxLength(45)
                .HasComment("食材名稱");
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

        modelBuilder.Entity<ingredients>(entity =>
        {
            entity.HasKey(e => e.ingredient_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Table to store ingredients used in each recipe"));

            entity.HasIndex(e => e.recipe_id, "FK_ingredients_recipe_recipe_id");

            entity.Property(e => e.amount).HasPrecision(10);
            entity.Property(e => e.ingredient_name).HasMaxLength(255);
            entity.Property(e => e.unit).HasMaxLength(50);
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

            entity.HasIndex(e => e.chef_id, "FK_recipe_chef_chef_id");

            entity.HasIndex(e => e.main_ingredient_id, "FK_recipe_main_ingredient_main_ingredient_id");

            entity.HasIndex(e => e.recipe_code, "recipe_code").IsUnique();

            entity.Property(e => e.recipe_id).HasComment("Unique identifier for each recipe");
            entity.Property(e => e.category)
                .HasMaxLength(255)
                .HasDefaultValueSql("''");
            entity.Property(e => e.description).HasMaxLength(255);
            entity.Property(e => e.portion_size).HasDefaultValueSql("'10'");
            entity.Property(e => e.recipe_name)
                .HasMaxLength(255)
                .HasComment("Name of the recipe (e.g., 糖醋豆包)");
        });

        modelBuilder.Entity<recipe_steps>(entity =>
        {
            entity.HasKey(e => e.step_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Table to store step-by-step instructions for each recipe"));

            entity.HasIndex(e => e.recipe_id, "FK_recipe_steps_recipe_recipe_id");

            entity.Property(e => e.step_id).HasComment("Unique identifier for each recipe step");
            entity.Property(e => e.description)
                .HasComment("Detailed description of the step")
                .HasColumnType("text");
            entity.Property(e => e.image_url)
                .HasMaxLength(255)
                .HasComment("URL for an image illustrating the step (if available)");
            entity.Property(e => e.step_number).HasComment("The order of the step in the recipe");
        });

        modelBuilder.Entity<seasonings>(entity =>
        {
            entity.HasKey(e => e.seasoning_id).HasName("PRIMARY");

            entity.ToTable(tb => tb.HasComment("Table to store seasonings used in each recipe"));

            entity.HasIndex(e => e.recipe_id, "FK_seasonings_recipe_recipe_id");

            entity.Property(e => e.amount).HasPrecision(10);
            entity.Property(e => e.seasoning_name).HasMaxLength(255);
            entity.Property(e => e.unit).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
