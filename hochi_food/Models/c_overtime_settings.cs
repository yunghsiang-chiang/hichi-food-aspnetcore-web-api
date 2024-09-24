using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class c_overtime_settings
{
    /// <summary>
    /// 唯一的識別碼，自動增量
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// 加班的類型，如「平日加班」、「假日加班」
    /// </summary>
    public string overtime_type { get; set; } = null!;

    /// <summary>
    /// 加班的計算比例，例如平日加班為1.5倍，假日加班為2倍
    /// </summary>
    public decimal rate { get; set; }

    /// <summary>
    /// 對該加班類型的詳細描述
    /// </summary>
    public string? description { get; set; }

    /// <summary>
    /// 紀錄該紀錄的創建時間
    /// </summary>
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 紀錄該紀錄的最後更新時間
    /// </summary>
    public DateTime? updated_at { get; set; }
}
