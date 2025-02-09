﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hochi_food.Models;

#nullable disable

namespace hochi_food.Migrations
{
    [DbContext(typeof(foodContext))]
    partial class foodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("hochi_food.Models.__efmigrationshistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("MigrationId")
                        .HasName("PRIMARY");

                    b.ToTable("__efmigrationshistory");
                });

            modelBuilder.Entity("hochi_food.Models.c_cooking_method", b =>
                {
                    b.Property<string>("cooking_method_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasComment("烹飪方式ID");

                    b.Property<string>("cooking_method")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasComment("烹飪方式");

                    b.Property<string>("method_description")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasComment("烹飪說明");

                    b.HasKey("cooking_method_id")
                        .HasName("PRIMARY");

                    b.ToTable("c_cooking_method", t =>
                        {
                            t.HasComment("烹飪方式");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.c_cooking_method_old", b =>
                {
                    b.Property<string>("cooking_method_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasComment("烹飪方式編碼");

                    b.Property<string>("cooking_explain")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("烹飪方式解釋");

                    b.Property<string>("cooking_method")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasComment("烹飪方式");

                    b.HasKey("cooking_method_id")
                        .HasName("PRIMARY");

                    b.ToTable("c_cooking_method_old", t =>
                        {
                            t.HasComment("烹飪方法對照表");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.c_dishes", b =>
                {
                    b.Property<string>("dishes_id")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasComment("菜品編號");

                    b.Property<string>("commentary")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasComment("介紹菜品");

                    b.Property<string>("cooking_method")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasComment("烹飪方式 分類");

                    b.Property<string>("cooking_step")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasComment("烹飪步驟 說明限制500字以內");

                    b.Property<int>("cooking_time")
                        .HasColumnType("int")
                        .HasComment("烹飪時間 單位:分鐘");

                    b.Property<string>("dishes_image")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasComment("菜品照片Urls");

                    b.Property<string>("dishes_name")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasComment("菜品名稱");

                    b.Property<string>("dishes_type")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasComment("菜品類型");

                    b.Property<string>("material_id_items")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasComment("食材名稱 代號");

                    b.Property<string>("material_id_names")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasComment("食材名稱 中文");

                    b.Property<string>("seasoning")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("調味品");

                    b.HasKey("dishes_id")
                        .HasName("PRIMARY");

                    b.ToTable("c_dishes");
                });

            modelBuilder.Entity("hochi_food.Models.c_dishes_type", b =>
                {
                    b.Property<string>("dishes_type_id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasComment("餐點類型ID");

                    b.Property<string>("dishes_type_name")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasComment("餐點類型名稱");

                    b.HasKey("dishes_type_id")
                        .HasName("PRIMARY");

                    b.ToTable("c_dishes_type", t =>
                        {
                            t.HasComment("餐點類型資訊");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.c_food_nutrition", b =>
                {
                    b.Property<string>("樣品編號")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("P_M_S")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("P/M/S");

                    b.Property<double>("α_生育酚_mg_")
                        .HasColumnType("double")
                        .HasColumnName("α-生育酚(mg)");

                    b.Property<double>("α_維生素E當量_α_TE__mg_")
                        .HasColumnType("double")
                        .HasColumnName("α-維生素E當量(α-TE)(mg)");

                    b.Property<int>("α_胡蘿蔔素_ug_")
                        .HasColumnType("int")
                        .HasColumnName("α-胡蘿蔔素(ug)");

                    b.Property<double>("β_生育酚_mg_")
                        .HasColumnType("double")
                        .HasColumnName("β-生育酚(mg)");

                    b.Property<int>("β_胡蘿蔔素_ug_")
                        .HasColumnType("int")
                        .HasColumnName("β-胡蘿蔔素(ug)");

                    b.Property<double>("γ_生育酚_mg_")
                        .HasColumnType("double")
                        .HasColumnName("γ-生育酚(mg)");

                    b.Property<double>("δ_生育酚_mg_")
                        .HasColumnType("double")
                        .HasColumnName("δ-生育酚(mg)");

                    b.Property<int>("丙胺酸_Ala__mg_")
                        .HasColumnType("int")
                        .HasColumnName("丙胺酸(Ala)(mg)");

                    b.Property<int>("乳糖_g_")
                        .HasColumnType("int")
                        .HasColumnName("乳糖(g)");

                    b.Property<int>("亞麻油酸_18_2__mg_")
                        .HasColumnType("int")
                        .HasColumnName("亞麻油酸(18:2)(mg)");

                    b.Property<string>("俗名")
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<int>("修正熱量_kcal_")
                        .HasColumnType("int")
                        .HasColumnName("修正熱量(kcal)");

                    b.Property<string>("內容物描述")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("其他脂肪酸_mg_")
                        .HasColumnType("int")
                        .HasColumnName("其他脂肪酸(mg)");

                    b.Property<int>("十七酸_17_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("十七酸(17:0)(mg)");

                    b.Property<int>("十三酸_13_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("十三酸(13:0)(mg)");

                    b.Property<int>("十九酸_19_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("十九酸(19:0)(mg)");

                    b.Property<int>("十五酸_15_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("十五酸(15:0)(mg)");

                    b.Property<int>("十八碳四烯酸_18_4__mg_")
                        .HasColumnType("int")
                        .HasColumnName("十八碳四烯酸(18:4)(mg)");

                    b.Property<int>("半乳糖_g_")
                        .HasColumnType("int")
                        .HasColumnName("半乳糖(g)");

                    b.Property<int>("反式脂肪_mg_")
                        .HasColumnType("int")
                        .HasColumnName("反式脂肪(mg)");

                    b.Property<int>("天門冬胺酸_Asp__mg_")
                        .HasColumnType("int")
                        .HasColumnName("天門冬胺酸(Asp)(mg)");

                    b.Property<int>("山酸_22_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("山酸(22:0)(mg)");

                    b.Property<int>("己酸_6_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("己酸(6:0)(mg)");

                    b.Property<int>("廢棄率___")
                        .HasColumnType("int")
                        .HasColumnName("廢棄率(%)");

                    b.Property<int>("廿二碳五烯酸_22_5__mg_")
                        .HasColumnType("int")
                        .HasColumnName("廿二碳五烯酸(22:5)(mg)");

                    b.Property<int>("廿二碳六烯酸_22_6__mg_")
                        .HasColumnType("int")
                        .HasColumnName("廿二碳六烯酸(22:6)(mg)");

                    b.Property<int>("廿四酸_24_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("廿四酸(24:0)(mg)");

                    b.Property<int>("廿碳五烯酸_20_5__mg_")
                        .HasColumnType("int")
                        .HasColumnName("廿碳五烯酸(20:5)(mg)");

                    b.Property<int>("月桂酸_12_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("月桂酸(12:0)(mg)");

                    b.Property<int>("果糖_g_")
                        .HasColumnType("int")
                        .HasColumnName("果糖(g)");

                    b.Property<int>("棕櫚烯酸_16_1__mg_")
                        .HasColumnType("int")
                        .HasColumnName("棕櫚烯酸(16:1)(mg)");

                    b.Property<int>("棕櫚酸_16_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("棕櫚酸(16:0)(mg)");

                    b.Property<string>("樣品名稱")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("次亞麻油酸_18_3__mg_")
                        .HasColumnType("int")
                        .HasColumnName("次亞麻油酸(18:3)(mg)");

                    b.Property<double>("水分_g_")
                        .HasColumnType("double")
                        .HasColumnName("水分(g)");

                    b.Property<int>("水解胺基酸總量_mg_")
                        .HasColumnType("int")
                        .HasColumnName("水解胺基酸總量(mg)");

                    b.Property<int>("油酸_18_1__mg_")
                        .HasColumnType("int")
                        .HasColumnName("油酸(18:1)(mg)");

                    b.Property<double>("灰分_g_")
                        .HasColumnType("double")
                        .HasColumnName("灰分(g)");

                    b.Property<int>("熱量_kcal_")
                        .HasColumnType("int")
                        .HasColumnName("熱量(kcal)");

                    b.Property<int>("甘胺酸_Gly__mg_")
                        .HasColumnType("int")
                        .HasColumnName("甘胺酸(Gly)(mg)");

                    b.Property<int>("甲硫胺酸_Met__mg_")
                        .HasColumnType("int")
                        .HasColumnName("甲硫胺酸(Met)(mg)");

                    b.Property<int>("異白胺酸_Ile__mg_")
                        .HasColumnType("int")
                        .HasColumnName("異白胺酸(Ile)(mg)");

                    b.Property<int>("癸酸_10_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("癸酸(10:0)(mg)");

                    b.Property<int>("白胺酸_Leu__mg_")
                        .HasColumnType("int")
                        .HasColumnName("白胺酸(Leu)(mg)");

                    b.Property<int>("硬脂酸_18_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("硬脂酸(18:0)(mg)");

                    b.Property<int>("磷_mg_")
                        .HasColumnType("int")
                        .HasColumnName("磷(mg)");

                    b.Property<double>("粗脂肪_g_")
                        .HasColumnType("double")
                        .HasColumnName("粗脂肪(g)");

                    b.Property<double>("粗蛋白_g_")
                        .HasColumnType("double")
                        .HasColumnName("粗蛋白(g)");

                    b.Property<int>("精胺酸_Arg__mg_")
                        .HasColumnType("int")
                        .HasColumnName("精胺酸(Arg)(mg)");

                    b.Property<double>("糖質總量_g_")
                        .HasColumnType("double")
                        .HasColumnName("糖質總量(g)");

                    b.Property<int>("組胺酸_His__mg_")
                        .HasColumnType("int")
                        .HasColumnName("組胺酸(His)(mg)");

                    b.Property<int>("絲胺酸_Ser__mg_")
                        .HasColumnType("int")
                        .HasColumnName("絲胺酸(Ser)(mg)");

                    b.Property<int>("維生素A總量_IU_")
                        .HasColumnType("int")
                        .HasColumnName("維生素A總量(IU)");

                    b.Property<int>("維生素B12_ug_")
                        .HasColumnType("int")
                        .HasColumnName("維生素B12(ug)");

                    b.Property<double>("維生素B1_mg_")
                        .HasColumnType("double")
                        .HasColumnName("維生素B1(mg)");

                    b.Property<double>("維生素B2_mg_")
                        .HasColumnType("double")
                        .HasColumnName("維生素B2(mg)");

                    b.Property<double>("維生素B6_mg_")
                        .HasColumnType("double")
                        .HasColumnName("維生素B6(mg)");

                    b.Property<double>("維生素C_mg_")
                        .HasColumnType("double")
                        .HasColumnName("維生素C(mg)");

                    b.Property<int>("維生素D2_ug_")
                        .HasColumnType("int")
                        .HasColumnName("維生素D2(ug)");

                    b.Property<int>("維生素D3_ug_")
                        .HasColumnType("int")
                        .HasColumnName("維生素D3(ug)");

                    b.Property<int>("維生素D總量_IU_")
                        .HasColumnType("int")
                        .HasColumnName("維生素D總量(IU)");

                    b.Property<int>("維生素D總量_ug_")
                        .HasColumnType("int")
                        .HasColumnName("維生素D總量(ug)");

                    b.Property<double>("維生素E總量_mg_")
                        .HasColumnType("double")
                        .HasColumnName("維生素E總量(mg)");

                    b.Property<int>("維生素K1_ug_")
                        .HasColumnType("int")
                        .HasColumnName("維生素K1(ug)");

                    b.Property<int>("維生素K2__MK_4__ug_")
                        .HasColumnType("int")
                        .HasColumnName("維生素K2 (MK-4)(ug)");

                    b.Property<int>("維生素K2__MK_7__ug_")
                        .HasColumnType("int")
                        .HasColumnName("維生素K2 (MK-7)(ug)");

                    b.Property<double>("總碳水化合物_g_")
                        .HasColumnType("double")
                        .HasColumnName("總碳水化合物(g)");

                    b.Property<int>("纈胺酸_Val__mg_")
                        .HasColumnType("int")
                        .HasColumnName("纈胺酸(Val)(mg)");

                    b.Property<int>("肉豆蔻烯酸_14_1__mg_")
                        .HasColumnType("int")
                        .HasColumnName("肉豆蔻烯酸(14:1)(mg)");

                    b.Property<int>("肉豆蔻酸_14_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("肉豆蔻酸(14:0)(mg)");

                    b.Property<int>("胱胺酸_Cys__mg_")
                        .HasColumnType("int")
                        .HasColumnName("胱胺酸(Cys)(mg)");

                    b.Property<int>("脂肪酸M總量_mg_")
                        .HasColumnType("int")
                        .HasColumnName("脂肪酸M總量(mg)");

                    b.Property<int>("脂肪酸P總量_mg_")
                        .HasColumnType("int")
                        .HasColumnName("脂肪酸P總量(mg)");

                    b.Property<int>("脂肪酸S總量_mg_")
                        .HasColumnType("int")
                        .HasColumnName("脂肪酸S總量(mg)");

                    b.Property<int>("脯胺酸_Pro__mg_")
                        .HasColumnType("int")
                        .HasColumnName("脯胺酸(Pro)(mg)");

                    b.Property<double>("膳食纖維_g_")
                        .HasColumnType("double")
                        .HasColumnName("膳食纖維(g)");

                    b.Property<int>("膽固醇_mg_")
                        .HasColumnType("int")
                        .HasColumnName("膽固醇(mg)");

                    b.Property<int>("色胺酸_Trp__mg_")
                        .HasColumnType("int")
                        .HasColumnName("色胺酸(Trp)(mg)");

                    b.Property<int>("芥子酸_22_1__mg_")
                        .HasColumnType("int")
                        .HasColumnName("芥子酸(22:1)(mg)");

                    b.Property<int>("花生油酸_20_4__mg_")
                        .HasColumnType("int")
                        .HasColumnName("花生油酸(20:4)(mg)");

                    b.Property<int>("花生酸_20_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("花生酸(20:0)(mg)");

                    b.Property<int>("苯丙胺酸_Phe__mg_")
                        .HasColumnType("int")
                        .HasColumnName("苯丙胺酸(Phe)(mg)");

                    b.Property<double>("菸鹼素_mg_")
                        .HasColumnType("double")
                        .HasColumnName("菸鹼素(mg)");

                    b.Property<double>("葉酸_ug_")
                        .HasColumnType("double")
                        .HasColumnName("葉酸(ug)");

                    b.Property<int>("葡萄糖_g_")
                        .HasColumnType("int")
                        .HasColumnName("葡萄糖(g)");

                    b.Property<double>("蔗糖_g_")
                        .HasColumnType("double")
                        .HasColumnName("蔗糖(g)");

                    b.Property<int>("視網醇_ug_")
                        .HasColumnType("int")
                        .HasColumnName("視網醇(ug)");

                    b.Property<int>("視網醇當量_RE__ug_")
                        .HasColumnType("int")
                        .HasColumnName("視網醇當量(RE)(ug)");

                    b.Property<int>("辛酸_8_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("辛酸(8:0)(mg)");

                    b.Property<int>("酒精含量_g_")
                        .HasColumnType("int")
                        .HasColumnName("酒精含量(g)");

                    b.Property<int>("酥胺酸_Thr__mg_")
                        .HasColumnType("int")
                        .HasColumnName("酥胺酸(Thr)(mg)");

                    b.Property<int>("酪胺酸_Tyr__mg_")
                        .HasColumnType("int")
                        .HasColumnName("酪胺酸(Tyr)(mg)");

                    b.Property<int>("酪酸_4_0__mg_")
                        .HasColumnType("int")
                        .HasColumnName("酪酸(4:0)(mg)");

                    b.Property<int>("鈉_mg_")
                        .HasColumnType("int")
                        .HasColumnName("鈉(mg)");

                    b.Property<int>("鈣_mg_")
                        .HasColumnType("int")
                        .HasColumnName("鈣(mg)");

                    b.Property<int>("鉀_mg_")
                        .HasColumnType("int")
                        .HasColumnName("鉀(mg)");

                    b.Property<int>("銅_mg_")
                        .HasColumnType("int")
                        .HasColumnName("銅(mg)");

                    b.Property<double>("鋅_mg_")
                        .HasColumnType("double")
                        .HasColumnName("鋅(mg)");

                    b.Property<int>("錳_mg_")
                        .HasColumnType("int")
                        .HasColumnName("錳(mg)");

                    b.Property<int>("鎂_mg_")
                        .HasColumnType("int")
                        .HasColumnName("鎂(mg)");

                    b.Property<double>("鐵_mg_")
                        .HasColumnType("double")
                        .HasColumnName("鐵(mg)");

                    b.Property<int>("離胺酸_Lys__mg_")
                        .HasColumnType("int")
                        .HasColumnName("離胺酸(Lys)(mg)");

                    b.Property<string>("食品分類")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<double>("飽和脂肪_g_")
                        .HasColumnType("double")
                        .HasColumnName("飽和脂肪(g)");

                    b.Property<int>("鱈烯酸_20_1__mg_")
                        .HasColumnType("int")
                        .HasColumnName("鱈烯酸(20:1)(mg)");

                    b.Property<int>("麥芽糖_g_")
                        .HasColumnType("int")
                        .HasColumnName("麥芽糖(g)");

                    b.Property<int>("麩胺酸_Glu__mg_")
                        .HasColumnType("int")
                        .HasColumnName("麩胺酸(Glu)(mg)");

                    b.HasKey("樣品編號")
                        .HasName("PRIMARY");

                    b.ToTable("c_food_nutrition");
                });

            modelBuilder.Entity("hochi_food.Models.c_fruits", b =>
                {
                    b.Property<string>("fruits_chinese")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("fruits_english")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("fruits_chinese")
                        .HasName("PRIMARY");

                    b.ToTable("c_fruits");
                });

            modelBuilder.Entity("hochi_food.Models.c_ingredients_unit", b =>
                {
                    b.Property<string>("unit_chinese")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasComment("單位中文稱呼");

                    b.Property<string>("unit_english")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasComment("單位英文稱呼");

                    b.Property<string>("unit_description")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasComment("單位說明");

                    b.Property<string>("unit_type")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasComment("單位類型");

                    b.HasKey("unit_chinese", "unit_english")
                        .HasName("PRIMARY");

                    b.ToTable("c_ingredients_unit", t =>
                        {
                            t.HasComment("食材單位表");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.c_meal_type", b =>
                {
                    b.Property<string>("meal_type")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasComment("餐別");

                    b.HasKey("meal_type")
                        .HasName("PRIMARY");

                    b.ToTable("c_meal_type", t =>
                        {
                            t.HasComment("餐別");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.c_seasoning", b =>
                {
                    b.Property<string>("seasoning_id")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasComment("調味料ID");

                    b.Property<string>("seasoning_description")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("seasoning_name")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasComment("調味料名稱");

                    b.HasKey("seasoning_id")
                        .HasName("PRIMARY");

                    b.ToTable("c_seasoning", t =>
                        {
                            t.HasComment("調味料");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.category", b =>
                {
                    b.Property<int>("category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique identifier for each recipe category");

                    b.Property<string>("category_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasComment("Name of the category (e.g., 主菜, 紅燒, 咖哩)");

                    b.Property<string>("description")
                        .HasColumnType("text")
                        .HasComment("Optional description or notes about the category");

                    b.Property<string>("icon")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("category_id")
                        .HasName("PRIMARY");

                    b.ToTable("category", t =>
                        {
                            t.HasComment("Table to store different categories for recipes");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.chef", b =>
                {
                    b.Property<int>("chef_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique identifier for each chef");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasComment("Name of the chef (e.g., 王金對)");

                    b.Property<string>("region")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasComment("Region or location associated with the chef (optional)");

                    b.HasKey("chef_id")
                        .HasName("PRIMARY");

                    b.ToTable("chef", t =>
                        {
                            t.HasComment("Table to store information about each chef");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.h_activity_records", b =>
                {
                    b.Property<string>("activity_name")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasComment("活動名稱");

                    b.Property<DateTime>("activity_date")
                        .HasColumnType("date")
                        .HasComment("活動日期");

                    b.Property<string>("meal_type")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasComment("餐別");

                    b.Property<int>("activity_days")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("'1'")
                        .HasComment("活動天數");

                    b.Property<string>("dishes_id_str")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("菜色清單");

                    b.Property<string>("during_the_activity")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasComment("活動期間");

                    b.Property<string>("lm_user")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasComment("最後編輯者");

                    b.HasKey("activity_name", "activity_date", "meal_type")
                        .HasName("PRIMARY");

                    b.ToTable("h_activity_records", t =>
                        {
                            t.HasComment("歷史活動紀錄");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.ingredient", b =>
                {
                    b.Property<int>("ingredient_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique identifier for each ingredient");

                    b.Property<string>("description")
                        .HasColumnType("text")
                        .HasComment("Optional description or notes about the ingredient");

                    b.Property<string>("ingredient_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasComment("Name of the ingredient (e.g., 天貝, 豆包)");

                    b.Property<string>("unit")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasComment("Unit of measurement for the ingredient (e.g., grams, ml)");

                    b.HasKey("ingredient_id")
                        .HasName("PRIMARY");

                    b.ToTable("ingredient", t =>
                        {
                            t.HasComment("Table to store detailed information about ingredients used in recipes");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.ingredients", b =>
                {
                    b.Property<int>("ingredient_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasPrecision(10)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ingredient_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("recipe_id")
                        .HasColumnType("int");

                    b.Property<string>("unit")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ingredient_id")
                        .HasName("PRIMARY");

                    b.ToTable("ingredients", t =>
                        {
                            t.HasComment("Table to store ingredients used in each recipe");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.main_ingredient", b =>
                {
                    b.Property<int>("main_ingredient_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique identifier for each main ingredient");

                    b.Property<string>("category")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasComment("Category of the ingredient (e.g., 豆製品 for tofu products)");

                    b.Property<string>("description")
                        .HasColumnType("text")
                        .HasComment("Optional description or notes about the ingredient");

                    b.Property<string>("main_ingredient_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasComment("Name of the main ingredient (e.g., 豆包, 天貝)");

                    b.HasKey("main_ingredient_id")
                        .HasName("PRIMARY");

                    b.ToTable("main_ingredient", t =>
                        {
                            t.HasComment("Table to store detailed information about each main ingredient used in recipes");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.recipe", b =>
                {
                    b.Property<int>("recipe_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique identifier for each recipe");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasComment("Category of the recipe (e.g., 主菜 - 紅燒, 咖哩)");

                    b.Property<int>("chef_id")
                        .HasColumnType("int")
                        .HasComment("References the ID of the chef from the Chef table");

                    b.Property<string>("description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("main_ingredient_id")
                        .HasColumnType("int")
                        .HasComment("References the ID of the main ingredient from the Main_Ingredient table");

                    b.Property<string>("recipe_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasComment("Name of the recipe (e.g., 糖醋豆包)");

                    b.HasKey("recipe_id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "main_ingredient_id" }, "recipe_ibfk_1");

                    b.HasIndex(new[] { "chef_id" }, "recipe_ibfk_2");

                    b.ToTable("recipe", t =>
                        {
                            t.HasComment("Table to store information about each recipe, including name, main ingredient, category, and chef reference");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.recipe_steps", b =>
                {
                    b.Property<int>("step_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Unique identifier for each recipe step");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasComment("Detailed description of the step");

                    b.Property<string>("image_url")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasComment("URL for an image illustrating the step (if available)");

                    b.Property<int>("recipe_id")
                        .HasColumnType("int")
                        .HasComment("References the ID of the recipe from the Recipe table");

                    b.Property<int>("step_number")
                        .HasColumnType("int")
                        .HasComment("The order of the step in the recipe");

                    b.HasKey("step_id")
                        .HasName("PRIMARY");

                    b.ToTable("recipe_steps", t =>
                        {
                            t.HasComment("Table to store step-by-step instructions for each recipe");
                        });
                });

            modelBuilder.Entity("hochi_food.Models.seasonings", b =>
                {
                    b.Property<int>("seasoning_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasPrecision(10)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("recipe_id")
                        .HasColumnType("int");

                    b.Property<string>("seasoning_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("unit")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("seasoning_id")
                        .HasName("PRIMARY");

                    b.ToTable("seasonings", t =>
                        {
                            t.HasComment("Table to store seasonings used in each recipe");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
