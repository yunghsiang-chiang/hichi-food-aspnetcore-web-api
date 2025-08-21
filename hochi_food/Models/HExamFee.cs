using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamFee
{
    public int HID { get; set; }

    /// <summary>
    /// dbo.HExamTemplate.HID
    /// </summary>
    public int? HExamContentID { get; set; }

    /// <summary>
    /// 報考科目最小值
    /// </summary>
    public int? HSubjectMinNum { get; set; }

    /// <summary>
    /// 報考科目最大值
    /// </summary>
    public int? HSubjectMaxNum { get; set; }

    /// <summary>
    /// 檢覈費用
    /// </summary>
    public string? HExamFee1 { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
