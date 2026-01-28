using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HPracticeRecordReason
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int HID { get; set; }

    /// <summary>
    /// 築基原因(HPracticeReason.HID)
    /// </summary>
    public string HPracticeReasonID { get; set; } = null!;

    /// <summary>
    /// 學員ID(填寫者)
    /// </summary>
    public int HMemberID { get; set; }

    /// <summary>
    /// 開始築基日期
    /// </summary>
    public DateOnly? HStartDate { get; set; }

    /// <summary>
    /// 結束築基日期
    /// </summary>
    public DateOnly? HEndDate { get; set; }

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
    /// 修改者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime? HModifyDT { get; set; }
}
