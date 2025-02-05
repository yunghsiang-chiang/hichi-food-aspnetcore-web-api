using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HLCourse_Detail
{
    public int HID { get; set; }

    public int? HLCourseID { get; set; }

    public string? HCourseName { get; set; }

    public string? HDateRange { get; set; }

    /// <summary>
    /// 折扣點數(*10)才會轉成金額
    /// </summary>
    public decimal? HDiscount { get; set; }

    public bool? HRequired { get; set; }

    public int? HPercentage { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
