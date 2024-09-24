using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class c_leave_types
{
    /// <summary>
    /// 唯一的識別碼，自動增量
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// 請假類型的名稱，例如「病假」、「事假」、「年假」等
    /// </summary>
    public string type_name { get; set; } = null!;

    /// <summary>
    /// 對該請假類型的詳細描述
    /// </summary>
    public string? description { get; set; }

    /// <summary>
    /// 每年可請的最大天數，便於系統自動計算剩餘可請假天數
    /// </summary>
    public int max_days { get; set; }

    /// <summary>
    /// 紀錄該紀錄的創建時間
    /// </summary>
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 紀錄該紀錄的最後更新時間
    /// </summary>
    public DateTime? updated_at { get; set; }
}
