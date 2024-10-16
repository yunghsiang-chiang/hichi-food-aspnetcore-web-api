using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// Table to store detailed information about ingredients used in recipes
/// </summary>
public partial class ingredient
{
    /// <summary>
    /// Unique identifier for each ingredient
    /// </summary>
    public int ingredient_id { get; set; }

    /// <summary>
    /// Name of the ingredient (e.g., 天貝, 豆包)
    /// </summary>
    public string ingredient_name { get; set; } = null!;

    /// <summary>
    /// Optional description or notes about the ingredient
    /// </summary>
    public string? description { get; set; }

    /// <summary>
    /// Unit of measurement for the ingredient (e.g., grams, ml)
    /// </summary>
    public string? unit { get; set; }
}
