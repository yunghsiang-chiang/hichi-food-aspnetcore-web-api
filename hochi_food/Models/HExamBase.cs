using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamBase
{
    public int HID { get; set; }

    public int? HCTemplateID { get; set; }

    public string? HExamBaseNum { get; set; }

    public string? HTitle { get; set; }

    public string? HIntroduce { get; set; }

    public string? HFeedBack { get; set; }

    public string? HExamBaseClass { get; set; }

    /// <summary>
    /// 檢覈方式(1:證照檢覈、2:分級檢定)
    /// </summary>
    public int? HExamMethod { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }
}
