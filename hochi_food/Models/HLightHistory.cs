using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HLightHistory
{
    public int HID { get; set; }

    /// <summary>
    /// dbo.HMember.HID
    /// </summary>
    public int? HMemberID { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateOnly? HCDate { get; set; }

    /// <summary>
    /// 原光系名稱
    /// </summary>
    public string? HOld { get; set; }

    /// <summary>
    /// 新光系名稱
    /// </summary>
    public string? HNew { get; set; }

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
    public DateTime? HCreateDT { get; set; }

    /// <summary>
    /// 編輯者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 編輯日期
    /// </summary>
    public DateTime? HModifyDT { get; set; }
}
