using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HDiscountCode
{
    public int HID { get; set; }

    public string? HDCode { get; set; }

    public string? HDSummary { get; set; }

    public string? HDPoint { get; set; }

    public string? HCourseID { get; set; }

    /// <summary>
    /// 可使用的課程範本(HCourse_T.HID)
    /// </summary>
    public string? HCTemplateID { get; set; }

    public string? HEmailGroup { get; set; }

    public string? HEmailPerson { get; set; }

    public string? HDType { get; set; }

    /// <summary>
    /// 僅能使用一次
    /// </summary>
    public bool? HUseOnce { get; set; }

    /// <summary>
    /// 折扣碼有效期間(起)
    /// </summary>
    public string? HSDate { get; set; }

    /// <summary>
    /// 折扣碼有效期間(迄)
    /// </summary>
    public string? HEDate { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
