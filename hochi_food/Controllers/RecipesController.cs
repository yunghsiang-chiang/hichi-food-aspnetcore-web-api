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
                existingRecipe.portion_size = recipe.portion_size;
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

        /// <summary>
        /// 取得沒有對應 activity_meal_recipes 的 activity_meals
        /// </summary>
        /// <returns></returns>
        [HttpGet("activity-meals/pending-recipes")]
        public async Task<ActionResult<IEnumerable<activity_meals>>> GetMealsPendingRecipes()
        {
            // 找出所有沒有在 activity_meal_recipes 中對應的 activity_meal_id
            var mealsWithoutRecipes = await _foodContext.activity_meals
                .Where(am => !_foodContext.activity_meal_recipes
                    .Any(amr => amr.activity_meal_id == am.activity_meal_id))
                .ToListAsync();

            if (mealsWithoutRecipes == null || !mealsWithoutRecipes.Any())
            {
                return NotFound("All activity meals have corresponding recipes.");
            }

            return Ok(mealsWithoutRecipes);
        }

        /// <summary>
        /// 取得所有活動餐點資料
        /// </summary>
        /// <returns></returns>
        [HttpGet("activity-meals")]
        public async Task<ActionResult<IEnumerable<activity_meals>>> GetActivityMeals()
        {
            var activityMeals = await _foodContext.activity_meals.ToListAsync();

            if (activityMeals == null || !activityMeals.Any())
            {
                return NotFound("No activity meals found.");
            }

            return Ok(activityMeals);
        }

        /// <summary>
        /// 根據活動餐點ID取得活動餐點對應的食譜列表
        /// </summary>
        /// <param name="activityMealId"></param>
        /// <returns></returns>
        [HttpGet("activity-meal-recipes/{activityMealId}")]
        public async Task<ActionResult<IEnumerable<activity_meal_recipes>>> GetActivityMealRecipes(int activityMealId)
        {
            var mealRecipes = await _foodContext.activity_meal_recipes
                .Where(amr => amr.activity_meal_id == activityMealId)
                .ToListAsync();

            if (mealRecipes == null || !mealRecipes.Any())
            {
                return NotFound($"No recipes found for activity meal ID: {activityMealId}");
            }

            return Ok(mealRecipes);
        }

        /// <summary>
        /// 根據起始日期與結束日期取得指定範圍內的活動日期與餐別
        /// </summary>
        /// <param name="startDate">起始日期</param>
        /// <param name="endDate">結束日期</param>
        /// <returns></returns>
        [HttpGet("activity-meals/date-range")]
        public async Task<ActionResult<IEnumerable<activity_meals>>> GetActivityMealsByDateRange(DateTime startDate, DateTime endDate)
        {
            var mealsInRange = await _foodContext.activity_meals
                .Where(am => am.activity_date >= startDate && am.activity_date <= endDate)
                .OrderBy(am => am.activity_date)
                .ThenBy(am => am.meal_type)
                .ToListAsync();

            if (mealsInRange == null || !mealsInRange.Any())
            {
                return NotFound("No activity meals found in the specified date range.");
            }

            return Ok(mealsInRange);
        }

        /// <summary>
        /// 儲存或更新多筆 Activity Meals
        /// </summary>
        /// <param name="activityMeals"></param>
        /// <returns></returns>
        [HttpPost("activity-meals")]
        public async Task<ActionResult> PostOrUpdateActivityMeals([FromBody] List<activity_meals> activityMeals)
        {
            if (activityMeals == null || activityMeals.Count == 0)
            {
                return BadRequest("Activity meal data is required.");
            }

            foreach (var activityMeal in activityMeals)
            {
                // 檢查是否存在該 activity_meal_id
                var existingMeal = await _foodContext.activity_meals
                    .FirstOrDefaultAsync(am => am.activity_meal_id == activityMeal.activity_meal_id);

                if (existingMeal != null)
                {
                    // 更新現有的 activity_meals 資料
                    existingMeal.activity_name = activityMeal.activity_name;
                    existingMeal.start_date = activityMeal.start_date;
                    existingMeal.end_date = activityMeal.end_date;
                    existingMeal.activity_date = activityMeal.activity_date;
                    existingMeal.meal_type = activityMeal.meal_type;

                    _foodContext.activity_meals.Update(existingMeal);
                }
                else
                {
                    // 新增新的 activity_meals 資料
                    _foodContext.activity_meals.Add(activityMeal);
                }
            }

            await _foodContext.SaveChangesAsync();
            return Ok("Activity meals saved/updated successfully.");
        }

        /// <summary>
        /// 儲存或更新活動餐點食譜
        /// </summary>
        /// <param name="mealRecipes"></param>
        /// <returns></returns>
        [HttpPost("activity-meal-recipes")]
        public async Task<ActionResult> PostOrUpdateActivityMealRecipes([FromBody] List<activity_meal_recipes> mealRecipes)
        {
            if (mealRecipes == null || mealRecipes.Count == 0)
            {
                return BadRequest("活動餐點食譜為必填項目。");
            }

            // 從第一個項目取得 activity_meal_id（所有項目應該具有相同的 activity_meal_id）
            var activityMealId = mealRecipes.First().activity_meal_id;
            if (activityMealId == 0)
            {
                return BadRequest("每個食譜都需要指定活動餐點 ID。");
            }

            // 刪除現有的對應 activity_meal_id 的項目
            var existingMealRecipes = _foodContext.activity_meal_recipes
                .Where(amr => amr.activity_meal_id == activityMealId)
                .ToList();

            if (existingMealRecipes.Any())
            {
                _foodContext.activity_meal_recipes.RemoveRange(existingMealRecipes);
            }

            // 新增新的項目
            foreach (var mealRecipe in mealRecipes)
            {
                // 僅映射必要的屬性以避免多餘的資料
                var newMealRecipe = new activity_meal_recipes
                {
                    activity_meal_id = mealRecipe.activity_meal_id,
                    recipe_id = mealRecipe.recipe_id,
                    recipe_category = mealRecipe.recipe_category
                };

                _foodContext.activity_meal_recipes.Add(newMealRecipe);
            }

            await _foodContext.SaveChangesAsync();
            return Ok("活動餐點食譜已成功儲存或更新。");
        }

        /// <summary>
        /// 取得所有 Food Nutrition 資料
        /// </summary>
        /// <returns></returns>
        [HttpGet("food-nutrition")]
        public async Task<ActionResult<IEnumerable<food_nutrition>>> GetFoodNutrition()
        {
            var foodNutritionList = await _foodContext.food_nutrition.ToListAsync();

            if (foodNutritionList == null || !foodNutritionList.Any())
            {
                return NotFound("No food nutrition data found.");
            }

            return Ok(foodNutritionList);
        }

        /// <summary>
        /// 儲存或更新 Food Nutrition
        /// </summary>
        /// <param name="foodNutrition"></param>
        /// <returns></returns>
        [HttpPost("food-nutrition")]
        public async Task<ActionResult> PostOrUpdateFoodNutrition([FromBody] food_nutrition foodNutrition)
        {
            if (foodNutrition == null || foodNutrition.ingredient_id == 0)
            {
                return BadRequest("Ingredient ID is required.");
            }

            // 查詢是否已存在相同的 ingredient_id
            var existingFoodNutrition = await _foodContext.food_nutrition
                .FirstOrDefaultAsync(fn => fn.ingredient_id == foodNutrition.ingredient_id);

            if (existingFoodNutrition != null)
            {
                // 刪除現有資料
                _foodContext.food_nutrition.Remove(existingFoodNutrition);
                await _foodContext.SaveChangesAsync();
            }

            // 新增新資料
            _foodContext.food_nutrition.Add(foodNutrition);
            await _foodContext.SaveChangesAsync();

            return Ok("Food nutrition data has been saved/updated successfully.");
        }

        /// <summary>
        /// 取得指定 activity_meal_id 清單中每個 recipe_id 的次數
        /// </summary>
        /// <param name="activityMealIds">活動餐點 ID 清單 (以逗號分隔)</param>
        /// <returns></returns>
        [HttpGet("activity-meals/recipe-count")]
        public async Task<ActionResult<IEnumerable<object>>> GetRecipeCountByActivityMealIds([FromQuery] string activityMealIds)
        {
            if (string.IsNullOrEmpty(activityMealIds))
                return BadRequest("Activity meal IDs are required.");

            // 將逗號分隔的 ID 字串轉換為整數列表
            var ids = activityMealIds.Split(',').Select(int.Parse).ToList();

            // 查詢統計每個 recipe_id 的次數
            var recipeCounts = await _foodContext.activity_meal_recipes
                .Where(amr => ids.Contains(amr.activity_meal_id))
                .GroupBy(amr => amr.recipe_id)
                .Select(group => new
                {
                    RecipeId = group.Key,
                    RecipeQty = group.Count()
                })
                .ToListAsync();

            if (!recipeCounts.Any())
                return NotFound("No recipes found for the specified activity meal IDs.");

            return Ok(recipeCounts);
        }

        /// <summary>
        /// 取得指定 activity_meal_id 清單中 recipe_id 對應的 ingredients 清單
        /// </summary>
        /// <param name="activityMealIds">活動餐點 ID 清單 (以逗號分隔)</param>
        /// <returns></returns>
        [HttpGet("activity-meals/recipe-ingredients")]
        public async Task<ActionResult<IEnumerable<object>>> GetIngredientsByActivityMealIds([FromQuery] string activityMealIds)
        {
            if (string.IsNullOrEmpty(activityMealIds))
                return BadRequest("Activity meal IDs are required.");

            // 將逗號分隔的 ID 字串轉換為整數列表
            var ids = activityMealIds.Split(',').Select(int.Parse).ToList();

            // 查詢對應的 recipe_id 清單
            var recipeIds = await _foodContext.activity_meal_recipes
                .Where(amr => ids.Contains(amr.activity_meal_id))
                .Select(amr => amr.recipe_id)
                .Distinct()
                .ToListAsync();

            if (!recipeIds.Any())
                return NotFound("No recipes found for the specified activity meal IDs.");

            // 查詢 recipe_id 對應的 ingredients 清單
            var ingredients = await _foodContext.ingredients
                .Where(ing => recipeIds.Contains(ing.recipe_id))
                .Select(ing => new
                {
                    RecipeId = ing.recipe_id,
                    IngredientName = ing.ingredient_name,
                    Amount = ing.amount,
                    Unit = ing.unit
                })
                .ToListAsync();

            if (!ingredients.Any())
                return NotFound("No ingredients found for the specified recipes.");

            return Ok(ingredients);
        }

        /// <summary>
        /// 取得所有有對應食譜的活動餐點資料
        /// </summary>
        /// <returns></returns>
        [HttpGet("activity-meals/with-recipes")]
        public async Task<ActionResult<IEnumerable<activity_meals>>> GetActivityMealsWithRecipes()
        {
            var activityMealsWithRecipes = await _foodContext.activity_meals
                .Where(am => _foodContext.activity_meal_recipes
                    .Select(amr => amr.activity_meal_id)
                    .Distinct()
                    .Contains(am.activity_meal_id))
                .ToListAsync();

            if (activityMealsWithRecipes == null || !activityMealsWithRecipes.Any())
            {
                return NotFound("No activity meals with recipes found.");
            }

            return Ok(activityMealsWithRecipes);
        }

        /// <summary>
        /// 取得指定日期範圍內有對應食譜的活動餐點資料
        /// </summary>
        /// <param name="startDate">起始日期</param>
        /// <param name="endDate">結束日期</param>
        /// <returns></returns>
        [HttpGet("activity-meals/with-recipes/date-range")]
        public async Task<ActionResult<IEnumerable<activity_meals>>> GetActivityMealsWithRecipesByDateRange(DateTime startDate, DateTime endDate)
        {
            var activityMealsInRange = await _foodContext.activity_meals
                .Where(am => _foodContext.activity_meal_recipes
                    .Select(amr => amr.activity_meal_id)
                    .Distinct()
                    .Contains(am.activity_meal_id) &&
                    am.activity_date >= startDate &&
                    am.activity_date <= endDate)
                .ToListAsync();

            if (activityMealsInRange == null || !activityMealsInRange.Any())
            {
                return NotFound("No activity meals with recipes found in the specified date range.");
            }

            return Ok(activityMealsInRange);
        }

        /// <summary>
        /// 使用關鍵字和/或日期範圍搜尋活動餐點
        /// </summary>
        /// <param name="keyword">關鍵字 (optional)</param>
        /// <param name="startDate">開始日期 (optional)</param>
        /// <param name="endDate">結束日期 (optional)</param>
        /// <returns>符合條件的活動餐點清單</returns>
        [HttpGet("activity-meals/search")]
        public async Task<ActionResult<IEnumerable<activity_meals>>> SearchActivityMeals(
            [FromQuery] string? keyword,
            [FromQuery] DateTime? startDate,
            [FromQuery] DateTime? endDate)
        {
            // 建立查詢基礎
            var query = _foodContext.activity_meals.AsQueryable();

            // 如果提供了關鍵字，搜尋 activity_name
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(am => am.activity_name.Contains(keyword));
            }

            // 如果提供了日期範圍，篩選符合條件的資料
            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(am => am.activity_date >= startDate.Value && am.activity_date <= endDate.Value);
            }
            else if (startDate.HasValue) // 只有起始日期
            {
                query = query.Where(am => am.activity_date >= startDate.Value);
            }
            else if (endDate.HasValue) // 只有結束日期
            {
                query = query.Where(am => am.activity_date <= endDate.Value);
            }

            // 執行查詢並排序
            var result = await query
                .OrderBy(am => am.activity_date)
                .ThenBy(am => am.meal_type)
                .ToListAsync();

            // 檢查結果是否為空
            if (result == null || !result.Any())
            {
                return NotFound("No activity meals match the search criteria.");
            }

            return Ok(result);
        }

        /// <summary>
        /// 使用 LINQ 查詢，結合 activity_meal_recipes、recipe 和 main_ingredient
        /// 通過 activity_meal_id 過濾活動餐點對應的食譜
        /// 如果 recipe 沒有對應的主食材 (main_ingredient)，則允許 MainIngredientName 為空（使用 DefaultIfEmpty()）
        /// </summary>
        /// <param name="activityMealId"></param>
        /// <returns></returns>
        [HttpGet("activity-meal/{activityMealId}/recipes")]
        public async Task<ActionResult<IEnumerable<object>>> GetRecipesByActivityMealId(int activityMealId)
        {
            var recipes = await (from amr in _foodContext.activity_meal_recipes
                                 join r in _foodContext.recipe on amr.recipe_id equals r.recipe_id
                                 join mi in _foodContext.main_ingredient on r.main_ingredient_id equals mi.main_ingredient_id into miGroup
                                 from mi in miGroup.DefaultIfEmpty()
                                 where amr.activity_meal_id == activityMealId
                                 select new
                                 {
                                     r.recipe_id,
                                     r.recipe_name,
                                     MainIngredientName = mi.main_ingredient_name,
                                     r.category,
                                     r.description,
                                     r.portion_size
                                 }).ToListAsync();

            if (recipes == null || recipes.Count == 0)
            {
                return NotFound($"No recipes found for activity meal ID: {activityMealId}");
            }

            return Ok(recipes);
        }


    }
}
