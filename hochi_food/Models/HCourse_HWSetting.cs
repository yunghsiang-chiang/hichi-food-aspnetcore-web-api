using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourse_HWSetting
{
    public int HID { get; set; }

    public int? HCourseID { get; set; }

    public int? HNumbers { get; set; }

    public string? HDeadLine { get; set; }

    public bool? HNotice { get; set; }

    public string? HCBatchNum { get; set; }

    /// <summary>
    /// 作業類型(回應/問卷)
    /// </summary>
    public int? HHWType { get; set; }

    /// <summary>
    /// 問卷(關聯HQuestionHID)
    /// </summary>
    public int? HQuestionHID { get; set; }

    /// <summary>
    /// 作業內容描述
    /// </summary>
    public string? HDescription { get; set; }

    /// <summary>
    /// 問卷連結
    /// </summary>
    public string? HQuestionLink { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
