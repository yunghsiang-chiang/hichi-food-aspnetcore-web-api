using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 調味料
/// </summary>
public partial class c_seasoning
{
    /// <summary>
    /// 調味料ID
    /// </summary>
    public string seasoning_id { get; set; } = null!;

    /// <summary>
    /// 調味料名稱
    /// </summary>
    public string seasoning_name { get; set; } = null!;

    public string? seasoning_description { get; set; }
}
