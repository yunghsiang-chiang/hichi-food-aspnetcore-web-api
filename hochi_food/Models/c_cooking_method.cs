using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 烹飪方式
/// </summary>
public partial class c_cooking_method
{
    /// <summary>
    /// 烹飪方式ID
    /// </summary>
    public string cooking_method_id { get; set; } = null!;

    /// <summary>
    /// 烹飪方式
    /// </summary>
    public string cooking_method { get; set; } = null!;

    /// <summary>
    /// 烹飪說明
    /// </summary>
    public string? method_description { get; set; }
}
