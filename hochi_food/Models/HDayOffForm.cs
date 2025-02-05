using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HDayOffForm
{
    public int HID { get; set; }

    public int? HCourseID { get; set; }

    public int? HRollCallID { get; set; }

    public int? HMemberID { get; set; }

    public string? HDayOffNum { get; set; }

    public string? HApplyDT { get; set; }

    public string? HReason { get; set; }

    public string? HRemark { get; set; }

    public int? HVStatus { get; set; }

    public string? HVDT { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public int? HDOReason { get; set; }
}
