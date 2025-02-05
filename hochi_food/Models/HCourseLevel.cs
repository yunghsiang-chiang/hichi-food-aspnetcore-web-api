using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseLevel
{
    public int HID { get; set; }

    /// <summary>
    /// 1:教材學程；2:出版分類
    /// </summary>
    public int? HCLClassID { get; set; }

    public string? HCourseLevel1 { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public int? HStatus { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public string? HCreate { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public string? HCreateDT { get; set; }

    /// <summary>
    /// 編輯者
    /// </summary>
    public string? HModify { get; set; }

    /// <summary>
    /// 編輯日期
    /// </summary>
    public string? HModifyDT { get; set; }
}
