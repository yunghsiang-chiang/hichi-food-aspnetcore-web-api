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
        public async Task<ActionResult<IEnumerable<recipe>>> GetRecipes()
        {
            var recipes = await _foodContext.recipe
                .Include(r => r.chef) // 包含关联的厨师信息
                .Include(r => r.main_ingredient) // 包含关联的主食材信息
                .ToListAsync();
            return Ok(recipes);
        }

        /// <summary>
        /// 获取单个食谱信息
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<recipe>> GetRecipe(int id)
        {
            var recipe = await _foodContext.recipe
                .Include(r => r.chef)
                .Include(r => r.main_ingredient)
                .Include(r => r.recipe_steps) // 包含关联的步骤信息
                .FirstOrDefaultAsync(r => r.recipe_id == id);

            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe);
        }

        /// <summary>
        /// 新增或更新食谱信息
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<recipe>> PostRecipe([FromBody] recipe newRecipe)
        {
            if (newRecipe == null || string.IsNullOrEmpty(newRecipe.recipe_name))
            {
                return BadRequest("Recipe name is required.");
            }

            var existingRecipe = await _foodContext.recipe
                .FirstOrDefaultAsync(r => r.recipe_id == newRecipe.recipe_id);

            if (existingRecipe != null)
            {
                // 更新现有食谱信息
                existingRecipe.recipe_name = newRecipe.recipe_name;
                existingRecipe.main_ingredient_id = newRecipe.main_ingredient_id;
                existingRecipe.category = newRecipe.category;
                existingRecipe.chef_id = newRecipe.chef_id;
                _foodContext.recipe.Update(existingRecipe);
                await _foodContext.SaveChangesAsync();
                return Ok(existingRecipe);
            }
            else
            {
                // 新增食谱信息
                _foodContext.recipe.Add(newRecipe);
                await _foodContext.SaveChangesAsync();
                return CreatedAtAction(nameof(GetRecipe), new { id = newRecipe.recipe_id }, newRecipe);
            }
        }

        /// <summary>
        /// 删除食谱及其关联的步骤信息
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipe(int id)
        {
            var recipe = await _foodContext.recipe
                .Include(r => r.recipe_steps) // 关联删除步骤信息
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
