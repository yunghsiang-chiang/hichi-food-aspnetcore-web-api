using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 出勤紀錄_詳細底層資料
/// </summary>
public partial class h_attendance_record
{
    /// <summary>
    /// ID 唯一碼
    /// </summary>
    public string user_id { get; set; } = null!;

    /// <summary>
    /// 姓名
    /// </summary>
    public string user_name { get; set; } = null!;

    /// <summary>
    /// 狀態
    /// </summary>
    public string attendance_status { get; set; } = null!;

    /// <summary>
    /// 時間
    /// </summary>
    public DateTime create_time { get; set; }
}
