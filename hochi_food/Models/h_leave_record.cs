using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 請假紀錄
/// </summary>
public partial class h_leave_record
{
    /// <summary>
    /// 使用者ID
    /// </summary>
    public string userId { get; set; } = null!;

    /// <summary>
    /// 姓名
    /// </summary>
    public string userName { get; set; } = null!;

    /// <summary>
    /// 請假類型
    /// </summary>
    public string leaveType { get; set; } = null!;

    /// <summary>
    /// 起始時間
    /// </summary>
    public DateTime startTime { get; set; }

    /// <summary>
    /// 結束時間
    /// </summary>
    public DateTime endTime { get; set; }

    /// <summary>
    /// 小時數(浮點)
    /// </summary>
    public float count_hours { get; set; }
}
