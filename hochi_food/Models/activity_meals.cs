using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class activity_meals
{
    /// <summary>
    /// 每場活動的餐點紀錄
    /// </summary>
    public int activity_meal_id { get; set; }

    /// <summary>
    /// 活動名稱
    /// </summary>
    public string activity_name { get; set; } = null!;

    /// <summary>
    /// 班會起始日
    /// </summary>
    public DateTime start_date { get; set; }

    /// <summary>
    /// 班會結束日
    /// </summary>
    public DateTime end_date { get; set; }

    /// <summary>
    /// 班會日期
    /// </summary>
    public DateTime activity_date { get; set; }

    /// <summary>
    /// 餐別
    /// </summary>
    public string meal_type { get; set; } = null!;
}
