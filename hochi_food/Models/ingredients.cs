using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// Table to store ingredients used in each recipe
/// </summary>
public partial class ingredients
{
    /// <summary>
    /// Unique identifier for each ingredient used in a recipe
    /// </summary>
    public int ingredient_id { get; set; }

    /// <summary>
    /// References the ID of the recipe from the Recipe table
    /// </summary>
    public int recipe_id { get; set; }

    /// <summary>
    /// Name of the ingredient used in the recipe
    /// </summary>
    public string ingredient_name { get; set; } = null!;

    /// <summary>
    /// Amount of the ingredient used
    /// </summary>
    public decimal amount { get; set; }

    /// <summary>
    /// Unit of measurement for the ingredient (e.g., grams, ml)
    /// </summary>
    public string? unit { get; set; }

    public virtual recipe recipe { get; set; } = null!;
}
