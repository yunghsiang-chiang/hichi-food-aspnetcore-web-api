using System;
using System.Collections.Generic;

namespace hochi_food.Models;

public partial class HCourseBooking_Other
{
    public int HID { get; set; }

    public int? HBookingID { get; set; }

    public int? HCourseID { get; set; }

    public int? HMemberID { get; set; }

    public int? HStatus { get; set; }

    public string? HCreate { get; set; }

    public string? HCreateDT { get; set; }

    public string? HModify { get; set; }

    public string? HModifyDT { get; set; }

    public int? HMailStatus { get; set; }
}
