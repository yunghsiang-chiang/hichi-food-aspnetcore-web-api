using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HTeacherDetail
{
    public int HID { get; set; }

    public int? HTeacherID { get; set; }

    /// <summary>
    /// 資格檢覈紀錄(HQualify.HID)
    /// </summary>
    public int? HQualifyID { get; set; }

    /// <summary>
    /// 講師名稱ID
    /// </summary>
    public int? HTeacherNameID { get; set; }

    /// <summary>
    /// 講師類別
    /// </summary>
    public int? HTeacherClass { get; set; }

    /// <summary>
    /// 講師層級分類(1:見習、2:試教、3:正式)
    /// </summary>
    public int? HTearcherLV { get; set; }

    /// <summary>
    /// 學程階級(0表示未分階)
    /// </summary>
    public int? HProgramLV { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
