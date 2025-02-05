using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HFileType
{
    public int HID { get; set; }

    /// <summary>
    /// 檔案類型
    /// </summary>
    public string? HFType { get; set; }

    /// <summary>
    /// 檔案類型編號
    /// </summary>
    public string? HFTCode { get; set; }

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
