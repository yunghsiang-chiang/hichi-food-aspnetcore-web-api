using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// Table to store different categories for recipes
/// </summary>
public partial class category
{
    /// <summary>
    /// Unique identifier for each recipe category
    /// </summary>
    public int category_id { get; set; }

    /// <summary>
    /// Name of the category (e.g., 主菜, 紅燒, 咖哩)
    /// </summary>
    public string category_name { get; set; } = null!;

    /// <summary>
    /// Optional description or notes about the category
    /// </summary>
    public string? description { get; set; }

    public string? icon { get; set; }
}
