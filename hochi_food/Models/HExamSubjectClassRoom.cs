using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamSubjectClassRoom
{
    public int HID { get; set; }

    /// <summary>
    /// 科目名稱(dbo.HExamSubject.HID)
    /// </summary>
    public int? HExamSubjectID { get; set; }

    /// <summary>
    /// 考場名稱(dbo.HPlace.HID)
    /// </summary>
    public int? HPlaceID { get; set; }

    /// <summary>
    /// 教室名稱(dbo.HExamClassRoom.HID)
    /// </summary>
    public int? HExamClassRoomID { get; set; }

    /// <summary>
    /// 教室同時可容納考試總人數
    /// </summary>
    public int? HExamPNum { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
