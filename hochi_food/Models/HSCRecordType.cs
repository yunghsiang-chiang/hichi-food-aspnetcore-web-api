using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCRecordType
{
    public int HID { get; set; }

    /// <summary>
    /// 紀錄類型
    /// </summary>
    public string? HSCRTName { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
