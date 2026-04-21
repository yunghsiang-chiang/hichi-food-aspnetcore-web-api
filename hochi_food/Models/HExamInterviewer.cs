using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamInterviewer
{
    public int HID { get; set; }

    /// <summary>
    /// 課程HID
    /// </summary>
    public int? HCourseID { get; set; }

    /// <summary>
    /// 檢覈內容HID
    /// </summary>
    public int? HExamContentID { get; set; }

    /// <summary>
    /// 考場HID
    /// </summary>
    public int? HPlaceID { get; set; }

    /// <summary>
    /// 考試科目HID
    /// </summary>
    public int? HExamSubjectID { get; set; }

    /// <summary>
    /// 教室HID
    /// </summary>
    public int? HExamClassRoomID { get; set; }

    /// <summary>
    /// 主考官1
    /// </summary>
    public string? HInterviewer1 { get; set; }

    /// <summary>
    /// 主考官2
    /// </summary>
    public string? HInterviewer2 { get; set; }

    /// <summary>
    /// 主考官3
    /// </summary>
    public string? HInterviewer3 { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public DateTime? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }
}
