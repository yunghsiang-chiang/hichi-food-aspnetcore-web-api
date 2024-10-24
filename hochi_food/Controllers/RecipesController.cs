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
        public async Task<ActionResult<recipe_steps>> PostRecipeSteps([FromBody] recipe_steps recipeSteps)
        {
            if (recipeSteps == null || recipeSteps.recipe_id == 0)
            {
                return BadRequest("Recipe ID and step details are required.");
            }

            // 新增步驟
            _foodContext.recipe_steps.Add(recipeSteps);
            await _foodContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRecipeSteps), new { id = recipeSteps.step_id }, recipeSteps);
        }
        /// <summary>
        /// 取得 Recipe Steps
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("steps/{id}")]
        public async Task<ActionResult<recipe_steps>> GetRecipeSteps(int id)
        {
            var step = await _foodContext.recipe_steps.FindAsync(id);

            if (step == null)
            {
                return NotFound();
            }

            return Ok(step);
        }

        /// <summary>
        /// 儲存 Ingredients
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        [HttpPost("ingredients")]
        public async Task<ActionResult<ingredients>> PostIngredients([FromBody] ingredients ingredient)
        {
            if (ingredient == null || ingredient.recipe_id == 0)
            {
                return BadRequest("Recipe ID and ingredient details are required.");
            }

            // 新增食材
            _foodContext.ingredients.Add(ingredient);
            await _foodContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIngredients), new { id = ingredient.ingredient_id }, ingredient);
        }
        /// <summary>
        /// 取得 Ingredients
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("ingredients/{id}")]
        public async Task<ActionResult<ingredients>> GetIngredients(int id)
        {
            var ingredient = await _foodContext.ingredients.FindAsync(id);

            if (ingredient == null)
            {
                return NotFound();
            }

            return Ok(ingredient);
        }
        /// <summary>
        /// 儲存 Seasonings
        /// </summary>
        /// <param name="seasoning"></param>
        /// <returns></returns>
        [HttpPost("seasonings")]
        public async Task<ActionResult<seasonings>> PostSeasonings([FromBody] seasonings seasoning)
        {
            if (seasoning == null || seasoning.recipe_id == 0)
            {
                return BadRequest("Recipe ID and seasoning details are required.");
            }

            // 新增調味料
            _foodContext.seasonings.Add(seasoning);
            await _foodContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSeasonings), new { id = seasoning.seasoning_id }, seasoning);
        }
        /// <summary>
        /// 取得 Seasonings
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("seasonings/{id}")]
        public async Task<ActionResult<seasonings>> GetSeasonings(int id)
        {
            var seasoning = await _foodContext.seasonings.FindAsync(id);

            if (seasoning == null)
            {
                return NotFound();
            }

            return Ok(seasoning);
        }

    }
}
