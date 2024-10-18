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
        /// 新增或更新食谱信息
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<recipe>> PostRecipe([FromBody] recipe newRecipe)
        {
            try
            {
                if (newRecipe == null || string.IsNullOrEmpty(newRecipe.recipe_name))
                {
                    return BadRequest("Recipe name is required.");
                }

                // 验证食材
                if (newRecipe.ingredients != null)
                {
                    foreach (var ingredient in newRecipe.ingredients)
                    {
                        if (ingredient.amount <= 0)
                        {
                            return BadRequest($"Ingredient '{ingredient.ingredient_name}' amount must be greater than zero.");
                        }
                        if (string.IsNullOrEmpty(ingredient.unit))
                        {
                            return BadRequest($"Ingredient '{ingredient.ingredient_name}' unit is required.");
                        }

                        // 設置食材的 recipe_id 而不是需要完整的 recipe 物件
                        ingredient.recipe_id = newRecipe.recipe_id;
                        ingredient.recipe = null;  // 清除 recipe 物件，只需要 recipe_id
                    }
                }

                // 验证调味料
                if (newRecipe.seasonings != null)
                {
                    foreach (var seasoning in newRecipe.seasonings)
                    {
                        if (seasoning.amount <= 0)
                        {
                            return BadRequest($"Seasoning '{seasoning.seasoning_name}' amount must be greater than zero.");
                        }
                        if (string.IsNullOrEmpty(seasoning.unit))
                        {
                            return BadRequest($"Seasoning '{seasoning.seasoning_name}' unit is required.");
                        }

                        // 設置調味料的 recipe_id 而不是需要完整的 recipe 物件
                        seasoning.recipe_id = newRecipe.recipe_id;
                        seasoning.recipe = null;  // 清除 recipe 物件，只需要 recipe_id
                    }
                }

                var existingRecipe = await _foodContext.recipe
                    .Include(r => r.ingredients)
                    .Include(r => r.seasonings)
                    .FirstOrDefaultAsync(r => r.recipe_id == newRecipe.recipe_id);

                if (existingRecipe != null)
                {
                    // 更新现有食谱信息
                    existingRecipe.recipe_name = newRecipe.recipe_name;
                    existingRecipe.main_ingredient_id = newRecipe.main_ingredient_id;
                    existingRecipe.category = newRecipe.category;
                    existingRecipe.chef_id = newRecipe.chef_id;
                    existingRecipe.description = newRecipe.description;

                    // 更新食材信息
                    existingRecipe.ingredients.Clear();
                    foreach (var ingredient in newRecipe.ingredients)
                    {
                        existingRecipe.ingredients.Add(ingredient);
                    }

                    // 更新调味料信息
                    existingRecipe.seasonings.Clear();
                    foreach (var seasoning in newRecipe.seasonings)
                    {
                        existingRecipe.seasonings.Add(seasoning);
                    }

                    _foodContext.recipe.Update(existingRecipe);
                    await _foodContext.SaveChangesAsync();
                    return Ok(existingRecipe);
                }
                else
                {
                    // 新增食谱信息及其食材和调味料
                    _foodContext.recipe.Add(newRecipe);
                    await _foodContext.SaveChangesAsync();
                    return CreatedAtAction(nameof(GetRecipe), new { id = newRecipe.recipe_id }, newRecipe);
                }
            }
            catch (DbUpdateException dbEx)
            {
                // 捕捉數據庫更新異常
                return StatusCode(500, $"Database update error: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                // 捕捉所有其他異常
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
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
