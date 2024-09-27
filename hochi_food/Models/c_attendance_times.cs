using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 定義公司全體員工的考勤時間
/// </summary>
public partial class c_attendance_times
{
    /// <summary>
    /// 唯一的識別碼，自動增量
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// 定義正常的上班時間
    /// </summary>
    [JsonConverter(typeof(TimeSpanConverter))]
    public TimeSpan work_start_time { get; set; }

    /// <summary>
    /// 正常下班時間
    /// </summary>
    [JsonConverter(typeof(TimeSpanConverter))]
    public TimeSpan work_end_time { get; set; }

    /// <summary>
    /// 午休開始時間
    /// </summary>
    [JsonConverter(typeof(TimeSpanConverter))]
    public TimeSpan lunch_start_time { get; set; }

    /// <summary>
    /// 午休結束時間
    /// </summary>
    [JsonConverter(typeof(TimeSpanConverter))]
    public TimeSpan lunch_end_time { get; set; }

    /// <summary>
    /// 紀錄創建時間
    /// </summary>
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 紀錄最後更新時間
    /// </summary>
    public DateTime? updated_at { get; set; }
}
