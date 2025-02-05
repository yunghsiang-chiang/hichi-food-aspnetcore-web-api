using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HDocCTypeClass
{
    public int HID { get; set; }

    /// <summary>
    /// 課程類型 (關聯dbo. HDocCType HID)
    /// </summary>
    public int? HDocCTypeID { get; set; }

    /// <summary>
    /// 課程類型班別編號
    /// </summary>
    public string? HDocCTCCode { get; set; }

    /// <summary>
    /// 課程類型班別
    /// </summary>
    public string? HDocCTClass { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? HRemark { get; set; }

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
    /// 編輯者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 編輯日期
    /// </summary>
    public string? HModifyDT { get; set; }
}
