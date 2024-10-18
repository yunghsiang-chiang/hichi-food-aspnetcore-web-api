using hochi_food.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace hochi_food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly foodContext _foodContext;

        public ChefsController(foodContext foodContext)
        {
            _foodContext = foodContext;
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
    }
}
