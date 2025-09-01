using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HMentorType
{
    public int HID { get; set; }

    /// <summary>
    /// 導師類型名稱(ex:生命導師、動功導師)
    /// </summary>
    public string? HMentorTypeName { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public string? HSort { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? HRemark { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
