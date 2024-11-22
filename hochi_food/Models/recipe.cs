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

    public int main_ingredient_id { get; set; }

    public string category { get; set; } = null!;

    public int chef_id { get; set; }

    public string? description { get; set; }

    public int? portion_size { get; set; }
}
