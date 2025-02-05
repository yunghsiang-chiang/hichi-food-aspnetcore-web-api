using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTeacher
{
    public int HID { get; set; }

    public int? HMemberID { get; set; }

    public string? HContent { get; set; }

    public string? HEvaluation { get; set; }

    public int? HQualifyID { get; set; }

    public int? HCourseID { get; set; }

    /// <summary>
    /// 講師類別
    /// </summary>
    public int? HTeacherClass { get; set; }

    /// <summary>
    /// 講師層級分類
    /// </summary>
    public int? HTearcherLV { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
