using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HSCClass
{
    public int HID { get; set; }

    /// <summary>
    /// 專欄分類
    /// </summary>
    public string? HSCClassName { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
