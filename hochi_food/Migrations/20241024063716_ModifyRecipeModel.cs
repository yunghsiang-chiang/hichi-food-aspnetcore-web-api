using hochi_food.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace hochi_food.Migrations
{
    /// <inheritdoc />
    public partial class ModifyRecipeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "seasoning_name",
                table: "seasonings",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldComment: "Name of the seasoning used in the recipe");

            migrationBuilder.AlterColumn<int>(
                name: "recipe_id",
                table: "seasonings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "References the ID of the recipe from the Recipe table");

            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                table: "seasonings",
                type: "decimal(10,2)",
                precision: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldComment: "Amount of the seasoning used");

            migrationBuilder.AlterColumn<int>(
                name: "seasoning_id",
                table: "seasonings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Unique identifier for each seasoning used in a recipe")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "recipe_id",
                table: "recipe_steps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "References the ID of the recipe from the Recipe table",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "References the ID of the recipe from the Recipe table");

            migrationBuilder.AlterColumn<int>(
                name: "main_ingredient_id",
                table: "recipe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "References the ID of the main ingredient from the Main_Ingredient table",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "References the ID of the main ingredient from the Main_Ingredient table");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "recipe",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Detailed description or further information about the recipe");

            migrationBuilder.AlterColumn<int>(
                name: "chef_id",
                table: "recipe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "References the ID of the chef from the Chef table",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "References the ID of the chef from the Chef table");

            migrationBuilder.AlterColumn<string>(
                name: "category",
                table: "recipe",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                comment: "Category of the recipe (e.g., 主菜 - 紅燒, 咖哩)",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Category of the recipe (e.g., 主菜 - 紅燒, 咖哩)");

            migrationBuilder.AlterColumn<string>(
                name: "unit",
                table: "ingredients",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "Unit of measurement for the ingredient (e.g., grams, ml)");

            migrationBuilder.AlterColumn<int>(
                name: "recipe_id",
                table: "ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "References the ID of the recipe from the Recipe table");

            migrationBuilder.AlterColumn<string>(
                name: "ingredient_name",
                table: "ingredients",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldComment: "Name of the ingredient used in the recipe");

            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                table: "ingredients",
                type: "decimal(10,2)",
                precision: 10,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldComment: "Amount of the ingredient used");

            migrationBuilder.AlterColumn<int>(
                name: "ingredient_id",
                table: "ingredients",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Unique identifier for each ingredient used in a recipe")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_ingredients_recipe_recipe_id",
                table: "ingredients",
                column: "recipe_id",
                principalTable: "recipe",
                principalColumn: "recipe_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipe_chef_chef_id",
                table: "recipe",
                column: "chef_id",
                principalTable: "chef",
                principalColumn: "chef_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipe_main_ingredient_main_ingredient_id",
                table: "recipe",
                column: "main_ingredient_id",
                principalTable: "main_ingredient",
                principalColumn: "main_ingredient_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipe_steps_recipe_recipe_id",
                table: "recipe_steps",
                column: "recipe_id",
                principalTable: "recipe",
                principalColumn: "recipe_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_seasonings_recipe_recipe_id",
                table: "seasonings",
                column: "recipe_id",
                principalTable: "recipe",
                principalColumn: "recipe_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ingredients_recipe_recipe_id",
                table: "ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_recipe_chef_chef_id",
                table: "recipe");

            migrationBuilder.DropForeignKey(
                name: "FK_recipe_main_ingredient_main_ingredient_id",
                table: "recipe");

            migrationBuilder.DropForeignKey(
                name: "FK_recipe_steps_recipe_recipe_id",
                table: "recipe_steps");

            migrationBuilder.DropForeignKey(
                name: "FK_seasonings_recipe_recipe_id",
                table: "seasonings");

            migrationBuilder.DropTable(
                name: "__efmigrationshistory");

            migrationBuilder.RenameIndex(
                name: "IX_seasonings_recipe_id",
                table: "seasonings",
                newName: "recipe_id1");

            migrationBuilder.RenameIndex(
                name: "IX_recipe_steps_recipe_id",
                table: "recipe_steps",
                newName: "recipe_steps_ibfk_1");

            migrationBuilder.RenameIndex(
                name: "recipe_ibfk_2",
                table: "recipe",
                newName: "chef_id");

            migrationBuilder.RenameIndex(
                name: "recipe_ibfk_1",
                table: "recipe",
                newName: "main_ingredient_id");

            migrationBuilder.RenameIndex(
                name: "IX_ingredients_recipe_id",
                table: "ingredients",
                newName: "recipe_id");

            migrationBuilder.AlterColumn<string>(
                name: "unit",
                table: "seasonings",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "Unit of measurement for the seasoning (e.g., grams, ml)",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "seasoning_name",
                table: "seasonings",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                comment: "Name of the seasoning used in the recipe",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "recipe_id",
                table: "seasonings",
                type: "int",
                nullable: true,
                comment: "References the ID of the recipe from the Recipe table",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                table: "seasonings",
                type: "decimal(10,2)",
                precision: 10,
                nullable: false,
                comment: "Amount of the seasoning used",
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10);

            migrationBuilder.AlterColumn<int>(
                name: "seasoning_id",
                table: "seasonings",
                type: "int",
                nullable: false,
                comment: "Unique identifier for each seasoning used in a recipe",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "recipe_id",
                table: "recipe_steps",
                type: "int",
                nullable: true,
                comment: "References the ID of the recipe from the Recipe table",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "References the ID of the recipe from the Recipe table");

            migrationBuilder.AlterColumn<int>(
                name: "main_ingredient_id",
                table: "recipe",
                type: "int",
                nullable: true,
                comment: "References the ID of the main ingredient from the Main_Ingredient table",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "References the ID of the main ingredient from the Main_Ingredient table");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "recipe",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Detailed description or further information about the recipe",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "chef_id",
                table: "recipe",
                type: "int",
                nullable: true,
                comment: "References the ID of the chef from the Chef table",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "References the ID of the chef from the Chef table");

            migrationBuilder.AlterColumn<string>(
                name: "category",
                table: "recipe",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Category of the recipe (e.g., 主菜 - 紅燒, 咖哩)",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldComment: "Category of the recipe (e.g., 主菜 - 紅燒, 咖哩)");

            migrationBuilder.AlterColumn<string>(
                name: "unit",
                table: "ingredients",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "Unit of measurement for the ingredient (e.g., grams, ml)",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "recipe_id",
                table: "ingredients",
                type: "int",
                nullable: true,
                comment: "References the ID of the recipe from the Recipe table",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ingredient_name",
                table: "ingredients",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                comment: "Name of the ingredient used in the recipe",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<decimal>(
                name: "amount",
                table: "ingredients",
                type: "decimal(10,2)",
                precision: 10,
                nullable: false,
                comment: "Amount of the ingredient used",
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10);

            migrationBuilder.AlterColumn<int>(
                name: "ingredient_id",
                table: "ingredients",
                type: "int",
                nullable: false,
                comment: "Unique identifier for each ingredient used in a recipe",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "ingredients_ibfk_1",
                table: "ingredients",
                column: "recipe_id",
                principalTable: "recipe",
                principalColumn: "recipe_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "recipe_ibfk_1",
                table: "recipe",
                column: "main_ingredient_id",
                principalTable: "main_ingredient",
                principalColumn: "main_ingredient_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "recipe_ibfk_2",
                table: "recipe",
                column: "chef_id",
                principalTable: "chef",
                principalColumn: "chef_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "recipe_steps_ibfk_1",
                table: "recipe_steps",
                column: "recipe_id",
                principalTable: "recipe",
                principalColumn: "recipe_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "seasonings_ibfk_1",
                table: "seasonings",
                column: "recipe_id",
                principalTable: "recipe",
                principalColumn: "recipe_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
