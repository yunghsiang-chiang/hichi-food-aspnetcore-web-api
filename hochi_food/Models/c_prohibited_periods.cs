using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 設定禁止異動的期間
/// </summary>
public partial class c_prohibited_periods
{
    /// <summary>
    /// 唯一的識別碼，自動增量，方便進行查詢和管理
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// 設定禁止異動的開始日期，通常是在計算薪資或特定會計期間的開始
    /// </summary>
    public DateTime? start_date { get; set; }

    /// <summary>
    /// 設定禁止異動的結束日期，通常是在計算薪資或特定會計期間的結束
    /// </summary>
    public DateTime? end_date { get; set; }

    /// <summary>
    /// 記錄禁止異動的原因，例如「月末薪資計算」、「年度報表準備」等
    /// </summary>
    public string? reason { get; set; }

    /// <summary>
    /// 紀錄該紀錄的創建時間，方便日後查詢和審計
    /// </summary>
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 紀錄該紀錄的最後更新時間，以便追踪修改歷史
    /// </summary>
    public DateTime? updated_at { get; set; }
}
