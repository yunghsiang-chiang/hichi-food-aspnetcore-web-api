using hochi_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using hochi_food.Dtos;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hochi_food.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    public class dishesController : ControllerBase
    {
        private readonly foodContext _foodContext;

        public dishesController(foodContext foodContext)
        {
            _foodContext = foodContext;
        }

        /// <summary>
        /// 获取所有菜品信息
        /// </summary>
        [HttpGet("get_dishes")]
        public async Task<ActionResult<IEnumerable<c_dishes>>> GetDishes()
        {
            return await _foodContext.c_dishes.ToListAsync();
        }

        /// <summary>
        /// 获取请购活动
        /// </summary>
        [HttpGet("get_purchase")]
        public async Task<ActionResult<IEnumerable<purchase_DTO>>> GetPurchase()
        {
            var result = await _foodContext.h_activity_records
                .Where(row => row.activity_date >= DateTime.UtcNow)
                .Select(row => new purchase_DTO
                {
                    activity_name = row.activity_name,
                    activity_date = row.activity_date,
                    meal_type = row.meal_type,
                    during_the_activity = row.during_the_activity,
                    dishes_id_str = row.dishes_id_str
                })
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 根据材料ID名称获取材料信息
        /// </summary>
        [HttpGet("get_material_id_names")]
        public async Task<ActionResult<IEnumerable<material_id_namesDTO>>> GetMaterialIdNames([FromQuery] string material_id_names_string)
        {
            var material_id_names_array = material_id_names_string.Split(',');
            var result = await _foodContext.c_dishes
                .Where(row => material_id_names_array.Contains(row.dishes_id))
                .Select(row => new material_id_namesDTO { material_id_names = row.material_id_names })
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 获取所有活动名称（Distinct）
        /// </summary>
        [HttpGet("get_activity_name")]
        public async Task<ActionResult<IEnumerable<activity_nameDTO>>> GetActivityName()
        {
            var result = await _foodContext.h_activity_records
                .Select(row => new activity_nameDTO { activity_name = row.activity_name })
                .Distinct()
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 根据活动天数获取活动历史记录
        /// </summary>
        [HttpGet("get_h_activity_records_byday/{activity_days}")]
        public async Task<ActionResult<IEnumerable<h_activity_records>>> GetActivityRecordsByDay(int activity_days)
        {
            var result = await _foodContext.h_activity_records
                .Where(x => x.activity_days == activity_days)
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 根据活动名称获取活动历史记录
        /// </summary>
        [HttpGet("get_h_activity_records_byname/{activity_name}")]
        public async Task<ActionResult<IEnumerable<h_activity_records>>> GetActivityRecordsByName(string activity_name)
        {
            var result = await _foodContext.h_activity_records
                .Where(x => x.activity_name == activity_name)
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 根据餐别获取活动历史记录
        /// </summary>
        [HttpGet("get_h_activity_records_bymealtype/{meal_type}")]
        public async Task<ActionResult<IEnumerable<h_activity_records>>> GetActivityRecordsByMealType(string meal_type)
        {
            var result = await _foodContext.h_activity_records
                .Where(x => x.meal_type == meal_type)
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 搜索活动记录 by 名称、餐别、活动天数、起始日期、结束日期
        /// </summary>
        [HttpGet("get_h_activity_records_search")]
        public async Task<ActionResult<IEnumerable<activity_searchDTO>>> SearchActivityRecords(
            [FromQuery] string activity_name = "default",
            [FromQuery] string meal_type = "default",
            [FromQuery] string activity_days = "default",
            [FromQuery] DateTime? activity_start = null,
            [FromQuery] DateTime? activity_end = null)
        {
            var query = _foodContext.h_activity_records.AsQueryable();

            if (activity_name != "default")
            {
                query = query.Where(x => x.activity_name == activity_name);
            }
            if (meal_type != "default")
            {
                query = query.Where(x => x.meal_type == meal_type);
            }
            if (activity_days != "default")
            {
                query = query.Where(x => x.activity_days == Convert.ToInt16(activity_days));
            }
            if (activity_start != null)
            {
                query = query.Where(x => x.activity_date >= activity_start);
            }
            if (activity_end != null)
            {
                query = query.Where(x => x.activity_date <= activity_end);
            }

            var result = await query.Select(row => new activity_searchDTO
            {
                activity_name = row.activity_name,
                activity_date = row.activity_date,
                meal_type = row.meal_type,
                activity_days = row.activity_days,
                during_the_activity = row.during_the_activity,
                lm_user = row.lm_user
            }).ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 根据名称、餐别、活动日期获取活动菜单信息
        /// </summary>
        [HttpGet("get_activity_dishes")]
        public async Task<ActionResult<IEnumerable<activity_dishesDTO>>> GetActivityDishes(
            [FromQuery] string activity_name,
            [FromQuery] string meal_type,
            [FromQuery] string activity_date)
        {
            var data1 = await _foodContext.h_activity_records
                .Where(row => row.activity_name == activity_name && row.meal_type == meal_type && row.activity_date == Convert.ToDateTime(activity_date))
                .Select(row => row.dishes_id_str)
                .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(data1))
            {
                return NoContent();
            }

            var dishes_ids = data1.Split(',');

            var dishes = await _foodContext.c_dishes
                .Where(d => dishes_ids.Contains(d.dishes_id))
                .Select(d => new activity_dishesDTO
                {
                    dishes_id = d.dishes_id,
                    dishes_name = d.dishes_name,
                    dishes_type = d.dishes_type
                }).ToListAsync();

            return Ok(dishes);
        }

        /// <summary>
        /// 获取所有水果信息
        /// </summary>
        [HttpGet("get_fruits")]
        public async Task<ActionResult<IEnumerable<c_fruits>>> GetFruits()
        {
            return await _foodContext.c_fruits.ToListAsync();
        }

        /// <summary>
        /// 获取所有食材单位
        /// </summary>
        [HttpGet("get_ingredients_unit")]
        public async Task<ActionResult<IEnumerable<ingredients_unitDTO>>> GetIngredientsUnit()
        {
            var result = await _foodContext.c_ingredients_unit
                .OrderBy(row => row.unit_type)
                .Select(row => new ingredients_unitDTO
                {
                    unit_chinese = row.unit_chinese,
                    unit_english = row.unit_english,
                    unit_type = row.unit_type,
                    unit_description = row.unit_description
                })
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 根据菜色名称获取菜品信息
        /// </summary>
        [HttpGet("get_dishes_by_name/{dishesName}")]
        public async Task<ActionResult<c_dishes>> GetDishesByName(string dishesName)
        {
            var dish = await _foodContext.c_dishes.FirstOrDefaultAsync(n => n.dishes_name == dishesName);
            if (dish == null)
            {
                return NotFound();
            }
            return Ok(dish);
        }

        /// <summary>
        /// 根据菜色ID前缀获取菜品信息
        /// </summary>
        [HttpGet("get_dishes_id_like/{dishes_id_like}")]
        public async Task<ActionResult<dishesIdDTO>> GetDishesIdLike(string dishes_id_like)
        {
            var dish = await _foodContext.c_dishes
                .Where(row => row.dishes_id.StartsWith(dishes_id_like))
                .OrderBy(row => row.dishes_id)
                .Select(row => new dishesIdDTO { dishes_id = row.dishes_id })
                .LastOrDefaultAsync();

            return Ok(dish);
        }

        /// <summary>
        /// 获取所有食材的营养信息
        /// </summary>
        [HttpGet("get_food_nutrition")]
        public async Task<ActionResult<IEnumerable<nutritionDTO>>> GetFoodNutrition()
        {
            var result = await _foodContext.c_food_nutrition
                .Select(row => new nutritionDTO { 樣品編號 = row.樣品編號, 樣品名稱 = row.樣品名稱 })
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 根据食材分类获取食材基本字段信息
        /// </summary>
        [HttpGet("get_food_nutrition_simple_field")]
        public async Task<ActionResult<IEnumerable<food_nutrition_simple_fieldDTO>>> GetFoodNutritionSimpleField([FromQuery] string food_classification)
        {
            var result = await _foodContext.c_food_nutrition
                .Where(row => row.食品分類 == food_classification)
                .Select(row => new food_nutrition_simple_fieldDTO
                {
                    樣品編號 = row.樣品編號,
                    食品分類 = row.食品分類,
                    樣品名稱 = row.樣品名稱,
                    俗名 = row.俗名,
                    內容物描述 = row.內容物描述
                })
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 获取食材分类
        /// </summary>
        [HttpGet("get_food_nutrition_category")]
        public async Task<ActionResult<IEnumerable<food_nutrition_categoryDTO>>> GetFoodNutritionCategory()
        {
            var result = await _foodContext.c_food_nutrition
                .Select(row => new food_nutrition_categoryDTO { 食品分類 = row.食品分類 })
                .Distinct()
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 根据关键词搜索菜品
        /// </summary>
        [HttpGet("search_dishes_by_words/{words}")]
        public async Task<ActionResult<IEnumerable<c_dishes>>> SearchDishesByWords(string words)
        {
            var result = await _foodContext.c_dishes
                .Where(n => n.dishes_name.Contains(words))
                .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// 根据关键词和材料搜索菜品
        /// </summary>
        [HttpGet("search_dishes_by_wordsAndMaterial/{words}/{material}")]
        public async Task<ActionResult<IEnumerable<c_dishes>>> SearchDishesByWordsAndMaterial(string words, string material)
        {
            var result = await _foodContext.c_dishes
                .Where(x => x.dishes_name.Contains(words) && x.material_id_names.Contains(material))
                .ToListAsync();

            return Ok(result);
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

        /// <summary>
        /// 获取所有厨师信息
        /// </summary>
        [HttpGet("chefs")]
        public async Task<ActionResult<IEnumerable<chef>>> GetChefs()
        {
            return await _foodContext.chef.ToListAsync();
        }

        /// <summary>
        /// 获取单个厨师信息
        /// </summary>
        [HttpGet("chefs/{id}")]
        public async Task<ActionResult<chef>> GetChef(int id)
        {
            var chef = await _foodContext.chef.FindAsync(id);
            if (chef == null)
            {
                return NotFound();
            }
            return Ok(chef);
        }

        /// <summary>
        /// 新增或更新厨师信息
        /// </summary>
        [HttpPost("chefs")]
        public async Task<ActionResult<chef>> PostChef([FromBody] chef newChef)
        {
            if (newChef == null || string.IsNullOrEmpty(newChef.name))
            {
                return BadRequest("Chef name is required.");
            }

            var existingChef = await _foodContext.chef
                .FirstOrDefaultAsync(c => c.chef_id == newChef.chef_id);

            if (existingChef != null)
            {
                existingChef.name = newChef.name;
                existingChef.region = newChef.region;
                _foodContext.chef.Update(existingChef);
                await _foodContext.SaveChangesAsync();
                return Ok(existingChef);
            }
            else
            {
                _foodContext.chef.Add(newChef);
                await _foodContext.SaveChangesAsync();
                return CreatedAtAction(nameof(GetChef), new { id = newChef.chef_id }, newChef);
            }
        }

        /// <summary>
        /// 新增菜品信息
        /// </summary>
        [HttpPost("appendNewdishes")]
        public async Task<IActionResult> AppendNewDishes([FromBody] c_dishes dishes)
        {
            _foodContext.c_dishes.Add(dishes);
            await _foodContext.SaveChangesAsync();
            return Ok();
        }

        /// <summary>
        /// 新增活动记录信息
        /// </summary>
        [HttpPost("appendActivity_records")]
        public async Task<IActionResult> AppendActivityRecords([FromBody] h_activity_records activity_records)
        {
            _foodContext.h_activity_records.Add(activity_records);
            await _foodContext.SaveChangesAsync();
            return Ok();
        }
    }
}
