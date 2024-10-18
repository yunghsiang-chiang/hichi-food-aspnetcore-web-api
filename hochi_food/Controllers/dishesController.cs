using hochi_food.Dtos;
using hochi_food.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hochi_food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly foodContext _foodContext;

        public DishesController(foodContext foodContext)
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
