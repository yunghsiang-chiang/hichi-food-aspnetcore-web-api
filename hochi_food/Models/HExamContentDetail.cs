using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamContentDetail
{
    public int HID { get; set; }

    /// <summary>
    /// dbo.HExamTemplate.HID
    /// </summary>
    public int? HExamContentID { get; set; }

    /// <summary>
    /// 科目名稱(dbo.HExamSubject.HID)
    /// </summary>
    public int? HExamSubjectID { get; set; }

    /// <summary>
    /// 檢覈時間(分鐘)
    /// </summary>
    public int? HExamTime { get; set; }

    /// <summary>
    /// 可同時檢覈人數
    /// </summary>
    public int? HExamTimesPNum { get; set; }

    /// <summary>
    /// 檢覈順序
    /// </summary>
    public int? HExamSort { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? HRemark { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    /// <summary>
    /// 考場名稱(dbo.HPlace.HID)
    /// </summary>
    public int? HPlaceID { get; set; }

    /// <summary>
    /// 教室名稱(dbo.HExamClassRoom.HID)
    /// </summary>
    public int? HExamClassRoomID { get; set; }

    /// <summary>
    /// 一天可容納考試總人數
    /// </summary>
    public int? HExamDayPNum { get; set; }
}
