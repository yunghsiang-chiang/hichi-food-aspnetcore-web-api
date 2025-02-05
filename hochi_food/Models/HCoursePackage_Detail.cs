using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCoursePackage_Detail
{
    public int HID { get; set; }

    /// <summary>
    /// 關聯HCoursePackage.HID
    /// </summary>
    public int? HCPkgHID { get; set; }

    /// <summary>
    /// 批號(關聯HCourse.HCBatchCode)
    /// </summary>
    public string? HCBatchCode { get; set; }

    /// <summary>
    /// 課程名稱(關聯HCourse.HCourseName)
    /// </summary>
    public string? HCourseName { get; set; }

    /// <summary>
    /// 上課日期(關聯HCourse.HDateRange)
    /// </summary>
    public string? HDateRange { get; set; }

    public int? HStatus { get; set; }

    public int? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public int? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public int? HSave { get; set; }
}
