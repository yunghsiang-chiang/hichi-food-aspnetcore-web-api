using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HLightTransfer
{
    public int HID { get; set; }

    /// <summary>
    /// 申請單號
    /// </summary>
    public string HApplyNum { get; set; } = null!;

    /// <summary>
    /// 1=申請成為光使、2=光使變更光系
    /// </summary>
    public int? HApplyType { get; set; }

    /// <summary>
    /// 原光系
    /// </summary>
    public string? HOriginalLight { get; set; }

    /// <summary>
    /// 新光系
    /// </summary>
    public string? HTargetLight { get; set; }

    /// <summary>
    /// 接手原光系的新光使長 (HMember.HID)
    /// </summary>
    public int? HNewLightLeader { get; set; }

    /// <summary>
    /// 變更光系的原因
    /// </summary>
    public string? HReason { get; set; }

    /// <summary>
    /// 申請者
    /// </summary>
    public string? HApplicant { get; set; }

    /// <summary>
    /// 申請日期
    /// </summary>
    public DateTime? HApplyDT { get; set; }

    /// <summary>
    /// 審核日期
    /// </summary>
    public DateTime? HVerifyDT { get; set; }

    /// <summary>
    /// 審核狀態
    /// </summary>
    public int? HVerifyStatus { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime? HCreateDT { get; set; }

    /// <summary>
    /// 修改者
    /// </summary>
    public string? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }
}
