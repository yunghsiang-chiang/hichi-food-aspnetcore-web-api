using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 食材單位表
/// </summary>
public partial class c_ingredients_unit
{
    /// <summary>
    /// 單位中文稱呼
    /// </summary>
    public string unit_chinese { get; set; } = null!;

    /// <summary>
    /// 單位英文稱呼
    /// </summary>
    public string unit_english { get; set; } = null!;

    /// <summary>
    /// 單位類型
    /// </summary>
    public string unit_type { get; set; } = null!;

    /// <summary>
    /// 單位說明
    /// </summary>
    public string unit_description { get; set; } = null!;
}
