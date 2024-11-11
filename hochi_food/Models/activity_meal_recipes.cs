using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class activity_meal_recipes
{
    public int activity_meal_recipe_id { get; set; }

    public int activity_meal_id { get; set; }

    public int recipe_id { get; set; }

    public string recipe_category { get; set; } = null!;
}
