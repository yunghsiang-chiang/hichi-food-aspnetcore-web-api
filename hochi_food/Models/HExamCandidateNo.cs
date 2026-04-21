using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HExamCandidateNo
{
    public int HID { get; set; }

    public string HCourseID { get; set; } = null!;

    public int HMemberID { get; set; }

    public int? HLAreaID { get; set; }

    public string? HExamNo { get; set; }

    public int HStatus { get; set; }

    public string? HCreate { get; set; }

    public DateTime HCreateDT { get; set; }

    public string? HModify { get; set; }

    public DateTime? HModifyDT { get; set; }
}
