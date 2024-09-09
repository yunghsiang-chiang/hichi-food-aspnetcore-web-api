using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 標記工作日
/// </summary>
public partial class c_attendance_calendar
{
    /// <summary>
    /// 年
    /// </summary>
    public int calendar_year { get; set; }

    /// <summary>
    /// 月
    /// </summary>
    public int calendar_month { get; set; }

    /// <summary>
    /// 工作日
    /// </summary>
    public string attendance_days { get; set; } = null!;
}
