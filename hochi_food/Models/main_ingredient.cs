using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// Table to store detailed information about each main ingredient used in recipes
/// </summary>
public partial class main_ingredient
{
    /// <summary>
    /// Unique identifier for each main ingredient
    /// </summary>
    public int main_ingredient_id { get; set; }

    /// <summary>
    /// Name of the main ingredient (e.g., 豆包, 天貝)
    /// </summary>
    public string main_ingredient_name { get; set; } = null!;

    /// <summary>
    /// Optional description or notes about the ingredient
    /// </summary>
    public string? description { get; set; }

    /// <summary>
    /// Category of the ingredient (e.g., 豆製品 for tofu products)
    /// </summary>
    public string? category { get; set; }

    public virtual ICollection<recipe> recipe { get; set; } = new List<recipe>();
}
