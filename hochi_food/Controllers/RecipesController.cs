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
        /// 取得各種類別的食譜數量
        /// </summary>
        /// <returns></returns>
        [HttpGet("description-count")]
        public async Task<ActionResult<IEnumerable<DescriptionCountDto>>> GetDescriptionCount()
        {
            var descriptionCounts = await _foodContext.recipe
                .GroupBy(r => r.description)
                .Select(g => new DescriptionCountDto
                {
                    Description = g.Key,
                    Qty = g.Count()
                })
                .ToListAsync();

            if (descriptionCounts == null || !descriptionCounts.Any())
            {
                return NotFound("No description data found.");
            }

            return Ok(descriptionCounts);
        }


        /// <summary>
        /// 儲存 Recipe
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        [HttpPost("recipes")]
        public async Task<ActionResult<recipe>> PostOrUpdateRecipe([FromBody] recipe recipe)
        {
            if (recipe == null || string.IsNullOrEmpty(recipe.recipe_name))
            {
                return BadRequest("Recipe name is required.");
            }

            // 檢查是否存在該 recipe_id
            var existingRecipe = await _foodContext.recipe.FindAsync(recipe.recipe_id);

            if (existingRecipe != null)
            {
                // 更新現有食譜
                existingRecipe.recipe_name = recipe.recipe_name;
                existingRecipe.main_ingredient_id = recipe.main_ingredient_id;
                existingRecipe.category = recipe.category;
                existingRecipe.chef_id = recipe.chef_id;
                existingRecipe.description = recipe.description;

                _foodContext.recipe.Update(existingRecipe);
                await _foodContext.SaveChangesAsync();

                return Ok(existingRecipe);
            }
            else
            {
                // 新增新食譜
                _foodContext.recipe.Add(recipe);
                await _foodContext.SaveChangesAsync();  // 保存以生成 recipe_id

                return CreatedAtAction(nameof(GetRecipe), new { id = recipe.recipe_id }, recipe);
            }
        }




        /// <summary>
        /// 取得所有 Recipe
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<recipe>>> GetRecipes()
        {
            var recipes = await _foodContext.recipe.ToListAsync();

            if (recipes == null || !recipes.Any())
            {
                return NotFound("No recipes found.");
            }

            return Ok(recipes);
        }

        /// <summary>
        /// 取得食譜 by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<recipe>> GetRecipe(int id)
        {
            var recipe = await _foodContext.recipe.FindAsync(id);

            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe);
        }
        /// <summary>
        /// 儲存或更新 Recipe Steps
        /// </summary>
        /// <param name="recipeSteps"></param>
        /// <returns></returns>
        [HttpPost("steps")]
        public async Task<ActionResult> PostOrUpdateRecipeSteps([FromBody] List<recipe_steps> recipeSteps)
        {
            if (recipeSteps == null || recipeSteps.Count == 0)
            {
                return BadRequest("Recipe steps are required.");
            }

            // 取得要更新的 recipe_id
            var recipeId = recipeSteps.First().recipe_id;
            if (recipeId == 0)
            {
                return BadRequest("Recipe ID is required for each step.");
            }

            // 查詢是否已有相同的 recipe_id 步驟
            var existingSteps = _foodContext.recipe_steps.Where(rs => rs.recipe_id == recipeId).ToList();

            if (existingSteps.Any())
            {
                // 若存在相同的 recipe_id，則刪除該 recipe_id 的所有舊步驟
                _foodContext.recipe_steps.RemoveRange(existingSteps);
            }

            // 新增新的步驟
            foreach (var step in recipeSteps)
            {
                _foodContext.recipe_steps.Add(step);
            }

            await _foodContext.SaveChangesAsync();
            return Ok("Recipe steps saved/updated successfully.");
        }



        /// <summary>
        /// 取得 Recipe Steps
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("steps/{id}")]
        public async Task<ActionResult<recipe_steps>> GetRecipeSteps(int id)
        {
            var steps = await _foodContext.recipe_steps
         .Where(step => step.recipe_id == id)
         .OrderBy(step => step.step_number)
         .ToListAsync();

            if (steps == null || !steps.Any())
            {
                return NotFound();
            }

            return Ok(steps);
        }

        /// <summary>
        /// 儲存或更新 Ingredients
        /// </summary>
        /// <param name="ingredientsList"></param>
        /// <returns></returns>
        [HttpPost("ingredients")]
        public async Task<ActionResult> PostOrUpdateIngredients([FromBody] List<ingredients> ingredientsList)
        {
            if (ingredientsList == null || ingredientsList.Count == 0)
            {
                return BadRequest("Ingredients are required.");
            }

            // 取得要更新的 recipe_id
            var recipeId = ingredientsList.First().recipe_id;
            if (recipeId == 0)
            {
                return BadRequest("Recipe ID is required for each ingredient.");
            }

            // 查詢是否已有相同的 recipe_id 的食材資料
            var existingIngredients = _foodContext.ingredients.Where(ing => ing.recipe_id == recipeId).ToList();

            if (existingIngredients.Any())
            {
                // 若存在相同的 recipe_id，則刪除該 recipe_id 的所有舊食材資料
                _foodContext.ingredients.RemoveRange(existingIngredients);
            }

            // 新增新的食材資料
            foreach (var ingredient in ingredientsList)
            {
                _foodContext.ingredients.Add(ingredient);
            }

            await _foodContext.SaveChangesAsync();
            return Ok("Ingredients saved/updated successfully.");
        }



        /// <summary>
        /// 取得 Ingredients
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("ingredients/{id}")]
        public async Task<ActionResult<ingredients>> GetIngredients(int id)
        {
            var ingredientsList = await _foodContext.ingredients
         .Where(ingredient => ingredient.recipe_id == id)
         .ToListAsync();

            if (ingredientsList == null || !ingredientsList.Any())
            {
                return NotFound();
            }

            return Ok(ingredientsList);
        }
        /// <summary>
        /// 儲存或更新 Seasonings
        /// </summary>
        /// <param name="seasoningsList"></param>
        /// <returns></returns>
        [HttpPost("seasonings")]
        public async Task<ActionResult> PostOrUpdateSeasonings([FromBody] List<seasonings> seasoningsList)
        {
            if (seasoningsList == null || seasoningsList.Count == 0)
            {
                return BadRequest("Seasonings are required.");
            }

            // 取得要更新的 recipe_id
            var recipeId = seasoningsList.First().recipe_id;
            if (recipeId == 0)
            {
                return BadRequest("Recipe ID is required for each seasoning.");
            }

            // 查詢是否已有相同的 recipe_id 的調味料資料
            var existingSeasonings = _foodContext.seasonings.Where(seas => seas.recipe_id == recipeId).ToList();

            if (existingSeasonings.Any())
            {
                // 若存在相同的 recipe_id，則刪除該 recipe_id 的所有舊調味料資料
                _foodContext.seasonings.RemoveRange(existingSeasonings);
            }

            // 新增新的調味料資料
            foreach (var seasoning in seasoningsList)
            {
                _foodContext.seasonings.Add(seasoning);
            }

            await _foodContext.SaveChangesAsync();
            return Ok("Seasonings saved/updated successfully.");
        }



        /// <summary>
        /// 取得 Seasonings
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("seasonings/{id}")]
        public async Task<ActionResult<seasonings>> GetSeasonings(int id)
        {
            var seasoningsList = await _foodContext.seasonings
         .Where(seasoning => seasoning.recipe_id == id)
         .ToListAsync();

            if (seasoningsList == null || !seasoningsList.Any())
            {
                return NotFound();
            }

            return Ok(seasoningsList);
        }

    }
}
