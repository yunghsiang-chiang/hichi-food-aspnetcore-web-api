using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTeacherMaterial
{
    public int HID { get; set; }

    /// <summary>
    /// 西元年月日(yyyy/MM/dd)
    /// </summary>
    public string? HTMDate { get; set; }

    /// <summary>
    /// 課程類型班別(Course Type Class) (關聯dbo. HDocCTypeClass HID)
    /// </summary>
    public int? HDocCTClassID { get; set; }

    /// <summary>
    /// 檔案類型(關聯dbo.HFileType HID)
    /// </summary>
    public int? HFileTypeID { get; set; }

    public int? HCourseLevelID { get; set; }

    /// <summary>
    /// 堂數(分段/分片)
    /// </summary>
    public string? HClassNo { get; set; }

    /// <summary>
    /// 節
    /// </summary>
    public string? HFestival { get; set; }

    /// <summary>
    /// 講師教材名稱
    /// </summary>
    public string? HTMName { get; set; }

    /// <summary>
    /// 講師教材檔案
    /// </summary>
    public string? HTMaterial { get; set; }

    public string? HDocFileName { get; set; }

    /// <summary>
    /// 講師教材連結
    /// </summary>
    public string? HTMLink { get; set; }

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
