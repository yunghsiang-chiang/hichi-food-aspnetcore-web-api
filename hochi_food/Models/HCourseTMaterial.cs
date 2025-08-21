using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseTMaterial
{
    public int HID { get; set; }

    public string? HCBatchNum { get; set; }

    /// <summary>
    /// 課程HID
    /// </summary>
    public int? HCourseID { get; set; }

    /// <summary>
    /// 講師教材HID
    /// </summary>
    public int? HTMaterialID { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? HSort { get; set; }

    public string? HTMaterial { get; set; }

    public string? HSave { get; set; }

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
