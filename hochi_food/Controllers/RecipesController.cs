using hochi_food.Dtos;
using hochi_food.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace hochi_food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly foodContext _foodContext;

        public RecipesController(foodContext foodContext)
        {
            _foodContext = foodContext;
        }

        /// <summary>
        /// 获取所有食谱
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeDto>>> GetRecipes()
        {
            var recipes = await _foodContext.recipe
                .Include(r => r.chef)
                .Include(r => r.main_ingredient)
                .Include(r => r.recipe_steps)
                .Include(r => r.ingredients)  // 加入對 Ingredients 的 Include
                .Include(r => r.seasonings)   // 加入對 Seasonings 的 Include
                .Select(r => new RecipeDto
                {
                    RecipeId = r.recipe_id,
                    RecipeName = r.recipe_name,
                    Category = r.category,
                    ChefName = r.chef.name,
                    MainIngredientName = r.main_ingredient.main_ingredient_name,
                    Description = r.description, // 新增返回 Description
                    RecipeSteps = r.recipe_steps.Select(rs => new RecipeStepDto
                    {
                        StepNumber = rs.step_number,
                        Description = rs.description
                    }).ToList(),
                    Ingredients = r.ingredients.Select(i => new IngredientDto
                    {
                        IngredientId = i.ingredient_id,
                        IngredientName = i.ingredient_name,
                        Amount = i.amount,
                        Unit = i.unit
                    }).ToList(),
                    Seasonings = r.seasonings.Select(s => new SeasoningDto
                    {
                        SeasoningId = s.seasoning_id,
                        SeasoningName = s.seasoning_name,
                        Amount = s.amount,
                        Unit = s.unit
                    }).ToList()
                })
                .ToListAsync();

            return Ok(recipes);
        }


        [HttpGet("{id}")]
        /// <summary>
        /// 获取单个食谱信息
        /// </summary>
        public async Task<ActionResult<RecipeDto>> GetRecipe(int id)
        {
            var recipe = await _foodContext.recipe
                .Include(r => r.chef)
                .Include(r => r.main_ingredient)
                .Include(r => r.recipe_steps)
                .Include(r => r.ingredients)
                .Include(r => r.seasonings)
                .Select(r => new RecipeDto
                {
                    RecipeId = r.recipe_id,
                    RecipeName = r.recipe_name,
                    Category = r.category,
                    ChefName = r.chef.name,
                    MainIngredientName = r.main_ingredient.main_ingredient_name,
                    RecipeSteps = r.recipe_steps.Select(rs => new RecipeStepDto
                    {
                        StepNumber = rs.step_number,
                        Description = rs.description
                    }).ToList(),
                    Ingredients = r.ingredients.Select(i => new IngredientDto
                    {
                        IngredientId = i.ingredient_id,
                        IngredientName = i.ingredient_name,
                        Amount = i.amount,
                        Unit = i.unit
                    }).ToList(),
                    Seasonings = r.seasonings.Select(s => new SeasoningDto
                    {
                        SeasoningId = s.seasoning_id,
                        SeasoningName = s.seasoning_name,
                        Amount = s.amount,
                        Unit = s.unit
                    }).ToList()
                })
                .FirstOrDefaultAsync(r => r.RecipeId == id);

            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe);
        }



        /// <summary>
        /// 新增食譜步驟
        /// </summary>
        /// <param name="steps"></param>
        /// <returns></returns>
        [HttpPost("recipeSteps")]
        public async Task<ActionResult> AddRecipeSteps([FromBody] List<recipe_steps> steps)
        {
            if (steps == null || steps.Count == 0)
            {
                return BadRequest("No steps provided.");
            }

            foreach (var step in steps)
            {
                _foodContext.recipe_steps.Add(step);
            }


            await _foodContext.SaveChangesAsync();
            return Ok();
        }

        /// <summary>
        /// 新增食譜的功能
        /// </summary>
        /// <param name="newRecipe"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<recipe>> PostRecipe([FromBody] recipe newRecipe)
        {
            if (newRecipe == null || string.IsNullOrEmpty(newRecipe.recipe_name))
            {
                return BadRequest("Recipe name is required.");
            }

            // 新增食譜邏輯
            _foodContext.recipe.Add(newRecipe);
            await _foodContext.SaveChangesAsync();  // 保存以便生成 recipe_id

            // 添加食材和調味料
            foreach (var ingredient in newRecipe.ingredients)
            {
                ingredient.recipe_id = newRecipe.recipe_id; // 設置正確的 recipe_id
                _foodContext.ingredients.Add(ingredient);
            }

            foreach (var seasoning in newRecipe.seasonings)
            {
                seasoning.recipe_id = newRecipe.recipe_id; // 設置正確的 recipe_id
                _foodContext.seasonings.Add(seasoning);
            }

            await _foodContext.SaveChangesAsync();

            // 返回創建的食譜
            return CreatedAtAction(nameof(GetRecipe), new { id = newRecipe.recipe_id }, newRecipe);
        }




        /// <summary>
        /// 删除食谱及其关联的步骤、食材和调味料信息
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipe(int id)
        {
            var recipe = await _foodContext.recipe
                .Include(r => r.recipe_steps)
                .Include(r => r.ingredients)
                .Include(r => r.seasonings)
                .FirstOrDefaultAsync(r => r.recipe_id == id);

            if (recipe == null)
            {
                return NotFound();
            }

            _foodContext.recipe.Remove(recipe);
            await _foodContext.SaveChangesAsync();

            return NoContent();
        }

    }
}
