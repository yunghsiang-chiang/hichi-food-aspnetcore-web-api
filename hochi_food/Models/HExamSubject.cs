using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamSubject
{
    public int HID { get; set; }

    public int? HExamSubjectGroupID { get; set; }

    /// <summary>
    /// 檢覈科目名稱
    /// </summary>
    public string? HExamSubjectName { get; set; }

    public int? HExamPassScore { get; set; }

    public int? HExamMinute { get; set; }

    public int? HExamTimesPNum { get; set; }

    public int? HExamSort { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
