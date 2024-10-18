using hochi_food.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace hochi_food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly foodContext _foodContext;

        public CategoriesController(foodContext foodContext)
        {
            _foodContext = foodContext;
        }

        /// <summary>
        /// 获取所有菜品分类
        /// </summary>
        [HttpGet("categories")]
        public async Task<ActionResult<IEnumerable<category>>> GetCategories()
        {
            var result = await _foodContext.category.ToListAsync();
            return Ok(result);
        }

        /// <summary>
        /// 获取单个菜品分类
        /// </summary>
        [HttpGet("categories/{id}")]
        public async Task<ActionResult<category>> GetCategory(int id)
        {
            var category = await _foodContext.category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        /// <summary>
        /// 新增或更新菜品分类
        /// </summary>
        [HttpPost("categories")]
        public async Task<ActionResult<category>> PostCategory([FromBody] category newCategory)
        {
            if (newCategory == null || string.IsNullOrEmpty(newCategory.category_name))
            {
                return BadRequest("Category name is required.");
            }

            var existingCategory = await _foodContext.category
                .FirstOrDefaultAsync(c => c.category_id == newCategory.category_id);

            if (existingCategory != null)
            {
                existingCategory.category_name = newCategory.category_name;
                existingCategory.description = newCategory.description;
                _foodContext.category.Update(existingCategory);
                await _foodContext.SaveChangesAsync();
                return Ok(existingCategory);
            }
            else
            {
                _foodContext.category.Add(newCategory);
                await _foodContext.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCategory), new { id = newCategory.category_id }, newCategory);
            }
        }
    }
}
