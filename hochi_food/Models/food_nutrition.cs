using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 食材
/// </summary>
public partial class food_nutrition
{
    /// <summary>
    /// 食材ID
    /// </summary>
    public int ingredient_id { get; set; }

    /// <summary>
    /// 食材名稱
    /// </summary>
    public string? ingredient_name { get; set; }

    /// <summary>
    /// 俗名
    /// </summary>
    public string? common_name { get; set; }
}
