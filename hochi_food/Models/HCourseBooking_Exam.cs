using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseBooking_Exam
{
    public int HID { get; set; }

    public int? HCourseBookingID { get; set; }

    /// <summary>
    /// 檢覈內容名稱(關聯HExamContent.HID)
    /// </summary>
    public int? HExamContentID { get; set; }

    /// <summary>
    /// 檢覈科目名稱
    /// </summary>
    public string? HExamSubjectID { get; set; }

    public int? HMemberID { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
