using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 餐點類型資訊
/// </summary>
public partial class c_dishes_type
{
    /// <summary>
    /// 餐點類型ID
    /// </summary>
    public string dishes_type_id { get; set; } = null!;

    /// <summary>
    /// 餐點類型名稱
    /// </summary>
    public string? dishes_type_name { get; set; }
}
