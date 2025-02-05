using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCMaterialRecord
{
    public int HID { get; set; }

    public int HCourseID { get; set; }

    public int HBookingID { get; set; }

    public int? HMemberID { get; set; }

    public int? HMaterialID { get; set; }

    public int? HRTimes { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }
}
