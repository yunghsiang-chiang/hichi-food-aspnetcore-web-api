using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamAssignment
{
    public int HID { get; set; }

    public int? HCourseID { get; set; }

    /// <summary>
    /// 檢覈內容名稱(關聯HExamContent.HID)
    /// </summary>
    public int? HExamContentID { get; set; }

    public int? HExamSubjectID { get; set; }

    public int? HPlaceID { get; set; }

    public int? HExamClassRoomID { get; set; }

    public int? HMemberID { get; set; }

    public string? HAssignTime { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
