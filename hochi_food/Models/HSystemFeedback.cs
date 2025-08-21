using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSystemFeedback
{
    public int HID { get; set; }

    /// <summary>
    /// 學員HID
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 回饋分類(1:建議、2:改善(問題回報))
    /// </summary>
    public int? HCategory { get; set; }

    /// <summary>
    /// 標題
    /// </summary>
    public string? HTitle { get; set; }

    /// <summary>
    /// 詳細說明
    /// </summary>
    public string? HContent { get; set; }

    public string? HIMG1 { get; set; }

    public string? HIMG2 { get; set; }

    public string? HIMG3 { get; set; }

    /// <summary>
    /// 處理者
    /// </summary>
    public int? HHandler { get; set; }

    /// <summary>
    /// 處理時間
    /// </summary>
    public string? HHandleTime { get; set; }

    /// <summary>
    /// 處理狀況
    /// </summary>
    public string? HHandleContent { get; set; }

    /// <summary>
    /// 處理狀態(1:待處理、2:處理中、3:已處理)
    /// </summary>
    public int? HEventStatus { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
