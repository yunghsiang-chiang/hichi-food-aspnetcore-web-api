using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseEvaluation
{
    public int HID { get; set; }

    /// <summary>
    /// 課程HID(HCourse.HID)
    /// </summary>
    public int? HCourseID { get; set; }

    /// <summary>
    /// 課程代碼(批號)
    /// </summary>
    public string? HCBatchNum { get; set; }

    /// <summary>
    /// 評比類型(1:影片/2:檔案)
    /// </summary>
    public int? HCEType { get; set; }

    /// <summary>
    /// 評比內容描述
    /// </summary>
    public string? HCEContent { get; set; }

    /// <summary>
    /// 繳交數量
    /// </summary>
    public int? HCENum { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
