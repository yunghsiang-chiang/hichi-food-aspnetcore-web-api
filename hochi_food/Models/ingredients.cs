using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// Table to store ingredients used in each recipe
/// </summary>
public partial class ingredients
{
    public int ingredient_id { get; set; }

    public int recipe_id { get; set; }

    public string ingredient_name { get; set; } = null!;

    public decimal amount { get; set; }

    public string? unit { get; set; }
}
