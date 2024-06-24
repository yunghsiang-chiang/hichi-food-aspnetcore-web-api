using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 烹飪方法對照表
/// </summary>
public partial class c_cooking_method_old
{
    /// <summary>
    /// 烹飪方式編碼
    /// </summary>
    public string cooking_method_id { get; set; } = null!;

    /// <summary>
    /// 烹飪方式
    /// </summary>
    public string cooking_method { get; set; } = null!;

    /// <summary>
    /// 烹飪方式解釋
    /// </summary>
    public string cooking_explain { get; set; } = null!;
}
