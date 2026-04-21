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

    public string? HExamSubjectName { get; set; }

    /// <summary>
    /// 考場名稱(dbo.HPlace.HID)
    /// </summary>
    public int? HPlaceID { get; set; }

    public string? HPlaceName { get; set; }

    /// <summary>
    /// 教室名稱(dbo.HExamClassRoom.HID)
    /// </summary>
    public int? HExamClassRoomID { get; set; }

    public string? HExamClassRoomName { get; set; }

    public int? HExamPNum { get; set; }

    public int? HExamMinute { get; set; }

    /// <summary>
    /// 可同時檢覈人數
    /// </summary>
    public int? HExamTimesPNum { get; set; }

    /// <summary>
    /// 檢覈順序
    /// </summary>
    public int? HExamSort { get; set; }

    public int? HExamPaperID { get; set; }

    public int? HExamPassScore { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? HRemark { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public DateTime? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }
}
