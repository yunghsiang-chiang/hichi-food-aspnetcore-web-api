using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// Table to store information about each recipe, including name, main ingredient, category, and chef reference
/// </summary>
public partial class recipe
{
    /// <summary>
    /// Unique identifier for each recipe
    /// </summary>
    public int recipe_id { get; set; }

    /// <summary>
    /// Name of the recipe (e.g., 糖醋豆包)
    /// </summary>
    public string recipe_name { get; set; } = null!;

    /// <summary>
    /// References the ID of the main ingredient from the Main_Ingredient table
    /// </summary>
    public int? main_ingredient_id { get; set; }

    /// <summary>
    /// Category of the recipe (e.g., 主菜 - 紅燒, 咖哩)
    /// </summary>
    public string? category { get; set; }

    /// <summary>
    /// References the ID of the chef from the Chef table
    /// </summary>
    public int? chef_id { get; set; }

    /// <summary>
    /// Link or identifier for further recipe details
    /// </summary>
    public string? description { get; set; }

    public virtual chef? chef { get; set; }

    public virtual ICollection<ingredients> ingredients { get; set; } = new List<ingredients>();

    public virtual main_ingredient? main_ingredient { get; set; }

    public virtual ICollection<recipe_steps> recipe_steps { get; set; } = new List<recipe_steps>();

    public virtual ICollection<seasonings> seasonings { get; set; } = new List<seasonings>();
}
