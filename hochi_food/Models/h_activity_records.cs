using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 歷史活動紀錄
/// </summary>
public partial class h_activity_records
{
    /// <summary>
    /// 活動名稱
    /// </summary>
    public string activity_name { get; set; } = null!;

    /// <summary>
    /// 活動日期
    /// </summary>
    public DateTime activity_date { get; set; }

    /// <summary>
    /// 餐別
    /// </summary>
    public string meal_type { get; set; } = null!;

    /// <summary>
    /// 活動天數
    /// </summary>
    public int activity_days { get; set; }

    /// <summary>
    /// 活動期間
    /// </summary>
    public string during_the_activity { get; set; } = null!;

    /// <summary>
    /// 最後編輯者
    /// </summary>
    public string lm_user { get; set; } = null!;

    /// <summary>
    /// 菜色清單
    /// </summary>
    public string? dishes_id_str { get; set; }
}
