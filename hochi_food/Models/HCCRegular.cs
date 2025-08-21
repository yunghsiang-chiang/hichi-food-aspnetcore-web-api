using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCCRegular
{
    public int HID { get; set; }

    public string? HCCPCodeHead { get; set; }

    /// <summary>
    /// 捐款用途HID
    /// </summary>
    public int? HDPurposeID { get; set; }

    /// <summary>
    /// 捐款用途
    /// </summary>
    public string? HDPurpose { get; set; }

    /// <summary>
    /// 捐款項目HID
    /// </summary>
    public int? HDItemID { get; set; }

    /// <summary>
    /// 捐款項目
    /// </summary>
    public string? HDItem { get; set; }

    /// <summary>
    /// 每期捐款金額
    /// </summary>
    public int? HDCCPAmount { get; set; }

    /// <summary>
    /// 是否限制最低總金額
    /// </summary>
    public int? HLimitTotal { get; set; }

    /// <summary>
    /// 最低總金額
    /// </summary>
    public int? HMinTotal { get; set; }

    /// <summary>
    /// 最低扣款期數
    /// </summary>
    public int? HMinTimes { get; set; }

    /// <summary>
    /// 最高扣款期數
    /// </summary>
    public int? HMaxTimes { get; set; }

    public string? HCCPSDate { get; set; }

    /// <summary>
    /// 開放捐款日期
    /// </summary>
    public string? HDOpenDate { get; set; }

    /// <summary>
    /// 截止捐款日期
    /// </summary>
    public string? HDExpDate { get; set; }

    public int? HOpenBlessing { get; set; }

    public int? HOpenPaper { get; set; }

    public int? HStatus { get; set; }

    public int? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public int? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
