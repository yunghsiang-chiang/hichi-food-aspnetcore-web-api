using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HFeelingsJournals
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    /// <summary>
    /// 學員ID (HMember.HID)
    /// </summary>
    public string? HMemberID { get; set; }

    /// <summary>
    /// 分享內容
    /// </summary>
    public string? HContent { get; set; }

    /// <summary>
    /// 附件一 (預留欄位，暫無使用)
    /// </summary>
    public string? HFile1 { get; set; }

    /// <summary>
    /// 附件二  (預留欄位，暫無使用)
    /// </summary>
    public string? HFile2 { get; set; }

    /// <summary>
    /// 附件三  (預留欄位，暫無使用)
    /// </summary>
    public string? HFile3 { get; set; }

    /// <summary>
    /// HashTag標籤  (預留欄位，暫無使用)
    /// </summary>
    public string? HHashTag { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public int? HStatus { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? HCreate { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public string? HCreateDT { get; set; }

    /// <summary>
    /// 修改者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public string? HModifyDT { get; set; }
}
