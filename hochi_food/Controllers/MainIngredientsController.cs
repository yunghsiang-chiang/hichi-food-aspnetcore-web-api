using hochi_food.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace hochi_food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainIngredientsController : ControllerBase
    {
        private readonly foodContext _foodContext;

        public MainIngredientsController(foodContext foodContext)
        {
            _foodContext = foodContext;
        }

        /// <summary>
        /// 获取所有主食材信息
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<main_ingredient>>> GetMainIngredients()
        {
            var mainIngredients = await _foodContext.main_ingredient.ToListAsync();
            return Ok(mainIngredients);
        }

        /// <summary>
        /// 根据ID获取单个主食材信息
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<main_ingredient>> GetMainIngredient(int id)
        {
            var mainIngredient = await _foodContext.main_ingredient.FindAsync(id);
            if (mainIngredient == null)
            {
                return NotFound();
            }
            return Ok(mainIngredient);
        }

        /// <summary>
        /// 新增或更新主食材信息
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<main_ingredient>> PostMainIngredient([FromBody] main_ingredient newMainIngredient)
        {
            if (newMainIngredient == null || string.IsNullOrEmpty(newMainIngredient.main_ingredient_name))
            {
                return BadRequest("主食材名称不能为空。");
            }

            var existingMainIngredient = await _foodContext.main_ingredient
                .FirstOrDefaultAsync(m => m.main_ingredient_id == newMainIngredient.main_ingredient_id);

            if (existingMainIngredient != null)
            {
                // 更新现有主食材
                existingMainIngredient.main_ingredient_name = newMainIngredient.main_ingredient_name;
                existingMainIngredient.description = newMainIngredient.description;
                existingMainIngredient.category = newMainIngredient.category;
                _foodContext.main_ingredient.Update(existingMainIngredient);
                await _foodContext.SaveChangesAsync();
                return Ok(existingMainIngredient);
            }
            else
            {
                // 新增主食材
                _foodContext.main_ingredient.Add(newMainIngredient);
                await _foodContext.SaveChangesAsync();
                return CreatedAtAction(nameof(GetMainIngredient), new { id = newMainIngredient.main_ingredient_id }, newMainIngredient);
            }
        }

        /// <summary>
        /// 删除指定ID的主食材
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMainIngredient(int id)
        {
            var mainIngredient = await _foodContext.main_ingredient.FindAsync(id);
            if (mainIngredient == null)
            {
                return NotFound();
            }

            _foodContext.main_ingredient.Remove(mainIngredient);
            await _foodContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
