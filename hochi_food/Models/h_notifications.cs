using System;
using System.Collections.Generic;

namespace hochi_food.Models;

/// <summary>
/// 出勤內部公告
/// </summary>
public partial class h_notifications
{
    /// <summary>
    /// 主鍵 (PK)
    /// </summary>
    public string notification_id { get; set; } = null!;

    /// <summary>
    /// 通知標題
    /// </summary>
    public string? title { get; set; }

    /// <summary>
    /// 通知內容 (可使用 HTML 格式)
    /// </summary>
    public string? content { get; set; }

    /// <summary>
    /// 創建日期 (記錄通知發布的時間)
    /// </summary>
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 更新日期 (如果通知內容需要修改)
    /// </summary>
    public DateTime? updated_at { get; set; }

    /// <summary>
    /// 到期日期 (可選，用於設定通知的有效期限)
    /// </summary>
    public DateTime? expires_at { get; set; }

    /// <summary>
    /// 通知狀態 (如：啟用、停用)
    /// </summary>
    public string? status { get; set; }

    /// <summary>
    /// 外鍵 (FK) 連結至 Employees 表，表示發布通知的員工
    /// </summary>
    public string? created_by { get; set; }

    /// <summary>
    /// 受眾群組 (如：所有員工、特定部門等，可選)
    /// </summary>
    public string? recipient_group { get; set; }
}
