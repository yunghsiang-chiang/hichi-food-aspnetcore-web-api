using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HLeadingCourse
{
    public int HID { get; set; }

    public string? HLCourseCode { get; set; }

    public int? HCourseID { get; set; }

    public string? HLCourseID { get; set; }

    public decimal? HDiscount { get; set; }

    /// <summary>
    /// 課程代碼(批號)
    /// </summary>
    public string? HCBatchNum { get; set; }

    /// <summary>
    /// 必修/選修
    /// </summary>
    public bool? HRequired { get; set; }

    /// <summary>
    /// 依比例
    /// </summary>
    public string? HPercentage { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
