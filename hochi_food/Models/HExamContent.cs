using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamContent
{
    public int HID { get; set; }

    /// <summary>
    /// 檢核項目類別 (dbo.HCourse_Class.HID)
    /// </summary>
    public int? HCourseClassID { get; set; }

    /// <summary>
    /// 檢覈範本名稱
    /// </summary>
    public string? HExamContentName { get; set; }

    /// <summary>
    /// 檢覈類型(1:筆試/2:實作/3:試教)
    /// </summary>
    public int? HExamType { get; set; }

    /// <summary>
    /// 收費方式(1:不分科目/2:一科一個金額/3:依報考科目總數量而定)
    /// </summary>
    public int? HChargeMethod { get; set; }

    /// <summary>
    /// 對應的前導檢覈名稱(多選)
    /// </summary>
    public string? HLeadingExam { get; set; }

    /// <summary>
    /// 勾稽成績通過
    /// </summary>
    public int? HExamPassYN { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? HRemark { get; set; }

    /// <summary>
    /// 考場與教室設定
    /// </summary>
    public int? HExamClassRoomType { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
