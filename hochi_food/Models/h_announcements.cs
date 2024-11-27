using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 公告
/// </summary>
public partial class h_announcements
{
    /// <summary>
    /// 公告的唯一識別碼
    /// </summary>
    public int announcement_id { get; set; }

    /// <summary>
    /// 公告標題
    /// </summary>
    public string title { get; set; } = null!;

    /// <summary>
    /// 公告內容 (HTML 格式)
    /// </summary>
    public string content { get; set; } = null!;

    /// <summary>
    /// 公告者
    /// </summary>
    public string author { get; set; } = null!;

    /// <summary>
    /// 發行時間
    /// </summary>
    public DateTime issue_time { get; set; }

    /// <summary>
    /// 上架時間
    /// </summary>
    public DateTime? start_time { get; set; }

    /// <summary>
    /// 下架時間
    /// </summary>
    public DateTime? end_time { get; set; }

    /// <summary>
    /// 公告狀態
    /// </summary>
    public string? status { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime? updated_at { get; set; }
}
