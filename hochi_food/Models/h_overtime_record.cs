using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 歷史加班紀錄
/// </summary>
public partial class h_overtime_record
{
    /// <summary>
    /// ID
    /// </summary>
    public string userID { get; set; } = null!;

    /// <summary>
    /// 姓名
    /// </summary>
    public string userName { get; set; } = null!;

    /// <summary>
    /// 加班類型
    /// </summary>
    public string overtimeType { get; set; } = null!;

    /// <summary>
    /// 開始時間
    /// </summary>
    public DateTime startTime { get; set; }

    /// <summary>
    /// 結束時間
    /// </summary>
    public DateTime endTime { get; set; }

    /// <summary>
    /// 小時數
    /// </summary>
    public float count_hours { get; set; }

    /// <summary>
    /// 提交日期
    /// </summary>
    public DateTime submitted_at { get; set; }

    /// <summary>
    /// 審核人
    /// </summary>
    public string? approved_by { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? remark { get; set; }
}
