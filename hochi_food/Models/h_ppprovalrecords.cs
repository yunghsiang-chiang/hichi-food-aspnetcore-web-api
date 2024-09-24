using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 歷史簽核紀錄
/// </summary>
public partial class h_ppprovalrecords
{
    /// <summary>
    /// 主鍵
    /// </summary>
    public string approval_id { get; set; } = null!;

    /// <summary>
    /// 請假或加班申請的 ID
    /// </summary>
    public string? request_id { get; set; }

    /// <summary>
    /// 假或加班的類型
    /// </summary>
    public string? request_type { get; set; }

    /// <summary>
    /// 審核人
    /// </summary>
    public string? approved_by { get; set; }

    /// <summary>
    /// 簽核日期
    /// </summary>
    public DateTime? approval_date { get; set; }

    /// <summary>
    /// 簽核狀態
    /// </summary>
    public string? status { get; set; }
}
