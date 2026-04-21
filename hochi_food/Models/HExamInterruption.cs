using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamInterruption
{
    public int HID { get; set; }

    public int HCourseID { get; set; }

    public int HExamContentID { get; set; }

    public int HExamSubjectID { get; set; }

    public int? HPlaceID { get; set; }

    public int? HExamClassRoomID { get; set; }

    public string HInterruptionType { get; set; } = null!;

    public string HStartBaseTime { get; set; } = null!;

    public int HDurationMinute { get; set; }

    public int HSort { get; set; }

    public string? HRemark { get; set; }

    public int HStatus { get; set; }

    public int? HCreate { get; set; }

    public DateTime? HCreateDT { get; set; }

    public int? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }
}
