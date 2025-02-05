using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HDocCType
{
    public int HID { get; set; }

    /// <summary>
    /// 編碼
    /// </summary>
    public string? HDocCTCode { get; set; }

    /// <summary>
    /// 課程類型(法系編碼規則)
    /// </summary>
    public string? HDocCType1 { get; set; }

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
