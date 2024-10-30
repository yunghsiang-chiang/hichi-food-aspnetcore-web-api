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
        public async Task<ActionResult<recipe>> PostRecipe([FromBody] recipe recipe)
        {
            if (recipe == null || string.IsNullOrEmpty(recipe.recipe_name))
            {
                return BadRequest("Recipe name is required.");
            }

            // 新增食譜
            _foodContext.recipe.Add(recipe);
            await _foodContext.SaveChangesAsync();  // 保存以生成 recipe_id

            return CreatedAtAction(nameof(GetRecipe), new { id = recipe.recipe_id }, recipe);
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
        /// 儲存 Recipe Steps
        /// </summary>
        /// <param name="recipeSteps"></param>
        /// <returns></returns>
        [HttpPost("steps")]
        public async Task<ActionResult> PostRecipeSteps([FromBody] List<recipe_steps> recipeSteps)
        {
            if (recipeSteps == null || recipeSteps.Count == 0)
            {
                return BadRequest("Recipe steps are required.");
            }

            foreach (var step in recipeSteps)
            {
                if (step.recipe_id == 0)
                {
                    return BadRequest("Recipe ID is required for each step.");
                }

                _foodContext.recipe_steps.Add(step);
            }

            await _foodContext.SaveChangesAsync();
            return Ok("Recipe steps saved successfully.");
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
        /// 儲存 Ingredients
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        [HttpPost("ingredients")]
        public async Task<ActionResult> PostIngredients([FromBody] List<ingredients> ingredientsList)
        {
            if (ingredientsList == null || ingredientsList.Count == 0)
            {
                return BadRequest("Ingredients are required.");
            }

            foreach (var ingredient in ingredientsList)
            {
                if (ingredient.recipe_id == 0)
                {
                    return BadRequest("Recipe ID is required for each ingredient.");
                }

                _foodContext.ingredients.Add(ingredient);
            }

            await _foodContext.SaveChangesAsync();
            return Ok("Ingredients saved successfully.");
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
        /// 儲存 Seasonings
        /// </summary>
        /// <param name="seasoning"></param>
        /// <returns></returns>
        [HttpPost("seasonings")]
        public async Task<ActionResult> PostSeasonings([FromBody] List<seasonings> seasoningsList)
        {
            if (seasoningsList == null || seasoningsList.Count == 0)
            {
                return BadRequest("Seasonings are required.");
            }

            foreach (var seasoning in seasoningsList)
            {
                if (seasoning.recipe_id == 0)
                {
                    return BadRequest("Recipe ID is required for each seasoning.");
                }

                _foodContext.seasonings.Add(seasoning);
            }

            await _foodContext.SaveChangesAsync();
            return Ok("Seasonings saved successfully.");
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
