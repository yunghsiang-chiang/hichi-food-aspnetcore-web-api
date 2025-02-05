using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTodoList
{
    public int HID { get; set; }

    public int? HCourseID { get; set; }

    public string? HGroupName { get; set; }

    public string? HTask { get; set; }

    public string? HTaskContent { get; set; }

    public int? HGroupLeaderID { get; set; }

    public string? HCBatchNum { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public string? HSave { get; set; }

    /// <summary>
    /// 試務人員名單
    /// </summary>
    public string? HExamStaff { get; set; }

    /// <summary>
    /// 人數
    /// </summary>
    public int? HTaskNum { get; set; }
}
