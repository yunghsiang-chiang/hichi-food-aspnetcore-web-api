using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// Table to store seasonings used in each recipe
/// </summary>
public partial class seasonings
{
    /// <summary>
    /// Unique identifier for each seasoning used in a recipe
    /// </summary>
    public int seasoning_id { get; set; }

    /// <summary>
    /// References the ID of the recipe from the Recipe table
    /// </summary>
    public int recipe_id { get; set; }

    /// <summary>
    /// Name of the seasoning used in the recipe
    /// </summary>
    public string seasoning_name { get; set; } = null!;

    /// <summary>
    /// Amount of the seasoning used
    /// </summary>
    public decimal amount { get; set; }

    /// <summary>
    /// Unit of measurement for the seasoning (e.g., grams, ml)
    /// </summary>
    public string? unit { get; set; }

    [JsonIgnore] // 忽略這個屬性在序列化時的輸出
    public virtual recipe recipe { get; set; } = null!;
}
